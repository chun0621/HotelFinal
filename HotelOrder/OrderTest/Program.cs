using Hotel;
using HotelManager;
using OrderTest.後台;
using prjMidterm1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Test_Room;

namespace OrderTest
{
    internal static class Program
    {
        /// <summary>
        /// 應用程式的主要進入點。
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new 首頁());
            //Application.Run(new Frm_Management());//後台管理
            //Application.Run(new Frm_Industry());//業者
            Application.Run(new Frm_Facility());//設備
            //Application.Run(new Frm_Order());//訂單
            //Application.Run(new Frm_Comments());//評論
            //Application.Run(new Frm_Room());//房間
            //Application.Run(new Frm_MemberLogIn());//會員註冊登入
            //Application.Run(new Frm_MemberModify());//會員管理
            //Application.Run(new Frm_Activity());//活動
            //Application.Run(new Frm_RoomPicture());//房間照片
            //Application.Run(new FrmUserSelectRoom());//下定房間




        }
    }
}
