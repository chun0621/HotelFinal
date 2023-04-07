using OrderTest;
using OrderTest.後台;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//using static Test_Room.MemberLogIn;

namespace Test_Room
{
    public partial class AdminLogin : Form
    {
        HotelOrderEntities HOTcontect = new HotelOrderEntities(); //new出實體
        public AdminLogin()
        {
            InitializeComponent();
            this.HOTcontect.Database.Log = Console.Write;
        }

        private void btnLogIn_Click(object sender, EventArgs e)
        {
            var AdminList = this.HOTcontect.RoomAdmins.ToList();

            foreach (var Admin in AdminList)
            {
                try
                {
                    if (txtAccount.Text == Admin.AdminID && txtPassword.Text == Admin.AdminPassword)
                    {

                        rememberAccount.Account = txtAccount.Text;
                        rememberAccount.Password = txtPassword.Text;
                        MessageBox.Show("登入成功");

                        this.Hide();
                        Frm_Management f = new Frm_Management();
                        f.ShowDialog();

                        return;


                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("錯誤訊息 : " + ex.ToString());
                }
            }
            MessageBox.Show("帳號與密碼不符");
        }

        private void btnLogInDemo_Click(object sender, EventArgs e)
        {
            txtAccount.Text = "AD00002";
            txtPassword.Text = "nY4HKbRH";
        }
        public static class rememberAccount
        {
            public static string Account = string.Empty;  //靜態類別裡面的資料也要靜態 static
            public static string Password = string.Empty;
            public static string Phone = string.Empty;
            public static string Identify = string.Empty;
            public static string Email = string.Empty;

        }
    }
}

