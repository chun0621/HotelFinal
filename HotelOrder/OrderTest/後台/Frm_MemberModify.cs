using OrderTest;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Test_Room
{
    public partial class Frm_MemberModify : Form
    {
        HotelOrderEntities HOTcontect = new HotelOrderEntities(); //new出實體
        public Frm_MemberModify()
        {
            InitializeComponent();
            HOTcontect.Database.Log = Console.WriteLine;  //log寫出輸入視窗

            this.pbxMemberPhoto.AllowDrop = true;  //拖放照片
            this.pbxMemberPhoto.DragDrop += PbxMemberPhoto_DragDrop;
            this.pbxMemberPhoto.DragEnter += PbxMemberPhoto_DragEnter;

            RoomAdmin_AdminId();  //管理編號下拉式選單

        }
        #region 拖拉照片
        private void PbxMemberPhoto_DragEnter(object sender, DragEventArgs e)  //拖放照片
        {
            e.Effect = DragDropEffects.Copy;
        }

        private void PbxMemberPhoto_DragDrop(object sender, DragEventArgs e)  //拖放照片
        {
            string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);
            pbxMemberPhoto.Image = System.Drawing.Image.FromFile(files[0]); //多個托放會抓第一個
        }
        #endregion


        #region 顯示資料

        void Read_RefreshDataGridView()
        {
            var result = this.HOTcontect.RoomMembers.ToList();

            ////參考
            ////https://dotblogs.com.tw/Leo_CodeSpace/2017/07/20/163800
            List<TempModel> newResult = new List<TempModel>(); //避免LINQ to Entities 查詢中無法建構實體或複雜類型的錯誤
            newResult = result.Select(o => new TempModel
            {
                MemberID = o.MemberID,
                MemberName = o.MemberName,
                MemberBirthday = o.MemberBirthday,
                MemberGender = o.MemberGender,
                MemberEMail = o.MemberEMail,
                MemberPhoto = o.MemberPhoto,
                MemberPhone = o.MemberPhone,
                MemberIdentity = o.MemberIdentity,
                AdminID = o.AdminID,
                MemberPassword = o.MemberPassword
            }).ToList();

            this.dataGridView1.DataSource = null;
            this.dataGridView1.DataSource = newResult;
        }

        #endregion


        #region 查詢資料

        private void btnCheck_Click(object sender, EventArgs e)  //查詢資料
        {
            Read_RefreshDataGridView();
        }

        #endregion


        #region 設定Admin流水字串

        void RoomAdmin_AdminId()  //設定RoomAdmin_AdminId方法
        {
            var q = from p in this.HOTcontect.RoomAdmins
                    select p.AdminID;
            this.comboAdminID.DataSource = q.ToList();
        }

        #endregion


        #region 新增資料
        private void btnInsert_Click(object sender, EventArgs e)  // 新增資料
        {
            if (string.IsNullOrWhiteSpace(txtMemberPhone.Text))
            {
                MessageBox.Show("會員電話不得為空");
                return;
            }

            if (string.IsNullOrWhiteSpace(txtMemberPassword.Text))
            {
                MessageBox.Show("密碼不得為空");
                return;
            }

            if (string.IsNullOrWhiteSpace(txtMemberName.Text))
            {
                MessageBox.Show("姓名不得為空");
                return;
            }

            if (string.IsNullOrWhiteSpace(txtMemberIdentity.Text))
            {
                MessageBox.Show("身分證字號不得為空");
                return;
            }

            if (string.IsNullOrWhiteSpace(MemberEMail.Text))
            {
                MessageBox.Show("Email不得為空");
                return;
            }

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
                    AdminID = comboAdminID.SelectedValue.ToString(),
                    MemberGender = Gender,
                    MemberPhoto = bytes[0] == 0 ? null : bytes
                };

                this.HOTcontect.RoomMembers.Add(newRoomMember);
                this.HOTcontect.SaveChanges();
                this.Read_RefreshDataGridView();
                MessageBox.Show("新增成功!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        #endregion


        #region  刪除資料

        private void btnDelete_Click(object sender, EventArgs e)  //刪除資料
        {
            //delete one product
            //var memberID = (from p in this.HOTcontect.RoomMembers
            //                    //where p.ProductName.Contains("Test")
            //                where p.MemberID == dataGridView1.CurrentCell.Value.ToString()
            //                select p).FirstOrDefault();

            //避免發生錯誤所以改用變數去接欄位裡面的值，然後再帶入
            try { 
            DialogResult result = MessageBox.Show("您確定要刪除此筆資料嗎?",
                      "刪除資料確認", MessageBoxButtons.YesNo, MessageBoxIcon.Warning
                    );
            if (result == DialogResult.Yes)
            {
                 

                    try
                    {

                        var CurrentMemberID = dataGridView1.CurrentRow.Cells["MemberID"].Value.ToString();

                        var memberID = this.HOTcontect.RoomMembers.Where(o => o.MemberID == CurrentMemberID).ToList().FirstOrDefault();

                        if (memberID == null) return;

                        this.HOTcontect.RoomMembers.Remove(memberID);
                        this.HOTcontect.SaveChanges();

                        this.Read_RefreshDataGridView();
                        MessageBox.Show("刪除成功!");
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

        #region 照片開啟資料夾

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            if (this.openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                this.pbxMemberPhoto.Image = Image.FromFile(this.openFileDialog1.FileName);

            }
        }
        #endregion

        #region 選取dataGridView整排資料

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //取得選取欄位的所有資料
            var data = dataGridView1.CurrentRow;

            //將每一個cell的值填入給對應的textbox裡面
            txtMemberID.Text = data.Cells["MemberID"].Value.ToString();
            txtMemberName.Text = data.Cells["MemberName"].Value.ToString();
            txtMemberPhone.Text = data.Cells["MemberPhone"].Value.ToString();
            MemberEMail.Text = data.Cells["MemberEMail"].Value.ToString();
            txtMemberIdentity.Text = Convert.ToString(data.Cells["MemberIdentity"].Value);
            rdoMale.Checked = Convert.ToString(data.Cells["MemberGender"].Value) == "男" ? true : false;
            rdoFemale.Checked = Convert.ToString(data.Cells["MemberGender"].Value) == "女" ? true : false;
            txtMemberPassword.Text = Convert.ToString(data.Cells["MemberPassword"].Value);

            if (data.Cells["MemberPhoto"].Value != null)
            {
                // 取得二進位資料
                byte[] imageBytes = (byte[])data.Cells["MemberPhoto"].Value;

                // 轉換二進位資料為圖片

                using (MemoryStream ms = new MemoryStream(imageBytes))
                {
                    pbxMemberPhoto.Image = Image.FromStream(ms);
                }
            }
        }

        #endregion

        #region 修改資料
        private void btnModify_Click(object sender, EventArgs e)
        {
            try
            {


                //update
                //取得該欄位的所有資料
                //========================================================
                string memberID_ = dataGridView1.CurrentRow.Cells["MemberID"].Value.ToString();

                var memberData = (from p in this.HOTcontect.RoomMembers
                                  where p.MemberID == memberID_
                                  select p).ToList().FirstOrDefault();
                //====圖片轉檔====================================================

                byte[] bytes = new byte[10];
                if (pbxMemberPhoto.Image != null)
                {
                    MemoryStream ms = new MemoryStream();
                    pbxMemberPhoto.Image.Save(ms, ImageFormat.Png);
                    bytes = ms.GetBuffer();
                }
                //========================================================

                //防止如果為Null出現的錯誤
                if (memberData == null) return; //exit method

                //欄位的修改
                //========================================================


                //性別處理
                // 0 : 女 ，1 : 男
                //string Gender = rdoMale.Checked ? "1" : "0";
                string Gender = rdoMale.Checked ? "男" : "女";

                memberData.MemberName = txtMemberName.Text;  //會員名字修改
                memberData.MemberID = memberID_;
                memberData.MemberIdentity = txtMemberIdentity.Text;
                memberData.MemberPhone = txtMemberPhone.Text;
                memberData.MemberPassword = txtMemberPassword.Text;
                memberData.MemberBirthday = dtmemberBirthday.Value;
                memberData.MemberEMail = MemberEMail.Text;
                memberData.AdminID = comboAdminID.SelectedValue.ToString();
                memberData.MemberGender = Gender;
                memberData.MemberPhoto = bytes[0] == 0 ? null : bytes;


                //========================================================

                //儲存邏輯
                //========================================================
                this.HOTcontect.SaveChanges();
                this.Read_RefreshDataGridView();
                //========================================================
                MessageBox.Show("修正成功!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        #endregion

        #region 欄位清空
        private void btnClear_Click(object sender, EventArgs e)
        {
            txtMemberID.Text = string.Empty;
            txtMemberPhone.Text = string.Empty;
            txtMemberPassword.Text = string.Empty;
            txtMemberName.Text = string.Empty;
            dtmemberBirthday.Text = DateTime.Now.ToString();
            rdoMale.Checked = false;
            rdoFemale.Checked = false;
            txtMemberIdentity.Text = string.Empty;
            MemberEMail.Text = string.Empty;
        }


        #endregion


        #region Demo
        private void btnDemo_Click(object sender, EventArgs e)
        {
            DateTime dateTime = new DateTime(2001, 2, 9);
            dtmemberBirthday.Value = dateTime;
            txtMemberIdentity.Text = "P296549893";
            txtMemberPhone.Text = "0930209738";
            txtMemberPassword.Text = "323NF668";
            txtMemberName.Text = "黃盈芝";
            MemberEMail.Text = "baker3225@gmail.com";
            rdoFemale.Checked = true;
        }

        #endregion



        public class TempModel
        {
            public string MemberID { get; set; }
            public string MemberName { get; set; }
            public string MemberPhone { get; set; }
            public string MemberEMail { get; set; }
            public byte[] MemberPhoto { get; set; }
            public Nullable<System.DateTime> MemberBirthday { get; set; }
            public string MemberPassword { get; set; }
            public string AdminID { get; set; }
            public string MemberGender { get; set; }

            public string MemberIdentity { get; set; }
        }

    }
}
