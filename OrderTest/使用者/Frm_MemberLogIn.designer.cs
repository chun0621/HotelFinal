namespace Test_Room
{
    partial class Frm_MemberLogIn
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtAccount = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.btnLogIn = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnLogInDemo = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.labEmail = new System.Windows.Forms.Label();
            this.labIdentity = new System.Windows.Forms.Label();
            this.labphone = new System.Windows.Forms.Label();
            this.labName = new System.Windows.Forms.Label();
            this.labPasswod = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.rdoFemale = new System.Windows.Forms.RadioButton();
            this.rdoMale = new System.Windows.Forms.RadioButton();
            this.txtMemberIdentity = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.dtmemberBirthday = new System.Windows.Forms.DateTimePicker();
            this.btnInsertDemo = new System.Windows.Forms.Button();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.MemberEMail = new System.Windows.Forms.TextBox();
            this.txtMemberName = new System.Windows.Forms.TextBox();
            this.txtMemberPassword = new System.Windows.Forms.TextBox();
            this.txtMemberPhone = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.pbxMemberPhoto = new System.Windows.Forms.PictureBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxMemberPhoto)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(46, 259);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "訂房帳號";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.Location = new System.Drawing.Point(46, 348);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "訂房密碼";
            // 
            // txtAccount
            // 
            this.txtAccount.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtAccount.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtAccount.Location = new System.Drawing.Point(44, 287);
            this.txtAccount.Multiline = true;
            this.txtAccount.Name = "txtAccount";
            this.txtAccount.Size = new System.Drawing.Size(648, 49);
            this.txtAccount.TabIndex = 2;
            this.txtAccount.Enter += new System.EventHandler(this.txtAccount_Enter);
            this.txtAccount.Leave += new System.EventHandler(this.txtAccount_Leave);
            // 
            // txtPassword
            // 
            this.txtPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPassword.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtPassword.Location = new System.Drawing.Point(44, 376);
            this.txtPassword.Multiline = true;
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(648, 49);
            this.txtPassword.TabIndex = 3;
            this.txtPassword.UseSystemPasswordChar = true;
            this.txtPassword.Enter += new System.EventHandler(this.txtPassword_Enter_1);
            this.txtPassword.Leave += new System.EventHandler(this.txtPassword_Leave_1);
            // 
            // btnLogIn
            // 
            this.btnLogIn.BackColor = System.Drawing.Color.Tan;
            this.btnLogIn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogIn.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnLogIn.Location = new System.Drawing.Point(44, 494);
            this.btnLogIn.Name = "btnLogIn";
            this.btnLogIn.Size = new System.Drawing.Size(646, 48);
            this.btnLogIn.TabIndex = 5;
            this.btnLogIn.Text = "確定登入";
            this.btnLogIn.UseVisualStyleBackColor = false;
            this.btnLogIn.Click += new System.EventHandler(this.btnLogIn_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Appearance = System.Windows.Forms.TabAppearance.Buttons;
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Font = new System.Drawing.Font("微軟正黑體", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.tabControl1.HotTrack = true;
            this.tabControl1.ItemSize = new System.Drawing.Size(160, 60);
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Multiline = true;
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(752, 706);
            this.tabControl1.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabControl1.TabIndex = 8;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(228)))), ((int)(((byte)(187)))));
            this.tabPage1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.tabPage1.Controls.Add(this.linkLabel1);
            this.tabPage1.Controls.Add(this.pictureBox1);
            this.tabPage1.Controls.Add(this.btnLogInDemo);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.txtAccount);
            this.tabPage1.Controls.Add(this.btnLogIn);
            this.tabPage1.Controls.Add(this.txtPassword);
            this.tabPage1.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.tabPage1.Location = new System.Drawing.Point(4, 64);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.tabPage1.Size = new System.Drawing.Size(744, 638);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "登入會員";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.Image = global::OrderTest.Properties.Resources._2530821_business_man_employee_general_human_member_icon;
            this.pictureBox1.Location = new System.Drawing.Point(249, 21);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(234, 208);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // btnLogInDemo
            // 
            this.btnLogInDemo.BackColor = System.Drawing.Color.Tan;
            this.btnLogInDemo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogInDemo.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnLogInDemo.Location = new System.Drawing.Point(44, 559);
            this.btnLogInDemo.Name = "btnLogInDemo";
            this.btnLogInDemo.Size = new System.Drawing.Size(646, 48);
            this.btnLogInDemo.TabIndex = 9;
            this.btnLogInDemo.Text = "DEMO";
            this.btnLogInDemo.UseVisualStyleBackColor = false;
            this.btnLogInDemo.Click += new System.EventHandler(this.btnLogInDemo_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(228)))), ((int)(((byte)(187)))));
            this.tabPage2.Controls.Add(this.labEmail);
            this.tabPage2.Controls.Add(this.labIdentity);
            this.tabPage2.Controls.Add(this.labphone);
            this.tabPage2.Controls.Add(this.labName);
            this.tabPage2.Controls.Add(this.labPasswod);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.rdoFemale);
            this.tabPage2.Controls.Add(this.rdoMale);
            this.tabPage2.Controls.Add(this.txtMemberIdentity);
            this.tabPage2.Controls.Add(this.label10);
            this.tabPage2.Controls.Add(this.label11);
            this.tabPage2.Controls.Add(this.dtmemberBirthday);
            this.tabPage2.Controls.Add(this.btnInsertDemo);
            this.tabPage2.Controls.Add(this.btnBrowse);
            this.tabPage2.Controls.Add(this.label9);
            this.tabPage2.Controls.Add(this.btnConfirm);
            this.tabPage2.Controls.Add(this.MemberEMail);
            this.tabPage2.Controls.Add(this.txtMemberName);
            this.tabPage2.Controls.Add(this.txtMemberPassword);
            this.tabPage2.Controls.Add(this.txtMemberPhone);
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.pbxMemberPhoto);
            this.tabPage2.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.tabPage2.Location = new System.Drawing.Point(4, 64);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(2);
            this.tabPage2.Size = new System.Drawing.Size(744, 638);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "註冊會員";
            // 
            // labEmail
            // 
            this.labEmail.Font = new System.Drawing.Font("微軟正黑體", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labEmail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.labEmail.Location = new System.Drawing.Point(154, 542);
            this.labEmail.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labEmail.Name = "labEmail";
            this.labEmail.Size = new System.Drawing.Size(265, 25);
            this.labEmail.TabIndex = 79;
            this.labEmail.Text = "labEmail";
            this.labEmail.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.labEmail.Visible = false;
            // 
            // labIdentity
            // 
            this.labIdentity.Font = new System.Drawing.Font("微軟正黑體", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labIdentity.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.labIdentity.Location = new System.Drawing.Point(157, 281);
            this.labIdentity.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labIdentity.Name = "labIdentity";
            this.labIdentity.Size = new System.Drawing.Size(262, 25);
            this.labIdentity.TabIndex = 78;
            this.labIdentity.Text = "labIdentity";
            this.labIdentity.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.labIdentity.Visible = false;
            // 
            // labphone
            // 
            this.labphone.Font = new System.Drawing.Font("微軟正黑體", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labphone.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.labphone.Location = new System.Drawing.Point(224, 22);
            this.labphone.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labphone.Name = "labphone";
            this.labphone.Size = new System.Drawing.Size(194, 25);
            this.labphone.TabIndex = 77;
            this.labphone.Text = "labphone";
            this.labphone.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.labphone.Visible = false;
            // 
            // labName
            // 
            this.labName.Font = new System.Drawing.Font("微軟正黑體", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.labName.Location = new System.Drawing.Point(227, 194);
            this.labName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labName.Name = "labName";
            this.labName.Size = new System.Drawing.Size(191, 25);
            this.labName.TabIndex = 76;
            this.labName.Text = "labName";
            this.labName.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.labName.Visible = false;
            // 
            // labPasswod
            // 
            this.labPasswod.Font = new System.Drawing.Font("微軟正黑體", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labPasswod.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.labPasswod.Location = new System.Drawing.Point(184, 106);
            this.labPasswod.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labPasswod.Name = "labPasswod";
            this.labPasswod.Size = new System.Drawing.Size(234, 25);
            this.labPasswod.TabIndex = 75;
            this.labPasswod.Text = "labPasswod";
            this.labPasswod.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.labPasswod.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label3.Location = new System.Drawing.Point(489, 18);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(245, 21);
            this.label3.TabIndex = 74;
            this.label3.Text = "* 為必填欄位，請填妥欄位資訊。";
            // 
            // rdoFemale
            // 
            this.rdoFemale.AutoSize = true;
            this.rdoFemale.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.rdoFemale.Location = new System.Drawing.Point(93, 390);
            this.rdoFemale.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rdoFemale.Name = "rdoFemale";
            this.rdoFemale.Size = new System.Drawing.Size(85, 28);
            this.rdoFemale.TabIndex = 73;
            this.rdoFemale.TabStop = true;
            this.rdoFemale.Text = "生理女";
            this.rdoFemale.UseVisualStyleBackColor = true;
            // 
            // rdoMale
            // 
            this.rdoMale.AutoSize = true;
            this.rdoMale.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.rdoMale.Location = new System.Drawing.Point(11, 390);
            this.rdoMale.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rdoMale.Name = "rdoMale";
            this.rdoMale.Size = new System.Drawing.Size(85, 28);
            this.rdoMale.TabIndex = 72;
            this.rdoMale.TabStop = true;
            this.rdoMale.Text = "生理男";
            this.rdoMale.UseVisualStyleBackColor = true;
            // 
            // txtMemberIdentity
            // 
            this.txtMemberIdentity.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtMemberIdentity.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtMemberIdentity.Location = new System.Drawing.Point(13, 306);
            this.txtMemberIdentity.Multiline = true;
            this.txtMemberIdentity.Name = "txtMemberIdentity";
            this.txtMemberIdentity.Size = new System.Drawing.Size(407, 27);
            this.txtMemberIdentity.TabIndex = 71;
            this.txtMemberIdentity.TextChanged += new System.EventHandler(this.txtMemberIdentity_TextChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label10.Location = new System.Drawing.Point(11, 277);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(114, 24);
            this.label10.TabIndex = 70;
            this.label10.Text = "*身份證字號";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label11.Location = new System.Drawing.Point(11, 363);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(57, 24);
            this.label11.TabIndex = 69;
            this.label11.Text = "*性別";
            // 
            // dtmemberBirthday
            // 
            this.dtmemberBirthday.CustomFormat = "yyyy-MM-dd";
            this.dtmemberBirthday.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.dtmemberBirthday.Location = new System.Drawing.Point(13, 479);
            this.dtmemberBirthday.Name = "dtmemberBirthday";
            this.dtmemberBirthday.Size = new System.Drawing.Size(407, 32);
            this.dtmemberBirthday.TabIndex = 21;
            this.dtmemberBirthday.Value = new System.DateTime(1990, 1, 1, 0, 0, 0, 0);
            // 
            // btnInsertDemo
            // 
            this.btnInsertDemo.BackColor = System.Drawing.Color.Tan;
            this.btnInsertDemo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnInsertDemo.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnInsertDemo.Location = new System.Drawing.Point(611, 503);
            this.btnInsertDemo.Name = "btnInsertDemo";
            this.btnInsertDemo.Size = new System.Drawing.Size(109, 44);
            this.btnInsertDemo.TabIndex = 20;
            this.btnInsertDemo.Text = "DEMO";
            this.btnInsertDemo.UseVisualStyleBackColor = false;
            this.btnInsertDemo.Click += new System.EventHandler(this.btnInsertDemo_Click);
            // 
            // btnBrowse
            // 
            this.btnBrowse.BackColor = System.Drawing.Color.Tan;
            this.btnBrowse.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBrowse.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnBrowse.Location = new System.Drawing.Point(610, 378);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(109, 42);
            this.btnBrowse.TabIndex = 19;
            this.btnBrowse.Text = "瀏覽照片";
            this.btnBrowse.UseVisualStyleBackColor = false;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label9.Location = new System.Drawing.Point(460, 76);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(86, 24);
            this.label9.TabIndex = 18;
            this.label9.Text = "會員照片";
            // 
            // btnConfirm
            // 
            this.btnConfirm.BackColor = System.Drawing.Color.Tan;
            this.btnConfirm.Enabled = false;
            this.btnConfirm.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnConfirm.Location = new System.Drawing.Point(611, 554);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(109, 44);
            this.btnConfirm.TabIndex = 15;
            this.btnConfirm.Text = "資料確認";
            this.btnConfirm.UseVisualStyleBackColor = false;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // MemberEMail
            // 
            this.MemberEMail.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.MemberEMail.Location = new System.Drawing.Point(13, 570);
            this.MemberEMail.Multiline = true;
            this.MemberEMail.Name = "MemberEMail";
            this.MemberEMail.Size = new System.Drawing.Size(407, 27);
            this.MemberEMail.TabIndex = 14;
            this.MemberEMail.TextChanged += new System.EventHandler(this.MemberEMail_TextChanged);
            // 
            // txtMemberName
            // 
            this.txtMemberName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMemberName.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtMemberName.Location = new System.Drawing.Point(13, 220);
            this.txtMemberName.Multiline = true;
            this.txtMemberName.Name = "txtMemberName";
            this.txtMemberName.Size = new System.Drawing.Size(407, 27);
            this.txtMemberName.TabIndex = 12;
            this.txtMemberName.TextChanged += new System.EventHandler(this.txtMemberName_TextChanged);
            // 
            // txtMemberPassword
            // 
            this.txtMemberPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMemberPassword.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtMemberPassword.Location = new System.Drawing.Point(13, 134);
            this.txtMemberPassword.Multiline = true;
            this.txtMemberPassword.Name = "txtMemberPassword";
            this.txtMemberPassword.Size = new System.Drawing.Size(407, 27);
            this.txtMemberPassword.TabIndex = 11;
            this.txtMemberPassword.TextChanged += new System.EventHandler(this.txtMemberPassword_TextChanged);
            this.txtMemberPassword.Enter += new System.EventHandler(this.txtMemberPassword_Enter);
            this.txtMemberPassword.Leave += new System.EventHandler(this.txtMemberPassword_Leave);
            // 
            // txtMemberPhone
            // 
            this.txtMemberPhone.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMemberPhone.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtMemberPhone.Location = new System.Drawing.Point(13, 47);
            this.txtMemberPhone.Multiline = true;
            this.txtMemberPhone.Name = "txtMemberPhone";
            this.txtMemberPhone.Size = new System.Drawing.Size(407, 27);
            this.txtMemberPhone.TabIndex = 10;
            this.txtMemberPhone.TextChanged += new System.EventHandler(this.txtMemberPhone_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label8.Location = new System.Drawing.Point(11, 541);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(95, 24);
            this.label8.TabIndex = 9;
            this.label8.Text = "*電子信箱";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label7.Location = new System.Drawing.Point(11, 450);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(57, 24);
            this.label7.TabIndex = 7;
            this.label7.Text = "*生日";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label6.Location = new System.Drawing.Point(11, 190);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 24);
            this.label6.TabIndex = 5;
            this.label6.Text = "*姓名";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label5.Location = new System.Drawing.Point(11, 104);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(95, 24);
            this.label5.TabIndex = 3;
            this.label5.Text = "*註冊密碼";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label4.Location = new System.Drawing.Point(11, 18);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(185, 24);
            this.label4.TabIndex = 1;
            this.label4.Text = "*手機號碼(註冊帳號)";
            // 
            // pbxMemberPhoto
            // 
            this.pbxMemberPhoto.BackColor = System.Drawing.Color.White;
            this.pbxMemberPhoto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pbxMemberPhoto.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pbxMemberPhoto.Image = global::OrderTest.Properties.Resources._2530788_add_user_business_man_employee_general_human_icon;
            this.pbxMemberPhoto.Location = new System.Drawing.Point(460, 106);
            this.pbxMemberPhoto.Name = "pbxMemberPhoto";
            this.pbxMemberPhoto.Size = new System.Drawing.Size(261, 266);
            this.pbxMemberPhoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbxMemberPhoto.TabIndex = 17;
            this.pbxMemberPhoto.TabStop = false;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(569, 428);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(123, 35);
            this.linkLabel1.TabIndex = 11;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "忘記密碼";
            this.linkLabel1.Click += new System.EventHandler(this.linkLabel1_Click);
            // 
            // Frm_MemberLogIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(228)))), ((int)(((byte)(187)))));
            this.ClientSize = new System.Drawing.Size(752, 706);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Frm_MemberLogIn";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "我的帳戶";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MemberLogIn_FormClosing);
            this.Load += new System.EventHandler(this.MemberLogIn_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxMemberPhoto)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtAccount;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Button btnLogIn;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button btnConfirm;
        private System.Windows.Forms.TextBox MemberEMail;
        private System.Windows.Forms.TextBox txtMemberName;
        private System.Windows.Forms.TextBox txtMemberPassword;
        private System.Windows.Forms.TextBox txtMemberPhone;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.PictureBox pbxMemberPhoto;
        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.Button btnLogInDemo;
        private System.Windows.Forms.Button btnInsertDemo;
        private System.Windows.Forms.DateTimePicker dtmemberBirthday;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.RadioButton rdoFemale;
        private System.Windows.Forms.RadioButton rdoMale;
        private System.Windows.Forms.TextBox txtMemberIdentity;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labEmail;
        private System.Windows.Forms.Label labIdentity;
        private System.Windows.Forms.Label labphone;
        private System.Windows.Forms.Label labName;
        private System.Windows.Forms.Label labPasswod;
        private System.Windows.Forms.LinkLabel linkLabel1;
    }
}

