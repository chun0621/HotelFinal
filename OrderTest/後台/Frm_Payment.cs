using OrderTest;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hotel
{
    public partial class Frm_Payment : Form
    {
        public Frm_Payment(HotelOrderEntities dbcontext)
        {
            InitializeComponent();
            this.dbcontext= dbcontext;
            showPayment();
        }

        HotelOrderEntities dbcontext;

        private void showPayment()
        {
            var q = from p in this.dbcontext.Payments
                    where p.PaymentID != null
                    orderby p.PaymentID
                    select p;

            var paylist = q.AsEnumerable()
                  .Select(p => new { MyPayment = $"{p.PaymentID}: {p.Payments}" })
                  .ToList();

            this.cbPay.DataSource = paylist;
            this.cbPay.DisplayMember = "MyPayment";
        }

        //傳遞消息的
        public event EventHandler<int> PaymentCompleted;

        private void btnCheck_Click(object sender, EventArgs e)
        {
            int paymentID = int.Parse(cbPay.Text.Substring(0, cbPay.Text.IndexOf(':')));

            if (PaymentCompleted != null)
            {
                PaymentCompleted(this, paymentID);
            }
            //另種寫法
            //PaymentCompleted?.Invoke(this, paymentID);
            this.Close();
        }
    }
}
