using OrderTest;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static Test_Room.Frm_MemberLogIn;
using static Test_Room.Frm_MemberModify;

namespace Test_Room
{
    public partial class Frm_UserModify : Form
    {

        HotelOrderEntities dbcontext = new HotelOrderEntities();
        Frm_MemberLogIn memberLogIn = new Frm_MemberLogIn();
        bool passwordCheck = false;
        bool emailCheck = false;

        public Frm_UserModify()
        {
            InitializeComponent();
            this.dbcontext.Database.Log = Console.Write;

            showOrderDataGridView();  //開啟視窗同時呈現出訂單資料
            showMemberInformation(); //開啟視窗同時會員資料

            pbxMemberPhoto.AllowDrop = true;
            pbxMemberPhoto.DragDrop += PbxMemberPhoto_DragDrop;
            pbxMemberPhoto.DragEnter += PbxMemberPhoto_DragEnter;

        

        }

  

        private void PbxMemberPhoto_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Copy;
        }

        private void PbxMemberPhoto_DragDrop(object sender, DragEventArgs e)
        {
            string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);
            pbxMemberPhoto.Image = System.Drawing.Image.FromFile(files[0]); //多個托放會抓第一個
            pbxMemberPhoto.BackgroundImage = null;
        }

        #region 查詢訂單
        //======查詢訂單===================================================================================
        private void showOrderDataGridView()  //查詢訂單
        {  
            try{

            string rememberAccountid = string.Empty;

            var m = from p in this.dbcontext.RoomMembers.Where(o => o.MemberPhone == rememberAccount.Account)

                    select new
                    {
                        會員編號 = p.MemberID,
                    };

            rememberAccountid = m.ToList().First().會員編號.ToString();

            var q = from p in this.dbcontext.Orders
                    select new
                    {
                        訂單編號 = p.OrderID,
                        會員編號 = p.MemberID,
                        訂單時間 = p.OrderDate,
                        訂單總金額 = p.OrderTotalPrice,
                        住宿人數 = p.CheckInPeople,
                        活動編號 = p.ActivityID,
                        備註 = p.OrderRemark,
                        訂單狀態 = p.OrderClosed
                    };
            this.OrderDataGridView.DataSource = q.Where(o => o.會員編號 == rememberAccountid).ToList();
            }
            catch (ArgumentNullException ex)
            {
                MessageBox.Show(Text, ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show(Text, ex.Message);
            }
        }

        //======訂單明細===================================================================================
        private void OrderDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try { 
            string orderid = OrderDataGridView.CurrentRow.Cells["訂單編號"].Value.ToString();

            var q = from od in this.dbcontext.OrderDetails
                    where od.OrderID == orderid
                    select new
                    {
                        訂單明細編號 = od.OrderDetailID,
                        訂單編號 = od.OrderID,
                        房間編號 = od.RoomID,
                        住宿日期 = od.MoveInDate,
                        退宿日期 = od.MoveOutDate,
                        付款日期 = od.PaymentDate,
                        付款編號 = od.PaymentID,
                        付款金額 = od.PaymentPrice,
                        訂單明細狀態 = od.OrderDetailStatusID,
                        備註 = od.OrderDetailRemark
                    };

            this.OrderDetaildataGridView2.DataSource = q.ToList();

            //取得同OrderID下, 所有OrederDetailID的內容
            var odlist = q.Select(od => od.訂單明細編號).ToList();
            }
            catch (ArgumentNullException ex)
            {
                MessageBox.Show(Text, ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show(Text, ex.Message);
            }
        }
        #endregion


        #region 密碼變更
        //======密碼變更===================================================================================
        private void btnCheckPasswork_Click(object sender, EventArgs e)
        {
            try
            {
                string rememberAccountid = string.Empty;
                var member = dbcontext.RoomMembers.SingleOrDefault
                    (o => o.MemberPhone == rememberAccount.Account && o.MemberPassword == rememberAccount.Password);
                if (member != null && rememberAccount.Password== txtOldPassword.Text)
                {
                    string newPassword = txtNewPassword.Text;
                    member.MemberPassword = newPassword;
                    dbcontext.SaveChanges();
                    MessageBox.Show("您的密碼已重設。", "成功");
                }

                else
                {
                    MessageBox.Show("您輸入的舊密碼錯誤。", "錯誤");
                }
            }
            catch (ArgumentNullException ex)
            {
                MessageBox.Show(Text, ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show(Text, ex.Message);
            }
        }
        #endregion

        #region 密碼防呆
        //===密碼防呆==================================================================================

        string isPasswordCorrect(string Password)  //密碼防呆方法
        {
            bool result = true;
            string returnMsg = string.Empty;
            if (Password != null)
            {
                result = Regex.IsMatch(Password, @"^(?=.*\d)(?=.*[a-z])(?=.*[A-Z]).{8,16}$|^$|^輸入8到16位大小寫英文加數字$");

                if (!result)  //初始為了隱藏標籤
                {
                    returnMsg = "請再確認您的密碼";
                    //labPasswod.Visible = true;
                    passwordCheck = false;
       
                }
                else
                {
                    passwordCheck = true;
       
                }
            }
            return returnMsg;
        }

        private void txtNewPassword_TextChanged(object sender, EventArgs e) //呼叫密碼防呆
        {
            labPasswod.Text = isPasswordCorrect(txtNewPassword.Text);
        }

        #endregion

        #region 資料修改

        private void showMemberInformation()
        {
            try
            {
                string rememberAccountid = string.Empty;

                var member = dbcontext.RoomMembers.Where
                 (o => o.MemberPhone == rememberAccount.Account && o.MemberPassword == rememberAccount.Password);
                if (member != null)
                {
                    txtMemberPhone.Text = member.First().MemberPhone.ToString();
                    MemberEMail.Text = member.First().MemberEMail.ToString();
                    txtMemberIdentity.Text = member.First().MemberIdentity.ToString();
                    txtMemberName.Text = member.First().MemberName.ToString();
                    dtmemberBirthday.Value = member.First().MemberBirthday.Value;
                    rdoMale.Checked = member.First().MemberGender.ToString() == "男" ? true : false;
                    rdoFemale.Checked = member.First().MemberGender.ToString() == "女" ? true : false;
                    //bytes =member.First().MemberPhoto as byte[];

                    //byte[] bytes = member.First().MemberPhoto as byte[];
                    //if (pbxMemberPhoto.Image != null)
                    //{
                    //    MemoryStream ms = new MemoryStream();
                    //    pbxMemberPhoto.Image.Save(ms, ImageFormat.Png);
                    //    bytes = ms.GetBuffer();
                    //}

                    if (member.First().MemberPhoto != null)
                    {
                        pbxMemberPhoto.BackgroundImage = null;
                        byte[] bytes = member.First().MemberPhoto;
                        using (MemoryStream ms = new MemoryStream(bytes))
                        {
                            pbxMemberPhoto.Image = Image.FromStream(ms);
                        }
                    }
                   
                }


            }
            catch (ArgumentNullException ex)
            {
                MessageBox.Show(Text, ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show(Text, ex.Message);
            }


            #endregion
        }

        #region 資料更新
        private void btnConfirm_Click(object sender, EventArgs e)
        {
            string rememberAccountid = string.Empty;

            string memberData = dbcontext.RoomMembers.ToString();

            byte[] bytes = new byte[10];
            if (pbxMemberPhoto.Image != null)
            {
                MemoryStream ms = new MemoryStream();
                pbxMemberPhoto.Image.Save(ms, ImageFormat.Png);
                bytes = ms.GetBuffer();
            }

            var member = dbcontext.RoomMembers.FirstOrDefault
             (o => o.MemberPhone == rememberAccount.Account && o.MemberPassword == rememberAccount.Password);

            if (member != null)
            {

                string Gender = rdoMale.Checked ? "男" : "女";

                member.MemberEMail = MemberEMail.Text;
                member.MemberGender = Gender;
                member.MemberPhone = txtMemberPhone.Text;
                member.MemberIdentity = txtMemberIdentity.Text;
                member.MemberName = txtMemberName.Text;
                member.MemberBirthday = dtmemberBirthday.Value;
                member.MemberPhoto =  bytes[0] == 0 ? null : bytes;

                //========================================================

                //儲存邏輯
                //========================================================
                this.dbcontext.SaveChanges();
                this.showMemberInformation();
                //========================================================
                MessageBox.Show("修正成功!");
            }

        }

        #endregion

        #region 電子信箱防呆

        string isEmailCorrect(string Email)  //電子信箱防呆方法  
        {
            bool result = false;
            string returnMsg = string.Empty;
            if (Email != null)
            {
                result = Regex.IsMatch(Email, @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$|^$");

                if (!result)  //初始為了隱藏標籤
                {
                    returnMsg = "請再確認您的電子信箱";
                    labEmail.Visible = true;
                    emailCheck = false;
                    btnConfirm.Enabled = false;
                }
                else
                {
                    emailCheck = true;
                    btnConfirm.Enabled = true;
                }
            }
            return returnMsg;
        }
         

        private void MemberEMail_TextChanged(object sender, EventArgs e)
        {
            labEmail.Text = isEmailCorrect(MemberEMail.Text);
        }



        #endregion



        private void btnBrowse_Click(object sender, EventArgs e)
        {
            if (this.openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                this.pbxMemberPhoto.Image = Image.FromFile(this.openFileDialog1.FileName);
                pbxMemberPhoto.BackgroundImage = null;

            }
        }
    }
}


