namespace OrderTest
{
    partial class 首頁
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
            this.btn_BrowerRoom = new System.Windows.Forms.Button();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.btn_Admin = new System.Windows.Forms.Button();
            this.btn_Activity = new System.Windows.Forms.Button();
            this.btn_Login = new System.Windows.Forms.Button();
            this.btn_ReserveRoom = new System.Windows.Forms.Button();
            this.btn_About = new System.Windows.Forms.Button();
            this.btnHome = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_BrowerRoom
            // 
            this.btn_BrowerRoom.BackColor = System.Drawing.Color.OldLace;
            this.btn_BrowerRoom.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_BrowerRoom.Font = new System.Drawing.Font("微軟正黑體", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_BrowerRoom.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btn_BrowerRoom.Location = new System.Drawing.Point(330, 12);
            this.btn_BrowerRoom.Name = "btn_BrowerRoom";
            this.btn_BrowerRoom.Size = new System.Drawing.Size(90, 35);
            this.btn_BrowerRoom.TabIndex = 1;
            this.btn_BrowerRoom.Text = "房型";
            this.btn_BrowerRoom.UseVisualStyleBackColor = false;
            this.btn_BrowerRoom.Visible = false;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.BackColor = System.Drawing.Color.Tan;
            this.splitContainer1.Panel1.Controls.Add(this.btn_Admin);
            this.splitContainer1.Panel1.Controls.Add(this.btn_Activity);
            this.splitContainer1.Panel1.Controls.Add(this.btn_Login);
            this.splitContainer1.Panel1.Controls.Add(this.btn_ReserveRoom);
            this.splitContainer1.Panel1.Controls.Add(this.btn_About);
            this.splitContainer1.Panel1.Controls.Add(this.btnHome);
            this.splitContainer1.Panel1.Controls.Add(this.btn_BrowerRoom);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.splitContainer1.Panel2.BackgroundImage = global::OrderTest.Properties.Resources._2;
            this.splitContainer1.Panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.splitContainer1.Size = new System.Drawing.Size(880, 677);
            this.splitContainer1.SplitterDistance = 92;
            this.splitContainer1.TabIndex = 5;
            // 
            // btn_Admin
            // 
            this.btn_Admin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Admin.BackColor = System.Drawing.Color.OldLace;
            this.btn_Admin.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Admin.Font = new System.Drawing.Font("微軟正黑體", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_Admin.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btn_Admin.Location = new System.Drawing.Point(666, 12);
            this.btn_Admin.Name = "btn_Admin";
            this.btn_Admin.Size = new System.Drawing.Size(106, 35);
            this.btn_Admin.TabIndex = 13;
            this.btn_Admin.Text = "管理者登入";
            this.btn_Admin.UseVisualStyleBackColor = false;
            this.btn_Admin.Click += new System.EventHandler(this.btn_Admin_Click);
            // 
            // btn_Activity
            // 
            this.btn_Activity.BackColor = System.Drawing.Color.OldLace;
            this.btn_Activity.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Activity.Font = new System.Drawing.Font("微軟正黑體", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_Activity.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btn_Activity.Location = new System.Drawing.Point(522, 12);
            this.btn_Activity.Name = "btn_Activity";
            this.btn_Activity.Size = new System.Drawing.Size(90, 35);
            this.btn_Activity.TabIndex = 12;
            this.btn_Activity.Text = "活動";
            this.btn_Activity.UseVisualStyleBackColor = false;
            this.btn_Activity.Visible = false;
            this.btn_Activity.Click += new System.EventHandler(this.btn_Activity_Click);
            // 
            // btn_Login
            // 
            this.btn_Login.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Login.BackColor = System.Drawing.Color.OldLace;
            this.btn_Login.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Login.Font = new System.Drawing.Font("微軟正黑體", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_Login.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btn_Login.Location = new System.Drawing.Point(778, 12);
            this.btn_Login.Name = "btn_Login";
            this.btn_Login.Size = new System.Drawing.Size(90, 35);
            this.btn_Login.TabIndex = 11;
            this.btn_Login.Text = "會員登入";
            this.btn_Login.UseVisualStyleBackColor = false;
            this.btn_Login.Click += new System.EventHandler(this.btn_Login_Click);
            // 
            // btn_ReserveRoom
            // 
            this.btn_ReserveRoom.BackColor = System.Drawing.Color.OldLace;
            this.btn_ReserveRoom.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_ReserveRoom.Font = new System.Drawing.Font("微軟正黑體", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_ReserveRoom.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btn_ReserveRoom.Location = new System.Drawing.Point(426, 12);
            this.btn_ReserveRoom.Name = "btn_ReserveRoom";
            this.btn_ReserveRoom.Size = new System.Drawing.Size(90, 35);
            this.btn_ReserveRoom.TabIndex = 9;
            this.btn_ReserveRoom.Text = "即刻預定";
            this.btn_ReserveRoom.UseVisualStyleBackColor = false;
            this.btn_ReserveRoom.Visible = false;
            // 
            // btn_About
            // 
            this.btn_About.BackColor = System.Drawing.Color.OldLace;
            this.btn_About.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_About.Font = new System.Drawing.Font("微軟正黑體", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_About.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btn_About.Location = new System.Drawing.Point(234, 12);
            this.btn_About.Name = "btn_About";
            this.btn_About.Size = new System.Drawing.Size(90, 35);
            this.btn_About.TabIndex = 8;
            this.btn_About.Text = "關於";
            this.btn_About.UseVisualStyleBackColor = false;
            this.btn_About.Visible = false;
            this.btn_About.Click += new System.EventHandler(this.btn_About_Click);
            // 
            // btnHome
            // 
            this.btnHome.BackColor = System.Drawing.Color.Transparent;
            this.btnHome.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHome.FlatAppearance.BorderSize = 0;
            this.btnHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHome.Image = global::OrderTest.Properties.Resources.HomePage_icon;
            this.btnHome.Location = new System.Drawing.Point(12, 12);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(41, 35);
            this.btnHome.TabIndex = 4;
            this.btnHome.UseVisualStyleBackColor = false;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // 首頁
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(880, 677);
            this.Controls.Add(this.splitContainer1);
            this.Name = "首頁";
            this.Text = "HomePage";
            this.splitContainer1.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btn_BrowerRoom;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Button btn_Login;
        private System.Windows.Forms.Button btn_ReserveRoom;
        private System.Windows.Forms.Button btn_About;
        private System.Windows.Forms.Button btn_Activity;
        private System.Windows.Forms.Button btn_Admin;
    }
}