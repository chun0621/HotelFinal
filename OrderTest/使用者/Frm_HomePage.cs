using OrderTest.使用者;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Test_Room;

namespace OrderTest
{
    public partial class 首頁 : Form
    {
        public 首頁()
        {
            InitializeComponent();
        }
       public void ShowForm(Form f)
        {
            this.splitContainer1.Panel2.Controls.Clear();

            f.TopLevel = false;
            f.FormBorderStyle = FormBorderStyle.None;
            f.Dock = DockStyle.Fill;
            f.Show();

            this.splitContainer1.Panel2.Controls.Add(f);
        }


        private void btn_UserCenter_Click(object sender, EventArgs e)
        {
            Frm_UserCenter f = new Frm_UserCenter();
            ShowForm(f);
        }

        private void btn_Login_Click(object sender, EventArgs e)
        {
            Frm_MemberLogIn f = new Frm_MemberLogIn();
            f.ShowDialog();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            this.splitContainer1.Panel2.Controls.Clear();
        }

        private void btn_About_Click(object sender, EventArgs e)
        {
            Frm_About f = new Frm_About();
            ShowForm(f);
        }

        private void btn_Activity_Click(object sender, EventArgs e)
        {

        }

        private void btn_Admin_Click(object sender, EventArgs e)
        {
            AdminLogin f = new AdminLogin();
            f.ShowDialog();
        }
    }
}
