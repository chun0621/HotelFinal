using OrderTest;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;



namespace Hotel
{
    public partial class Frm_Order : Form
    {
        public Frm_Order()
        {
            InitializeComponent();
            this.dbcontext.Database.Log = Console.Write;

            showOrderDataGridView();
            showOrderDetaildataGridView2();
        }

        //資料庫寫入
        HotelOrderEntities dbcontext = new HotelOrderEntities();

        //呼叫資料
        private void showOrderDataGridView()
        {
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

            this.OrderdataGridView.DataSource = q.ToList();
        }

        private void showOrderDataGridView1()
        {
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

            this.OrderdataGridView1.DataSource = q.ToList();
        }

        private void showOrderDetaildataGridView2()
        {
            var o = from p in this.dbcontext.OrderDetails
                    select new
                    {
                        訂單明細編號 = p.OrderDetailID,
                        訂單編號 = p.OrderID,
                        房間編號 = p.RoomID,
                        住宿日期 = p.MoveInDate,
                        退宿日期 = p.MoveOutDate,
                        付款日期 = p.PaymentDate,
                        付款編號 = p.PaymentID,
                        付款金額 = p.PaymentPrice,
                        訂單明細狀態 = p.OrderDetailStatusID,
                        備註 = p.OrderDetailRemark
                    };

            this.OrderDetaildataGridView2.DataSource = o.ToList();
        }

        private void showOrderDetaildataGridView3()
        {
            var o = from p in this.dbcontext.OrderDetails
                    select new
                    {
                        訂單明細編號 = p.OrderDetailID,
                        訂單編號 = p.OrderID,
                        房間編號 = p.RoomID,
                        住宿日期 = p.MoveInDate,
                        退宿日期 = p.MoveOutDate,
                        付款日期 = p.PaymentDate,
                        付款編號 = p.PaymentID,
                        付款金額 = p.PaymentPrice,
                        訂單明細狀態 = p.OrderDetailStatusID,
                        備註 = p.OrderDetailRemark
                    };

            this.OrderDetaildataGridView3.DataSource = o.ToList();
        }

        //private void showOrderDetailDataGridView()
        //{
        //    var q = from p in this.dbcontext.OrderDetails
        //            select new
        //            {
        //                訂單明細編號 = p.OrderDetailID,
        //                訂單編號 = p.OrderID,
        //                房間編號 = p.RoomID,
        //                住宿日期 = p.MoveInDate,
        //                退宿日期 = p.MoveOutDate,
        //                付款日期 = p.PaymentDate,
        //                付款編號 = p.PaymentID,
        //                付款金額 = p.PaymentPrice,
        //                訂單明細狀態 = p.OrderDetailStatusID,
        //                備註 = p.OrderDetailRemark
        //            };

        //    this.OrderDetaildataGridView.DataSource = q.ToList();
        //}

        //private void showOrderDetailStatusDataGridView()
        //{
        //    var q = from p in this.dbcontext.OrderDetailStatus
        //            select new {
        //                訂單明細狀態編號 = p.OrderDetailStatusID,
        //                訂單明細狀態 = p.OrderDetaiStatusContent
        //            };

        //    this.OrderDetailStatusdataGridView.DataSource = q.ToList();
        //}

        private void showPaymentDataGridView()
        {
            var q = from p in this.dbcontext.Payments
                    select new {
                        付款方式編號 = p.PaymentID,
                        付款方式 = p.Payments
                    };

            this.PaymentdataGridView.DataSource = q.ToList();
        }

