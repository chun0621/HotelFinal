namespace OrderTest.使用者
{
    partial class Frm_UserCenter
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.btn_UserOrder = new System.Windows.Forms.Button();
            this.btn_Member = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(204)))), ((int)(((byte)(190)))));
            this.splitContainer1.Panel1.Controls.Add(this.btn_UserOrder);
            this.splitContainer1.Panel1.Controls.Add(this.btn_Member);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(228)))), ((int)(((byte)(187)))));
            this.splitContainer1.Size = new System.Drawing.Size(800, 450);
            this.splitContainer1.SplitterDistance = 156;
            this.splitContainer1.TabIndex = 0;
            // 
            // btn_UserOrder
            // 
            this.btn_UserOrder.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_UserOrder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(228)))), ((int)(((byte)(187)))));
            this.btn_UserOrder.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_UserOrder.ForeColor = System.Drawing.Color.Black;
            this.btn_UserOrder.Location = new System.Drawing.Point(28, 43);
            this.btn_UserOrder.Name = "btn_UserOrder";
            this.btn_UserOrder.Size = new System.Drawing.Size(94, 38);
            this.btn_UserOrder.TabIndex = 9;
            this.btn_UserOrder.Text = "訂單查詢";
            this.btn_UserOrder.UseVisualStyleBackColor = false;
            this.btn_UserOrder.Click += new System.EventHandler(this.btn_UserOrder_Click);
            // 
            // btn_Member
            // 
            this.btn_Member.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Member.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(228)))), ((int)(((byte)(187)))));
            this.btn_Member.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Member.ForeColor = System.Drawing.Color.Black;
            this.btn_Member.Location = new System.Drawing.Point(28, 99);
            this.btn_Member.Name = "btn_Member";
            this.btn_Member.Size = new System.Drawing.Size(94, 38);
            this.btn_Member.TabIndex = 8;
            this.btn_Member.Text = "修改資料";
            this.btn_Member.UseVisualStyleBackColor = false;
            this.btn_Member.Click += new System.EventHandler(this.btn_Member_Click);
            // 
            // Frm_UserCenter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.splitContainer1);
            this.Name = "Frm_UserCenter";
            this.Text = "Frm_MemberCenter";
            this.splitContainer1.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Button btn_UserOrder;
        private System.Windows.Forms.Button btn_Member;
    }
}