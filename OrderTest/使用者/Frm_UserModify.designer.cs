namespace Test_Room
{
    partial class Frm_UserModify
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
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.OrderDetaildataGridView2 = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.OrderDataGridView = new System.Windows.Forms.DataGridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.labPasswod = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNewPassword = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtOldPassword = new System.Windows.Forms.TextBox();
            this.btnCheckPasswork = new System.Windows.Forms.Button();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.labEmail = new System.Windows.Forms.Label();
            this.labName = new System.Windows.Forms.Label();
            this.rdoFemale = new System.Windows.Forms.RadioButton();
            this.rdoMale = new System.Windows.Forms.RadioButton();
            this.txtMemberIdentity = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.dtmemberBirthday = new System.Windows.Forms.DateTimePicker();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.pbxMemberPhoto = new System.Windows.Forms.PictureBox();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.MemberEMail = new System.Windows.Forms.TextBox();
            this.txtMemberName = new System.Windows.Forms.TextBox();
            this.txtMemberPhone = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.OrderDetaildataGridView2)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.OrderDataGridView)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxMemberPhoto)).BeginInit();
            this.SuspendLayout();
            // 
            // webBrowser1
            // 
            this.webBrowser1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webBrowser1.Location = new System.Drawing.Point(0, 0);
            this.webBrowser1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(15, 16);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(837, 612);
            this.webBrowser1.TabIndex = 0;
            // 
            // tabControl1
            // 
            this.tabControl1.Appearance = System.Windows.Forms.TabAppearance.Buttons;
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.tabControl1.ItemSize = new System.Drawing.Size(200, 80);
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(837, 612);
            this.tabControl1.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.White;
            this.tabPage1.Controls.Add(this.groupBox2);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.tabPage1.Location = new System.Drawing.Point(4, 84);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabPage1.Size = new System.Drawing.Size(829, 524);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "訂單查詢";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.OrderDetaildataGridView2);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox2.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.groupBox2.Location = new System.Drawing.Point(2, 322);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox2.Size = new System.Drawing.Size(825, 320);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "訂單明細";
            // 
            // OrderDetaildataGridView2
            // 
            this.OrderDetaildataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.OrderDetaildataGridView2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.OrderDetaildataGridView2.Location = new System.Drawing.Point(2, 27);
            this.OrderDetaildataGridView2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.OrderDetaildataGridView2.Name = "OrderDetaildataGridView2";
            this.OrderDetaildataGridView2.RowHeadersWidth = 51;
            this.OrderDetaildataGridView2.RowTemplate.Height = 27;
            this.OrderDetaildataGridView2.Size = new System.Drawing.Size(821, 291);
            this.OrderDetaildataGridView2.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(228)))), ((int)(((byte)(187)))));
            this.groupBox1.Controls.Add(this.OrderDataGridView);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.groupBox1.Location = new System.Drawing.Point(2, 2);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Size = new System.Drawing.Size(825, 320);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "訂單查詢";
            // 
            // OrderDataGridView
            // 
            this.OrderDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.OrderDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.OrderDataGridView.Location = new System.Drawing.Point(2, 27);
            this.OrderDataGridView.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.OrderDataGridView.Name = "OrderDataGridView";
            this.OrderDataGridView.RowHeadersWidth = 51;
            this.OrderDataGridView.RowTemplate.Height = 27;
            this.OrderDataGridView.Size = new System.Drawing.Size(821, 291);
            this.OrderDataGridView.TabIndex = 0;
            this.OrderDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.OrderDataGridView_CellClick);
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(228)))), ((int)(((byte)(187)))));
            this.tabPage2.Controls.Add(this.labPasswod);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.txtNewPassword);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Controls.Add(this.txtOldPassword);
            this.tabPage2.Controls.Add(this.btnCheckPasswork);
            this.tabPage2.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.tabPage2.Location = new System.Drawing.Point(4, 84);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabPage2.Size = new System.Drawing.Size(829, 524);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "密碼修改";
            // 
            // labPasswod
            // 
            this.labPasswod.Font = new System.Drawing.Font("微軟正黑體", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labPasswod.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.labPasswod.Location = new System.Drawing.Point(417, 188);
            this.labPasswod.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labPasswod.Name = "labPasswod";
            this.labPasswod.Size = new System.Drawing.Size(234, 25);
            this.labPasswod.TabIndex = 76;
            this.labPasswod.Text = "請包含大小寫英文加數字共8到16位";
            this.labPasswod.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(181, 162);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 24);
            this.label2.TabIndex = 4;
            this.label2.Text = "新密碼";
            // 
            // txtNewPassword
            // 
            this.txtNewPassword.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNewPassword.BackColor = System.Drawing.Color.White;
            this.txtNewPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNewPassword.Location = new System.Drawing.Point(256, 155);
            this.txtNewPassword.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtNewPassword.Name = "txtNewPassword";
            this.txtNewPassword.Size = new System.Drawing.Size(396, 32);
            this.txtNewPassword.TabIndex = 3;
            this.txtNewPassword.TextChanged += new System.EventHandler(this.txtNewPassword_TextChanged);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(181, 65);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 24);
            this.label1.TabIndex = 2;
            this.label1.Text = "舊密碼";
            // 
            // txtOldPassword
            // 
            this.txtOldPassword.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtOldPassword.BackColor = System.Drawing.Color.White;
            this.txtOldPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtOldPassword.Location = new System.Drawing.Point(256, 58);
            this.txtOldPassword.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtOldPassword.Name = "txtOldPassword";
            this.txtOldPassword.Size = new System.Drawing.Size(396, 32);
            this.txtOldPassword.TabIndex = 1;
            // 
            // btnCheckPasswork
            // 
            this.btnCheckPasswork.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCheckPasswork.BackColor = System.Drawing.Color.Tan;
            this.btnCheckPasswork.Location = new System.Drawing.Point(256, 247);
            this.btnCheckPasswork.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnCheckPasswork.Name = "btnCheckPasswork";
            this.btnCheckPasswork.Size = new System.Drawing.Size(395, 48);
            this.btnCheckPasswork.TabIndex = 0;
            this.btnCheckPasswork.Text = "確定更改";
            this.btnCheckPasswork.UseVisualStyleBackColor = false;
            this.btnCheckPasswork.Click += new System.EventHandler(this.btnCheckPasswork_Click);
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(228)))), ((int)(((byte)(187)))));
            this.tabPage3.Controls.Add(this.labEmail);
            this.tabPage3.Controls.Add(this.labName);
            this.tabPage3.Controls.Add(this.rdoFemale);
            this.tabPage3.Controls.Add(this.rdoMale);
            this.tabPage3.Controls.Add(this.txtMemberIdentity);
            this.tabPage3.Controls.Add(this.label10);
            this.tabPage3.Controls.Add(this.label11);
            this.tabPage3.Controls.Add(this.dtmemberBirthday);
            this.tabPage3.Controls.Add(this.btnBrowse);
            this.tabPage3.Controls.Add(this.label9);
            this.tabPage3.Controls.Add(this.pbxMemberPhoto);
            this.tabPage3.Controls.Add(this.btnConfirm);
            this.tabPage3.Controls.Add(this.MemberEMail);
            this.tabPage3.Controls.Add(this.txtMemberName);
            this.tabPage3.Controls.Add(this.txtMemberPhone);
            this.tabPage3.Controls.Add(this.label8);
            this.tabPage3.Controls.Add(this.label7);
            this.tabPage3.Controls.Add(this.label6);
            this.tabPage3.Controls.Add(this.label12);
            this.tabPage3.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.tabPage3.Location = new System.Drawing.Point(4, 84);
            this.tabPage3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabPage3.Size = new System.Drawing.Size(829, 524);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "資料修改";
            // 
            // labEmail
            // 
            this.labEmail.Font = new System.Drawing.Font("微軟正黑體", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labEmail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.labEmail.Location = new System.Drawing.Point(609, 396);
            this.labEmail.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labEmail.Name = "labEmail";
            this.labEmail.Size = new System.Drawing.Size(177, 25);
            this.labEmail.TabIndex = 106;
            this.labEmail.Text = "labEmail";
            this.labEmail.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.labEmail.Visible = false;
            // 
            // labName
            // 
            this.labName.Font = new System.Drawing.Font("微軟正黑體", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.labName.Location = new System.Drawing.Point(653, 199);
            this.labName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labName.Name = "labName";
            this.labName.Size = new System.Drawing.Size(133, 25);
            this.labName.TabIndex = 103;
            this.labName.Text = "labName";
            this.labName.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.labName.Visible = false;
            // 
            // rdoFemale
            // 
            this.rdoFemale.AutoSize = true;
            this.rdoFemale.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.rdoFemale.Location = new System.Drawing.Point(565, 234);
            this.rdoFemale.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rdoFemale.Name = "rdoFemale";
            this.rdoFemale.Size = new System.Drawing.Size(85, 28);
            this.rdoFemale.TabIndex = 100;
            this.rdoFemale.TabStop = true;
            this.rdoFemale.Text = "生理女";
            this.rdoFemale.UseVisualStyleBackColor = true;
            // 
            // rdoMale
            // 
            this.rdoMale.AutoSize = true;
            this.rdoMale.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.rdoMale.Location = new System.Drawing.Point(483, 234);
            this.rdoMale.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rdoMale.Name = "rdoMale";
            this.rdoMale.Size = new System.Drawing.Size(85, 28);
            this.rdoMale.TabIndex = 99;
            this.rdoMale.TabStop = true;
            this.rdoMale.Text = "生理男";
            this.rdoMale.UseVisualStyleBackColor = true;
            // 
            // txtMemberIdentity
            // 
            this.txtMemberIdentity.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtMemberIdentity.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtMemberIdentity.Enabled = false;
            this.txtMemberIdentity.Location = new System.Drawing.Point(483, 106);
            this.txtMemberIdentity.Multiline = true;
            this.txtMemberIdentity.Name = "txtMemberIdentity";
            this.txtMemberIdentity.Size = new System.Drawing.Size(304, 27);
            this.txtMemberIdentity.TabIndex = 98;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label10.Location = new System.Drawing.Point(368, 106);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(114, 24);
            this.label10.TabIndex = 97;
            this.label10.Text = "*身份證字號";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label11.Location = new System.Drawing.Point(368, 235);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(57, 24);
            this.label11.TabIndex = 96;
            this.label11.Text = "*性別";
            // 
            // dtmemberBirthday
            // 
            this.dtmemberBirthday.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtmemberBirthday.CustomFormat = "yyyy-MM-dd";
            this.dtmemberBirthday.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.dtmemberBirthday.Location = new System.Drawing.Point(483, 298);
            this.dtmemberBirthday.Name = "dtmemberBirthday";
            this.dtmemberBirthday.Size = new System.Drawing.Size(304, 33);
            this.dtmemberBirthday.TabIndex = 95;
            this.dtmemberBirthday.Value = new System.DateTime(1990, 1, 1, 0, 0, 0, 0);
            // 
            // btnBrowse
            // 
            this.btnBrowse.BackColor = System.Drawing.Color.Tan;
            this.btnBrowse.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBrowse.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnBrowse.Location = new System.Drawing.Point(196, 335);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(100, 32);
            this.btnBrowse.TabIndex = 93;
            this.btnBrowse.Text = "瀏覽照片";
            this.btnBrowse.UseVisualStyleBackColor = false;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label9.Location = new System.Drawing.Point(124, 58);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(86, 24);
            this.label9.TabIndex = 92;
            this.label9.Text = "會員照片";
            // 
            // pbxMemberPhoto
            // 
            this.pbxMemberPhoto.BackColor = System.Drawing.Color.White;
            this.pbxMemberPhoto.BackgroundImage = global::OrderTest.Properties.Resources._2530788_add_user_business_man_employee_general_human_icon;
            this.pbxMemberPhoto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pbxMemberPhoto.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pbxMemberPhoto.Location = new System.Drawing.Point(41, 86);
            this.pbxMemberPhoto.Name = "pbxMemberPhoto";
            this.pbxMemberPhoto.Size = new System.Drawing.Size(256, 243);
            this.pbxMemberPhoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbxMemberPhoto.TabIndex = 91;
            this.pbxMemberPhoto.TabStop = false;
            // 
            // btnConfirm
            // 
            this.btnConfirm.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnConfirm.BackColor = System.Drawing.Color.Tan;
            this.btnConfirm.Location = new System.Drawing.Point(677, 438);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(109, 44);
            this.btnConfirm.TabIndex = 89;
            this.btnConfirm.Text = "更新送出";
            this.btnConfirm.UseVisualStyleBackColor = false;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // MemberEMail
            // 
            this.MemberEMail.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MemberEMail.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.MemberEMail.Location = new System.Drawing.Point(483, 366);
            this.MemberEMail.Multiline = true;
            this.MemberEMail.Name = "MemberEMail";
            this.MemberEMail.Size = new System.Drawing.Size(304, 27);
            this.MemberEMail.TabIndex = 88;
            this.MemberEMail.TextChanged += new System.EventHandler(this.MemberEMail_TextChanged);
            // 
            // txtMemberName
            // 
            this.txtMemberName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtMemberName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMemberName.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtMemberName.Location = new System.Drawing.Point(483, 170);
            this.txtMemberName.Multiline = true;
            this.txtMemberName.Name = "txtMemberName";
            this.txtMemberName.Size = new System.Drawing.Size(304, 27);
            this.txtMemberName.TabIndex = 87;
            // 
            // txtMemberPhone
            // 
            this.txtMemberPhone.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtMemberPhone.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMemberPhone.Enabled = false;
            this.txtMemberPhone.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtMemberPhone.Location = new System.Drawing.Point(483, 42);
            this.txtMemberPhone.Multiline = true;
            this.txtMemberPhone.Name = "txtMemberPhone";
            this.txtMemberPhone.Size = new System.Drawing.Size(304, 27);
            this.txtMemberPhone.TabIndex = 85;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label8.Location = new System.Drawing.Point(368, 369);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(95, 24);
            this.label8.TabIndex = 84;
            this.label8.Text = "*電子信箱";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label7.Location = new System.Drawing.Point(368, 302);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(57, 24);
            this.label7.TabIndex = 83;
            this.label7.Text = "*生日";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label6.Location = new System.Drawing.Point(368, 170);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 24);
            this.label6.TabIndex = 82;
            this.label6.Text = "*姓名";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label12.Location = new System.Drawing.Point(368, 42);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(95, 24);
            this.label12.TabIndex = 80;
            this.label12.Text = "*手機號碼";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Frm_UserModify
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(837, 612);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.webBrowser1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Frm_UserModify";
            this.Text = "MemberInformation";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.OrderDetaildataGridView2)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.OrderDataGridView)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxMemberPhoto)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.WebBrowser webBrowser1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView OrderDetaildataGridView2;
        private System.Windows.Forms.DataGridView OrderDataGridView;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNewPassword;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtOldPassword;
        private System.Windows.Forms.Button btnCheckPasswork;
        private System.Windows.Forms.Label labPasswod;
        private System.Windows.Forms.Label labEmail;
        private System.Windows.Forms.Label labName;
        private System.Windows.Forms.RadioButton rdoFemale;
        private System.Windows.Forms.RadioButton rdoMale;
        private System.Windows.Forms.TextBox txtMemberIdentity;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DateTimePicker dtmemberBirthday;
        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.PictureBox pbxMemberPhoto;
        private System.Windows.Forms.Button btnConfirm;
        private System.Windows.Forms.TextBox MemberEMail;
        private System.Windows.Forms.TextBox txtMemberName;
        private System.Windows.Forms.TextBox txtMemberPhone;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}