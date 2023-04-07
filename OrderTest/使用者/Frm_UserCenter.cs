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

namespace OrderTest.使用者
{
    public partial class Frm_UserCenter : Form
    {
        public Frm_UserCenter()
        {
            InitializeComponent();
        }
        void ShowForm(Form f)
        {
            this.splitContainer1.Panel2.Controls.Clear();

            f.TopLevel = false;
            f.FormBorderStyle = FormBorderStyle.None;
            f.Dock = DockStyle.Fill;
            f.Show();

            this.splitContainer1.Panel2.Controls.Add(f);
        }
        private void btn_UserOrder_Click(object sender, EventArgs e)
        {
            
        }

        private void btn_Member_Click(object sender, EventArgs e)
        {
            Frm_UserModify f = new Frm_UserModify();
            ShowForm(f);
        }
    }
}
