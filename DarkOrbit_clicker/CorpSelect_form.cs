using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DarkOrbit_clicker
{
    public partial class CorpSelect_form : Form
    {
        public CorpSelect_form(Registration_form authForm)
        {
            this.authForm = authForm;
            InitializeComponent();
            btn_acceptMMO.Tag = User.Corp.Mars;
            btn_acceptEIC.Tag = User.Corp.Earth;
            btn_acceptVRU.Tag = User.Corp.Venus;


        }

        private Registration_form authForm;

        private void panel1_MouseEnter(object sender, EventArgs e)
        {
            lbl_companyDescription.Text = "This is Mars.You have permanent bonus 10% for your all damage.";
        }

        private void panel2_MouseEnter(object sender, EventArgs e)
        {
            lbl_companyDescription.Text = "This is Venus.You have permanent bonus 15% for your health.";
        }

        private void panel3_MouseEnter(object sender, EventArgs e)
        {
            lbl_companyDescription.Text = "This is Earth.You have permanent bonus 15% for your shield.";
        }

        private void btn_acceptCorp_Click(object sender, EventArgs e)

        {

            Button buttonClicked = (Button)sender;
            User.Corp corp = (User.Corp)buttonClicked.Tag;
            if (MessageBox.Show("Are you sure you want to choose " + corp + "?", "Confirm", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                AuthService.currentUser.corporation = corp;
                //Tag у каждой кнопки содержит в себе соответствующий ей User.Corp
                //Если будет нажата кнопка, отвечающая за Марс, то MessageBox выведет "Mars"
                //Tag возвращает object. Чтобы из него получить User.Corp, надо "кастовать" его
                //Кастовать объект - указывать более точный тип объекта, когда ты наверняка знаешь, что именно этот тип тут будет
                //Синтаксис:       (ТипВКоторыйКастовать)объектКоторыйКастовать
                //В строчке выше я кастую объект sender к типу Button
                authForm.Success();
                this.Close();
            }
        }
    }
}
