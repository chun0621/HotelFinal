using OrderTest;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Reflection.Emit;
using System.Security.Principal;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Test_Room
{
    public partial class Frm_MemberLogIn : Form
    {
        HotelOrderEntities HOTcontect = new HotelOrderEntities(); //new出實體
        bool phoneCheck = false;
        bool passwordCheck = false;
        bool nameCheck = false;
        bool idCheck = false;
        bool emailCheck = false;
        List<TextBox> textBoxes; //所有的TextBox
        public Frm_MemberLogIn()
        {
            InitializeComponent();
            this.HOTcontect.Database.Log = Console.Write;

            this.pbxMemberPhoto.AllowDrop = true;
            this.pbxMemberPhoto.DragEnter += PbxMemberPhoto_DragEnter;
            this.pbxMemberPhoto.DragDrop += PbxMemberPhoto_DragDrop;

            txtPassword.UseSystemPasswordChar = true;
            //計算textBoxes數量
            textBoxes = tabPage2.Controls.OfType<TextBox>().ToList();
        }



        ////取得Form裡面所有的textbox
        //private List<TextBox> GetAllTextBoxControls(Control container)
        //{
        //    var textBoxList = new List<TextBox>();
        //    foreach (Control control in container.Controls)
        //    {
        //        if (control is TextBox textBox)
        //        {
        //            textBoxList.Add(textBox);
        //        }
        //        else if (control.HasChildren)
        //        {
        //            textBoxList.AddRange(GetAllTextBoxControls(control));
        //        }
        //    }
        //    return textBoxList;
        //}





        #region  註冊畫面_拖拉照片
        private void PbxMemberPhoto_DragDrop(object sender, DragEventArgs e)
        {
            string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);
            pbxMemberPhoto.Image = System.Drawing.Image.FromFile(files[0]); //多個托放會抓第一個
            pbxMemberPhoto.BackgroundImage = null;
        }

        private void PbxMemberPhoto_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Copy;

        }

        #endregion

        #region 註冊畫面_資料確認

        private void btnConfirm_Click(object sender, EventArgs e)  //資料確認
        {
            string Gender = rdoMale.Checked ? "男" : "女";
            try
            {

                DialogResult result = MessageBox.Show(
                    "您的手機號碼為：" + txtMemberPhone.Text + "\n\r" +
                    "您的密碼為：" + txtMemberPassword.Text + "\n\r" +
                    "您的姓名為：" + txtMemberName.Text + "\n\r" +
                    "您的身分證字號為：" + txtMemberIdentity.Text + "\n\r" +
                    "您的生日為：" + dtmemberBirthday.Value.ToString("yyyy-MM-dd") + "\n\r" +
                    "您的性別為：" + Gender + "\n\r" +
                    "您的電子信箱為：" + MemberEMail.Text + "\n\r",
                    "請您確認如下資料", MessageBoxButtons.OKCancel, MessageBoxIcon.Information
                    );
                if (result == DialogResult.OK)
                {
                    // btnInsert.Enabled = true;

                    try
                    {  //圖片轉檔
                        byte[] bytes = new byte[10];
                        if (pbxMemberPhoto.Image != null)
                        {
                            MemoryStream ms = new MemoryStream();
                            pbxMemberPhoto.Image.Save(ms, ImageFormat.Png);
                            bytes = ms.GetBuffer();
                        }


                        //性別處理
                        // 0 : 女 ，1 : 男
                        //string Gender = rdoMale.Checked ? "男" : "女";


                        //抓DB資料，先判斷是否有資料
                        //如果沒資料，MemberID的流水號由0開始
                        //如果有資料，取MemberID的最大值，並且+1
                        string memberID_ = string.Empty;
                        int maxMemberID = 0;

                        var q = this.HOTcontect.RoomMembers.Select(x => x.MemberID).ToList();

                        int count = q.Count();

                        maxMemberID = (count > 0) ? Convert.ToInt32(q.Max().Substring(2)) : 0;

                        memberID_ = (count == 0) ? "MB00000" : "MB" + (maxMemberID + 1).ToString().PadLeft(5, '0');

                        RoomMember newRoomMember = new RoomMember  //新增各項資料
                        {
                            MemberID = memberID_,
                            MemberIdentity = txtMemberIdentity.Text,
                            MemberPhone = txtMemberPhone.Text,
                            MemberPassword = txtMemberPassword.Text,
                            MemberName = txtMemberName.Text,
                            MemberBirthday = dtmemberBirthday.Value,
                            MemberEMail = MemberEMail.Text,
                            AdminID = "AD00010",
                            MemberGender = Gender,
                            MemberPhoto = bytes[0] == 0 ? null : bytes
                        };

                        this.HOTcontect.RoomMembers.Add(newRoomMember);
                        this.HOTcontect.SaveChanges();

                        MessageBox.Show("新增成功!");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }


                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        #endregion

        #region 註冊畫面_圖片開啟資料夾
        private void btnBrowse_Click(object sender, EventArgs e)  //圖片開啟資料夾
        {
            if (this.openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                this.pbxMemberPhoto.Image = Image.FromFile(this.openFileDialog1.FileName);
                pbxMemberPhoto.BackgroundImage = null;

            }
        }
        #endregion

        #region 註冊畫面_新增資料

        private void btnInsert_Click(object sender, EventArgs e) //新增資料
        {

            try
            {  //圖片轉檔
                byte[] bytes = new byte[10];
                if (pbxMemberPhoto.Image != null)
                {
                    MemoryStream ms = new MemoryStream();
                    pbxMemberPhoto.Image.Save(ms, ImageFormat.Png);
                    bytes = ms.GetBuffer();
                }


                //性別處理
                // 0 : 女 ，1 : 男
                string Gender = rdoMale.Checked ? "男" : "女";


                //抓DB資料，先判斷是否有資料
                //如果沒資料，MemberID的流水號由0開始
                //如果有資料，取MemberID的最大值，並且+1
                string memberID_ = string.Empty;
                int maxMemberID = 0;

                var q = this.HOTcontect.RoomMembers.Select(x => x.MemberID).ToList();

                int count = q.Count();

                maxMemberID = (count > 0) ? Convert.ToInt32(q.Max().Substring(2)) : 0;

                memberID_ = (count == 0) ? "MB00000" : "MB" + (maxMemberID + 1).ToString().PadLeft(5, '0');

                RoomMember newRoomMember = new RoomMember  //新增各項資料
                {
                    MemberID = memberID_,
                    MemberIdentity = txtMemberIdentity.Text,
                    MemberPhone = txtMemberPhone.Text,
                    MemberPassword = txtMemberPassword.Text,
                    MemberName = txtMemberName.Text,
                    MemberBirthday = dtmemberBirthday.Value,
                    MemberEMail = MemberEMail.Text,
                    AdminID = "AD00010",
                    MemberGender = Gender,
                    MemberPhoto = bytes[0] == 0 ? null : bytes
                };

                this.HOTcontect.RoomMembers.Add(newRoomMember);
                this.HOTcontect.SaveChanges();

                MessageBox.Show("新增成功!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        #endregion

        #region  登入畫面-登入確認
        private void btnLogIn_Click(object sender, EventArgs e)
        {
            var memberList = this.HOTcontect.RoomMembers.ToList();

            foreach (var member in memberList)
            {
                try
                {
                    if (txtAccount.Text == member.MemberPhone && txtPassword.Text == member.MemberPassword)
                    {

                        rememberAccount.Account = txtAccount.Text;
                        rememberAccount.Password = txtPassword.Text;
                        MessageBox.Show("登入成功");
                        //this.Close();
                        //Application.Run(new MemberInformation());


                        Frm_UserModify frmInformation = new Frm_UserModify();//產生MemberInformation的物件，才可以使用它所提供的Method

                        this.Visible = false;//將Form1隱藏。由於在Form1的程式碼內使用this，所以this為Form1的物件本身
                        frmInformation.Visible = true;//顯示第二個視窗
                        frmInformation.Show();
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

        #endregion

        #region 登入畫面-Demo資料

        private void btnLogInDemo_Click(object sender, EventArgs e)
        {
            txtAccount.Text = "0952221770";
            txtPassword.Text = "6Z674dK9";
        }

        #endregion

        #region Form表單

        private void MemberLogIn_Load(object sender, EventArgs e)
        {
            txtMemberPassword_Leave(sender, e);  //帳號密碼提示
            txtAccount_Leave(sender, e);  //登入帳號提示
            //txtPassword_Enter(sender, e);
            txtPassword_Leave_1(sender, e);  //登入密碼提示
            txtMemberPassword_TextChanged(sender, e); //呼叫密碼防呆
            txtMemberPhone_TextChanged(sender, e);  //呼叫手機號碼防呆方法
            txtPassword.UseSystemPasswordChar = true;

            //==========================================================

        }
        //=================================================================
        public void MemberLogIn_FormClosing(object sender, FormClosingEventArgs e)
        {
   
        }




        #endregion

        #region 註冊畫面_密碼提示
        Boolean txtInputHasText = true;

        void txtMemberPassword_Enter(object sender, EventArgs e)
        {
            if (txtInputHasText == false)
                txtMemberPassword.Text = "";
            txtMemberPassword.ForeColor = Color.Black;
        }
        void txtMemberPassword_Leave(object sender, EventArgs e)
        {
            if (txtMemberPassword.Text == "")
            {
                txtMemberPassword.Text = "輸入8到16位大小寫英文加數字";
                txtMemberPassword.ForeColor = Color.Gray;
                txtInputHasText = false;

            }
            else
                txtInputHasText = true;
        }
        #endregion

        #region  登入畫面_帳號提示
        Boolean txtAccountHasText = false;

        private void txtAccount_Enter(object sender, EventArgs e)
        {
            if (txtAccountHasText == false)
                txtAccount.Text = "";
            txtAccount.ForeColor = Color.Black;
        }

        private void txtAccount_Leave(object sender, EventArgs e)
        {
            if (txtAccount.Text == "")
            {
                txtAccount.Text = "為您的手機號碼";
                txtAccount.ForeColor = Color.Gray;
                txtAccountHasText = false;

            }
            else
                txtAccountHasText = true;
        }

        #endregion

        #region  登入畫面_密碼提示

        Boolean txtPasswordHasText = true;

        private void txtPassword_Enter_1(object sender, EventArgs e)
        {

            if (txtPasswordHasText == false)
                txtPassword.Text = "";
            txtPassword.ForeColor = Color.Black;
            txtPassword.UseSystemPasswordChar = true;  //會隱藏字元
        }

        private void txtPassword_Leave_1(object sender, EventArgs e)
        {
            if (txtPassword.Text == "")
            {
                txtPassword.Text = "8到16位大小寫英文加數字";
                txtPassword.ForeColor = Color.Gray;
                txtPasswordHasText = false;
                //txtPassword.UseSystemPasswordChar = false;  //不會隱藏字元

            }
            else
                txtPasswordHasText = true;
        }

        #endregion


        #region 防呆裝置

        //===密碼防呆==================================================================================

        string isPasswordCorrect(string Password)  //密碼防呆方法
        {
            bool result = true;
            string returnMsg = string.Empty;
            if (Password != null)
            {
                result = Regex.IsMatch(Password, @"^(?=.*\d)(?=.*[a-z])(?=.*[A-Z]).{8,16}$|^$|^輸入8到16位大小寫英文加數字$");

                //returnMsg =result ? "" : "密碼格式不正確";
                if (!result)  //初始為了隱藏標籤
                {
                    returnMsg = "請再確認您的密碼";
                    labPasswod.Visible = true;
                    passwordCheck = false;
                    btnConfirm.Enabled = false;
                }
                else
                {
                    passwordCheck = true;
                    if (phoneCheck && passwordCheck && nameCheck && idCheck && emailCheck) //防呆皆通過
                        btnConfirm.Enabled = true;
                }
            }
            return returnMsg;
        }

        private void txtMemberPassword_TextChanged(object sender, EventArgs e) //呼叫密碼防呆
        {
            labPasswod.Text = isPasswordCorrect(txtMemberPassword.Text);
        }

        //====手機號碼防呆=================================================================================

        string isPhoneCorrect(string Phone)  //手機號碼防呆方法
        {
            bool result = false;
            string returnMsg = string.Empty;
            if (Phone != null)
            {
                result = Regex.IsMatch(Phone, @"^09\d{8}$|^$");

                //returnMsg = result ? "" : "手機格式不正確"; 

                if (!result)  //初始為了隱藏標籤
                {
                    returnMsg = "請再確認您的手機號碼";
                    labphone.Visible = true;
                    phoneCheck = false;
                    btnConfirm.Enabled = false;
                }
                else
                {
                    phoneCheck = true;
                    if (phoneCheck && passwordCheck && nameCheck && idCheck && emailCheck) //防呆皆通過
                        btnConfirm.Enabled = true;
                }
            }
            return returnMsg;
        }

        private void txtMemberPhone_TextChanged(object sender, EventArgs e)  //呼叫手機號碼防呆方法
        {
            labphone.Text = isPhoneCorrect(txtMemberPhone.Text);
        }

        //====身分證字號防呆=================================================================================

        string isIdentityCorrect(string Identity)  //身分證字號防呆方法txtMemberIdentity
        {
            bool result = false;
            string returnMsg = string.Empty;
            if (Identity != null)
            {
                result = Regex.IsMatch(Identity, @"^[A-Z][12]\d{8}$|^$");

                if (!result)  //初始為了隱藏標籤
                {
                    returnMsg = "請再確認您的身份證字號";
                    labIdentity.Visible = true;
                    idCheck = false;
                    btnConfirm.Enabled = false;
                }
                else
                {
                    idCheck = true;
                    if (phoneCheck && passwordCheck && nameCheck && idCheck && emailCheck) //防呆皆通過
                        btnConfirm.Enabled = true;
                }
            }
            return returnMsg;
        }
        private void txtMemberIdentity_TextChanged(object sender, EventArgs e)  //呼叫身分證字號防呆方法
        {
            labIdentity.Text = isIdentityCorrect(txtMemberIdentity.Text);
        }

        //====電子信箱防呆=================================================================================

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
                    if (phoneCheck && passwordCheck && nameCheck && idCheck && emailCheck) //防呆皆通過
                        btnConfirm.Enabled = true;
                }
            }
            return returnMsg;
        }

        private void MemberEMail_TextChanged(object sender, EventArgs e)  //呼叫電子信箱防呆方法
        {
            labEmail.Text = isEmailCorrect(MemberEMail.Text);
        }

        //=====姓名防呆================================================================================

        string isNameCorrect(string Name)  //姓名防呆方法  
        {
            bool result = false;
            string returnMsg = string.Empty;
            if (Name != null)
            {
                result = Regex.IsMatch(Name, @"^[\u4e00-\u9fa5]{2,5}$|^$");

                if (!result)  //初始為了隱藏標籤
                {
                    returnMsg = "請輸入您完整中文姓名";
                    labName.Visible = true;
                    nameCheck = false;
                    btnConfirm.Enabled = false;
                }
                else
                {
                    nameCheck = true;
                    if (phoneCheck && passwordCheck && nameCheck && idCheck && emailCheck) //防呆皆通過
                        btnConfirm.Enabled = true;
                }
            }
            return returnMsg;
        }

        private void txtMemberName_TextChanged(object sender, EventArgs e) //呼叫姓名防呆方法
        {
            labName.Text = isNameCorrect(txtMemberName.Text);
        }

        #endregion

        #region 註冊畫面-Demo資料

        private void btnInsertDemo_Click(object sender, EventArgs e)
        {

            DateTime dateTime = new DateTime(2001, 1, 2);
            dtmemberBirthday.Value = dateTime;
            txtMemberIdentity.Text = "B109630088";
            txtMemberPhone.Text = "0912973280";
            txtMemberPassword.Text = "CBQ2ec3r";
            txtMemberName.Text = "賴弘逞";
            MemberEMail.Text = "eddie3862@hotmail.com";
            rdoMale.Checked = true;
        }


        #endregion





        //將註冊畫面的帳號使用靜態模式，讓MemberInformation可以抓到資料
        public static class rememberAccount
        {
            public static string Account = string.Empty;  //靜態類別裡面的資料也要靜態 static
            public static string Password = string.Empty;
            public static string Phone = string.Empty;
            public static string Identify = string.Empty;

        }

        private void linkLabel1_Click(object sender, EventArgs e)
        {
            Frm_MemberIForgetPassword f = new Frm_MemberIForgetPassword();
            f.ShowDialog();
        }
    }

}




