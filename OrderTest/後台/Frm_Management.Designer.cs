namespace OrderTest.後台
{
    partial class Frm_Management
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
            this.btn_Member = new System.Windows.Forms.Button();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.label2 = new System.Windows.Forms.Label();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.btn_Comment = new System.Windows.Forms.Button();
            this.btn_Industry = new System.Windows.Forms.Button();
            this.btn_Activity = new System.Windows.Forms.Button();
            this.btn_Order = new System.Windows.Forms.Button();
            this.btn_Facility = new System.Windows.Forms.Button();
            this.btn_Room = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_Member
            // 
            this.btn_Member.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Member.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(228)))), ((int)(((byte)(187)))));
            this.btn_Member.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Member.ForeColor = System.Drawing.Color.Black;
            this.btn_Member.Location = new System.Drawing.Point(34, 12);
            this.btn_Member.Name = "btn_Member";
            this.btn_Member.Size = new System.Drawing.Size(94, 38);
            this.btn_Member.TabIndex = 7;
            this.btn_Member.Text = "會員管理";
            this.btn_Member.UseVisualStyleBackColor = false;
            this.btn_Member.Click += new System.EventHandler(this.btn_Member_Click);
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
            this.splitContainer1.Panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(166)))), ((int)(((byte)(160)))));
            this.splitContainer1.Panel1.Controls.Add(this.label2);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.splitContainer2);
            this.splitContainer1.Size = new System.Drawing.Size(792, 586);
            this.splitContainer1.SplitterDistance = 66;
            this.splitContainer1.TabIndex = 14;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.Font = new System.Drawing.Font("微軟正黑體", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(161, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(470, 39);
            this.label2.TabIndex = 2;
            this.label2.Text = "Hotel management";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(204)))), ((int)(((byte)(190)))));
            this.splitContainer2.Panel1.Controls.Add(this.btn_Comment);
            this.splitContainer2.Panel1.Controls.Add(this.btn_Industry);
            this.splitContainer2.Panel1.Controls.Add(this.btn_Activity);
            this.splitContainer2.Panel1.Controls.Add(this.btn_Order);
            this.splitContainer2.Panel1.Controls.Add(this.btn_Facility);
            this.splitContainer2.Panel1.Controls.Add(this.btn_Room);
            this.splitContainer2.Panel1.Controls.Add(this.btn_Member);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(228)))), ((int)(((byte)(187)))));
            this.splitContainer2.Size = new System.Drawing.Size(792, 516);
            this.splitContainer2.SplitterDistance = 163;
            this.splitContainer2.TabIndex = 0;
            // 
            // btn_Comment
            // 
            this.btn_Comment.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Comment.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(228)))), ((int)(((byte)(187)))));
            this.btn_Comment.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Comment.ForeColor = System.Drawing.Color.Black;
            this.btn_Comment.Location = new System.Drawing.Point(34, 348);
            this.btn_Comment.Name = "btn_Comment";
            this.btn_Comment.Size = new System.Drawing.Size(94, 38);
            this.btn_Comment.TabIndex = 19;
            this.btn_Comment.Text = "回饋管理";
            this.btn_Comment.UseVisualStyleBackColor = false;
            this.btn_Comment.Click += new System.EventHandler(this.btn_Comment_Click);
            // 
            // btn_Industry
            // 
            this.btn_Industry.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Industry.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(228)))), ((int)(((byte)(187)))));
            this.btn_Industry.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Industry.ForeColor = System.Drawing.Color.Black;
            this.btn_Industry.Location = new System.Drawing.Point(34, 292);
            this.btn_Industry.Name = "btn_Industry";
            this.btn_Industry.Size = new System.Drawing.Size(94, 38);
            this.btn_Industry.TabIndex = 18;
            this.btn_Industry.Text = "業者管理";
            this.btn_Industry.UseVisualStyleBackColor = false;
            this.btn_Industry.Click += new System.EventHandler(this.btn_Industry_Click);
            // 
            // btn_Activity
            // 
            this.btn_Activity.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Activity.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(228)))), ((int)(((byte)(187)))));
            this.btn_Activity.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Activity.ForeColor = System.Drawing.Color.Black;
            this.btn_Activity.Location = new System.Drawing.Point(34, 236);
            this.btn_Activity.Name = "btn_Activity";
            this.btn_Activity.Size = new System.Drawing.Size(94, 38);
            this.btn_Activity.TabIndex = 17;
            this.btn_Activity.Text = "活動管理";
            this.btn_Activity.UseVisualStyleBackColor = false;
            this.btn_Activity.Click += new System.EventHandler(this.btn_Activity_Click);
            // 
            // btn_Order
            // 
            this.btn_Order.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Order.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(228)))), ((int)(((byte)(187)))));
            this.btn_Order.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Order.ForeColor = System.Drawing.Color.Black;
            this.btn_Order.Location = new System.Drawing.Point(34, 180);
            this.btn_Order.Name = "btn_Order";
            this.btn_Order.Size = new System.Drawing.Size(94, 38);
            this.btn_Order.TabIndex = 16;
            this.btn_Order.Text = "訂單管理";
            this.btn_Order.UseVisualStyleBackColor = false;
            this.btn_Order.Click += new System.EventHandler(this.btn_Order_Click);
            // 
            // btn_Facility
            // 
            this.btn_Facility.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Facility.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(228)))), ((int)(((byte)(187)))));
            this.btn_Facility.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Facility.ForeColor = System.Drawing.Color.Black;
            this.btn_Facility.Location = new System.Drawing.Point(34, 124);
            this.btn_Facility.Name = "btn_Facility";
            this.btn_Facility.Size = new System.Drawing.Size(94, 38);
            this.btn_Facility.TabIndex = 15;
            this.btn_Facility.Text = "設備管理";
            this.btn_Facility.UseVisualStyleBackColor = false;
            this.btn_Facility.Click += new System.EventHandler(this.btn_Facility_Click);
            // 
            // btn_Room
            // 
            this.btn_Room.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Room.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(228)))), ((int)(((byte)(187)))));
            this.btn_Room.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Room.ForeColor = System.Drawing.Color.Black;
            this.btn_Room.Location = new System.Drawing.Point(34, 68);
            this.btn_Room.Name = "btn_Room";
            this.btn_Room.Size = new System.Drawing.Size(94, 38);
            this.btn_Room.TabIndex = 14;
            this.btn_Room.Text = "房間管理";
            this.btn_Room.UseVisualStyleBackColor = false;
            this.btn_Room.Click += new System.EventHandler(this.btn_Room_Click);
            // 
            // Frm_Management
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(792, 586);
            this.Controls.Add(this.splitContainer1);
            this.Name = "Frm_Management";
            this.Text = "後台";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btn_Member;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.Button btn_Comment;
        private System.Windows.Forms.Button btn_Industry;
        private System.Windows.Forms.Button btn_Activity;
        private System.Windows.Forms.Button btn_Order;
        private System.Windows.Forms.Button btn_Facility;
        private System.Windows.Forms.Button btn_Room;
        internal System.Windows.Forms.Label label2;
    }
}