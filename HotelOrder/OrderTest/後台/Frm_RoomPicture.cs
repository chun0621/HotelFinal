using OrderTest;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prjMidterm1
{
    public partial class Frm_RoomPicture : Form
    {
        public Frm_RoomPicture()
        {
            InitializeComponent();
            this.HotelOrder.Database.Log = Console.Write;
            this.PicBRoom.DragEnter += FLPInsert_DragEnter;
            this.PicBRoom.DragDrop += FLPInsert_DragDrop;
            showRoomDate();

        }

        HotelOrderEntities HotelOrder = new HotelOrderEntities();
        PictureBox pic = new PictureBox();
        void showRoomDate()
        {
            var q = from p in HotelOrder.RoomImages
                    select new { p.RoomImagesID, p.RoomImageName, p.RoomID, p.RoomImage1, p.RoomImageDetail };

            this.dataGridView1.DataSource = q.ToList();
        }
        public void FLPInsert_DragDrop(object sender, DragEventArgs e)
        {
            string [] files = (string[])e.Data.GetData(DataFormats.FileDrop);
            for(int i = 0; i < files.Length; i++)
            {
                pic.Image = Image.FromFile(files[i]);
                pic.SizeMode = PictureBoxSizeMode.StretchImage;
                pic.Click += Pic_Click;

            }
        }

        public void Pic_Click(object sender, EventArgs e) //點選照片額外跳出視窗
        {
            Form f = new Form();
            f.BackgroundImage = ((PictureBox)sender).Image;
            f.BackgroundImageLayout = ImageLayout.Stretch;
            f.Show();
        }

        public void FLPInsert_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Copy;
        }     
        void Add(int A)//新增房間圖片表
        {
            RoomImage roomManage = new RoomImage()
            {
                RoomID = txtRoomID.Text,
                RoomImageName = txtRoomImagesName.Text,
                RoomImage1 = SavePicture(),
                RoomImageDetail = txtRoomImageDetail.Text,
               
            };
            HotelOrder.RoomImages.Add(roomManage);
        }
        void Read_RefreshDGV()//刷新DGV
        {
            this.dataGridView1.DataSource = null;
            this.dataGridView1.DataSource = HotelOrder.RoomImages.ToList();
        }
        void browse()
        {
            if (this.openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                this.PicBRoom.Image = Image.FromFile(this.openFileDialog1.FileName);
            }
        }//預覽圖片
        public byte[] SavePicture()//圖片轉成資料流
        {
            if(PicBRoom.Image != null)
            {
                byte[] bytes;
                MemoryStream ms = new MemoryStream();
                PicBRoom.Image.Save(ms, ImageFormat.Jpeg) ;
                bytes = ms.GetBuffer();
                return bytes;             
            }
            else
            {
                return null;
            }
            
                   

        }
        void Delete()
        {
            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("請先選擇一行資料", "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            // 取得該行的 RoomID
            string roomID = dataGridView1.CurrentRow.Cells["RoomID"].Value.ToString();    

            // 使用 LINQ 查詢找到符合該 RoomID 的房間圖片記錄
            var roomPicture = HotelOrder.RoomImages.FirstOrDefault(rp => rp.RoomID == roomID);

            // 如果找到符合的記錄，就刪除它
            if (roomPicture != null)
            {
                HotelOrder.RoomImages.Remove(roomPicture);
                HotelOrder.SaveChanges();
                Read_RefreshDGV();
            }

        }//選取索引[0] 做刪除
        void UpDate()
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                string selectedRoomID = dataGridView1.SelectedRows[0].Cells["RoomID"].Value.ToString();

                // 找到要更新的資料
                var roomPictureToUpdate = HotelOrder.RoomImages.FirstOrDefault(rp => rp.RoomID == selectedRoomID);

                if (roomPictureToUpdate != null)
                {
                    // 進行更新
                    roomPictureToUpdate.RoomImageName = txtRoomImagesName.Text;
                    roomPictureToUpdate.RoomID = txtRoomID.Text;
                    roomPictureToUpdate.RoomImage1 = SavePicture();
                    roomPictureToUpdate.RoomImageDetail = txtRoomImageDetail.Text;


                    HotelOrder.SaveChanges();
                    Read_RefreshDGV();
                }
            }

        }//指定欄位直接做修改 

        public void btnBrowse_Click(object sender, EventArgs e)
        {
            browse();
        }

        public void btnAdd_Click(object sender, EventArgs e)
        {
            int A = 0;
            if (txtRoomID.Text != "" &&
                txtRoomImagesName.Text != "" )             
            {
                Add(A);
                HotelOrder.SaveChanges();
                Read_RefreshDGV();
            }
            else
            {
                MessageBox.Show("欄位不可為空值 新增無效",(MessageBoxButtons.OK,MessageBoxIcon.Error).ToString());
            }

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            Delete();

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            UpDate();
        }


        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            //取得選取欄位的所有資料
            var data = dataGridView1.CurrentRow;

            //將每一個cell的值填入給對應的textbox裡面
            txtRoomImagesName.Text = data.Cells["RoomImageName"].Value.ToString();
            txtRoomID.Text = data.Cells["RoomID"].Value.ToString();                       

            if (data.Cells["RoomImageDetail"].Value != null)
            {
                txtRoomImageDetail.Text = data.Cells["RoomImageDetail"].Value.ToString();
            }
            else
            {
                txtRoomImageDetail.Text = null;
            }
            if (data.Cells["RoomImage1"].Value != null)
            {
                // 取得二進位資料
                byte[] imageBytes = (byte[])data.Cells["RoomImage1"].Value;

                // 轉換二進位資料為圖片

                using (MemoryStream ms = new MemoryStream(imageBytes))
                {
                    PicBRoom.Image = Image.FromStream(ms);
                }

            }
            else
            {
                PicBRoom.Image = null;
            }
        }
    }
}
