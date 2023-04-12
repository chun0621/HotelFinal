namespace OrderTest.使用者
{
    partial class RoomUserControl
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

        #region 元件設計工具產生的程式碼

        /// <summary> 
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.labRoomName = new System.Windows.Forms.Label();
            this.btnGood = new System.Windows.Forms.Button();
            this.btnCollectRoom = new System.Windows.Forms.Button();
            this.btnShare = new System.Windows.Forms.Button();
            this.btnOrder = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // labRoomName
            // 
            this.labRoomName.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labRoomName.Location = new System.Drawing.Point(3, 3);
            this.labRoomName.Name = "labRoomName";
            this.labRoomName.Size = new System.Drawing.Size(225, 38);
            this.labRoomName.TabIndex = 1;
            this.labRoomName.Text = "labRoomName";
            this.labRoomName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnGood
            // 
            this.btnGood.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnGood.Location = new System.Drawing.Point(238, 23);
            this.btnGood.Name = "btnGood";
            this.btnGood.Size = new System.Drawing.Size(69, 49);
            this.btnGood.TabIndex = 2;
            this.btnGood.Text = "案讚";
            this.btnGood.UseVisualStyleBackColor = true;
            // 
            // btnCollectRoom
            // 
            this.btnCollectRoom.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnCollectRoom.Location = new System.Drawing.Point(313, 23);
            this.btnCollectRoom.Name = "btnCollectRoom";
            this.btnCollectRoom.Size = new System.Drawing.Size(69, 49);
            this.btnCollectRoom.TabIndex = 3;
            this.btnCollectRoom.Text = "收藏";
            this.btnCollectRoom.UseVisualStyleBackColor = true;
            // 
            // btnShare
            // 
            this.btnShare.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnShare.Location = new System.Drawing.Point(388, 23);
            this.btnShare.Name = "btnShare";
            this.btnShare.Size = new System.Drawing.Size(69, 49);
            this.btnShare.TabIndex = 4;
            this.btnShare.Text = "分享";
            this.btnShare.UseVisualStyleBackColor = true;
            // 
            // btnOrder
            // 
            this.btnOrder.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnOrder.Location = new System.Drawing.Point(238, 78);
            this.btnOrder.Name = "btnOrder";
            this.btnOrder.Size = new System.Drawing.Size(219, 49);
            this.btnOrder.TabIndex = 5;
            this.btnOrder.Text = "即刻訂房";
            this.btnOrder.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.Location = new System.Drawing.Point(3, 44);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(225, 191);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // RoomUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.btnOrder);
            this.Controls.Add(this.btnShare);
            this.Controls.Add(this.btnCollectRoom);
            this.Controls.Add(this.btnGood);
            this.Controls.Add(this.labRoomName);
            this.Controls.Add(this.pictureBox1);
            this.Name = "RoomUserControl";
            this.Size = new System.Drawing.Size(456, 242);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label labRoomName;
        private System.Windows.Forms.Button btnGood;
        private System.Windows.Forms.Button btnCollectRoom;
        private System.Windows.Forms.Button btnShare;
        private System.Windows.Forms.Button btnOrder;
    }
}
