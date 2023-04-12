using Hotel;
using HotelManager;
using prjMidterm1;
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

namespace OrderTest.後台
{
    public partial class Frm_Management : Form
    {
        public Frm_Management()
        {
            InitializeComponent();
        }
        void ShowForm(Form f)
        {
            this.splitContainer2.Panel2.Controls.Clear();

            f.TopLevel = false;
            f.FormBorderStyle = FormBorderStyle.None;
            f.Dock = DockStyle.Fill;
            f.Show();

            this.splitContainer2.Panel2.Controls.Add(f);
        }
        private void btn_Member_Click(object sender, EventArgs e)
        {
            Frm_MemberModify f =new Frm_MemberModify();
            ShowForm(f);
        }

        private void btn_Room_Click(object sender, EventArgs e)
        {
            Frm_Room f = new Frm_Room();
            ShowForm(f);
        }

        private void btn_Facility_Click(object sender, EventArgs e)
        {
            Frm_Facility f = new Frm_Facility();
            ShowForm(f);
        }

        private void btn_Order_Click(object sender, EventArgs e)
        {
            Frm_Order f = new Frm_Order();
            ShowForm(f);
        }

        private void btn_Activity_Click(object sender, EventArgs e)
        {
            Frm_Activity f = new Frm_Activity();
            ShowForm(f);
        }

        private void btn_Industry_Click(object sender, EventArgs e)
        {
            Frm_Industry f = new Frm_Industry();
            ShowForm(f);
        }

        private void btn_Comment_Click(object sender, EventArgs e)
        {
            Frm_Comments f = new Frm_Comments();
            ShowForm(f);
        }
    }
}
