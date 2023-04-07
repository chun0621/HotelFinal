using OrderTest;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Data;
using System.Data.Entity;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Hotel
{
    public partial class Frm_Comments : Form
    {
        public Frm_Comments()
        {
            InitializeComponent();

            this.dbHotel.Database.Log = Console.WriteLine;

            dateTimePicker1.ResetText();
            Load_RoomMembers();
            Load_Rooms();
        }

        //===============================
        //HotelOrderTestEntities2 dbHotel = new HotelOrderTestEntities2();//教室用DB
        HotelOrderEntities dbHotel = new HotelOrderEntities();//家裡NB用

        //載入房間號碼
        void Load_Rooms()
        {
            var q = from p in this.dbHotel.Rooms
                    orderby p.RoomID
                    select p.RoomID;

            this.combxRoomId.DataSource = q.ToList();
        }
        //載入會員資料
        void Load_RoomMembers()
        {
            var q = from p in this.dbHotel.RoomMembers
                    orderby p.MemberID
                    select p.MemberID;

            this.combxMemberId.DataSource = q.ToList();
        }
        //新增資料
        private void btnInsert_Click(object sender, EventArgs e)
        {
            decimal Point;
            bool N = decimal.TryParse(txtCommentPoint.Text, out Point);
            if (N && Point >= 1 && Point <= 5)
            {
                Comment comment = new Comment
                {
                    MemberID = combxMemberId.Text,
                    RoomId = combxRoomId.Text,
                    CommentDate = dateTimePicker1.Value,
                    CommentPoint = Convert.ToDecimal(txtCommentPoint.Text), //轉小數點
                    CommentDetail = txtCommentDetail.Text
                };
                this.dbHotel.Comments.Add(comment);
                this.dbHotel.SaveChanges();

                this.Read_RefreshDataGridView();
            }
            else
            {
                MessageBox.Show("回饋評點請輸入1-5之間的數字");
            }
        }
        //修改
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            //update
            int commentid = Convert.ToInt32(this.dataGridView1.CurrentRow.Cells["CommentId"].Value);

            var CommentUpDate = dbHotel.Comments.FirstOrDefault(rp => rp.CommentId == commentid);

            if (CommentUpDate != null)
            {
                CommentUpDate.MemberID = combxMemberId.Text;
                CommentUpDate.RoomId = combxRoomId.Text;
                CommentUpDate.CommentPoint = Convert.ToDecimal(txtCommentPoint.Text);
                CommentUpDate.CommentDetail = txtCommentDetail.Text;

                dbHotel.SaveChanges();
                this.Read_RefreshDataGridView();
            }
        }
        //查詢:將資料載入到到dataGridView1
        private void btnSearch_Click(object sender, EventArgs e)
        {
            var q = from c in this.dbHotel.Comments
                    join m in this.dbHotel.RoomMembers
                    on c.MemberID equals m.MemberID
                    select new { c.CommentId, c.CommentDate, c.CommentPoint, c.CommentDetail, c.MemberID, m.MemberName, c.RoomId };

            this.dataGridView1.DataSource = q.ToList();
        }
        //刪除一筆資料
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentCellAddress.X > 0)
            {
                MessageBox.Show("請選擇要刪除的資料項", "刪除失敗", MessageBoxButtons.OK);
                return;
            }
            var deleteRow = (from p in this.dbHotel.Comments.AsEnumerable()
                             where p.CommentId == Convert.ToInt32(dataGridView1.CurrentCell.Value)
                             select p).FirstOrDefault(); 
            
            DialogResult result = MessageBox.Show("確定要刪除資料嗎？", "提示", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                try
                {
                    if (deleteRow != null)
                    {
                        this.dbHotel.Comments.Remove(deleteRow);

                        this.dbHotel.SaveChanges();

                        this.Read_RefreshDataGridView();
                        MessageBox.Show("已成功刪除資料");
                    }
                }
                catch (IndexOutOfRangeException ex)
                {
                    MessageBox.Show($"{ex}");
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"{ex}");
                }
            }
        }
        //重新載入資料到dataGridView1
        void Read_RefreshDataGridView()
        {
            this.dataGridView1.DataSource = null;
            this.dataGridView1.DataSource = this.dbHotel.Comments.ToList();
        }
        //將游標所在資料放進畫面各欄位項目
        private void dataGridView1_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            int commentid = Convert.ToInt32(this.dataGridView1.CurrentRow.Cells["CommentId"].Value);
                        
            var o = from c in this.dbHotel.Comments
                    join m in this.dbHotel.RoomMembers
                    on c.MemberID equals m.MemberID
                    where c.CommentId == commentid
                    select new
                    {
                        c.CommentId,
                        c.CommentDate,
                        c.MemberID,
                        m.MemberName,
                        c.RoomId,
                        c.CommentPoint,
                        c.CommentDetail,
                    };
            foreach (var CommentId in o)
            {
                txtCommentId.Text = CommentId .CommentId.ToString();
                dateTimePicker1.Text = CommentId.CommentDate.Value.ToString("yyyy-MM-dd HH:mm:ss");
                combxMemberId.Text = CommentId.MemberID;
                txtMemberName.Text = CommentId.MemberName;
                combxRoomId.Text = CommentId.RoomId;
                txtCommentPoint.Text = Convert.ToString(CommentId.CommentPoint);
                txtCommentDetail.Text = CommentId.CommentDetail;
            }
        }
        //清除畫面欄位資料
        private void btnClear_Click(object sender, EventArgs e)
        {
            txtCommentId.Clear();
            dateTimePicker1.ResetText();
            Load_RoomMembers();
            txtMemberName.Clear();
            Load_Rooms();
            txtCommentPoint.Clear();
            txtCommentDetail.Clear();

            this.dataGridView1.DataSource = null;
        }
    }
}
