namespace Test_Room
{
    partial class Frm_MemberIForgetPassword
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
            this.btnCheckEmail = new System.Windows.Forms.Button();
            this.txtCheckEmail = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnCheckEmail
            // 
            this.btnCheckEmail.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnCheckEmail.Location = new System.Drawing.Point(29, 161);
            this.btnCheckEmail.Name = "btnCheckEmail";
            this.btnCheckEmail.Size = new System.Drawing.Size(508, 57);
            this.btnCheckEmail.TabIndex = 0;
            this.btnCheckEmail.Text = "確認輸入";
            this.btnCheckEmail.UseVisualStyleBackColor = true;
            this.btnCheckEmail.Click += new System.EventHandler(this.btnCheckEmail_Click);
            // 
            // txtCheckEmail
            // 
            this.txtCheckEmail.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtCheckEmail.ForeColor = System.Drawing.Color.Black;
            this.txtCheckEmail.Location = new System.Drawing.Point(29, 82);
            this.txtCheckEmail.Multiline = true;
            this.txtCheckEmail.Name = "txtCheckEmail";
            this.txtCheckEmail.Size = new System.Drawing.Size(508, 57);
            this.txtCheckEmail.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(24, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(266, 29);
            this.label1.TabIndex = 2;
            this.label1.Text = "請輸入註冊時的電子信箱";
            // 
            // MemberInformation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(585, 270);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtCheckEmail);
            this.Controls.Add(this.btnCheckEmail);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "MemberInformation";
            this.Text = "忘記密碼";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCheckEmail;
        private System.Windows.Forms.TextBox txtCheckEmail;
        private System.Windows.Forms.Label label1;
    }
}