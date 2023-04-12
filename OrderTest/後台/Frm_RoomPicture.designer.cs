namespace prjMidterm1
{
    partial class Frm_RoomPicture
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
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.PicBRoom = new System.Windows.Forms.PictureBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.txtRoomImagesName = new System.Windows.Forms.TextBox();
            this.labRoomImagesName = new System.Windows.Forms.Label();
            this.labRoomID = new System.Windows.Forms.Label();
            this.txtRoomID = new System.Windows.Forms.TextBox();
            this.labRoomImageDetail = new System.Windows.Forms.Label();
            this.txtRoomImageDetail = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.PicBRoom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(700, 397);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(87, 41);
            this.btnDelete.TabIndex = 10;
            this.btnDelete.Text = "刪除";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(579, 397);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(87, 41);
            this.btnUpdate.TabIndex = 9;
            this.btnUpdate.Text = "修改";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(458, 397);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(87, 41);
            this.btnAdd.TabIndex = 8;
            this.btnAdd.Text = "新增";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // PicBRoom
            // 
            this.PicBRoom.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.PicBRoom.Location = new System.Drawing.Point(16, 185);
            this.PicBRoom.Name = "PicBRoom";
            this.PicBRoom.Size = new System.Drawing.Size(300, 253);
            this.PicBRoom.TabIndex = 12;
            this.PicBRoom.TabStop = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(341, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(447, 357);
            this.dataGridView1.TabIndex = 13;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // btnBrowse
            // 
            this.btnBrowse.Location = new System.Drawing.Point(337, 397);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(87, 41);
            this.btnBrowse.TabIndex = 14;
            this.btnBrowse.Text = "Browse";
            this.btnBrowse.UseVisualStyleBackColor = true;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // txtRoomImagesName
            // 
            this.txtRoomImagesName.Location = new System.Drawing.Point(181, 12);
            this.txtRoomImagesName.Name = "txtRoomImagesName";
            this.txtRoomImagesName.Size = new System.Drawing.Size(135, 22);
            this.txtRoomImagesName.TabIndex = 15;
            // 
            // labRoomImagesName
            // 
            this.labRoomImagesName.AutoSize = true;
            this.labRoomImagesName.Font = new System.Drawing.Font("新細明體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labRoomImagesName.Location = new System.Drawing.Point(12, 12);
            this.labRoomImagesName.Name = "labRoomImagesName";
            this.labRoomImagesName.Size = new System.Drawing.Size(163, 21);
            this.labRoomImagesName.TabIndex = 16;
            this.labRoomImagesName.Text = "RoomImagesName";
            // 
            // labRoomID
            // 
            this.labRoomID.AccessibleRole = System.Windows.Forms.AccessibleRole.Diagram;
            this.labRoomID.AutoSize = true;
            this.labRoomID.Font = new System.Drawing.Font("新細明體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labRoomID.Location = new System.Drawing.Point(12, 44);
            this.labRoomID.Name = "labRoomID";
            this.labRoomID.Size = new System.Drawing.Size(79, 21);
            this.labRoomID.TabIndex = 18;
            this.labRoomID.Text = "RoomID";
            // 
            // txtRoomID
            // 
            this.txtRoomID.Location = new System.Drawing.Point(181, 44);
            this.txtRoomID.Name = "txtRoomID";
            this.txtRoomID.Size = new System.Drawing.Size(135, 22);
            this.txtRoomID.TabIndex = 17;
            // 
            // labRoomImageDetail
            // 
            this.labRoomImageDetail.AccessibleRole = System.Windows.Forms.AccessibleRole.Diagram;
            this.labRoomImageDetail.AutoSize = true;
            this.labRoomImageDetail.Font = new System.Drawing.Font("新細明體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labRoomImageDetail.Location = new System.Drawing.Point(12, 78);
            this.labRoomImageDetail.Name = "labRoomImageDetail";
            this.labRoomImageDetail.Size = new System.Drawing.Size(155, 21);
            this.labRoomImageDetail.TabIndex = 20;
            this.labRoomImageDetail.Text = "RoomImageDetail";
            // 
            // txtRoomImageDetail
            // 
            this.txtRoomImageDetail.Location = new System.Drawing.Point(181, 82);
            this.txtRoomImageDetail.Multiline = true;
            this.txtRoomImageDetail.Name = "txtRoomImageDetail";
            this.txtRoomImageDetail.Size = new System.Drawing.Size(135, 97);
            this.txtRoomImageDetail.TabIndex = 19;
            // 
            // Frm_RoomPicture
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labRoomImageDetail);
            this.Controls.Add(this.txtRoomImageDetail);
            this.Controls.Add(this.labRoomID);
            this.Controls.Add(this.txtRoomID);
            this.Controls.Add(this.labRoomImagesName);
            this.Controls.Add(this.txtRoomImagesName);
            this.Controls.Add(this.btnBrowse);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.PicBRoom);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnAdd);
            this.Name = "Frm_RoomPicture";
            ((System.ComponentModel.ISupportInitialize)(this.PicBRoom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.PictureBox PicBRoom;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.TextBox txtRoomImagesName;
        private System.Windows.Forms.Label labRoomImagesName;
        private System.Windows.Forms.Label labRoomID;
        private System.Windows.Forms.TextBox txtRoomID;
        private System.Windows.Forms.Label labRoomImageDetail;
        private System.Windows.Forms.TextBox txtRoomImageDetail;
    }
}