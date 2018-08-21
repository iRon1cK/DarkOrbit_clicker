using DarkOrbit_clicker;
using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
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
        String dbPath = "";

        List<ListMap> listMap = new List<ListMap>();

        public MainForm()
        {
            InitializeComponent();
            cbxCreateTypeSelection.SelectedIndex = 0;
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
                            ListMap map = listMap.Find(s => s.type == o.GetType());
                            if (map != null)
                            {
                                map.list.Add(o);
                            }
                            else
                            {
                                map = new ListMap(new List<object>(), o);
                                map.list.Add(o);
                                listMap.Add(map);
                            }
                        }
                    }
                }
                catch (Exception e)
                {
                    MessageBox.Show("An error has occured: " + e.Message, "Error");
                }
                if (dbPath.EndsWith(".dodb"))
                {
                    List<object> objs = new List<object>();
                    objs.Add(new Ammo());
                    objs.Add(new Booster());
                    objs.Add(new Drone());
                    objs.Add(new Design());
                    objs.Add(new Laser());
                    objs.Add(new Pet());
                    objs.Add(new Protocol());
                    objs.Add(new Shield());
                    objs.Add(new Spaceship());
                    foreach (object o in objs)
                    {
                        ListMap map = listMap.Find(s => s.type == o.GetType());
                        if (map == null)
                        {
                            map = new ListMap(new List<object>(), o);
                            listMap.Add(map);
                        }
                    }
                }
            }
            refreshDataSource();
        }

        public void SaveData()
        {
            if (lbxListTypes.Items.Count < 1)
            {
                MessageBox.Show("You have nothing to save!", "Error");
                return;
            }
            List<object> toSave = new List<object>();
            foreach (ListMap map in listMap)
            {
                toSave.Add(map.list);
            }

            BinaryFormatter bf = new BinaryFormatter();

            if (dbPath == "")
            {
                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.Title = "Select where to save file";
                saveFileDialog.Filter = lbxListTypes.Items.Count > 1 ? "DarkOrbit Database (*.dodb)|*.dodb" : "DarkOrbit SaveFile (*.dosv)|*.dosv";
                saveFileDialog.CheckPathExists = true;
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    dbPath = saveFileDialog.FileName;
                    txbDbPath.Text = dbPath;
                } else
                {
                    return;
                }
            }
            FileStream fsout = new FileStream(dbPath, FileMode.Create, FileAccess.Write, FileShare.None);
            try
            {
                using (fsout)
                {
                    bf.Serialize(fsout, toSave);
                }
                btnSaveToDB.BackColor = btnSelectDb.BackColor;
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
            fileDialog.Filter = "DarkOrbit Database (*.dodb, *.dosv)|*.dodb;*.dosv";
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
            if (sender is ListBox)
            {
                ListBox lbx = (ListBox)sender;
                if (lbx.Items.Count < 1 || lbx.SelectedItem == null || lbx.SelectedItem.ToString() == "")
                {
                    return;
                }
            }
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
                                break;
                            default:
                                Console.WriteLine(field.FieldType.Name + " type is not supported in flpItems!");
                                break;
                        }
                    }
                    catch (Exception ex)
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
            btnAddItem.Size = new Size(size / 2, size / 2);
            btnAddItem.Margin = new Padding(size / 4);
            btnAddItem.Click += BtnAddItem_Click;
            btnAddItem.Tag = mappedList;

            flpItems.Controls.Add(btnAddItem);
        }

        private void BtnAddItem_Click(object sender, EventArgs e)
        {
            ListMap listMap = (ListMap)((Control)sender).Tag;
            Panel s = new Panel();
            s.Tag = new object[] { Activator.CreateInstance(listMap.type), listMap };
            Item_Click(s, new EventArgs());
        }

        private void Item_Click(object sender, EventArgs e)
        {
            foreach(Control cntrl in flpItems.Controls)
            {
                if (cntrl is Panel)
                {
                    cntrl.BackColor = Color.FromArgb(25, 0, 0, 0);
                }
            }
            Control c = (Control)sender;
            object[] tag = (object[])c.Tag;
            c.BackColor = Color.FromArgb(25, Color.Gold);
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

                object value;
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
                            if ((value = field.GetValue(obj)) != null)
                            {
                                if (f.Name == field.GetValue(obj).ToString())
                                {
                                    cbx.SelectedIndex = i - 1;
                                }
                            }
                        }
                        i++;
                    }
                    if (cbx.SelectedIndex == -1 && cbx.Items.Count > 0)
                    {
                        cbx.SelectedIndex = 0;
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
                            if ((value = field.GetValue(obj)) != null)
                            {
                                txbString.Text = value.ToString();
                            }
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
                            if ((value = field.GetValue(obj)) != null)
                            {
                                nudInt.Value = (int)field.GetValue(obj);
                            }
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
                            if ((value = field.GetValue(obj)) != null)
                            {
                                pbx.BackgroundImage = (Image)field.GetValue(obj);
                            }
                            pbx.BackgroundImageLayout = ImageLayout.Zoom;
                            pbx.Height = pbx.Width = pnl.Width - 6;
                            pbx.Top = labName.Bottom + 5;
                            pbx.Click += detailsImagePbx_Click;

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

        private void detailsImagePbx_Click(object sender, EventArgs e)
        {
            OpenFileDialog fileDialog = new OpenFileDialog();
            fileDialog.Title = "Select new image";
            fileDialog.CheckFileExists = true;
            ImageCodecInfo[] codecs = ImageCodecInfo.GetImageEncoders();
            string extentions = "";
            foreach (ImageCodecInfo c in codecs)
            {
                extentions += c.FilenameExtension.Replace(";", "");
            }
            extentions = extentions.Replace("*.", ";*.");
            while (extentions.First() == ';')
            {
                extentions = extentions.Substring(1);
            }
            fileDialog.Filter = "Image Files|" + extentions;
            if (fileDialog.ShowDialog() == DialogResult.OK)
            {
                PictureBox pbxImage = (PictureBox)sender;
                pbxImage.BackgroundImage = Image.FromFile(fileDialog.FileName);
            }
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
        }

        private void refreshDataSource()
        {
            lbxListTypes.DataSource = null;
            lbxListTypes.DataSource = listMap;
        }

        private void btnCreateDB_Click(object sender, EventArgs e)
        {
            switch (cbxCreateTypeSelection.SelectedItem.ToString())
            {
                case "Game Database":
                    listMap.Clear();
                    if (dbPath != null)
                    {
                        txbDbPath.Text = dbPath = "";
                    }
                    listMap.Add(new ListMap(new Ammo()));
                    listMap.Add(new ListMap(new Booster()));
                    listMap.Add(new ListMap(new Drone()));
                    listMap.Add(new ListMap(new Design()));
                    listMap.Add(new ListMap(new Laser()));
                    listMap.Add(new ListMap(new Pet()));
                    listMap.Add(new ListMap(new Protocol()));
                    listMap.Add(new ListMap(new Shield()));
                    listMap.Add(new ListMap(new Spaceship()));
                    break;
                case "User save file":
                    listMap.Clear();
                    if (dbPath != null)
                    {
                        txbDbPath.Text = dbPath = "";
                    }
                    listMap.Add(new ListMap(new User()));
                    break;
                default:
                    MessageBox.Show("You've selected unsupported database type!", "Error");
                    break;
            }
            refreshDataSource();
        }
    }
}
