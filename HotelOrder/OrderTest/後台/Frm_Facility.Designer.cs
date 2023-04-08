namespace OrderTest.後台
{
    partial class Frm_Facility
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
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnFacility = new System.Windows.Forms.Button();
            this.btn_Insert = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textFacilityName = new System.Windows.Forms.TextBox();
            this.btnBrowers = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_Alter_RoomFacility = new System.Windows.Forms.Button();
            this.comboBoxFacilityID = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBoxRoomID = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_Del_RoomFacility = new System.Windows.Forms.Button();
            this.btn_Insert_RoomFacility = new System.Windows.Forms.Button();
            this.comboBoxRoomSearch = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnRoomFacilities = new System.Windows.Forms.Button();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.btn_Alter = new System.Windows.Forms.Button();
            this.btn_Delete = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBoxFacility = new System.Windows.Forms.PictureBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.bindingSourceFacilities = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFacility)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceFacilities)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(472, 538);
            this.dataGridView1.TabIndex = 25;
            this.dataGridView1.SelectionChanged += new System.EventHandler(this.dataGridView1_SelectionChanged);
            // 
            // btnFacility
            // 
            this.btnFacility.Location = new System.Drawing.Point(34, 421);
            this.btnFacility.Name = "btnFacility";
            this.btnFacility.Size = new System.Drawing.Size(187, 29);
            this.btnFacility.TabIndex = 23;
            this.btnFacility.Text = "查看設備清單";
            this.btnFacility.UseVisualStyleBackColor = true;
            this.btnFacility.Click += new System.EventHandler(this.btnFacility_Click);
            // 
            // btn_Insert
            // 
            this.btn_Insert.Location = new System.Drawing.Point(34, 260);
            this.btn_Insert.Name = "btn_Insert";
            this.btn_Insert.Size = new System.Drawing.Size(187, 23);
            this.btn_Insert.TabIndex = 22;
            this.btn_Insert.Text = "新增設備";
            this.btn_Insert.UseVisualStyleBackColor = true;
            this.btn_Insert.Click += new System.EventHandler(this.btn_Insert_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 21;
            this.label1.Text = "設備名稱";
            // 
            // textFacilityName
            // 
            this.textFacilityName.Location = new System.Drawing.Point(85, 13);
            this.textFacilityName.Name = "textFacilityName";
            this.textFacilityName.Size = new System.Drawing.Size(112, 22);
            this.textFacilityName.TabIndex = 20;
            // 
            // btnBrowers
            // 
            this.btnBrowers.Location = new System.Drawing.Point(34, 231);
            this.btnBrowers.Name = "btnBrowers";
            this.btnBrowers.Size = new System.Drawing.Size(187, 23);
            this.btnBrowers.TabIndex = 18;
            this.btnBrowers.Text = "瀏覽圖片";
            this.btnBrowers.UseVisualStyleBackColor = true;
            this.btnBrowers.Click += new System.EventHandler(this.btnBrowers_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(751, 570);
            this.tabControl1.TabIndex = 26;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.splitContainer2);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(743, 544);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "房間設備";
            this.tabPage1.UseVisualStyleBackColor = true;
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
            this.splitContainer2.Panel1.Controls.Add(this.groupBox1);
            this.splitContainer2.Panel1.Controls.Add(this.comboBoxRoomSearch);
            this.splitContainer2.Panel1.Controls.Add(this.label2);
            this.splitContainer2.Panel1.Controls.Add(this.btnRoomFacilities);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.dataGridView2);
            this.splitContainer2.Size = new System.Drawing.Size(737, 538);
            this.splitContainer2.SplitterDistance = 243;
            this.splitContainer2.TabIndex = 31;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.btn_Alter_RoomFacility);
            this.groupBox1.Controls.Add(this.comboBoxFacilityID);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.comboBoxRoomID);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.btn_Del_RoomFacility);
            this.groupBox1.Controls.Add(this.btn_Insert_RoomFacility);
            this.groupBox1.Location = new System.Drawing.Point(20, 133);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(185, 280);
            this.groupBox1.TabIndex = 31;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "修改";
            // 
            // btn_Alter_RoomFacility
            // 
            this.btn_Alter_RoomFacility.Location = new System.Drawing.Point(6, 184);
            this.btn_Alter_RoomFacility.Name = "btn_Alter_RoomFacility";
            this.btn_Alter_RoomFacility.Size = new System.Drawing.Size(144, 23);
            this.btn_Alter_RoomFacility.TabIndex = 36;
            this.btn_Alter_RoomFacility.Text = "修改房間設備";
            this.btn_Alter_RoomFacility.UseVisualStyleBackColor = true;
            this.btn_Alter_RoomFacility.Click += new System.EventHandler(this.btn_Alter_RoomFacility_Click);
            // 
            // comboBoxFacilityID
            // 
            this.comboBoxFacilityID.FormattingEnabled = true;
            this.comboBoxFacilityID.Location = new System.Drawing.Point(6, 94);
            this.comboBoxFacilityID.Name = "comboBoxFacilityID";
            this.comboBoxFacilityID.Size = new System.Drawing.Size(144, 20);
            this.comboBoxFacilityID.TabIndex = 35;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(4, 79);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 12);
            this.label5.TabIndex = 34;
            this.label5.Text = "設備編號";
            // 
            // comboBoxRoomID
            // 
            this.comboBoxRoomID.FormattingEnabled = true;
            this.comboBoxRoomID.Location = new System.Drawing.Point(6, 36);
            this.comboBoxRoomID.Name = "comboBoxRoomID";
            this.comboBoxRoomID.Size = new System.Drawing.Size(144, 20);
            this.comboBoxRoomID.TabIndex = 33;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(4, 21);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 12);
            this.label4.TabIndex = 32;
            this.label4.Text = "房間編號";
            // 
            // btn_Del_RoomFacility
            // 
            this.btn_Del_RoomFacility.Location = new System.Drawing.Point(6, 213);
            this.btn_Del_RoomFacility.Name = "btn_Del_RoomFacility";
            this.btn_Del_RoomFacility.Size = new System.Drawing.Size(144, 23);
            this.btn_Del_RoomFacility.TabIndex = 33;
            this.btn_Del_RoomFacility.Text = "刪除房間設備";
            this.btn_Del_RoomFacility.UseVisualStyleBackColor = true;
            this.btn_Del_RoomFacility.Click += new System.EventHandler(this.btn_Del_RoomFacility_Click);
            // 
            // btn_Insert_RoomFacility
            // 
            this.btn_Insert_RoomFacility.Location = new System.Drawing.Point(6, 157);
            this.btn_Insert_RoomFacility.Name = "btn_Insert_RoomFacility";
            this.btn_Insert_RoomFacility.Size = new System.Drawing.Size(144, 23);
            this.btn_Insert_RoomFacility.TabIndex = 32;
            this.btn_Insert_RoomFacility.Text = "新增房間設備";
            this.btn_Insert_RoomFacility.UseVisualStyleBackColor = true;
            this.btn_Insert_RoomFacility.Click += new System.EventHandler(this.btn_Insert_RoomFacility_Click);
            // 
            // comboBoxRoomSearch
            // 
            this.comboBoxRoomSearch.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBoxRoomSearch.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxRoomSearch.FormattingEnabled = true;
            this.comboBoxRoomSearch.Location = new System.Drawing.Point(20, 46);
            this.comboBoxRoomSearch.Name = "comboBoxRoomSearch";
            this.comboBoxRoomSearch.Size = new System.Drawing.Size(185, 24);
            this.comboBoxRoomSearch.TabIndex = 29;
            this.comboBoxRoomSearch.SelectedIndexChanged += new System.EventHandler(this.comboBoxRoomSearch_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 27;
            this.label2.Text = "房間搜尋";
            // 
            // btnRoomFacilities
            // 
            this.btnRoomFacilities.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRoomFacilities.Location = new System.Drawing.Point(20, 83);
            this.btnRoomFacilities.Name = "btnRoomFacilities";
            this.btnRoomFacilities.Size = new System.Drawing.Size(150, 23);
            this.btnRoomFacilities.TabIndex = 30;
            this.btnRoomFacilities.Text = "顯示全部房間設備";
            this.btnRoomFacilities.UseVisualStyleBackColor = true;
            this.btnRoomFacilities.Click += new System.EventHandler(this.btnRoomFacilities_Click);
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView2.Location = new System.Drawing.Point(0, 0);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(490, 538);
            this.dataGridView2.TabIndex = 26;
            this.dataGridView2.SelectionChanged += new System.EventHandler(this.dataGridView2_SelectionChanged);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.splitContainer1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(743, 544);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "設備管理";
            this.tabPage2.UseVisualStyleBackColor = true;
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
            this.splitContainer1.Panel1.Controls.Add(this.btn_Alter);
            this.splitContainer1.Panel1.Controls.Add(this.btn_Delete);
            this.splitContainer1.Panel1.Controls.Add(this.label3);
            this.splitContainer1.Panel1.Controls.Add(this.btnFacility);
            this.splitContainer1.Panel1.Controls.Add(this.pictureBoxFacility);
            this.splitContainer1.Panel1.Controls.Add(this.btnBrowers);
            this.splitContainer1.Panel1.Controls.Add(this.btn_Insert);
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            this.splitContainer1.Panel1.Controls.Add(this.textFacilityName);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.dataGridView1);
            this.splitContainer1.Size = new System.Drawing.Size(737, 538);
            this.splitContainer1.SplitterDistance = 261;
            this.splitContainer1.TabIndex = 26;
            // 
            // btn_Alter
            // 
            this.btn_Alter.Location = new System.Drawing.Point(34, 289);
            this.btn_Alter.Name = "btn_Alter";
            this.btn_Alter.Size = new System.Drawing.Size(187, 23);
            this.btn_Alter.TabIndex = 25;
            this.btn_Alter.Text = "修改設備";
            this.btn_Alter.UseVisualStyleBackColor = true;
            this.btn_Alter.Click += new System.EventHandler(this.btn_Alter_Click);
            // 
            // btn_Delete
            // 
            this.btn_Delete.Location = new System.Drawing.Point(34, 318);
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.Size = new System.Drawing.Size(187, 23);
            this.btn_Delete.TabIndex = 24;
            this.btn_Delete.Text = "刪除設備";
            this.btn_Delete.UseVisualStyleBackColor = true;
            this.btn_Delete.Click += new System.EventHandler(this.btn_Delete_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 43);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 12);
            this.label3.TabIndex = 23;
            this.label3.Text = "設備圖片";
            // 
            // pictureBoxFacility
            // 
            this.pictureBoxFacility.BackColor = System.Drawing.Color.White;
            this.pictureBoxFacility.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBoxFacility.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBoxFacility.Location = new System.Drawing.Point(34, 58);
            this.pictureBoxFacility.Name = "pictureBoxFacility";
            this.pictureBoxFacility.Size = new System.Drawing.Size(187, 166);
            this.pictureBoxFacility.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxFacility.TabIndex = 19;
            this.pictureBoxFacility.TabStop = false;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Frm_Facility
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(751, 570);
            this.Controls.Add(this.tabControl1);
            this.Name = "Frm_Facility";
            this.Text = "設備管理";
            this.Load += new System.EventHandler(this.設備管理_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel1.PerformLayout();
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFacility)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceFacilities)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnFacility;
        private System.Windows.Forms.Button btn_Insert;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textFacilityName;
        private System.Windows.Forms.PictureBox pictureBoxFacility;
        private System.Windows.Forms.Button btnBrowers;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button btnRoomFacilities;
        private System.Windows.Forms.ComboBox comboBoxRoomSearch;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button btn_Delete;
        private System.Windows.Forms.Button btn_Alter;
        private System.Windows.Forms.BindingSource bindingSourceFacilities;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_Alter_RoomFacility;
        private System.Windows.Forms.ComboBox comboBoxFacilityID;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboBoxRoomID;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_Del_RoomFacility;
        private System.Windows.Forms.Button btn_Insert_RoomFacility;
    }
}