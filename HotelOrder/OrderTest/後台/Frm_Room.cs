using OrderTest;
using prjMidterm1;
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
    public partial class Frm_Room : Form
    {
        public Frm_Room()
        {
            InitializeComponent();
            this.Hotel.Database.Log = Console.WriteLine;
            Load_Room_RoomClassID();
            Load_Room_RoomStyleID();
            Load_Room_HotelID();
            Load_Room_AdminID();
        }

        HotelOrderEntities Hotel = new HotelOrderEntities();

        void Load_Room_AdminID()
        {
            var q = from p in this.Hotel.RoomAdmins
                    select p.AdminID;

            this.comboBox_AdminID.DataSource = q.ToList();

        }

        void Load_Room_HotelID()
        {
            var q = from p in this.Hotel.HotelIndustries
                    select p.HotelID;

            this.comboBox_HotelID.DataSource = q.ToList();
        }

        void Load_Room_RoomStyleID()
        {
            var q = from p in this.Hotel.RoomStyles
                    select p.RoomStyleID;

            this.comboBox_RoomStyleID.DataSource = q.ToList();
        }

        void Load_Room_RoomClassID()
        {
            var q = from p in this.Hotel.RoomClasses
                    select p.RoomClassID;

            this.comboBox_RoomClassID.DataSource= q.ToList();

        }

        private void button_Search_Classification_Click(object sender, EventArgs e)
        {
            var q = from p in this.Hotel.RoomClasses
                    select new { p.RoomClassID, p.RoomClassName, p.RoomClassDetail };

            this.dataGridView_RoomClass.DataSource = q.ToList();
        }

        private void button_Search_TimePrice_Click(object sender, EventArgs e)
        {
            var q = from p in this.Hotel.RoomTimePrices
                    select new { p.RoomClassID, p.WeekdayPrice, p.HolidayPrice };

            this.dataGridView_RoomTimePrice.DataSource = q.ToList();
        }

        private void button_Room_Add_Click(object sender, EventArgs e)
        {
            Room Room_Add = new Room
            {
                RoomID = textBox_RoomID.Text,
                RoomClassID = comboBox_RoomClassID.Text,
                RoomSize = Convert.ToInt32(textBox_RoomSize.Text),
                RoomPeople = Convert.ToInt32(textBox_RoomPeople.Text),
                RoomStyleID = comboBox_RoomStyleID.Text,
                HotelID = Convert.ToInt32(comboBox_HotelID.Text),
                RoomStatus = textBox_RoomStatus.Text,
                AdminID = comboBox_AdminID.Text,
            };
            this.Hotel.Rooms.Add(Room_Add);

            this.Hotel.SaveChanges();

            this.Read_RefreshDataGridView_Room();
        }

        private void Read_RefreshDataGridView_Room()
        {
            this.dataGridView_Room.DataSource = null;
            this.dataGridView_Room.DataSource = this.Hotel.Rooms.ToList();
        }



        private void button_Room_UpDete_Click(object sender, EventArgs e)
        {
                string room_updete = dataGridView_Room.CurrentRow.Cells["RoomID"].Value.ToString();

                var RoomUpDate = Hotel.Rooms.FirstOrDefault(rp => rp.RoomID == room_updete);
                if (RoomUpDate != null)
                {
                    RoomUpDate.RoomID = textBox_RoomID.Text;
                    RoomUpDate.RoomClassID = comboBox_RoomClassID.Text;
                    RoomUpDate.RoomSize = Convert.ToInt32(textBox_RoomSize.Text);
                    RoomUpDate.RoomPeople = Convert.ToInt32(textBox_RoomPeople.Text);
                    RoomUpDate.RoomStyleID = comboBox_RoomStyleID.Text;
                    RoomUpDate.HotelID = Convert.ToInt32(comboBox_HotelID.Text);
                    RoomUpDate.RoomStatus = textBox_RoomStatus.Text;
                    RoomUpDate.AdminID = comboBox_AdminID.Text;

                    Hotel.SaveChanges();
                    Read_RefreshDataGridView_Room();
                }
        }

        private void dataGridView_Room_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string roomid = dataGridView_Room.CurrentRow.Cells["RoomID"].Value.ToString();

            var q = from p in this.Hotel.Rooms
                    where p.RoomID == roomid
                    select new
                    {
                        p.RoomID,
                        p.RoomClassID,
                        p.RoomSize,
                        p.RoomPeople,
                        p.RoomStyleID,
                        p.HotelID,
                        p.RoomStatus,
                        p.AdminID,
                    };
            var o = from p in this.Hotel.Rooms
                    where p.RoomID == roomid
                    select p;
            foreach (var ROOMID in o)
            {
                textBox_RoomID.Text=ROOMID.RoomID.ToString();
                comboBox_RoomClassID.Text=ROOMID.RoomClassID.ToString();
                textBox_RoomSize.Text=ROOMID.RoomSize.ToString();
                textBox_RoomPeople.Text= ROOMID.RoomPeople.ToString();
                comboBox_RoomStyleID.Text=ROOMID.RoomStyleID.ToString();
                comboBox_HotelID.Text=ROOMID.HotelID.ToString();
                textBox_RoomStatus.Text=ROOMID.RoomStatus.ToString();
                comboBox_AdminID.Text = ROOMID.AdminID.ToString();
            }
        }


        private void button_Room_Search_Click(object sender, EventArgs e)
        {
            var q = from p in this.Hotel.Rooms
                    select new { p.RoomID, p.RoomClassID, p.RoomSize, p.RoomPeople, p.RoomStyleID, p.HotelID, p.RoomStatus, p.AdminID };

            this.dataGridView_Room.DataSource = q.ToList();
        }

        private void button_Room_Delete_Click(object sender, EventArgs e)
        {
            string room_delete = dataGridView_Room.CurrentRow.Cells["RoomID"].Value.ToString();

            var Room_Delete = Hotel.Rooms.FirstOrDefault(rp => rp.RoomID == room_delete);

            if (Room_Delete != null)
            {
                Hotel.Rooms.Remove(Room_Delete);
                Hotel.SaveChanges();
                Read_RefreshDataGridView_Room();
            }
        }

        private void button_RoomClass_Add_Click(object sender, EventArgs e)
        {
            RoomClass RoomClass_Add = new RoomClass
            {
                RoomClassID = textBox_ClassID.Text,
                RoomClassName = textBox_ClassName.Text,
                RoomClassDetail = textBox_ClassDetail.Text,
            };

            RoomTimePrice TimePrice_Add = new RoomTimePrice
            {
                RoomClassID = textBox_ClassID.Text,
            };

            this.Hotel.RoomClasses.Add(RoomClass_Add);
            this.Hotel.RoomTimePrices.Add(TimePrice_Add);

            this.Hotel.SaveChanges();

            this.Read_RefreshDataGridView_RoomClass();
        }

        private void Read_RefreshDataGridView_RoomClass()
        {
            this.dataGridView_RoomClass.DataSource = null;
            this.dataGridView_RoomClass.DataSource = this.Hotel.RoomClasses.ToList();
        }

        private void dataGridView_RoomClass_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string roomclass = dataGridView_RoomClass.CurrentRow.Cells["RoomClassID"].Value.ToString();

            var q = from p in this.Hotel.RoomClasses
                    where p.RoomClassID == roomclass
                    select new
                    {
                        p.RoomClassID,
                        p.RoomClassName,
                        p.RoomClassDetail,
                    };
            var o = from p in this.Hotel.RoomClasses
                    where p.RoomClassID == roomclass
                    select p;
            foreach (var ROOMCLASS in o)
            {
                textBox_ClassID.Text = ROOMCLASS.RoomClassID.ToString();
                textBox_ClassName.Text = ROOMCLASS.RoomClassName.ToString();
                textBox_ClassDetail.Text = ROOMCLASS.RoomClassDetail.ToString();
            }
        }

        private void button_RoomClass_UpDete_Click(object sender, EventArgs e)
        {
            string roomclass_updete = dataGridView_RoomClass.CurrentRow.Cells["RoomClassID"].Value.ToString();

            var RoomUpDate = Hotel.RoomClasses.FirstOrDefault(rp => rp.RoomClassID == roomclass_updete);
            if (RoomUpDate != null)
            {
                RoomUpDate.RoomClassID = textBox_ClassID.Text;
                RoomUpDate.RoomClassName = textBox_ClassName.Text;
                RoomUpDate.RoomClassDetail = textBox_ClassDetail.Text;

                Hotel.SaveChanges();
                Read_RefreshDataGridView_RoomClass();
            }
        }

        private void button_RoomClass_Delete_Click(object sender, EventArgs e)
        {
            string roomclass_delete = dataGridView_RoomClass.CurrentRow.Cells["RoomClassID"].Value.ToString();

            var RoomClass_Delete = Hotel.RoomClasses.FirstOrDefault(rp => rp.RoomClassID == roomclass_delete);

            if (RoomClass_Delete != null)
            {
                Hotel.RoomClasses.Remove(RoomClass_Delete);
                Hotel.SaveChanges() ;
                Read_RefreshDataGridView_RoomClass();
            }
        }

        private void button_TimePrice_Add_Click(object sender, EventArgs e)
        {
            RoomTimePrice TimePrice_Add = new RoomTimePrice
            {
                RoomClassID = textBox_Price_ClassID.Text,
                WeekdayPrice = Convert.ToInt32(textBox_WeekdayPrice.Text),
                HolidayPrice = Convert.ToInt32(textBox_HolidayPrice.Text),
            };
            RoomClass RoomClass_Add = new RoomClass
            {
                RoomClassID = textBox_ClassID.Text,
            };

       
            this.Hotel.RoomTimePrices.Add(TimePrice_Add);

            this.Hotel.SaveChanges();

            this.Read_RefreshDataGridView_RoomClass();
        }

        private void Read_RefreshDataGridView_TimePrice()
        {
            this.dataGridView_RoomTimePrice.DataSource = null;
            this.dataGridView_RoomTimePrice.DataSource = this.Hotel.RoomTimePrices.ToList();
        }

        private void dataGridView_RoomTimePrice_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string roomtimeprice = dataGridView_RoomTimePrice.CurrentRow.Cells["RoomClassID"].Value.ToString();

            var q = from p in this.Hotel.RoomTimePrices
                    where p.RoomClassID == roomtimeprice
                    select new
                    {
                        p.RoomClassID,
                        p.WeekdayPrice,
                        p.HolidayPrice,
                    };
            var o = from p in this.Hotel.RoomTimePrices
                    where p.RoomClassID == roomtimeprice
                    select p;
            foreach (var ROOMTIMEPRICE in o)
            {
                textBox_Price_ClassID.Text = ROOMTIMEPRICE.RoomClassID.ToString();
                textBox_WeekdayPrice.Text = ROOMTIMEPRICE.WeekdayPrice.ToString();
                textBox_HolidayPrice.Text = ROOMTIMEPRICE.HolidayPrice.ToString();
            }
        }

        private void button_TimePrice_UpDete_Click(object sender, EventArgs e)
        {
            string roomclass_updete = dataGridView_RoomTimePrice.CurrentRow.Cells["RoomClassID"].Value.ToString();

            var TimePrice_UpDete = Hotel.RoomTimePrices.FirstOrDefault(rp => rp.RoomClassID == roomclass_updete);
            if (TimePrice_UpDete != null)
            {
                TimePrice_UpDete.WeekdayPrice = Convert.ToInt32(textBox_WeekdayPrice.Text);
                TimePrice_UpDete.HolidayPrice = Convert.ToInt32(textBox_HolidayPrice.Text);

                Hotel.SaveChanges();
                Read_RefreshDataGridView_TimePrice();
            }
        }

        private void button_TimePrice_Delete_Click(object sender, EventArgs e)
        {
            string timeprice_delete = dataGridView_RoomTimePrice.CurrentRow.Cells["RoomClassID"].Value.ToString();

            var TimePrice_Delete = Hotel.RoomTimePrices.FirstOrDefault(rp => rp.RoomClassID == timeprice_delete);

            if (TimePrice_Delete != null)
            {
                Hotel.RoomTimePrices.Remove(TimePrice_Delete);
                Hotel.SaveChanges();
                Read_RefreshDataGridView_TimePrice();
            }
        }

        private void btn_FrmRoomPicture_Click(object sender, EventArgs e)
        {
            Frm_RoomPicture f = new Frm_RoomPicture();
            f.ShowDialog();
        }
    }
}
