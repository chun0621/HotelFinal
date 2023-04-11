using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder;
using System.Data.Entity.Core.Metadata.Edm;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Reflection.Emit;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace OrderTest.後台
{
    public partial class Frm_Facility : Form
    {
        public Frm_Facility()
        {
            InitializeComponent();
            //設定瀏覽圖片可以用拖進去的方式
            //兩個pictureBox
            this.pictureBoxFacility.AllowDrop = true;
            this.pictureBoxFacility.DragEnter += pictureDragEnter;
            this.pictureBoxFacility.DragDrop += pictureDragDrop;

            this.pictureBoxHFacility.AllowDrop = true;
            this.pictureBoxHFacility.DragEnter += HpictureDragEnter;
            this.pictureBoxHFacility.DragDrop += pictureDragDrop;

            tabControl1.SelectedTab = tabPage3;
        }
        #region 圖片拖曳
        private void HpictureDragEnter(object sender, DragEventArgs e)
        {
            string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);
            this.pictureBoxHFacility.Image = Image.FromFile(files[0]);
        }

        HotelOrderEntities dbContext = new HotelOrderEntities();
        private void pictureDragDrop(object sender, DragEventArgs e)
        {
            string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);
            this.pictureBoxFacility.Image = Image.FromFile(files[0]);
        }

        private void pictureDragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Copy;
        }

        #endregion      

        #region 新增設備
        private void btnFacility_Click(object sender, EventArgs e)
        {
            showfacility();
        }

        private void btn_Insert_Click(object sender, EventArgs e)
        {
            //Add Product

            //byte[] bytes;
            //MemoryStream ms = new MemoryStream();
            //pictureBoxFacility.Image.Save(ms, ImageFormat.Png);
            //bytes = ms.GetBuffer();
            

                Facility newfacility = new Facility { 
                    FacilityName = textFacilityName.Text, FacilityImage = SavePicture()};
                this.dbContext.Facilities.Add(newfacility);

                this.dbContext.SaveChanges();
            showfacility();
            LoadRoomFacilitySelect();
        }
        #endregion

        #region 瀏覽設備圖片、儲存
        public byte[] SavePicture()//圖片轉成資料流
        {
            if (pictureBoxFacility.Image != null)
            {
                byte[] bytes;
                MemoryStream ms = new MemoryStream();
                pictureBoxFacility.Image.Save(ms, ImageFormat.Png);
                bytes = ms.GetBuffer();
                return bytes;
            }
            else
            {
                return null;
            }
        }
            private void btnBrowers_Click(object sender, EventArgs e)
        {
            DialogResult result = this.openFileDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {
                this.pictureBoxFacility.Image = Image.FromFile(this.openFileDialog1.FileName);
            }//瀏覽圖片並載入           
        }
        #endregion

        #region 選擇DGV設備資料行 資料會顯示在控制項上
        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                // 取得選取的資料列
                DataGridViewRow row = dataGridView1.SelectedRows[0];

                // 設定資料到 textbox
                textFacilityName.Text = row.Cells["FacilityName"].Value.ToString();

                if (row.Cells["FacilityImage"].Value != null)
                {
                    // 取得二進位資料
                    byte[] imageBytes = (byte[])row.Cells["FacilityImage"].Value;

                    // 轉換二進位資料為圖片

                    using (MemoryStream ms = new MemoryStream(imageBytes))
                    {
                        pictureBoxFacility.Image = Image.FromStream(ms);
                    }
                }
            }
        }
        #endregion

        #region 顯示設備
        private void showfacility()
        {
            var q = from p in dbContext.Facilities
                    select new { p.FacilityID, p.FacilityName, p.FacilityImage };

            this.dataGridView1.DataSource = q.ToList();
            //自動調欄寬高
            dataGridView1.AutoResizeColumns();
            dataGridView1.AutoResizeRows();

        }
        #endregion

        #region 刪除設備
        private void btn_Delete_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedCells.Count == 0)
            {
                MessageBox.Show("請先選擇一行資料", "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            int facilityID = (int)dataGridView1.CurrentRow.Cells["FacilityID"].Value;
            var delf = dbContext.Facilities.FirstOrDefault(f => f.FacilityID == facilityID);
            // 如果找到符合的記錄，就刪除它
                                           
                DialogResult result = MessageBox.Show("確定要刪除資料嗎？", "提示", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {//....
               
                    if (delf != null)
                    {
                        dbContext.Facilities.Remove(delf);
                        dbContext.SaveChanges();

                        MessageBox.Show("已刪除該筆資料");
                        showfacility();
                    LoadRoomFacilitySelect();
                }               
              
            }//......
            else
            {
                MessageBox.Show("不執行刪除資料動作");
            }
        }
        #endregion

        #region 更新設備

        void UpDateFacility()
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                int selectFactilityID = (int)dataGridView1.SelectedRows[0].Cells["FacilityID"].Value;

                // 找到要更新的資料
                var FacilityIDToUpdate = dbContext.Facilities.FirstOrDefault(rp => rp.FacilityID == selectFactilityID);

                if (FacilityIDToUpdate != null)
                {
                    // 進行更新
                    FacilityIDToUpdate.FacilityName = textFacilityName.Text;
                    FacilityIDToUpdate.FacilityImage = SavePicture();                    


                    this.dbContext.SaveChanges();
                    showfacility();
                }
            }
        }
        private void btn_Alter_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("確定要修改資料嗎？", "提示", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                UpDateFacility();
            }
        }
        #endregion
             
        #region 選擇DGV多設備資料行 資料會顯示在控制項上
        private void dataGridView2_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView2.SelectedRows.Count > 0)
            {
                // 取得選取的資料列
                DataGridViewRow row = dataGridView2.SelectedRows[0];

                // 設定資料顯示到 combobox               
                comboBoxFacilityID.Text = row.Cells["FacilityID"].Value.ToString();
                comboBoxRoomID.Text = row.Cells["RoomID"].Value.ToString();

            }
        }
        #endregion 

        #region 顯示房間多設備
        private void btnRoomFacilities_Click(object sender, EventArgs e)
        {
            var q = from p in dbContext.MultipleFacilities
                    select new { p.MultipleFacilitiesID, p.RoomID,p.FacilityID  };

            this.dataGridView2.DataSource = q.ToList();
        }
        #endregion

        #region Load設備管理的下拉式選單
        private void 設備管理_Load(object sender, EventArgs e)
        {
            {
                // 從 Entity Framework 中取得資料

                //var q = from r in dbContext.房型資訊管理
                //       select r.RoomID;             
                var q = from r in dbContext.Rooms
                        join rs in this.dbContext.RoomClasses
                        on r.RoomClassID equals rs.RoomClassID
                        join rf in this.dbContext.RoomStyles
                        on r.RoomStyleID equals rf.RoomStyleID

                        select new
                        {
                            Id = r.RoomID,
                            Name = rs.RoomClassName,
                            IdAndName = r.RoomID + " - " + rs.RoomClassName  + " - " + rf.RoomStyleName
                        };
                comboBoxRoomSearch.DisplayMember = "IdAndName";
                comboBoxRoomSearch.ValueMember = "Id";
                comboBoxRoomSearch.DataSource = q.ToList();

                var q2 = from r in dbContext.Rooms
                        select r.RoomID;
                comboBoxRoomID.DataSource = q2.ToList();

                LoadRoomFacilitySelect();


                var i = from hd in dbContext.HotelIndustries
                        select new
                        {
                            HID = hd.HotelID,
                            HName = hd.HotelName,
                            HIDAndName = hd.HotelID + "." + hd.HotelName
                        };                        
                    
                comboBoxHotelSearch.DisplayMember = "HIDAndName";
                comboBoxHotelSearch.ValueMember = "HID";
                comboBoxHotelSearch.DataSource = i.ToList();

                var q4 = from r in dbContext.HotelIndustries
                         select r.HotelID;
                comboBoxHotelID.DataSource = q4.ToList();

                showHotelFacility();

            }
            }    

        private void LoadRoomFacilitySelect()
        {
            var q3 = from r in dbContext.Facilities
                     select r.FacilityID;
            comboBoxFacilityID.DataSource = q3.ToList();

            var q5 = from r in dbContext.HotelFacilities
                     select r.HotelFacilityID;
            comboBoxHotelFacilityID.DataSource = q5.ToList();

        }
        #endregion
      
        #region 選擇房間 顯示的圖表變更
        private void RoomSearch()
        {
            var q = from mf in dbContext.MultipleFacilities
                    where mf.RoomID == comboBoxRoomSearch.Text.Substring(0, 4)
                    //select mf.MultipleFacilitiesID;
                    select new { mf.MultipleFacilitiesID, mf.RoomID, mf.FacilityID };

            this.dataGridView2.DataSource = q.ToList();
        }
        private void comboBoxRoomSearch_SelectedIndexChanged(object sender, EventArgs e)
        {            
            RoomSearch();
        }

        #endregion

        #region 新增房間多設備

        private void btn_Insert_RoomFacility_Click(object sender, EventArgs e)
        {                       

            int FacID = Convert.ToInt32(comboBoxFacilityID.SelectedValue);
            string newRoomID = comboBoxRoomID.SelectedValue.ToString();

            //var q3 = from r in dbContext.Facilities
            //         where r.FacilityID == FacID
            //         select r.FacilityID;

            //var q4 = from r in dbContext.房型資訊管理
            //         where r.RoomID == newRoomID
            //         select r.RoomID;

            var newRoomFacility = new MultipleFacility
            {
                FacilityID = FacID,
                RoomID = newRoomID,
            };

            this.dbContext.MultipleFacilities.Add(newRoomFacility);

            this.dbContext.SaveChanges();
            RoomSearch();            
        }
        #endregion

        #region 更新房間多設備
        void UpDateMutipleFacility()
        {
            if (dataGridView2.SelectedRows.Count > 0)
            {
                int selectMutipleFactilityID = (int)dataGridView2.SelectedRows[0].Cells["MultipleFacilitiesID"].Value;

                // 找到要更新的資料
                var MutipleFacilityIDToUpdate = dbContext.MultipleFacilities.FirstOrDefault(rp => rp.MultipleFacilitiesID == selectMutipleFactilityID);

                if (MutipleFacilityIDToUpdate != null)
                {
                    // 進行更新
                    MutipleFacilityIDToUpdate.RoomID = comboBoxRoomID.Text;
                    MutipleFacilityIDToUpdate.FacilityID = Convert.ToInt32(comboBoxFacilityID.Text);


                    this.dbContext.SaveChanges();
                    RoomSearch();
                }
            }
        }
        private void btn_Alter_RoomFacility_Click(object sender, EventArgs e)
        {
            UpDateMutipleFacility();
        }
        #endregion

        # region 刪除房間多設備
        private void btn_Del_RoomFacility_Click(object sender, EventArgs e)
        {
            {
                if (dataGridView2.SelectedCells.Count == 0)
                {
                    MessageBox.Show("請先選擇一行資料", "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                int MutiplyFacilityID = (int)dataGridView2.CurrentRow.Cells["MultipleFacilitiesID"].Value;
                var delf = dbContext.MultipleFacilities.FirstOrDefault(f => f.MultipleFacilitiesID == MutiplyFacilityID);
                // 如果找到符合的記錄，就刪除它

                DialogResult result = MessageBox.Show("確定要刪除資料嗎？", "提示", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {//....

                    if (delf != null)
                    {
                        dbContext.MultipleFacilities.Remove(delf);
                        dbContext.SaveChanges();

                        MessageBox.Show("已刪除該筆資料");
                        RoomSearch();
                        LoadRoomFacilitySelect();
                    }

                }//......
                else
                {
                    MessageBox.Show("不執行刪除資料動作");
                }
            }
        }
        #endregion

        #region 瀏覽飯店設施圖片、儲存、清空圖片
        private void btnBrowersHFacilityImage_Click(object sender, EventArgs e)
        {
            DialogResult result = this.openFileDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {
                this.pictureBoxHFacility.Image = Image.FromFile(this.openFileDialog1.FileName);
            }//瀏覽圖片並載入           
        }              
        public byte[] SaveHotelFacilityPicture()//圖片轉成資料流
        {
            if (pictureBoxHFacility.Image != null)
            {
                byte[] bytes;
                MemoryStream ms = new MemoryStream();
                //要承接受jpg和png圖檔
                ImageFormat format;
                if (pictureBoxHFacility.Image.RawFormat.Equals(ImageFormat.Jpeg))
                {
                    format = ImageFormat.Jpeg;
                }
                else
                {
                    format = ImageFormat.Png;
                }
                pictureBoxHFacility.Image.Save(ms, format);
                bytes = ms.GetBuffer();
                return bytes;
            }
            else
            {
                return null;
            }
        }
        
        private void btnClearHFacilityImage_Click(object sender, EventArgs e)
        {
            this.pictureBoxHFacility.Image = null;
        }
        #endregion        

        #region 顯示飯店設施
        private void showHotelFacility()
        {
            var q = from p in dbContext.HotelFacilities
                    select new { p.HotelFacilityID, p.HotelFacilityName, p.HotelFacilityImage };

            this.dataGridView4.DataSource = q.ToList();
            //自動調欄寬高
            dataGridView4.AutoResizeColumns();
            dataGridView4.AutoResizeRows();
        }
        private void btnHFacilityShow_Click(object sender, EventArgs e)
        {
            showHotelFacility();
        }
        #endregion

        #region 選擇飯店設施DGV
        private void dataGridView4_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //取得選取欄位的所有資料
            var data = dataGridView4.CurrentRow;

            //將每一個cell的值填入給對應的textbox裡面
            textBoxHotelFacilityName.Text = data.Cells["HotelFacilityName"].Value.ToString();

            if (data.Cells["HotelFacilityImage"].Value != null)
            {
                // 取得二進位資料
                byte[] imageBytes = (byte[])data.Cells["HotelFacilityImage"].Value;

                // 轉換二進位資料為圖片
                using (MemoryStream ms = new MemoryStream(imageBytes))
                {
                    pictureBoxHFacility.Image = Image.FromStream(ms);
                }
            }
        }

        #endregion

        #region 加入飯店設施
        private void btn_Insert_HFacility_Click(object sender, EventArgs e)
        {

            HotelFacility newHFacility = new HotelFacility
            {
                HotelFacilityName = textBoxHotelFacilityName.Text,
                HotelFacilityImage = SaveHotelFacilityPicture()
            };
            this.dbContext.HotelFacilities.Add(newHFacility);

            this.dbContext.SaveChanges();
            showHotelFacility();
        }
        #endregion

        #region 修改飯店設施

        private void btn_Alter_HFacility_Click(object sender, EventArgs e)
        {
            UpDateHotelFacility();
        }
       
        void UpDateHotelFacility()
        {
            if (dataGridView4.SelectedCells.Count == 0)
            {
                MessageBox.Show("請先選擇一行資料", "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            int selectHFactilityID = (int)dataGridView4.CurrentRow.Cells["HotelFacilityID"].Value;
            // 找到要更新的資料
                var HFacilityIDToUpdate = dbContext.HotelFacilities.FirstOrDefault(rp => rp.HotelFacilityID == selectHFactilityID);
                
                DialogResult result = MessageBox.Show("確定要修改資料嗎？", "提示", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {

                    if (HFacilityIDToUpdate != null)
                    {
                        // 進行更新
                        HFacilityIDToUpdate.HotelFacilityName = textBoxHotelFacilityName.Text;
                        HFacilityIDToUpdate.HotelFacilityImage = SavePicture();

                        this.dbContext.SaveChanges();
                        MessageBox.Show("已修改該筆資料");
                        showHotelFacility();
                    }
                }
                else
                {
                    MessageBox.Show("不執行修改資料動作");
                }            
        }

        #endregion

        #region 刪除飯店設施
        private void btn_Delete_HFacility_Click(object sender, EventArgs e)
        {
            if (dataGridView4.SelectedCells.Count == 0)
            {
                MessageBox.Show("請先選擇一行資料", "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            int HfacilityID = (int)dataGridView4.CurrentRow.Cells["HotelFacilityID"].Value;
            var delf = dbContext.HotelFacilities.FirstOrDefault(f => f.HotelFacilityID == HfacilityID);
            // 如果找到符合的記錄，就刪除它

            DialogResult result = MessageBox.Show("確定要刪除資料嗎？", "提示", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {//....

                if (delf != null)
                {
                    dbContext.HotelFacilities.Remove(delf);
                    dbContext.SaveChanges();

                    MessageBox.Show("已刪除該筆資料");
                    showHotelFacility();                    
                }
            }//......
            else
            {
                MessageBox.Show("不執行刪除資料動作");
            }
        }

        #endregion

      
        #region 顯示該飯店擁有的設施
        private void btnHotelFacilitiesShow_Click(object sender, EventArgs e)
        {
            var q = from p in dbContext.MultipleHotelFacilities
                    select new { p.MultipleHotelFacilityID, p.HotelID, p.HotelFacilityID };

            this.dataGridView3.DataSource = q.ToList();
        }
        #endregion

        #region 選擇飯店 顯示的圖表變更
        private void HotelSearch()
        {
            int num = Convert.ToInt32(comboBoxHotelSearch.Text.Substring(0, 1));
            var q = from mf in dbContext.MultipleHotelFacilities
                    where mf.HotelID == num
                    select new { mf.MultipleHotelFacilityID, mf.HotelID, mf.HotelFacilityID };

            this.dataGridView3.DataSource = q.ToList();
        }
        private void comboBoxHotelSearch_SelectedIndexChanged(object sender, EventArgs e)
        {
            HotelSearch();
        }


        #endregion

        #region 範本
        #endregion

        #region 新增飯店多設施
        private void btn_Insert_HotelFacility_Click(object sender, EventArgs e)
        {
            int newFacilityID = Convert.ToInt32(comboBoxHotelFacilityID.SelectedValue);
            int newHotelID = Convert.ToInt32(comboBoxHotelID.SelectedValue);
            

            var newHotelFacility = new MultipleHotelFacility
            {
                HotelFacilityID = newFacilityID,
                HotelID = newHotelID,
            };

            this.dbContext.MultipleHotelFacilities.Add(newHotelFacility);

            this.dbContext.SaveChanges();
            HotelSearch();
        }
        #endregion

        #region 修改飯店多設施
        void UpDateMutipleHotelFacility()
        {
            if (dataGridView3.SelectedCells.Count == 0)
            {
                MessageBox.Show("請先選擇一行資料", "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            int selectMHFactilityID = (int)dataGridView3.CurrentRow.Cells["MultipleHotelFacilityID"].Value;
            // 找到要更新的資料
            var MHFacilityIDToUpdate = dbContext.MultipleHotelFacilities.FirstOrDefault(rp => rp.MultipleHotelFacilityID == selectMHFactilityID);

            DialogResult result = MessageBox.Show("確定要修改資料嗎？", "提示", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {

                if (MHFacilityIDToUpdate != null)
                {
                    // 進行更新
                    MHFacilityIDToUpdate.HotelID = Convert.ToInt32(comboBoxHotelID.Text);
                    MHFacilityIDToUpdate.HotelFacilityID = Convert.ToInt32(comboBoxHotelFacilityID.Text);

                    this.dbContext.SaveChanges();
                    MessageBox.Show("已修改該筆資料");
                    HotelSearch();
                }
            }
            else
            {
                MessageBox.Show("不執行修改資料動作");
            }
        }
        private void btn_Alter_HotelFacility_Click(object sender, EventArgs e)
        {
            UpDateMutipleHotelFacility();
        }
        #endregion

        #region 刪除飯店多設施      
       
        private void btn_Delete_HotelFacility_Click(object sender, EventArgs e)
        {
            if (dataGridView3.SelectedCells.Count == 0)
            {
                MessageBox.Show("請先選擇一行資料", "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            int HMHfacilityID = (int)dataGridView3.CurrentRow.Cells["MultipleHotelFacilityID"].Value;
            var delf = dbContext.MultipleHotelFacilities.FirstOrDefault(f => f.MultipleHotelFacilityID == HMHfacilityID);
            // 如果找到符合的記錄，就刪除它

            DialogResult result = MessageBox.Show("確定要刪除資料嗎？", "提示", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {//....

                if (delf != null)
                {
                    dbContext.MultipleHotelFacilities.Remove(delf);
                    dbContext.SaveChanges();

                    MessageBox.Show("已刪除該筆資料");
                    HotelSearch();
                }
            }//......
            else
            {
                MessageBox.Show("不執行刪除資料動作");
            }
        }
        #endregion

        private void dataGridView3_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var data = dataGridView3.CurrentRow;

            //將每一個cell的值填入給對應的textbox裡面
            comboBoxHotelID.Text = data.Cells["HotelID"].Value.ToString();
            comboBoxHotelFacilityID.Text = data.Cells["HotelFacilityID"].Value.ToString();

        
        }
    }
}
