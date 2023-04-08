namespace Hotel
{
    partial class Frm_Room
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl_Room = new System.Windows.Forms.TabControl();
            this.tabPage_Room = new System.Windows.Forms.TabPage();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.button_Room_UpDete = new System.Windows.Forms.Button();
            this.comboBox_AdminID = new System.Windows.Forms.ComboBox();
            this.comboBox_HotelID = new System.Windows.Forms.ComboBox();
            this.comboBox_RoomStyleID = new System.Windows.Forms.ComboBox();
            this.comboBox_RoomClassID = new System.Windows.Forms.ComboBox();
            this.button_Room_Delete = new System.Windows.Forms.Button();
            this.button_Room_Search = new System.Windows.Forms.Button();
            this.button_Room_Add = new System.Windows.Forms.Button();
            this.textBox_RoomPeople = new System.Windows.Forms.TextBox();
            this.label_RoomStatus = new System.Windows.Forms.Label();
            this.textBox_RoomSize = new System.Windows.Forms.TextBox();
            this.label_RoomID = new System.Windows.Forms.Label();
            this.label_SquareFeet = new System.Windows.Forms.Label();
            this.label_NumberOfPeople = new System.Windows.Forms.Label();
            this.textBox_RoomID = new System.Windows.Forms.TextBox();
            this.textBox_RoomStatus = new System.Windows.Forms.TextBox();
            this.label_HotelID = new System.Windows.Forms.Label();
            this.label_RoomClassificationID = new System.Windows.Forms.Label();
            this.label_RoomStyleID = new System.Windows.Forms.Label();
            this.label_AdminID = new System.Windows.Forms.Label();
            this.dataGridView_Room = new System.Windows.Forms.DataGridView();
            this.tabPage_RoomClassification = new System.Windows.Forms.TabPage();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.button_RoomClass_UpDete = new System.Windows.Forms.Button();
            this.button_RoomClass_Search = new System.Windows.Forms.Button();
            this.button_RoomClass_Delete = new System.Windows.Forms.Button();
            this.button_RoomClass_Add = new System.Windows.Forms.Button();
            this.textBox_ClassDetail = new System.Windows.Forms.TextBox();
            this.textBox_ClassName = new System.Windows.Forms.TextBox();
            this.textBox_ClassID = new System.Windows.Forms.TextBox();
            this.label_ClassDetail = new System.Windows.Forms.Label();
            this.label_ClassName = new System.Windows.Forms.Label();
            this.label_ClassID = new System.Windows.Forms.Label();
            this.dataGridView_RoomClass = new System.Windows.Forms.DataGridView();
            this.tabPage_RoomTimePrice = new System.Windows.Forms.TabPage();
            this.splitContainer3 = new System.Windows.Forms.SplitContainer();
            this.button_TimePrice_UpDete = new System.Windows.Forms.Button();
            this.button_TimePrice_Delete = new System.Windows.Forms.Button();
            this.textBox_HolidayPrice = new System.Windows.Forms.TextBox();
            this.button_TimePrice_Add = new System.Windows.Forms.Button();
            this.button_TimePrice_Search = new System.Windows.Forms.Button();
            this.textBox_WeekdayPrice = new System.Windows.Forms.TextBox();
            this.labellabel_Price_ClassificationID = new System.Windows.Forms.Label();
            this.textBox_Price_ClassID = new System.Windows.Forms.TextBox();
            this.label_WeekdayPrice = new System.Windows.Forms.Label();
            this.label_HolidayPrice = new System.Windows.Forms.Label();
            this.dataGridView_RoomTimePrice = new System.Windows.Forms.DataGridView();
            this.btn_FrmRoomPicture = new System.Windows.Forms.Button();
            this.tabControl_Room.SuspendLayout();
            this.tabPage_Room.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Room)).BeginInit();
            this.tabPage_RoomClassification.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_RoomClass)).BeginInit();
            this.tabPage_RoomTimePrice.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).BeginInit();
            this.splitContainer3.Panel1.SuspendLayout();
            this.splitContainer3.Panel2.SuspendLayout();
            this.splitContainer3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_RoomTimePrice)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl_Room
            // 
            this.tabControl_Room.Controls.Add(this.tabPage_Room);
            this.tabControl_Room.Controls.Add(this.tabPage_RoomClassification);
            this.tabControl_Room.Controls.Add(this.tabPage_RoomTimePrice);
            this.tabControl_Room.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl_Room.Location = new System.Drawing.Point(0, 0);
            this.tabControl_Room.Name = "tabControl_Room";
            this.tabControl_Room.SelectedIndex = 0;
            this.tabControl_Room.Size = new System.Drawing.Size(881, 521);
            this.tabControl_Room.TabIndex = 0;
            // 
            // tabPage_Room
            // 
            this.tabPage_Room.Controls.Add(this.splitContainer1);
            this.tabPage_Room.Location = new System.Drawing.Point(4, 22);
            this.tabPage_Room.Name = "tabPage_Room";
            this.tabPage_Room.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_Room.Size = new System.Drawing.Size(873, 495);
            this.tabPage_Room.TabIndex = 0;
            this.tabPage_Room.Text = "房間資訊管理";
            this.tabPage_Room.UseVisualStyleBackColor = true;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(3, 3);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(228)))), ((int)(((byte)(187)))));
            this.splitContainer1.Panel1.Controls.Add(this.button_Room_UpDete);
            this.splitContainer1.Panel1.Controls.Add(this.comboBox_AdminID);
            this.splitContainer1.Panel1.Controls.Add(this.comboBox_HotelID);
            this.splitContainer1.Panel1.Controls.Add(this.comboBox_RoomStyleID);
            this.splitContainer1.Panel1.Controls.Add(this.comboBox_RoomClassID);
            this.splitContainer1.Panel1.Controls.Add(this.button_Room_Delete);
            this.splitContainer1.Panel1.Controls.Add(this.button_Room_Search);
            this.splitContainer1.Panel1.Controls.Add(this.button_Room_Add);
            this.splitContainer1.Panel1.Controls.Add(this.textBox_RoomPeople);
            this.splitContainer1.Panel1.Controls.Add(this.label_RoomStatus);
            this.splitContainer1.Panel1.Controls.Add(this.textBox_RoomSize);
            this.splitContainer1.Panel1.Controls.Add(this.label_RoomID);
            this.splitContainer1.Panel1.Controls.Add(this.label_SquareFeet);
            this.splitContainer1.Panel1.Controls.Add(this.label_NumberOfPeople);
            this.splitContainer1.Panel1.Controls.Add(this.textBox_RoomID);
            this.splitContainer1.Panel1.Controls.Add(this.textBox_RoomStatus);
            this.splitContainer1.Panel1.Controls.Add(this.label_HotelID);
            this.splitContainer1.Panel1.Controls.Add(this.label_RoomClassificationID);
            this.splitContainer1.Panel1.Controls.Add(this.label_RoomStyleID);
            this.splitContainer1.Panel1.Controls.Add(this.label_AdminID);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.dataGridView_Room);
            this.splitContainer1.Size = new System.Drawing.Size(867, 489);
            this.splitContainer1.SplitterDistance = 254;
            this.splitContainer1.TabIndex = 0;
            // 
            // button_Room_UpDete
            // 
            this.button_Room_UpDete.Location = new System.Drawing.Point(27, 298);
            this.button_Room_UpDete.Name = "button_Room_UpDete";
            this.button_Room_UpDete.Size = new System.Drawing.Size(75, 23);
            this.button_Room_UpDete.TabIndex = 99;
            this.button_Room_UpDete.Text = "修改";
            this.button_Room_UpDete.UseVisualStyleBackColor = true;
            this.button_Room_UpDete.Click += new System.EventHandler(this.button_Room_UpDete_Click);
            // 
            // comboBox_AdminID
            // 
            this.comboBox_AdminID.FormattingEnabled = true;
            this.comboBox_AdminID.Location = new System.Drawing.Point(93, 211);
            this.comboBox_AdminID.Name = "comboBox_AdminID";
            this.comboBox_AdminID.Size = new System.Drawing.Size(121, 20);
            this.comboBox_AdminID.TabIndex = 98;
            // 
            // comboBox_HotelID
            // 
            this.comboBox_HotelID.FormattingEnabled = true;
            this.comboBox_HotelID.Location = new System.Drawing.Point(93, 155);
            this.comboBox_HotelID.Name = "comboBox_HotelID";
            this.comboBox_HotelID.Size = new System.Drawing.Size(121, 20);
            this.comboBox_HotelID.TabIndex = 97;
            // 
            // comboBox_RoomStyleID
            // 
            this.comboBox_RoomStyleID.FormattingEnabled = true;
            this.comboBox_RoomStyleID.Location = new System.Drawing.Point(93, 128);
            this.comboBox_RoomStyleID.Name = "comboBox_RoomStyleID";
            this.comboBox_RoomStyleID.Size = new System.Drawing.Size(121, 20);
            this.comboBox_RoomStyleID.TabIndex = 96;
            // 
            // comboBox_RoomClassID
            // 
            this.comboBox_RoomClassID.FormattingEnabled = true;
            this.comboBox_RoomClassID.Location = new System.Drawing.Point(93, 43);
            this.comboBox_RoomClassID.Name = "comboBox_RoomClassID";
            this.comboBox_RoomClassID.Size = new System.Drawing.Size(121, 20);
            this.comboBox_RoomClassID.TabIndex = 95;
            // 
            // button_Room_Delete
            // 
            this.button_Room_Delete.Location = new System.Drawing.Point(117, 298);
            this.button_Room_Delete.Name = "button_Room_Delete";
            this.button_Room_Delete.Size = new System.Drawing.Size(75, 23);
            this.button_Room_Delete.TabIndex = 93;
            this.button_Room_Delete.Text = "刪除";
            this.button_Room_Delete.UseVisualStyleBackColor = true;
            this.button_Room_Delete.Click += new System.EventHandler(this.button_Room_Delete_Click);
            // 
            // button_Room_Search
            // 
            this.button_Room_Search.Location = new System.Drawing.Point(27, 259);
            this.button_Room_Search.Name = "button_Room_Search";
            this.button_Room_Search.Size = new System.Drawing.Size(75, 23);
            this.button_Room_Search.TabIndex = 94;
            this.button_Room_Search.Text = "查詢";
            this.button_Room_Search.UseVisualStyleBackColor = true;
            this.button_Room_Search.Click += new System.EventHandler(this.button_Room_Search_Click);
            // 
            // button_Room_Add
            // 
            this.button_Room_Add.Location = new System.Drawing.Point(117, 259);
            this.button_Room_Add.Name = "button_Room_Add";
            this.button_Room_Add.Size = new System.Drawing.Size(75, 23);
            this.button_Room_Add.TabIndex = 76;
            this.button_Room_Add.Text = "新增";
            this.button_Room_Add.UseVisualStyleBackColor = true;
            this.button_Room_Add.Click += new System.EventHandler(this.button_Room_Add_Click);
            // 
            // textBox_RoomPeople
            // 
            this.textBox_RoomPeople.Location = new System.Drawing.Point(93, 99);
            this.textBox_RoomPeople.Name = "textBox_RoomPeople";
            this.textBox_RoomPeople.Size = new System.Drawing.Size(122, 22);
            this.textBox_RoomPeople.TabIndex = 80;
            // 
            // label_RoomStatus
            // 
            this.label_RoomStatus.AutoSize = true;
            this.label_RoomStatus.Location = new System.Drawing.Point(7, 188);
            this.label_RoomStatus.Name = "label_RoomStatus";
            this.label_RoomStatus.Size = new System.Drawing.Size(56, 12);
            this.label_RoomStatus.TabIndex = 91;
            this.label_RoomStatus.Text = "房間狀態:";
            // 
            // textBox_RoomSize
            // 
            this.textBox_RoomSize.Location = new System.Drawing.Point(93, 70);
            this.textBox_RoomSize.Name = "textBox_RoomSize";
            this.textBox_RoomSize.Size = new System.Drawing.Size(122, 22);
            this.textBox_RoomSize.TabIndex = 79;
            // 
            // label_RoomID
            // 
            this.label_RoomID.AutoSize = true;
            this.label_RoomID.Location = new System.Drawing.Point(7, 20);
            this.label_RoomID.Name = "label_RoomID";
            this.label_RoomID.Size = new System.Drawing.Size(56, 12);
            this.label_RoomID.TabIndex = 85;
            this.label_RoomID.Text = "房間編號:";
            // 
            // label_SquareFeet
            // 
            this.label_SquareFeet.AutoSize = true;
            this.label_SquareFeet.Location = new System.Drawing.Point(7, 76);
            this.label_SquareFeet.Name = "label_SquareFeet";
            this.label_SquareFeet.Size = new System.Drawing.Size(32, 12);
            this.label_SquareFeet.TabIndex = 87;
            this.label_SquareFeet.Text = "坪數:";
            // 
            // label_NumberOfPeople
            // 
            this.label_NumberOfPeople.AutoSize = true;
            this.label_NumberOfPeople.Location = new System.Drawing.Point(7, 101);
            this.label_NumberOfPeople.Name = "label_NumberOfPeople";
            this.label_NumberOfPeople.Size = new System.Drawing.Size(56, 12);
            this.label_NumberOfPeople.TabIndex = 88;
            this.label_NumberOfPeople.Text = "入住人數:";
            // 
            // textBox_RoomID
            // 
            this.textBox_RoomID.Location = new System.Drawing.Point(93, 14);
            this.textBox_RoomID.Multiline = true;
            this.textBox_RoomID.Name = "textBox_RoomID";
            this.textBox_RoomID.Size = new System.Drawing.Size(122, 22);
            this.textBox_RoomID.TabIndex = 77;
            // 
            // textBox_RoomStatus
            // 
            this.textBox_RoomStatus.Location = new System.Drawing.Point(93, 182);
            this.textBox_RoomStatus.Name = "textBox_RoomStatus";
            this.textBox_RoomStatus.Size = new System.Drawing.Size(122, 22);
            this.textBox_RoomStatus.TabIndex = 83;
            // 
            // label_HotelID
            // 
            this.label_HotelID.AutoSize = true;
            this.label_HotelID.Location = new System.Drawing.Point(7, 157);
            this.label_HotelID.Name = "label_HotelID";
            this.label_HotelID.Size = new System.Drawing.Size(56, 12);
            this.label_HotelID.TabIndex = 90;
            this.label_HotelID.Text = "業者編號:";
            // 
            // label_RoomClassificationID
            // 
            this.label_RoomClassificationID.AutoSize = true;
            this.label_RoomClassificationID.Location = new System.Drawing.Point(7, 48);
            this.label_RoomClassificationID.Name = "label_RoomClassificationID";
            this.label_RoomClassificationID.Size = new System.Drawing.Size(80, 12);
            this.label_RoomClassificationID.TabIndex = 86;
            this.label_RoomClassificationID.Text = "房間分類編號:";
            // 
            // label_RoomStyleID
            // 
            this.label_RoomStyleID.AutoSize = true;
            this.label_RoomStyleID.Location = new System.Drawing.Point(7, 129);
            this.label_RoomStyleID.Name = "label_RoomStyleID";
            this.label_RoomStyleID.Size = new System.Drawing.Size(80, 12);
            this.label_RoomStyleID.TabIndex = 89;
            this.label_RoomStyleID.Text = "房間風格編號:";
            // 
            // label_AdminID
            // 
            this.label_AdminID.AutoSize = true;
            this.label_AdminID.Location = new System.Drawing.Point(7, 217);
            this.label_AdminID.Name = "label_AdminID";
            this.label_AdminID.Size = new System.Drawing.Size(68, 12);
            this.label_AdminID.TabIndex = 92;
            this.label_AdminID.Text = "管理者編號:";
            // 
            // dataGridView_Room
            // 
            this.dataGridView_Room.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Room.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView_Room.Location = new System.Drawing.Point(0, 0);
            this.dataGridView_Room.Name = "dataGridView_Room";
            this.dataGridView_Room.RowHeadersWidth = 51;
            this.dataGridView_Room.RowTemplate.Height = 24;
            this.dataGridView_Room.Size = new System.Drawing.Size(609, 489);
            this.dataGridView_Room.TabIndex = 77;
            this.dataGridView_Room.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_Room_CellClick);
            // 
            // tabPage_RoomClassification
            // 
            this.tabPage_RoomClassification.Controls.Add(this.splitContainer2);
            this.tabPage_RoomClassification.Location = new System.Drawing.Point(4, 22);
            this.tabPage_RoomClassification.Name = "tabPage_RoomClassification";
            this.tabPage_RoomClassification.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_RoomClassification.Size = new System.Drawing.Size(873, 495);
            this.tabPage_RoomClassification.TabIndex = 1;
            this.tabPage_RoomClassification.Text = "房型分類";
            this.tabPage_RoomClassification.UseVisualStyleBackColor = true;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(3, 3);
            this.splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(228)))), ((int)(((byte)(187)))));
            this.splitContainer2.Panel1.Controls.Add(this.btn_FrmRoomPicture);
            this.splitContainer2.Panel1.Controls.Add(this.button_RoomClass_UpDete);
            this.splitContainer2.Panel1.Controls.Add(this.button_RoomClass_Search);
            this.splitContainer2.Panel1.Controls.Add(this.button_RoomClass_Delete);
            this.splitContainer2.Panel1.Controls.Add(this.button_RoomClass_Add);
            this.splitContainer2.Panel1.Controls.Add(this.textBox_ClassDetail);
            this.splitContainer2.Panel1.Controls.Add(this.textBox_ClassName);
            this.splitContainer2.Panel1.Controls.Add(this.textBox_ClassID);
            this.splitContainer2.Panel1.Controls.Add(this.label_ClassDetail);
            this.splitContainer2.Panel1.Controls.Add(this.label_ClassName);
            this.splitContainer2.Panel1.Controls.Add(this.label_ClassID);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.dataGridView_RoomClass);
            this.splitContainer2.Size = new System.Drawing.Size(867, 489);
            this.splitContainer2.SplitterDistance = 245;
            this.splitContainer2.TabIndex = 0;
            // 
            // button_RoomClass_UpDete
            // 
            this.button_RoomClass_UpDete.Location = new System.Drawing.Point(39, 332);
            this.button_RoomClass_UpDete.Name = "button_RoomClass_UpDete";
            this.button_RoomClass_UpDete.Size = new System.Drawing.Size(74, 23);
            this.button_RoomClass_UpDete.TabIndex = 75;
            this.button_RoomClass_UpDete.Text = "修改";
            this.button_RoomClass_UpDete.UseVisualStyleBackColor = true;
            this.button_RoomClass_UpDete.Click += new System.EventHandler(this.button_RoomClass_UpDete_Click);
            // 
            // button_RoomClass_Search
            // 
            this.button_RoomClass_Search.Location = new System.Drawing.Point(39, 294);
            this.button_RoomClass_Search.Name = "button_RoomClass_Search";
            this.button_RoomClass_Search.Size = new System.Drawing.Size(74, 23);
            this.button_RoomClass_Search.TabIndex = 74;
            this.button_RoomClass_Search.Text = "查詢";
            this.button_RoomClass_Search.UseVisualStyleBackColor = true;
            this.button_RoomClass_Search.Click += new System.EventHandler(this.button_Search_Classification_Click);
            // 
            // button_RoomClass_Delete
            // 
            this.button_RoomClass_Delete.Location = new System.Drawing.Point(120, 332);
            this.button_RoomClass_Delete.Name = "button_RoomClass_Delete";
            this.button_RoomClass_Delete.Size = new System.Drawing.Size(74, 23);
            this.button_RoomClass_Delete.TabIndex = 73;
            this.button_RoomClass_Delete.Text = "刪除";
            this.button_RoomClass_Delete.UseVisualStyleBackColor = true;
            this.button_RoomClass_Delete.Click += new System.EventHandler(this.button_RoomClass_Delete_Click);
            // 
            // button_RoomClass_Add
            // 
            this.button_RoomClass_Add.Location = new System.Drawing.Point(120, 294);
            this.button_RoomClass_Add.Name = "button_RoomClass_Add";
            this.button_RoomClass_Add.Size = new System.Drawing.Size(74, 23);
            this.button_RoomClass_Add.TabIndex = 72;
            this.button_RoomClass_Add.Text = "新增";
            this.button_RoomClass_Add.UseVisualStyleBackColor = true;
            this.button_RoomClass_Add.Click += new System.EventHandler(this.button_RoomClass_Add_Click);
            // 
            // textBox_ClassDetail
            // 
            this.textBox_ClassDetail.Font = new System.Drawing.Font("新細明體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.textBox_ClassDetail.Location = new System.Drawing.Point(52, 104);
            this.textBox_ClassDetail.Multiline = true;
            this.textBox_ClassDetail.Name = "textBox_ClassDetail";
            this.textBox_ClassDetail.Size = new System.Drawing.Size(156, 176);
            this.textBox_ClassDetail.TabIndex = 71;
            // 
            // textBox_ClassName
            // 
            this.textBox_ClassName.Font = new System.Drawing.Font("新細明體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.textBox_ClassName.Location = new System.Drawing.Point(100, 71);
            this.textBox_ClassName.Multiline = true;
            this.textBox_ClassName.Name = "textBox_ClassName";
            this.textBox_ClassName.Size = new System.Drawing.Size(107, 22);
            this.textBox_ClassName.TabIndex = 70;
            // 
            // textBox_ClassID
            // 
            this.textBox_ClassID.Font = new System.Drawing.Font("新細明體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.textBox_ClassID.Location = new System.Drawing.Point(100, 42);
            this.textBox_ClassID.Name = "textBox_ClassID";
            this.textBox_ClassID.Size = new System.Drawing.Size(107, 23);
            this.textBox_ClassID.TabIndex = 69;
            // 
            // label_ClassDetail
            // 
            this.label_ClassDetail.AutoSize = true;
            this.label_ClassDetail.Font = new System.Drawing.Font("新細明體", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label_ClassDetail.Location = new System.Drawing.Point(9, 104);
            this.label_ClassDetail.Name = "label_ClassDetail";
            this.label_ClassDetail.Size = new System.Drawing.Size(39, 14);
            this.label_ClassDetail.TabIndex = 68;
            this.label_ClassDetail.Text = "描述:";
            // 
            // label_ClassName
            // 
            this.label_ClassName.AutoSize = true;
            this.label_ClassName.Font = new System.Drawing.Font("新細明體", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label_ClassName.Location = new System.Drawing.Point(9, 73);
            this.label_ClassName.Name = "label_ClassName";
            this.label_ClassName.Size = new System.Drawing.Size(39, 14);
            this.label_ClassName.TabIndex = 67;
            this.label_ClassName.Text = "名稱:";
            // 
            // label_ClassID
            // 
            this.label_ClassID.AutoSize = true;
            this.label_ClassID.Font = new System.Drawing.Font("新細明體", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label_ClassID.Location = new System.Drawing.Point(9, 44);
            this.label_ClassID.Name = "label_ClassID";
            this.label_ClassID.Size = new System.Drawing.Size(95, 14);
            this.label_ClassID.TabIndex = 66;
            this.label_ClassID.Text = "房型分類編號:";
            // 
            // dataGridView_RoomClass
            // 
            this.dataGridView_RoomClass.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_RoomClass.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView_RoomClass.Location = new System.Drawing.Point(0, 0);
            this.dataGridView_RoomClass.Name = "dataGridView_RoomClass";
            this.dataGridView_RoomClass.RowHeadersWidth = 51;
            this.dataGridView_RoomClass.RowTemplate.Height = 24;
            this.dataGridView_RoomClass.Size = new System.Drawing.Size(618, 489);
            this.dataGridView_RoomClass.TabIndex = 70;
            this.dataGridView_RoomClass.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_RoomClass_CellClick);
            // 
            // tabPage_RoomTimePrice
            // 
            this.tabPage_RoomTimePrice.Controls.Add(this.splitContainer3);
            this.tabPage_RoomTimePrice.Location = new System.Drawing.Point(4, 22);
            this.tabPage_RoomTimePrice.Name = "tabPage_RoomTimePrice";
            this.tabPage_RoomTimePrice.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_RoomTimePrice.Size = new System.Drawing.Size(873, 495);
            this.tabPage_RoomTimePrice.TabIndex = 2;
            this.tabPage_RoomTimePrice.Text = "價格時段";
            this.tabPage_RoomTimePrice.UseVisualStyleBackColor = true;
            // 
            // splitContainer3
            // 
            this.splitContainer3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer3.Location = new System.Drawing.Point(3, 3);
            this.splitContainer3.Name = "splitContainer3";
            // 
            // splitContainer3.Panel1
            // 
            this.splitContainer3.Panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(228)))), ((int)(((byte)(187)))));
            this.splitContainer3.Panel1.Controls.Add(this.button_TimePrice_UpDete);
            this.splitContainer3.Panel1.Controls.Add(this.button_TimePrice_Delete);
            this.splitContainer3.Panel1.Controls.Add(this.textBox_HolidayPrice);
            this.splitContainer3.Panel1.Controls.Add(this.button_TimePrice_Add);
            this.splitContainer3.Panel1.Controls.Add(this.button_TimePrice_Search);
            this.splitContainer3.Panel1.Controls.Add(this.textBox_WeekdayPrice);
            this.splitContainer3.Panel1.Controls.Add(this.labellabel_Price_ClassificationID);
            this.splitContainer3.Panel1.Controls.Add(this.textBox_Price_ClassID);
            this.splitContainer3.Panel1.Controls.Add(this.label_WeekdayPrice);
            this.splitContainer3.Panel1.Controls.Add(this.label_HolidayPrice);
            // 
            // splitContainer3.Panel2
            // 
            this.splitContainer3.Panel2.Controls.Add(this.dataGridView_RoomTimePrice);
            this.splitContainer3.Size = new System.Drawing.Size(867, 489);
            this.splitContainer3.SplitterDistance = 235;
            this.splitContainer3.TabIndex = 0;
            // 
            // button_TimePrice_UpDete
            // 
            this.button_TimePrice_UpDete.Location = new System.Drawing.Point(37, 280);
            this.button_TimePrice_UpDete.Name = "button_TimePrice_UpDete";
            this.button_TimePrice_UpDete.Size = new System.Drawing.Size(74, 23);
            this.button_TimePrice_UpDete.TabIndex = 117;
            this.button_TimePrice_UpDete.Text = "修改";
            this.button_TimePrice_UpDete.UseVisualStyleBackColor = true;
            this.button_TimePrice_UpDete.Click += new System.EventHandler(this.button_TimePrice_UpDete_Click);
            // 
            // button_TimePrice_Delete
            // 
            this.button_TimePrice_Delete.Location = new System.Drawing.Point(116, 280);
            this.button_TimePrice_Delete.Name = "button_TimePrice_Delete";
            this.button_TimePrice_Delete.Size = new System.Drawing.Size(74, 23);
            this.button_TimePrice_Delete.TabIndex = 116;
            this.button_TimePrice_Delete.Text = "刪除";
            this.button_TimePrice_Delete.UseVisualStyleBackColor = true;
            this.button_TimePrice_Delete.Click += new System.EventHandler(this.button_TimePrice_Delete_Click);
            // 
            // textBox_HolidayPrice
            // 
            this.textBox_HolidayPrice.Location = new System.Drawing.Point(100, 143);
            this.textBox_HolidayPrice.Name = "textBox_HolidayPrice";
            this.textBox_HolidayPrice.Size = new System.Drawing.Size(100, 22);
            this.textBox_HolidayPrice.TabIndex = 113;
            // 
            // button_TimePrice_Add
            // 
            this.button_TimePrice_Add.Location = new System.Drawing.Point(116, 240);
            this.button_TimePrice_Add.Name = "button_TimePrice_Add";
            this.button_TimePrice_Add.Size = new System.Drawing.Size(74, 23);
            this.button_TimePrice_Add.TabIndex = 115;
            this.button_TimePrice_Add.Text = "新增";
            this.button_TimePrice_Add.UseVisualStyleBackColor = true;
            this.button_TimePrice_Add.Visible = false;
            this.button_TimePrice_Add.Click += new System.EventHandler(this.button_TimePrice_Add_Click);
            // 
            // button_TimePrice_Search
            // 
            this.button_TimePrice_Search.Location = new System.Drawing.Point(35, 240);
            this.button_TimePrice_Search.Name = "button_TimePrice_Search";
            this.button_TimePrice_Search.Size = new System.Drawing.Size(75, 23);
            this.button_TimePrice_Search.TabIndex = 114;
            this.button_TimePrice_Search.Text = "查詢";
            this.button_TimePrice_Search.UseVisualStyleBackColor = true;
            this.button_TimePrice_Search.Click += new System.EventHandler(this.button_Search_TimePrice_Click);
            // 
            // textBox_WeekdayPrice
            // 
            this.textBox_WeekdayPrice.Location = new System.Drawing.Point(100, 110);
            this.textBox_WeekdayPrice.Name = "textBox_WeekdayPrice";
            this.textBox_WeekdayPrice.Size = new System.Drawing.Size(100, 22);
            this.textBox_WeekdayPrice.TabIndex = 112;
            // 
            // labellabel_Price_ClassificationID
            // 
            this.labellabel_Price_ClassificationID.AutoSize = true;
            this.labellabel_Price_ClassificationID.Location = new System.Drawing.Point(13, 78);
            this.labellabel_Price_ClassificationID.Name = "labellabel_Price_ClassificationID";
            this.labellabel_Price_ClassificationID.Size = new System.Drawing.Size(80, 12);
            this.labellabel_Price_ClassificationID.TabIndex = 108;
            this.labellabel_Price_ClassificationID.Text = "房型分類編號:";
            // 
            // textBox_Price_ClassID
            // 
            this.textBox_Price_ClassID.Location = new System.Drawing.Point(100, 76);
            this.textBox_Price_ClassID.Name = "textBox_Price_ClassID";
            this.textBox_Price_ClassID.Size = new System.Drawing.Size(100, 22);
            this.textBox_Price_ClassID.TabIndex = 111;
            // 
            // label_WeekdayPrice
            // 
            this.label_WeekdayPrice.AutoSize = true;
            this.label_WeekdayPrice.Location = new System.Drawing.Point(13, 113);
            this.label_WeekdayPrice.Name = "label_WeekdayPrice";
            this.label_WeekdayPrice.Size = new System.Drawing.Size(56, 12);
            this.label_WeekdayPrice.TabIndex = 109;
            this.label_WeekdayPrice.Text = "平日金額:";
            // 
            // label_HolidayPrice
            // 
            this.label_HolidayPrice.AutoSize = true;
            this.label_HolidayPrice.Location = new System.Drawing.Point(13, 146);
            this.label_HolidayPrice.Name = "label_HolidayPrice";
            this.label_HolidayPrice.Size = new System.Drawing.Size(56, 12);
            this.label_HolidayPrice.TabIndex = 110;
            this.label_HolidayPrice.Text = "假日金額:";
            // 
            // dataGridView_RoomTimePrice
            // 
            this.dataGridView_RoomTimePrice.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_RoomTimePrice.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView_RoomTimePrice.Location = new System.Drawing.Point(0, 0);
            this.dataGridView_RoomTimePrice.Name = "dataGridView_RoomTimePrice";
            this.dataGridView_RoomTimePrice.RowHeadersWidth = 51;
            this.dataGridView_RoomTimePrice.RowTemplate.Height = 24;
            this.dataGridView_RoomTimePrice.Size = new System.Drawing.Size(628, 489);
            this.dataGridView_RoomTimePrice.TabIndex = 107;
            this.dataGridView_RoomTimePrice.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_RoomTimePrice_CellClick);
            // 
            // btn_FrmRoomPicture
            // 
            this.btn_FrmRoomPicture.Location = new System.Drawing.Point(39, 393);
            this.btn_FrmRoomPicture.Name = "btn_FrmRoomPicture";
            this.btn_FrmRoomPicture.Size = new System.Drawing.Size(103, 23);
            this.btn_FrmRoomPicture.TabIndex = 76;
            this.btn_FrmRoomPicture.Text = "管理房間圖片";
            this.btn_FrmRoomPicture.UseVisualStyleBackColor = true;
            this.btn_FrmRoomPicture.Click += new System.EventHandler(this.btn_FrmRoomPicture_Click);
            // 
            // Frm_Room
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(881, 521);
            this.Controls.Add(this.tabControl_Room);
            this.Name = "Frm_Room";
            this.Text = "Form_Room";
            this.tabControl_Room.ResumeLayout(false);
            this.tabPage_Room.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Room)).EndInit();
            this.tabPage_RoomClassification.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel1.PerformLayout();
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_RoomClass)).EndInit();
            this.tabPage_RoomTimePrice.ResumeLayout(false);
            this.splitContainer3.Panel1.ResumeLayout(false);
            this.splitContainer3.Panel1.PerformLayout();
            this.splitContainer3.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).EndInit();
            this.splitContainer3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_RoomTimePrice)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl_Room;
        private System.Windows.Forms.TabPage tabPage_Room;
        private System.Windows.Forms.TabPage tabPage_RoomTimePrice;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Button button_Room_Delete;
        private System.Windows.Forms.Button button_Room_Search;
        private System.Windows.Forms.Button button_Room_Add;
        private System.Windows.Forms.TextBox textBox_RoomPeople;
        private System.Windows.Forms.Label label_RoomStatus;
        private System.Windows.Forms.TextBox textBox_RoomSize;
        private System.Windows.Forms.Label label_RoomID;
        private System.Windows.Forms.Label label_SquareFeet;
        private System.Windows.Forms.Label label_NumberOfPeople;
        private System.Windows.Forms.TextBox textBox_RoomID;
        private System.Windows.Forms.TextBox textBox_RoomStatus;
        private System.Windows.Forms.Label label_HotelID;
        private System.Windows.Forms.Label label_RoomClassificationID;
        private System.Windows.Forms.Label label_RoomStyleID;
        private System.Windows.Forms.Label label_AdminID;
        private System.Windows.Forms.DataGridView dataGridView_Room;
        private System.Windows.Forms.TabPage tabPage_RoomClassification;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.DataGridView dataGridView_RoomClass;
        private System.Windows.Forms.TextBox textBox_ClassDetail;
        private System.Windows.Forms.TextBox textBox_ClassName;
        private System.Windows.Forms.TextBox textBox_ClassID;
        private System.Windows.Forms.Label label_ClassDetail;
        private System.Windows.Forms.Label label_ClassName;
        private System.Windows.Forms.Label label_ClassID;
        private System.Windows.Forms.Button button_RoomClass_Search;
        private System.Windows.Forms.Button button_RoomClass_Delete;
        private System.Windows.Forms.Button button_RoomClass_Add;
        private System.Windows.Forms.SplitContainer splitContainer3;
        private System.Windows.Forms.Button button_TimePrice_Delete;
        private System.Windows.Forms.Button button_TimePrice_Add;
        private System.Windows.Forms.Button button_TimePrice_Search;
        private System.Windows.Forms.Label labellabel_Price_ClassificationID;
        private System.Windows.Forms.TextBox textBox_Price_ClassID;
        private System.Windows.Forms.DataGridView dataGridView_RoomTimePrice;
        private System.Windows.Forms.ComboBox comboBox_RoomStyleID;
        private System.Windows.Forms.ComboBox comboBox_RoomClassID;
        private System.Windows.Forms.ComboBox comboBox_AdminID;
        private System.Windows.Forms.ComboBox comboBox_HotelID;
        private System.Windows.Forms.Button button_Room_UpDete;
        private System.Windows.Forms.Button button_RoomClass_UpDete;
        private System.Windows.Forms.Button button_TimePrice_UpDete;
        private System.Windows.Forms.TextBox textBox_HolidayPrice;
        private System.Windows.Forms.TextBox textBox_WeekdayPrice;
        private System.Windows.Forms.Label label_WeekdayPrice;
        private System.Windows.Forms.Label label_HolidayPrice;
        private System.Windows.Forms.Button btn_FrmRoomPicture;
    }
}