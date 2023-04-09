namespace OrderTest.使用者
{
    partial class FrmUserSelectRoom
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
            this.roomUserControl1 = new OrderTest.使用者.RoomUserControl();
            this.roomUserControl2 = new OrderTest.使用者.RoomUserControl();
            this.roomUserControl3 = new OrderTest.使用者.RoomUserControl();
            this.roomUserControl4 = new OrderTest.使用者.RoomUserControl();
            this.SuspendLayout();
            // 
            // roomUserControl1
            // 
            this.roomUserControl1.BackColor = System.Drawing.Color.White;
            this.roomUserControl1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.roomUserControl1.Location = new System.Drawing.Point(24, 36);
            this.roomUserControl1.Name = "roomUserControl1";
            this.roomUserControl1.Size = new System.Drawing.Size(456, 242);
            this.roomUserControl1.TabIndex = 0;
            // 
            // roomUserControl2
            // 
            this.roomUserControl2.BackColor = System.Drawing.Color.White;
            this.roomUserControl2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.roomUserControl2.Location = new System.Drawing.Point(532, 36);
            this.roomUserControl2.Name = "roomUserControl2";
            this.roomUserControl2.Size = new System.Drawing.Size(456, 242);
            this.roomUserControl2.TabIndex = 1;
            // 
            // roomUserControl3
            // 
            this.roomUserControl3.BackColor = System.Drawing.Color.White;
            this.roomUserControl3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.roomUserControl3.Location = new System.Drawing.Point(24, 323);
            this.roomUserControl3.Name = "roomUserControl3";
            this.roomUserControl3.Size = new System.Drawing.Size(456, 242);
            this.roomUserControl3.TabIndex = 2;
            // 
            // roomUserControl4
            // 
            this.roomUserControl4.BackColor = System.Drawing.Color.White;
            this.roomUserControl4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.roomUserControl4.Location = new System.Drawing.Point(532, 323);
            this.roomUserControl4.Name = "roomUserControl4";
            this.roomUserControl4.Size = new System.Drawing.Size(456, 242);
            this.roomUserControl4.TabIndex = 3;
            // 
            // FrmUserSelectRoom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1047, 629);
            this.Controls.Add(this.roomUserControl4);
            this.Controls.Add(this.roomUserControl3);
            this.Controls.Add(this.roomUserControl2);
            this.Controls.Add(this.roomUserControl1);
            this.Name = "FrmUserSelectRoom";
            this.Text = "FrmUserSelectRoom";
            this.ResumeLayout(false);

        }

        #endregion

        private RoomUserControl roomUserControl1;
        private RoomUserControl roomUserControl2;
        private RoomUserControl roomUserControl3;
        private RoomUserControl roomUserControl4;
    }
}