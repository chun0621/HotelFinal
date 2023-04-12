namespace HotelManager
{
    partial class Frm_Industry
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonClear = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonInsertImage = new System.Windows.Forms.Button();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.buttonDrop = new System.Windows.Forms.Button();
            this.buttonAlter = new System.Windows.Forms.Button();
            this.buttonCreate = new System.Windows.Forms.Button();
            this.textBoxHotelImageDiscription = new System.Windows.Forms.TextBox();
            this.pictureBoxImage = new System.Windows.Forms.PictureBox();
            this.comboBoxRegionName = new System.Windows.Forms.ComboBox();
            this.textBoxHotelAddress = new System.Windows.Forms.TextBox();
            this.textBoxHotelPhone = new System.Windows.Forms.TextBox();
            this.textBoxHotelName = new System.Windows.Forms.TextBox();
            this.textBoxHotelID = new System.Windows.Forms.TextBox();
            this.labelHotelImageDiscription = new System.Windows.Forms.Label();
            this.labelRegionName = new System.Windows.Forms.Label();
            this.HotelImage = new System.Windows.Forms.Label();
            this.labelHotelAdress = new System.Windows.Forms.Label();
            this.labelPhone = new System.Windows.Forms.Label();
            this.labelHotelName = new System.Windows.Forms.Label();
            this.labelHotelID = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.buttonshowall = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(228)))), ((int)(((byte)(187)))));
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.buttonClear);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.buttonInsertImage);
            this.groupBox1.Controls.Add(this.buttonSearch);
            this.groupBox1.Controls.Add(this.buttonDrop);
            this.groupBox1.Controls.Add(this.buttonAlter);
            this.groupBox1.Controls.Add(this.buttonCreate);
            this.groupBox1.Controls.Add(this.textBoxHotelImageDiscription);
            this.groupBox1.Controls.Add(this.pictureBoxImage);
            this.groupBox1.Controls.Add(this.comboBoxRegionName);
            this.groupBox1.Controls.Add(this.textBoxHotelAddress);
            this.groupBox1.Controls.Add(this.textBoxHotelPhone);
            this.groupBox1.Controls.Add(this.textBoxHotelName);
            this.groupBox1.Controls.Add(this.textBoxHotelID);
            this.groupBox1.Controls.Add(this.labelHotelImageDiscription);
            this.groupBox1.Controls.Add(this.labelRegionName);
            this.groupBox1.Controls.Add(this.HotelImage);
            this.groupBox1.Controls.Add(this.labelHotelAdress);
            this.groupBox1.Controls.Add(this.labelPhone);
            this.groupBox1.Controls.Add(this.labelHotelName);
            this.groupBox1.Controls.Add(this.labelHotelID);
            this.groupBox1.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.groupBox1.Location = new System.Drawing.Point(31, 80);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(930, 423);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "業者基本資料";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label3.Location = new System.Drawing.Point(211, 134);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(163, 20);
            this.label3.TabIndex = 26;
            this.label3.Text = "(此欄查詢無須輸入值)";
            // 
            // buttonClear
            // 
            this.buttonClear.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.buttonClear.Location = new System.Drawing.Point(718, 134);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(172, 38);
            this.buttonClear.TabIndex = 25;
            this.buttonClear.Text = "清空所有欄位(含照片)";
            this.buttonClear.UseVisualStyleBackColor = true;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.Location = new System.Drawing.Point(556, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(131, 20);
            this.label2.TabIndex = 24;
            this.label2.Text = "(僅供查詢資料用)";
            // 
            // buttonInsertImage
            // 
            this.buttonInsertImage.Location = new System.Drawing.Point(302, 195);
            this.buttonInsertImage.Name = "buttonInsertImage";
            this.buttonInsertImage.Size = new System.Drawing.Size(95, 31);
            this.buttonInsertImage.TabIndex = 22;
            this.buttonInsertImage.Text = "插入圖片";
            this.buttonInsertImage.UseVisualStyleBackColor = true;
            this.buttonInsertImage.Click += new System.EventHandler(this.buttonInsertImage_Click);
            // 
            // buttonSearch
            // 
            this.buttonSearch.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.buttonSearch.Location = new System.Drawing.Point(756, 251);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(168, 38);
            this.buttonSearch.TabIndex = 21;
            this.buttonSearch.Text = "查詢資料";
            this.buttonSearch.UseVisualStyleBackColor = true;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // buttonDrop
            // 
            this.buttonDrop.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.buttonDrop.Location = new System.Drawing.Point(756, 378);
            this.buttonDrop.Name = "buttonDrop";
            this.buttonDrop.Size = new System.Drawing.Size(168, 38);
            this.buttonDrop.TabIndex = 20;
            this.buttonDrop.Text = "刪除單筆資料";
            this.buttonDrop.UseVisualStyleBackColor = true;
            this.buttonDrop.Click += new System.EventHandler(this.buttonDrop_Click);
            // 
            // buttonAlter
            // 
            this.buttonAlter.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.buttonAlter.Location = new System.Drawing.Point(756, 318);
            this.buttonAlter.Name = "buttonAlter";
            this.buttonAlter.Size = new System.Drawing.Size(168, 38);
            this.buttonAlter.TabIndex = 19;
            this.buttonAlter.Text = "完整修改單筆資料";
            this.buttonAlter.UseVisualStyleBackColor = true;
            this.buttonAlter.Click += new System.EventHandler(this.buttonAlter_Click);
            // 
            // buttonCreate
            // 
            this.buttonCreate.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.buttonCreate.Location = new System.Drawing.Point(756, 188);
            this.buttonCreate.Name = "buttonCreate";
            this.buttonCreate.Size = new System.Drawing.Size(168, 38);
            this.buttonCreate.TabIndex = 18;
            this.buttonCreate.Text = "新增單筆資料";
            this.buttonCreate.UseVisualStyleBackColor = true;
            this.buttonCreate.Click += new System.EventHandler(this.buttonCreate_Click);
            // 
            // textBoxHotelImageDiscription
            // 
            this.textBoxHotelImageDiscription.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.textBoxHotelImageDiscription.Location = new System.Drawing.Point(438, 195);
            this.textBoxHotelImageDiscription.Multiline = true;
            this.textBoxHotelImageDiscription.Name = "textBoxHotelImageDiscription";
            this.textBoxHotelImageDiscription.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBoxHotelImageDiscription.Size = new System.Drawing.Size(283, 199);
            this.textBoxHotelImageDiscription.TabIndex = 17;
            // 
            // pictureBoxImage
            // 
            this.pictureBoxImage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxImage.Location = new System.Drawing.Point(15, 195);
            this.pictureBoxImage.Name = "pictureBoxImage";
            this.pictureBoxImage.Size = new System.Drawing.Size(281, 199);
            this.pictureBoxImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxImage.TabIndex = 16;
            this.pictureBoxImage.TabStop = false;
            // 
            // comboBoxRegionName
            // 
            this.comboBoxRegionName.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.comboBoxRegionName.FormattingEnabled = true;
            this.comboBoxRegionName.Items.AddRange(new object[] {
            "北部地區",
            "中部地區",
            "南部地區"});
            this.comboBoxRegionName.Location = new System.Drawing.Point(85, 127);
            this.comboBoxRegionName.Name = "comboBoxRegionName";
            this.comboBoxRegionName.Size = new System.Drawing.Size(121, 28);
            this.comboBoxRegionName.TabIndex = 15;
            // 
            // textBoxHotelAddress
            // 
            this.textBoxHotelAddress.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.textBoxHotelAddress.Location = new System.Drawing.Point(448, 79);
            this.textBoxHotelAddress.Name = "textBoxHotelAddress";
            this.textBoxHotelAddress.Size = new System.Drawing.Size(273, 29);
            this.textBoxHotelAddress.TabIndex = 14;
            // 
            // textBoxHotelPhone
            // 
            this.textBoxHotelPhone.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.textBoxHotelPhone.Location = new System.Drawing.Point(85, 79);
            this.textBoxHotelPhone.Name = "textBoxHotelPhone";
            this.textBoxHotelPhone.Size = new System.Drawing.Size(273, 29);
            this.textBoxHotelPhone.TabIndex = 13;
            // 
            // textBoxHotelName
            // 
            this.textBoxHotelName.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.textBoxHotelName.Location = new System.Drawing.Point(85, 32);
            this.textBoxHotelName.Name = "textBoxHotelName";
            this.textBoxHotelName.Size = new System.Drawing.Size(273, 29);
            this.textBoxHotelName.TabIndex = 12;
            // 
            // textBoxHotelID
            // 
            this.textBoxHotelID.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.textBoxHotelID.Location = new System.Drawing.Point(448, 31);
            this.textBoxHotelID.Name = "textBoxHotelID";
            this.textBoxHotelID.Size = new System.Drawing.Size(102, 29);
            this.textBoxHotelID.TabIndex = 11;
            // 
            // labelHotelImageDiscription
            // 
            this.labelHotelImageDiscription.AutoSize = true;
            this.labelHotelImageDiscription.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labelHotelImageDiscription.Location = new System.Drawing.Point(434, 172);
            this.labelHotelImageDiscription.Name = "labelHotelImageDiscription";
            this.labelHotelImageDiscription.Size = new System.Drawing.Size(131, 20);
            this.labelHotelImageDiscription.TabIndex = 9;
            this.labelHotelImageDiscription.Text = "照片描述(非必填)";
            // 
            // labelRegionName
            // 
            this.labelRegionName.AutoSize = true;
            this.labelRegionName.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labelRegionName.Location = new System.Drawing.Point(6, 128);
            this.labelRegionName.Name = "labelRegionName";
            this.labelRegionName.Size = new System.Drawing.Size(73, 20);
            this.labelRegionName.TabIndex = 10;
            this.labelRegionName.Text = "地區名稱";
            // 
            // HotelImage
            // 
            this.HotelImage.AutoSize = true;
            this.HotelImage.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.HotelImage.Location = new System.Drawing.Point(11, 172);
            this.HotelImage.Name = "HotelImage";
            this.HotelImage.Size = new System.Drawing.Size(131, 20);
            this.HotelImage.TabIndex = 8;
            this.HotelImage.Text = "業者照片(非必填)";
            // 
            // labelHotelAdress
            // 
            this.labelHotelAdress.AutoSize = true;
            this.labelHotelAdress.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labelHotelAdress.Location = new System.Drawing.Point(369, 79);
            this.labelHotelAdress.Name = "labelHotelAdress";
            this.labelHotelAdress.Size = new System.Drawing.Size(73, 20);
            this.labelHotelAdress.TabIndex = 7;
            this.labelHotelAdress.Text = "業者地址";
            // 
            // labelPhone
            // 
            this.labelPhone.AutoSize = true;
            this.labelPhone.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labelPhone.Location = new System.Drawing.Point(6, 79);
            this.labelPhone.Name = "labelPhone";
            this.labelPhone.Size = new System.Drawing.Size(73, 20);
            this.labelPhone.TabIndex = 5;
            this.labelPhone.Text = "業者電話";
            // 
            // labelHotelName
            // 
            this.labelHotelName.AutoSize = true;
            this.labelHotelName.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labelHotelName.Location = new System.Drawing.Point(6, 41);
            this.labelHotelName.Name = "labelHotelName";
            this.labelHotelName.Size = new System.Drawing.Size(73, 20);
            this.labelHotelName.TabIndex = 4;
            this.labelHotelName.Text = "業者名稱";
            // 
            // labelHotelID
            // 
            this.labelHotelID.AutoSize = true;
            this.labelHotelID.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labelHotelID.Location = new System.Drawing.Point(369, 35);
            this.labelHotelID.Name = "labelHotelID";
            this.labelHotelID.Size = new System.Drawing.Size(73, 20);
            this.labelHotelID.TabIndex = 3;
            this.labelHotelID.Text = "業者編號";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(176, 22);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(105, 38);
            this.button1.TabIndex = 23;
            this.button1.Text = "Test";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Visible = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(36, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "業者管理";
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(31, 541);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(720, 264);
            this.dataGridView1.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label4.Location = new System.Drawing.Point(31, 522);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(930, 2);
            this.label4.TabIndex = 9;
            this.label4.Text = "label4";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // buttonshowall
            // 
            this.buttonshowall.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.buttonshowall.Location = new System.Drawing.Point(787, 541);
            this.buttonshowall.Name = "buttonshowall";
            this.buttonshowall.Size = new System.Drawing.Size(135, 38);
            this.buttonshowall.TabIndex = 27;
            this.buttonshowall.Text = "刷新全部資料";
            this.buttonshowall.UseVisualStyleBackColor = true;
            this.buttonshowall.Click += new System.EventHandler(this.buttonshowall_Click);
            // 
            // Frm_Industry
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(228)))), ((int)(((byte)(187)))));
            this.ClientSize = new System.Drawing.Size(1062, 817);
            this.Controls.Add(this.buttonshowall);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Name = "Frm_Industry";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBoxHotelName;
        private System.Windows.Forms.TextBox textBoxHotelID;
        private System.Windows.Forms.Label labelHotelImageDiscription;
        private System.Windows.Forms.Label labelRegionName;
        private System.Windows.Forms.Label HotelImage;
        private System.Windows.Forms.Label labelHotelAdress;
        private System.Windows.Forms.Label labelPhone;
        private System.Windows.Forms.Label labelHotelName;
        private System.Windows.Forms.Label labelHotelID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxHotelImageDiscription;
        private System.Windows.Forms.PictureBox pictureBoxImage;
        private System.Windows.Forms.ComboBox comboBoxRegionName;
        private System.Windows.Forms.TextBox textBoxHotelAddress;
        private System.Windows.Forms.TextBox textBoxHotelPhone;
        private System.Windows.Forms.Button buttonDrop;
        private System.Windows.Forms.Button buttonAlter;
        private System.Windows.Forms.Button buttonCreate;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button buttonInsertImage;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonshowall;
    }
}

