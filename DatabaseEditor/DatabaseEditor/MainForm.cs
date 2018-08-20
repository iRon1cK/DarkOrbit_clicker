using DarkOrbit_clicker;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DatabaseEditor
{
    public partial class MainForm : Form
    {
        String dbPath = "data.dodb";

        List<ListMap> listMap = new List<ListMap>();

        public MainForm()
        {
            InitializeComponent();
            LoadData();
        }

        public void LoadData()
        {
            foreach (ListMap lmap in listMap)
            {
                lmap.list.Clear();
            }
            List<object> result = new List<object>();
            BinaryFormatter bf = new BinaryFormatter();
            if (File.Exists(dbPath))
            {
                FileStream fsin = new FileStream(dbPath, FileMode.Open, FileAccess.Read, FileShare.None);
                try
                {
                    using (fsin)
                    {
                        result = (List<object>)bf.Deserialize(fsin);
                    }
                    foreach (object obj in result)
                    {
                        foreach (object o in (List<object>)obj)
                        {
                            if (listMap.Find(s => s.list.Contains(o)) == null)
                            {
                                ListMap map = listMap.Find(s => s.type == o.GetType());
                                if (map != null)
                                {
                                    map.list.Add(o);
                                }
                                else
                                {
                                    map = new ListMap(new List<object>(), o);
                                    listMap.Add(map);
                                }
                            }
                        }
                    }
                }
                catch (Exception e)
                {
                    MessageBox.Show("An error has occured" + e.Message);
                }
            }
            lbxListTypes.DataSource = listMap;
        }

        public void SaveData()
        {
            List<object> toSave = new List<object>();
            foreach (ListMap pair in listMap)
            {
                toSave.Add(pair.list);
            }

            BinaryFormatter bf = new BinaryFormatter();

            FileStream fsout = new FileStream(dbPath, FileMode.Create, FileAccess.Write, FileShare.None);
            try
            {
                using (fsout)
                {
                    bf.Serialize(fsout, toSave);
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("An error has occured: " + e.Message);
            }
        }

        private void btnSelectDb_Click(object sender, EventArgs e)
        {
            OpenFileDialog fileDialog = new OpenFileDialog();
            fileDialog.Title = "Select DB file";
            fileDialog.Filter = "DarkOrbit Database (*.dodb)|*.dodb";
            fileDialog.CheckPathExists = true;
            if (fileDialog.ShowDialog() == DialogResult.OK)
            {
                dbPath = fileDialog.FileName;
                txbDbPath.Text = dbPath;
                LoadData();
            }
        }

        private void lbxListTypes_SelectedIndexChanged(object sender, EventArgs e)
        {
            int size = 160;
            flpItems.Controls.Clear();
            ListMap mappedList = ((ListMap)lbxListTypes.SelectedItem);
            foreach (object obj in mappedList.list)
            {
                Panel pnl = new Panel();
                pnl.Width = pnl.Height = size;
                pnl.BackColor = Color.FromArgb(25, 0, 0, 0);
                pnl.Tag = new object[] { obj, mappedList };
                foreach (var field in mappedList.fields)
                {
                    try
                    {
                        switch (field.FieldType.Name)
                        {
                            case "String":
                                if (field.Name == "name")
                                {
                                    Label labName = new Label();
                                    labName.Text = field.GetValue(obj).ToString();
                                    labName.AutoSize = false;
                                    labName.Width = pnl.Width - 2;
                                    labName.Left = 1;
                                    labName.Top = 1;
                                    labName.TextAlign = ContentAlignment.MiddleCenter;
                                    labName.BackColor = Color.FromArgb(175, Color.Black);
                                    labName.ForeColor = Color.White;
                                    pnl.Controls.Add(labName);
                                }
                                break;
                            case "Image":
                                pnl.BackgroundImage = (Image)field.GetValue(obj);
                                pnl.BackgroundImageLayout = ImageLayout.Zoom;
                                Console.WriteLine(field.FieldType.Name);
                                break;
                            default:
                                Console.WriteLine(field.FieldType.Name + " type is not supported in flpItems!");
                                break;
                        }
                    } catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                }
                foreach (Control c in pnl.Controls)
                {
                    c.Tag = new object[] { obj, mappedList };
                    c.Click += Item_Click;
                }
                pnl.Click += Item_Click;
                flpItems.Controls.Add(pnl);
            }

            Button btnAddItem = new Button();
            btnAddItem.Text = "+";
            btnAddItem.Font = new Font(btnAddItem.Font.FontFamily, 30);
            btnAddItem.TextAlign = ContentAlignment.MiddleCenter;
            btnAddItem.Anchor = AnchorStyles.None;
            btnAddItem.Size = new Size(size/2, size/2);
            btnAddItem.Margin = new Padding(size/4);
            btnAddItem.Click += BtnAddItem_Click;
            btnAddItem.Tag = mappedList;

            flpItems.Controls.Add(btnAddItem);
        }

        private void BtnAddItem_Click(object sender, EventArgs e)
        {
            ListMap listMap = (ListMap)((Control)sender).Tag;
            Control s = new Control();
            s.Tag = new object[] { Activator.CreateInstance(listMap.type), listMap };
            Item_Click(s, new EventArgs());
        }

        private void Item_Click(object sender, EventArgs e)
        {
            object[] tag = (object[])((Control)sender).Tag;
            object obj = tag[0];
            ListMap mappedList = (ListMap)tag[1];
            flpDetails.Controls.Clear();
            foreach (var field in mappedList.fields)
            {
                Panel pnl = new Panel();
                pnl.Size = new Size(flpDetails.Width - 25, 100);
                pnl.BorderStyle = BorderStyle.FixedSingle;
                pnl.AutoScroll = true;
                Label labName = new Label();
                labName.Text = field.Name;
                labName.AutoSize = false;
                labName.Width = pnl.Width - 6;
                labName.Left = 3;
                labName.Top = 1;
                labName.TextAlign = ContentAlignment.MiddleCenter;
                pnl.Controls.Add(labName);

                object[] pnlTag = new object[] { obj, field, new object() };

                if (field.FieldType.IsEnum)
                {
                    ComboBox cbx = new ComboBox();
                    cbx.DropDownStyle = ComboBoxStyle.DropDownList;
                    int i = 0;
                    foreach (FieldInfo f in field.FieldType.GetFields())
                    {
                        if (i > 0)
                        {
                            cbx.Items.Add(f.Name);
                            if (f.Name == field.GetValue(obj).ToString())
                            {
                                cbx.SelectedIndex = i-1;
                            }
                        }
                        i++;
                    }
                    cbx.Width = pnl.Width - 6;
                    cbx.Top = labName.Bottom + 5;
                    cbx.Left = 3;
                    pnl.Controls.Add(cbx);
                    flpDetails.Controls.Add(pnl);
                    pnlTag[2] = Enum.Parse(field.FieldType, cbx.SelectedItem.ToString());
                    cbx.SelectedValueChanged += detailsField_ValueChanged;
                }
                else
                {
                    switch (field.FieldType.Name)
                    {
                        case "String":
                            TextBox txbString = new TextBox();
                            txbString.Text = field.GetValue(obj).ToString();
                            txbString.AutoSize = false;
                            txbString.Width = pnl.Width - 6;
                            txbString.Left = 3;
                            txbString.Top = labName.Bottom + 5;
                            txbString.TextAlign = HorizontalAlignment.Center;
                            pnl.Controls.Add(txbString);
                            flpDetails.Controls.Add(pnl);

                            pnlTag[2] = txbString.Text;
                            txbString.TextChanged += detailsField_ValueChanged;
                            break;
                        case "Int32":
                            NumericUpDown nudInt = new NumericUpDown();
                            nudInt.Maximum = Int32.MaxValue;
                            nudInt.Minimum = Int32.MinValue;
                            nudInt.Value = (int)field.GetValue(obj);
                            nudInt.AutoSize = false;
                            nudInt.Width = pnl.Width - 6;
                            nudInt.Left = 3;
                            nudInt.Top = labName.Bottom + 5;
                            nudInt.TextAlign = HorizontalAlignment.Center;
                            pnl.Controls.Add(nudInt);
                            flpDetails.Controls.Add(pnl);

                            pnlTag[2] = Int32.Parse(nudInt.Value.ToString());
                            nudInt.ValueChanged += detailsField_ValueChanged;
                            break;
                        case "Image":
                            PictureBox pbx = new PictureBox();
                            pbx.BackgroundImage = (Image)field.GetValue(obj);
                            pbx.BackgroundImageLayout = ImageLayout.Zoom;
                            pbx.Height = pbx.Width = pnl.Width - 6;
                            pbx.Top = labName.Bottom + 5;
                            pnl.Controls.Add(pbx);
                            flpDetails.Controls.Add(pnl);

                            pnlTag[2] = pbx.BackgroundImage;
                            pbx.BackgroundImageChanged += detailsField_ValueChanged;
                            break;
                        default:
                            Console.WriteLine(field.FieldType.Name + " type is not supported in flpDetails!");
                            break;
                    }
                }
                pnl.Tag = pnlTag;
                pnl.Height = pnl.PreferredSize.Height;
            }
            Button saveBtn = new Button();
            saveBtn.Text = "Save";
            saveBtn.Size = new Size(flpDetails.Width - 25, 35);
            saveBtn.Tag = tag;
            saveBtn.Click += SaveBtn_Click;
            flpDetails.Controls.Add(saveBtn);
        }

        private void detailsField_ValueChanged(object sender, EventArgs e)
        {
            object[] tag = (object[])((Control)sender).Parent.Tag;
            if (sender is ComboBox)
            {
                ComboBox cbxEnum = (ComboBox)sender;
                tag[2] = Enum.Parse(((FieldInfo)tag[1]).FieldType, cbxEnum.SelectedItem.ToString());
            }
            else if (sender is NumericUpDown)
            {
                NumericUpDown nudInt = (NumericUpDown)sender;
                if (tag[2] is Int32)
                {
                    tag[2] = Int32.Parse(nudInt.Value.ToString());
                }
            }
            else if (sender is PictureBox)
            {
                PictureBox pbxImage = (PictureBox)sender;
                tag[2] = pbxImage.BackgroundImage;
            }
            else if (sender is TextBox)
            {
                TextBox txbString = (TextBox)sender;
                tag[2] = txbString.Text;
            }
            else
            {
                Console.WriteLine(sender.ToString() + " object is not supported!");
            }
        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            foreach(Control c in flpDetails.Controls)
            {
                if (c is Panel)
                {
                    object[] tag = (object[])c.Tag;
                    FieldInfo field = (FieldInfo)tag[1];
                    field.SetValue(tag[0], tag[2]);
                    if (listMap.Find(s => s.list.Contains(tag[0])) == null)
                    {
                        listMap.Find(s => s.type == tag[0].GetType()).list.Add(tag[0]);
                    }
                }
            }
            lbxListTypes_SelectedIndexChanged(new object(), new EventArgs());
            btnSaveToDB.BackColor = Color.Red;
        }

        private void btnSaveToDB_Click(object sender, EventArgs e)
        {
            SaveData();
            btnSaveToDB.BackColor = SystemColors.Control;
        }
    }
}
