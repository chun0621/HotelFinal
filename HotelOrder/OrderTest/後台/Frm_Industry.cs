using OrderTest;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace HotelManager
{
    public partial class Frm_Industry : Form
    {
        public Frm_Industry()
        {
            InitializeComponent();
            Read_RefreshDataGridView();
        }

        //HotelOrderTestEntities HotelOrder = new HotelOrderTestEntities(); //在校時用的資料庫 //舊版
        //HotelOrderTestEntities2 HotelOrder = new HotelOrderTestEntities2(); //舊資料庫 已移除
        HotelOrderEntities HotelOrder = new HotelOrderEntities(); //最新版資料庫 現用 版本Hotel10.bak

        private void buttonSearch_Click(object sender, EventArgs e) //查詢完整資料
        {
            if (!string.IsNullOrWhiteSpace(textBoxHotelName.Text)
                    || !string.IsNullOrWhiteSpace(textBoxHotelPhone.Text)
                    || !string.IsNullOrWhiteSpace(textBoxHotelAddress.Text)
                    || !string.IsNullOrWhiteSpace(textBoxHotelID.Text))
            {
                var q = from p in HotelOrder.HotelIndustries.AsEnumerable()
                        where p.HotelID.ToString().Contains(textBoxHotelID.Text)
                        && p.HotelName.Contains(textBoxHotelName.Text)
                        && p.HotelPhone.Contains(textBoxHotelPhone.Text)
                        && p.HotelAddress.Contains(textBoxHotelAddress.Text)
                        select new
                        {
                            p.HotelID,
                            p.HotelName,
                            p.HotelPhone,
                            p.HotelAddress,
                            p.HotelRegionID,
                            p.HotelImage,
                            p.HotelImageDiscription
                        };
                this.dataGridView1.DataSource = q.ToList();
            }
            else
            {
                MessageBox.Show("至少輸入一個欄位", "查詢失敗", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        int A = 0;
        private void buttonCreate_Click(object sender, EventArgs e)
        {
            if (textBoxHotelName.Text != "" 
                && textBoxHotelPhone.Text != "" 
                && textBoxHotelAddress.Text != "" 
                && comboBoxRegionName.Text != "")
            {
                RegionIDChecK(ref A);
                Insert(A);
                HotelOrder.SaveChanges();
                Read_RefreshDataGridView();
            }
            else 
            {
                MessageBox.Show("欄位不可為空","新增失敗",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        private  void Insert(int A) //新增一筆資料
        {
            HotelIndustry HotelManage = new HotelIndustry
            {
                HotelName = textBoxHotelName.Text,
                HotelPhone = textBoxHotelPhone.Text,
                HotelAddress = textBoxHotelAddress.Text,
                HotelRegionID = A,
                HotelImage = pictureInsert(),
                HotelImageDiscription = textBoxHotelImageDiscription.Text,
            };
            HotelOrder.HotelIndustries.Add(HotelManage);
        }

        private void RegionIDChecK(ref int A)
        {
            if (comboBoxRegionName.Text == "北部地區")
            {
                A = 1;
            }
            else if (comboBoxRegionName.Text == "中部地區")
            {
                A = 2;
            }
            else if (comboBoxRegionName.Text == "南部地區")
            {
                A = 3;
            }
        }

        private byte[] pictureInsert()//將圖片轉換成資料流
        {
            if (pictureBoxImage.Image != null)
            {
                byte[] bytes;
                System.IO.MemoryStream ms = new System.IO.MemoryStream();
                pictureBoxImage.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                bytes = ms.GetBuffer();
                return bytes;
            }
            else 
            {
                return null;
            }
        }

        private void buttonAlter_Click(object sender, EventArgs e)//修改一筆資料 
        {
            if (dataGridView1.CurrentCellAddress.X > 0)
            {
                MessageBox.Show("請在Hotel ID欄選擇以完整修改資料", "修改失敗", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (textBoxHotelAddress.Text == "" || comboBoxRegionName.Text == "" || textBoxHotelName.Text == "" || textBoxHotelPhone.Text == "")
            {
                MessageBox.Show("偵測到有必需輸入資料欄位為空", "修改失敗", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            var AlterData = (from p in HotelOrder.HotelIndustries.AsEnumerable()
                             where p.HotelID == Convert.ToInt32(dataGridView1.CurrentCell.Value) //修改一筆資料
                             select p).FirstOrDefault();
            RegionIDChecK(ref A);
            if (AlterData == null) return;

            NewData(AlterData);

            HotelOrder.SaveChanges();
            Read_RefreshDataGridView();
        }

        private void NewData(HotelIndustry AlterData)
        {
            AlterData.HotelName = textBoxHotelName.Text;
            AlterData.HotelPhone = textBoxHotelPhone.Text;
            AlterData.HotelAddress = textBoxHotelAddress.Text;
            AlterData.HotelRegionID = A;
            AlterData.HotelImage = pictureInsert();
            AlterData.HotelImageDiscription = textBoxHotelImageDiscription.Text;
        }

        private void buttonDrop_Click(object sender, EventArgs e) //刪除一筆資料 //基本功能完成 //跟ROOM連動到 先改Room的子資料 再動HotelIndustries的主資料
        {

            if (dataGridView1.CurrentCellAddress.X > 0)
            {
                MessageBox.Show("請選擇Hotel ID以完整刪除資料", "刪除失敗", MessageBoxButtons.OK);
                return;
            }
            var DeleteHotelRow = (from p in HotelOrder.HotelIndustries.AsEnumerable()
                                  where p.HotelID == Convert.ToInt32(dataGridView1.CurrentCell.Value)
                                  select p).FirstOrDefault();
            if (DeleteHotelRow == null) return;
            //將刪除資料的關聯資料設為null
            var RoomDeleteHotelID = (from R in HotelOrder.Rooms.AsEnumerable()
                                     where R.HotelID == DeleteHotelRow.HotelID
                                     select R).ToList();
            if (RoomDeleteHotelID.Count > 0)
            {
                foreach (var room in RoomDeleteHotelID)
                {
                    room.HotelID = null;
                }
            }
            //刪除該筆資料
            HotelOrder.HotelIndustries.Remove(DeleteHotelRow);
            HotelOrder.SaveChanges();
            Read_RefreshDataGridView();

        }


        private void buttonInsertImage_Click(object sender, EventArgs e)
        {
            if (this.openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                pictureBoxImage.Image = Image.FromFile(openFileDialog1.FileName);
            }
        }
        void Read_RefreshDataGridView() //不可動 //刷新Datagridview1
        {
            var q = from p in HotelOrder.HotelIndustries.AsEnumerable() 
                    select new { p.HotelID, p.HotelName, p.HotelPhone, p.HotelAddress, p.HotelRegionID, p.HotelImage, p.HotelImageDiscription };
            this.dataGridView1.DataSource = null;
            this.dataGridView1.DataSource = q.ToList();
        }

        private void button1_Click(object sender, EventArgs e) //不要動 測試功能用按鈕
        {
            //var X = dataGridView1.CurrentCellAddress.X; //Column=X
            //var Y = dataGridView1.CurrentCellAddress.Y; //Row=Y
            //var Z = dataGridView1.CurrentCellAddress;
            //var Q = dataGridView1.CurrentRow.ToString(); //Datagridview { index=i }
            ////MessageBox.Show("Column == " + X + "" + "Row ==" + Y + "Z=" + Z);
            //MessageBox.Show("" + Q);
            //var AlterData = HotelOrder.業者資料.FirstOrDefault(p => p.HotelID == _selectedRowID);
            //if (AlterData == null) return;
            //NewData(AlterData);
            //HotelOrder.SaveChanges();
            //Read_RefreshDataGridView();
            var DeleteHotelRow = (from p in HotelOrder.HotelIndustries.AsEnumerable()
                                  where p.HotelID == Convert.ToInt32(dataGridView1.CurrentCell.Value)
                                  select p).FirstOrDefault();
            var RoomDeleteHotelID = from R in HotelOrder.Rooms
                                    where R.HotelID == DeleteHotelRow.HotelID
                                    select R;
            //MessageBox.Show(DeleteHotelRow.HotelID.ToString()+"AAA : "+ RoomDeleteHotelID.HotelID);

            var DeleteHotelRow1 = (from p in HotelOrder.HotelIndustries.AsEnumerable()
                                  where p.HotelID == Convert.ToInt32(dataGridView1.CurrentCell.Value)
                                  select p).FirstOrDefault();
            if (DeleteHotelRow == null) return;
            var RoomDeleteHotelID1 = (from R in HotelOrder.Rooms.AsEnumerable()
                                     where R.HotelID == DeleteHotelRow.HotelID
                                     select R).FirstOrDefault();
            if (RoomDeleteHotelID1 == null) return;
            RoomDeleteHotelID1.HotelID = null;

            dataGridView1.DataSource = RoomDeleteHotelID.ToList();


        }

        private void buttonClear_Click(object sender, EventArgs e) //清空
        {
            textBoxHotelID.Clear();
            textBoxHotelName.Clear();
            textBoxHotelPhone.Clear();
            textBoxHotelAddress.Clear();
            textBoxHotelImageDiscription.Clear();
            comboBoxRegionName.Text= string.Empty;
            pictureBoxImage.Image = null;
        }

        private void buttonshowall_Click(object sender, EventArgs e)//預覽全部資料
        {
            var q = from p in HotelOrder.HotelIndustries
                    select new { p.HotelID, p.HotelName, p.HotelPhone, p.HotelAddress, p.HotelRegionID, p.HotelImage, p.HotelImageDiscription };
            this.dataGridView1.DataSource = q.ToList();
        }
        
    }
}