        //切換頁籤自動呼叫
        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.tabControl1.SelectedIndex == 0)
            {
                showOrderDataGridView();
                showOrderDetaildataGridView2();
            }
            //if (this.tabControl1.SelectedIndex == 1)
            //{
            //    showOrderDetailDataGridView();
            //}
            //if (this.tabControl1.SelectedIndex == 2)
            //{
            //    showOrderDetailStatusDataGridView();
            //}
            if (this.tabControl1.SelectedIndex == 1)
            {
                showPaymentDataGridView();
                showPayment();
            }
            if (this.tabControl1.SelectedIndex == 2)
            {
                showOrderDataGridView1();
                showOrderDetaildataGridView3();
            }
        }

        //當空白或未輸入內容不執行
        private bool IsTextBoxEmpty(TextBox textBox)
        {
            if (string.IsNullOrWhiteSpace(textBox.Text))
            {
                MessageBox.Show("請輸入內容");
                return true;
            }
            return false;
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            //判斷是否有內容
            if (IsTextBoxEmpty(txtInsert))
            {
                return;
            }

            Payment p = new Payment { Payments = txtInsert.Text };
            this.dbcontext.Payments.Add(p);

            //確認是否新增
            DialogResult result = MessageBox.Show("確定要新增資料嗎？", "提示", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                int saveresult = this.dbcontext.SaveChanges();
                try
                {
                    if (saveresult > 0)
                    {
                        MessageBox.Show("新增成功");
                        showPayment();
                        showPaymentDataGridView();
                        txtInsert.Clear();
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
                //finally
                //{
                //    MessageBox.Show("新增失敗");
                //}
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            //選項的ID
            int paymentID = int.Parse(cbPay.Text.Substring(0, cbPay.Text.IndexOf(':')));

            var q = from p in this.dbcontext.Payments
                    where p.PaymentID == paymentID
                    select p;

            DialogResult result = MessageBox.Show("確定要刪除資料嗎？", "提示", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                try
                {
                    if (q != null)
                    {
                        dbcontext.Payments.Remove(q.FirstOrDefault());
                        dbcontext.SaveChanges();
                        MessageBox.Show("已成功刪除資料");
                        showPayment();
                        showPaymentDataGridView();
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

        public void showPayment()
        {
            var q = from p in this.dbcontext.Payments
                    //where p.PaymentID != null
                    orderby p.PaymentID
                    select p;

            var paylist = q.AsEnumerable()
                  .Select(p => new { MyPayment = $"{p.PaymentID}: {p.Payments}" })
                  .ToList();

            this.cbPay.DataSource = paylist;
            this.cbPay.DisplayMember = "MyPayment";
        }

        //combobox變更同步dtaaGridView
        private void cbPay_SelectedIndexChanged(object sender, EventArgs e)
        {
            int o;
            int paymentID;

            if (int.TryParse(cbPay.Text.Substring(0, cbPay.Text.IndexOf(':')), out o))
            {
                paymentID = int.Parse(cbPay.Text.Substring(0, cbPay.Text.IndexOf(':')));
            }
            else return;

            //取得ID的index
            int rowIndex = PaymentdataGridView.Rows
                .Cast<DataGridViewRow>()
                .ToList()
                .FindIndex(row => Convert.ToInt32(row.Cells["付款方式編號"].Value) == paymentID);

            this.PaymentdataGridView.CurrentCell = PaymentdataGridView.Rows[rowIndex].Cells[0];
        }

        //dtaaGridView變更同步combobox
        private void PaymentdataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int o;
            int paymentID;
            if (int.TryParse(cbPay.Text.Substring(0, cbPay.Text.IndexOf(':')), out o))
            {
                paymentID = int.Parse(cbPay.Text.Substring(0, cbPay.Text.IndexOf(':')));
            }
            else return;
            //將所有ID放進陣列
            int[] rowValues = PaymentdataGridView.Rows
                .Cast<DataGridViewRow>()
                .Select(row => Convert.ToInt32(row.Cells["付款方式編號"].Value))
                .ToArray();

            //從陣列中取得ID的index            
            int index = Array.IndexOf(rowValues, paymentID);

            this.cbPay.SelectedIndex = index;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (IsTextBoxEmpty(txtUpdate))
            {
                return;
            }

            DialogResult result = MessageBox.Show("確定要修改資料嗎？", "提示", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                try
                {
                    int paymentID = int.Parse(cbPay.Text.Substring(0, cbPay.Text.IndexOf(':')));
                    var payment = dbcontext.Payments.Find(paymentID);
                    //另種寫法
                    //var payment = dbcontext.Payments.FirstOrDefault(p => p.PaymentID == paymentID);

                    payment.Payments = txtUpdate.Text;
                    dbcontext.SaveChanges();
                    MessageBox.Show("已成功修改資料");
                    showPayment();
                    showPaymentDataGridView();
                    txtUpdate.Clear();
                }
                catch (IndexOutOfRangeException ex)
                {
                    MessageBox.Show($"修改資料失敗\n發生{ex}錯誤");
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"修改資料失敗\n發生{ex}錯誤");
                }
            }
        }

        private void OrderdataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string orderid = OrderdataGridView.CurrentRow.Cells["訂單編號"].Value.ToString();

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

            var o = from p in this.dbcontext.Orders
                    where p.OrderID == orderid
                    select p;

            var r = from p in this.dbcontext.Rooms
                    where p.RoomID != null
                    orderby p.RoomID
                    select p.RoomID;

            this.cbRoom.DataSource = r.ToList();

            removetextbox();
            foreach (var OrderDetailID in odlist)
            {
                var orderDetail = this.dbcontext.OrderDetails.FirstOrDefault
                    (od => od.OrderDetailID == OrderDetailID);
                if (orderDetail != null)
                {
                    this.txtRoom.Text += orderDetail.RoomID;
                    this.txtOrderRemark.Text += orderDetail.OrderDetailRemark;
                    this.IndateTimePicker.Value = (DateTime)orderDetail.MoveInDate;
                    this.OutdateTimePicker.Value = (DateTime)orderDetail.MoveOutDate;
                }
            }

            foreach (var OrderID in o)
            {
                this.txtPeople.Text = OrderID.CheckInPeople.ToString();
                this.txtMemberID.Text = OrderID.MemberID;
                this.txtOrderPrice.Text = OrderID.OrderTotalPrice.Value.ToString("0");
                this.txtOrderTime.Text = OrderID.OrderDate.ToString();
                if (OrderID.ActivityID.ToString() != null)
                {
                    this.txtActivityID.Text = OrderID.ActivityID.ToString();
                }
                else
                {
                    this.txtActivityID.Text = null;
                }
            }
        }

        //清空內容
        private void removetextbox()
        {
            this.txtRoom.Clear();
            this.txtOrderRemark.Clear();
            this.txtPeople.Clear();
            this.txtMemberID.Clear();
            this.txtOrderTime.Clear();
            this.txtOrderPrice.Clear();
            this.txtActivityID.Clear();

            this.txtmoney.Clear();
            this.txtCheckInPeople.Clear();
            this.txtOrderRemark1.Clear();
            this.txtActityID.Clear();
            this.txtRoomList.Clear();
            this.txtRoomPrice.Clear();
            this.labActivity.Text= string.Empty;
            this.cbRoom1.DataSource = null;
            this.cbRoom1.Items.Clear();

        }

        //查詢空閒房間方法
        private IEnumerable<string> getavailableRooms(DateTime i, DateTime o)
        {
            // 查詢指定時間區間內已被預訂的房間
            var reservedRooms = from od in dbcontext.OrderDetails
                                where !(od.MoveOutDate <= i || od.MoveInDate >= o)
                                select od.RoomID;

            //所有房間扣掉已預訂房間
            var freeRooms = from r in dbcontext.Rooms
                            where !reservedRooms.Contains(r.RoomID)
                            select r.RoomID;
            
            return freeRooms;
        }

        //order表的查詢
        private void button1_Click(object sender, EventArgs e)
        {
            DateTime intime;
            DateTime outtime;

            if ( IndateTimePicker.Value.ToString("yyyy-MM-dd") == OutdateTimePicker.Value.ToString("yyyy-MM-dd") )
            {
                intime = DateTime.ParseExact(IndateTimePicker.Value.ToString("yyyy-MM-dd") + " 14:00:00", "yyyy-MM-dd HH:mm:ss", CultureInfo.InvariantCulture);
                outtime = DateTime.ParseExact(OutdateTimePicker.Value.ToString("yyyy-MM-dd") + " 11:00:00", "yyyy-MM-dd HH:mm:ss", CultureInfo.InvariantCulture);
                outtime = outtime.AddDays(1);
            }
            else
            {
                intime = DateTime.ParseExact(IndateTimePicker.Value.ToString("yyyy-MM-dd") + " 14:00:00", "yyyy-MM-dd HH:mm:ss", CultureInfo.InvariantCulture);
                outtime = DateTime.ParseExact(OutdateTimePicker.Value.ToString("yyyy-MM-dd") + " 11:00:00", "yyyy-MM-dd HH:mm:ss", CultureInfo.InvariantCulture);
            }       

            var availableRooms = getavailableRooms(intime, outtime);

            this.cbRoom.DataSource = availableRooms.ToList();
        }

        private void getIntimeAndOuttime(out DateTime intime, out DateTime outtime)
        {
            //時間比對，若入宿日期>退宿日期
            if (DateTime.Compare(IndateTimePicker1.Value.Date, OutdateTimePicker1.Value.Date) > 0)
            {
                MessageBox.Show("入宿時間錯誤，請重新選擇");
                intime = IndateTimePicker1.Value;
                outtime = OutdateTimePicker1.Value;
                return;
            }

            //若入宿日期=退宿日期
            if (DateTime.Compare(IndateTimePicker1.Value.Date, OutdateTimePicker1.Value.Date) == 0)
            {
                intime = DateTime.ParseExact(IndateTimePicker1.Value.ToString("yyyy-MM-dd") + " 14:00:00", "yyyy-MM-dd HH:mm:ss", CultureInfo.InvariantCulture);
                outtime = DateTime.ParseExact(OutdateTimePicker1.Value.ToString("yyyy-MM-dd") + " 11:00:00", "yyyy-MM-dd HH:mm:ss", CultureInfo.InvariantCulture);
                outtime = outtime.AddDays(1);
            }
            //日期格式化
            else
            {
                intime = DateTime.ParseExact(IndateTimePicker1.Value.ToString("yyyy-MM-dd") + " 14:00:00", "yyyy-MM-dd HH:mm:ss", CultureInfo.InvariantCulture);
                outtime = DateTime.ParseExact(OutdateTimePicker1.Value.ToString("yyyy-MM-dd") + " 11:00:00", "yyyy-MM-dd HH:mm:ss", CultureInfo.InvariantCulture);
            }
        }

        //查詢按鈕
        private void btnInquire_Click(object sender, EventArgs e)
        {
            DateTime intime;
            DateTime outtime;

            //獲得正確格式化日期
            getIntimeAndOuttime(out intime, out outtime);

            //當入宿日期>退宿日期，不顯示房間列表
            if (DateTime.Compare(IndateTimePicker1.Value.Date, OutdateTimePicker1.Value.Date) > 0)
            {
                this.cbRoom1.DataSource = null;
                this.cbRoom1.Items.Clear();
                return;
            }

            var availableRooms = getavailableRooms(intime, outtime);
            if (availableRooms == null)
            {
                MessageBox.Show("沒有空閒房間，請選擇其他日期");
            }
            else
            {
               this.cbRoom1.DataSource = availableRooms.ToList();
            }
        }

        //用來接視窗Payment的消息
        private int? ODPaymentID;

        // 實作 PaymentCompleted 事件的回呼函式
        private void FrmPayemt_PaymentCompleted(object sender, int paymentID)
        {
            this.ODPaymentID = paymentID;
        }

        private void btnaddOrder_Click(object sender, EventArgs e)
        {
           
            //取得最大ID
            string maxOID = dbcontext.Orders.Max(oid => oid.OrderID);
            string maxODID = dbcontext.OrderDetails.Max(odid => odid.OrderDetailID);

            //取得ID的數字
            int numOID = int.Parse(maxOID.Substring(2));
            string newOrderID = string.Format("OD{0:D6}", numOID + 1);
            int numODID = int.Parse(maxODID.Substring(3));
            string newOrderDetailID = string.Format("ODD{0:D6}", numODID + 1);

            int s;
            if (IsTextBoxEmpty(txtCheckInPeople))
            {
                this.txtCheckInPeople.Focus();
                return;
            } 
            else if (IsTextBoxEmpty(txtRoomList))
            {
                this.txtRoomList.Focus();
                return;
            }
            else if (!int.TryParse(txtCheckInPeople.Text, out s))
            {
                MessageBox.Show("「住宿人數」請輸入正確內容");
                this.txtCheckInPeople.Focus();
                this.txtCheckInPeople.Clear();
                return;
            };

            DateTime intime;
            DateTime outtime;

            //獲得正確格式化日期
            getIntimeAndOuttime(out intime, out outtime);

            Frm_Payment frmPayment = new Frm_Payment(this.dbcontext);
            frmPayment.PaymentCompleted += FrmPayemt_PaymentCompleted;

            if (!ODPaymentID.HasValue)
            {
                frmPayment.ShowDialog();
            }

            Order o = new Order
            {
                OrderID = newOrderID,
                MemberID = txtMemberID1.Text,
                OrderDate = DateTime.Now,
                OrderTotalPrice = decimal.Parse(txtmoney.Text),
                CheckInPeople = int.Parse(txtCheckInPeople.Text),
                OrderRemark = txtOrderRemark1.Text,
            };

            OrderDetail od = new OrderDetail
            {
                OrderDetailID = newOrderDetailID,
                OrderID = newOrderID,
                RoomID = cbRoom1.SelectedItem.ToString(),
                MoveInDate = intime,
                MoveOutDate = outtime,
                PaymentDate = DateTime.Now,
                PaymentID = this.ODPaymentID,
                PaymentPrice = decimal.Parse(txtmoney.Text),
                OrderDetailStatusID = 1,//代改
                OrderDetailRemark = txtOrderRemark1.Text,
            };

            this.dbcontext.Orders.Add(o);
            this.dbcontext.OrderDetails.Add(od);

            DialogResult result = MessageBox.Show("確定要新增訂單嗎？", "提示", MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes)
            {
                try
                {
                    int saveresult = this.dbcontext.SaveChanges();
                    if (saveresult > 0)
                    {
                        MessageBox.Show("新增成功");
                        this.dbcontext.SaveChanges();
                        removetextbox();
                        showOrderDataGridView1();
                        showOrderDetaildataGridView3();
                        this.ODPaymentID = null;
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

        private void btnaddroom_Click(object sender, EventArgs e)
        {
            this.txtRoomList.Text = cbRoom1.SelectedItem.ToString();

            string roomID = this.txtRoomList.Text;
            var roomlist = this.dbcontext.Rooms.FirstOrDefault(r => r.RoomID == roomID);
            string roomclassID = roomlist.RoomClassID;
            //取得房價
            var pricelist = this.dbcontext.RoomTimePrices.FirstOrDefault(p => p.RoomClassID==roomclassID);
            int weekdayprice = (int)pricelist.WeekdayPrice;
            int holidayprice = (int)pricelist.HolidayPrice;

            DateTime intime;
            DateTime outtime;

            getIntimeAndOuttime(out intime, out outtime);

            var (weekdaycount, holidaycount) = getdays(intime, outtime);

            IEnumerable<Activity> activeitylist = IsDayActivity(intime, outtime);

            if (activeitylist.Any())
            {
                foreach (var activity in activeitylist)
                {
                    string actweekdayprice = string.Format("{0:0}",(weekdayprice * activity.Discount));
                    string actholidayprice = string.Format("{0:0}", (holidayprice * activity.Discount));

                    this.txtActityID.Text = activity.ActivityID.ToString();
                    this.labActivity.Text = $"在{activity.ActivityName}期間，享有{activity.Discount}折優惠!";
                    this.txtRoomPrice.Text = $"平日價格:{actweekdayprice},假日價格:{actholidayprice}";
                    this.txtmoney.Text = (int.Parse(actweekdayprice) * weekdaycount + int.Parse(actholidayprice) * holidaycount).ToString();
                }
            }
            else
            {
                this.labActivity.Text = string.Empty;
                this.txtRoomPrice.Text = $"平日價格:{weekdayprice},假日價格:{holidayprice}";
                this.txtmoney.Text = (weekdayprice * weekdaycount+ holidayprice* holidaycount).ToString();
            }
        }

        //計算天數跟平假日天數
        private (int,int) getdays(DateTime i, DateTime o)
        {
            //平日定義為週1-4
            List<string> weekdayList = new List<string> { "Monday", "Tuesday", "Wednesday", "Thursday" };

            DateTime intime = DateTime.ParseExact(IndateTimePicker1.Value.ToString("yyyy-MM-dd") + " 14:00:00", "yyyy-MM-dd HH:mm:ss", CultureInfo.InvariantCulture);
            DateTime outtime = DateTime.ParseExact(OutdateTimePicker1.Value.ToString("yyyy-MM-dd") + " 11:00:00", "yyyy-MM-dd HH:mm:ss", CultureInfo.InvariantCulture);

            //總天數
            int totaldays = (int)(outtime - intime).TotalDays + 1;

            int weekdaycount = 0;
            int holidaycount = 0;           

            for (int d = 0; d < totaldays; d++)
            {
                DateTime currentDate = intime.AddDays(d);
                //string currentDayOfWeek = currentDate.DayOfWeek.ToString();

                if (weekdayList.Contains(currentDate.ToShortDateString()))
                    weekdaycount++;
                else
                    holidaycount++;
            }

            return (weekdaycount, holidaycount);
        }

        //判斷是否符合活動
        private IEnumerable<Activity> IsDayActivity(DateTime i, DateTime o)
        {
            //是否有活動的資料
            var activeitylist = from a in dbcontext.Activities
                                where a.ActivityEndDate >= i && a.ActivityStartDate <= o
                                select a;

            if (!activeitylist.Any())
                return Enumerable.Empty<Activity>();
            else
                return activeitylist;
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            // 取得 OrderdataGridView 目前所選擇的資料列的訂單編號
            string orderid = OrderdataGridView.CurrentRow.Cells["訂單編號"].Value.ToString();
            var order = dbcontext.Orders.FirstOrDefault(o => o.OrderID == orderid);

            var orderDetails = dbcontext.OrderDetails.Where(od => od.OrderID == orderid);

            DialogResult result = MessageBox.Show("確定要刪除資料嗎？", "提示", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                try
                {
                    if (order != null)
                    {
                        dbcontext.Orders.Remove(order);
                        dbcontext.OrderDetails.RemoveRange(orderDetails);
                        dbcontext.SaveChanges();
                        MessageBox.Show("已成功刪除資料");
                        removetextbox();
                        showOrderDataGridView();
                        showOrderDetaildataGridView2();
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
    }
}
