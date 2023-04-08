using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Mail;
using System.Net;
using System.Runtime.InteropServices;
using System.Text.RegularExpressions;
//using static Test_Room.MemberLogIn;
using System.Data.Entity;
using System.Drawing.Imaging;
using System.IO;
using OrderTest;

namespace Test_Room
{
    public partial class Frm_MemberIForgetPassword : Form
    {
        HotelOrderEntities HOTcontect = new HotelOrderEntities(); //new出實體
        public Frm_MemberIForgetPassword()
        {
            InitializeComponent();
            HOTcontect.Database.Log = Console.WriteLine;  //log寫出輸入視窗
        }

        private void btnCheckEmail_Click(object sender, EventArgs e)
        {
            string email = txtCheckEmail.Text; // 或用戶名      
            bool userExists = HOTcontect.RoomMembers.Where(o => o.MemberEMail == email).ToList().Any();
            string memberID_ = string.Empty;
            int maxMemberID = 0;

            var q = this.HOTcontect.RoomMembers.Select(x => x.MemberID).ToList();

            int count = q.Count();

            maxMemberID = (count > 0) ? Convert.ToInt32(q.Max().Substring(2)) : 0;

            if (!userExists)
            {
                MessageBox.Show("該電子郵件地址或用戶名不存在。", "錯誤");
            }
            else
            {
                // 生成一個新的隨機密碼
                string newPassword = GenerateRandomPassword();

                // 使用 Google Mail Server 發信
                string GoogleID = "imapple1991@gmail.com"; //Google 發信帳號
                string TempPwd = "notffmckaayqzchi"; //應用程式密碼
                string ReceiveMail = txtCheckEmail.Text; //接收信箱

                string SmtpServer = "smtp.gmail.com";
                int SmtpPort = 587;
                MailMessage mms = new MailMessage();
                mms.From = new MailAddress(GoogleID);
                mms.Subject = "[密碼重設]-資展訂房會員";
                mms.Body = "您好" + "\r\n" + "您的新密碼為 :" + newPassword;
                mms.IsBodyHtml = true;
                mms.SubjectEncoding = Encoding.UTF8;
                mms.To.Add(new MailAddress(ReceiveMail));
                using (SmtpClient client = new SmtpClient(SmtpServer, SmtpPort))
                {
                    client.EnableSsl = true;
                    client.Credentials = new NetworkCredential(GoogleID, TempPwd);//寄信帳密 
                    client.Send(mms); //寄出信件
                }


                string rememberAccountid = string.Empty;
                string memberData = HOTcontect.RoomMembers.ToString();

                var member = (from p in this.HOTcontect.RoomMembers
                                  where p.MemberEMail == txtCheckEmail.Text
                              select p).ToList().FirstOrDefault();


                //var member = HOTcontect.RoomMembers.FirstOrDefault
                // (o => o.MemberEMail == rememberAccount.Email );

                if (member != null)
                {
                    member.MemberPassword = newPassword;
                    this.HOTcontect.SaveChanges();
                    MessageBox.Show("您的密碼已重設。請檢查您的電子郵件。", "成功");
                }
            }

        }
        private string GenerateRandomPassword()
            {
                const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";
                var random = new Random();
                var password = new string(Enumerable.Repeat(chars, 8)
                  .Select(s => s[random.Next(s.Length)]).ToArray());
                // 使用正則表達式驗證密碼
                var regex = new Regex("^(?=.*[a-z])(?=.*[A-Z])(?=.*\\d).{8}$");

                while (!regex.IsMatch(password))
                {
                    password = new string(Enumerable.Repeat(chars, 8)
                      .Select(s => s[random.Next(s.Length)]).ToArray());
                }

                return password;
            }
        }
    } 

