using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder;
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
            this.pictureBoxFacility.AllowDrop = true;
            this.pictureBoxFacility.DragEnter += pictureDragEnter;
            this.pictureBoxFacility.DragDrop += pictureDragDrop;
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
        private void showfacility()
        {
 
            var q = from p in dbContext.Facilities
                    select new { p.FacilityID, p.FacilityName, p.FacilityImage };

            this.dataGridView1.DataSource = q.ToList();
            //自動調欄寬高
            dataGridView1.AutoResizeColumns();
            dataGridView1.AutoResizeRows();

        }
        private void btnRoomFacilities_Click(object sender, EventArgs e)
        {
            var q = from p in dbContext.MultipleFacilities
                    select new { p.MultipleFacilitiesID, p.RoomID,p.FacilityID  };

            this.dataGridView2.DataSource = q.ToList();
        }

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
                
            }
            }

        private void LoadRoomFacilitySelect()
        {
            var q3 = from r in dbContext.Facilities
                     select r.FacilityID;
            comboBoxFacilityID.DataSource = q3.ToList();
        }

        private void comboBoxRoomSearch_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            RoomSearch();
        }

        private void RoomSearch()
        {
            var q = from mf in dbContext.MultipleFacilities
                    where mf.RoomID == comboBoxRoomSearch.Text.Substring(0, 4)
                    //select mf.MultipleFacilitiesID;
                    select new { mf.MultipleFacilitiesID, mf.RoomID, mf.FacilityID };

            this.dataGridView2.DataSource = q.ToList();
        }

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

        private void btn_Alter_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("確定要修改資料嗎？", "提示", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                UpDateFacility();              
            }
            /////////
        }

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
            //////////////////////////////////////////////////////////////////

        }
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
    }
}
