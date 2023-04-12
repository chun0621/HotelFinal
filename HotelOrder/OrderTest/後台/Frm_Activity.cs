using OrderTest;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prjMidterm1
{
    public partial class Frm_Activity : Form
    {
        public Frm_Activity()
        {
            InitializeComponent();
            //showYeaActivity();
        }

        HotelOrderEntities HotelOrder = new HotelOrderEntities();
        void showYeaActivity()
        {
            var q = from p in HotelOrder.Activities
                    select new { p.ActivityID, p.ActivityName, p.ActivityStartDate, p.ActivityEndDate, p.ActivityDescription, p.Discount };

            this.dataGridView1.DataSource = q.ToList();
        } 
        void Add(int A)
        {

            Activity Activity = new Activity()
            {
                ActivityName = txtActivityName.Text,
                ActivityStartDate = DTCStart.Value,
                ActivityEndDate = DTCEnd.Value,
                ActivityDescription = txtActivityDescription.Text,
                Discount = decimal.Parse(txtDisCount.Text)
            };
            HotelOrder.Activities.Add(Activity);

        }//新增
        void Delete()
        {
            if (dataGridView1.SelectedRows.Count > 0) // 檢查是否有選取資料列
            {
                int selectedRowIndex = dataGridView1.SelectedRows[0].Index; // 取得選取資料列的索引值
                int activityId = (int)dataGridView1.Rows[selectedRowIndex].Cells["ActivityID"].Value; // 取得選取資料列的活動 ID

                // 從資料庫中刪除選取的活動資料
                var activity = HotelOrder.Activities.Find(activityId);
                HotelOrder.Activities.Remove(activity);
                HotelOrder.SaveChanges();

                Read_RefreshDGV(); // 刷新資料表
            }
            else
            {
                MessageBox.Show("請選取要刪除的資料列", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }//刪除
        void UpDate()
        {
            // 確認dataGridView1中選取了一行
            if (dataGridView1.SelectedRows.Count > 0)
            {
                // 獲取選取行的第一行（假設只允許單行選取）
                DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];

                // 獲取所選行的ID，此處假設ID欄位是第0個欄位，且其值的類型為int
                int selectedId = (int)selectedRow.Cells[0].Value;

                // 根據所選ID獲取要修改的活動管理記錄
                Activity selectedActivity = HotelOrder.Activities.FirstOrDefault(a => a.ActivityID == selectedId);

                // 如果找到了該活動管理記錄
                if (selectedActivity != null)
                {
                    // 更新活動管理記錄的屬性值
                    selectedActivity.ActivityName = txtActivityName.Text;
                    selectedActivity.ActivityStartDate = DTCStart.Value;
                    selectedActivity.ActivityEndDate = DTCEnd.Value;
                    selectedActivity.ActivityDescription = txtActivityDescription.Text;
                    selectedActivity.Discount = decimal.Parse(txtDisCount.Text);

                    // 提交更改
                    HotelOrder.SaveChanges();
                    // 刷新DGV以更新資料
                    Read_RefreshDGV();
                }
                else
                {
                    MessageBox.Show("找不到要修改的活動管理記錄。", (MessageBoxButtons.OK).ToString());
                }
            }
            else
            {
                MessageBox.Show("請選擇要修改的活動管理記錄。" , (MessageBoxButtons.OK).ToString());
            }
           
        }//修改
        void Read_RefreshDGV()//刷新DGV
        {
            this.dataGridView1.DataSource = null;
            this.dataGridView1.DataSource = HotelOrder.Activities.ToList();
        }
        
        private void btnAdd_Click(object sender, EventArgs e)
        {
            int A = 0;
            if (txtActivityName.Text != "" &&
                DTCStart.Value != null &&
                DTCEnd.Value != null)

            {
                Add(A);
               
                HotelOrder.SaveChanges();
                Read_RefreshDGV();
            }
            else
            {
                MessageBox.Show("欄位不可為空值 新增無效", (MessageBoxButtons.OK, MessageBoxIcon.Error).ToString());
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            UpDate();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            Delete();
        }
    }
}
