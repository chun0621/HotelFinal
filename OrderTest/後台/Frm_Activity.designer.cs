namespace prjMidterm1
{
    partial class Frm_Activity
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
            this.SPCActivityDetails = new System.Windows.Forms.SplitContainer();
            this.txtDisCount = new System.Windows.Forms.TextBox();
            this.labDisCount = new System.Windows.Forms.Label();
            this.labActivityDescription = new System.Windows.Forms.Label();
            this.labActivityName = new System.Windows.Forms.Label();
            this.txtActivityDescription = new System.Windows.Forms.TextBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.txtActivityName = new System.Windows.Forms.TextBox();
            this.DTCEnd = new System.Windows.Forms.DateTimePicker();
            this.DTCStart = new System.Windows.Forms.DateTimePicker();
            this.labSelectDate = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.SPCActivityDetails)).BeginInit();
            this.SPCActivityDetails.Panel1.SuspendLayout();
            this.SPCActivityDetails.Panel2.SuspendLayout();
            this.SPCActivityDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // SPCActivityDetails
            // 
            this.SPCActivityDetails.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SPCActivityDetails.Location = new System.Drawing.Point(0, 0);
            this.SPCActivityDetails.Name = "SPCActivityDetails";
            this.SPCActivityDetails.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // SPCActivityDetails.Panel1
            // 
            this.SPCActivityDetails.Panel1.Controls.Add(this.txtDisCount);
            this.SPCActivityDetails.Panel1.Controls.Add(this.labDisCount);
            this.SPCActivityDetails.Panel1.Controls.Add(this.labActivityDescription);
            this.SPCActivityDetails.Panel1.Controls.Add(this.labActivityName);
            this.SPCActivityDetails.Panel1.Controls.Add(this.txtActivityDescription);
            this.SPCActivityDetails.Panel1.Controls.Add(this.btnDelete);
            this.SPCActivityDetails.Panel1.Controls.Add(this.btnUpdate);
            this.SPCActivityDetails.Panel1.Controls.Add(this.btnAdd);
            this.SPCActivityDetails.Panel1.Controls.Add(this.txtActivityName);
            this.SPCActivityDetails.Panel1.Controls.Add(this.DTCEnd);
            this.SPCActivityDetails.Panel1.Controls.Add(this.DTCStart);
            this.SPCActivityDetails.Panel1.Controls.Add(this.labSelectDate);
            // 
            // SPCActivityDetails.Panel2
            // 
            this.SPCActivityDetails.Panel2.Controls.Add(this.dataGridView1);
            this.SPCActivityDetails.Size = new System.Drawing.Size(800, 450);
            this.SPCActivityDetails.SplitterDistance = 171;
            this.SPCActivityDetails.TabIndex = 0;
            // 
            // txtDisCount
            // 
            this.txtDisCount.Location = new System.Drawing.Point(314, 92);
            this.txtDisCount.Name = "txtDisCount";
            this.txtDisCount.Size = new System.Drawing.Size(135, 22);
            this.txtDisCount.TabIndex = 24;
            // 
            // labDisCount
            // 
            this.labDisCount.AccessibleRole = System.Windows.Forms.AccessibleRole.Diagram;
            this.labDisCount.AutoSize = true;
            this.labDisCount.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labDisCount.Location = new System.Drawing.Point(311, 62);
            this.labDisCount.Name = "labDisCount";
            this.labDisCount.Size = new System.Drawing.Size(74, 16);
            this.labDisCount.TabIndex = 23;
            this.labDisCount.Text = "DisCount";
            // 
            // labActivityDescription
            // 
            this.labActivityDescription.AutoSize = true;
            this.labActivityDescription.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labActivityDescription.Location = new System.Drawing.Point(311, 12);
            this.labActivityDescription.Name = "labActivityDescription";
            this.labActivityDescription.Size = new System.Drawing.Size(148, 16);
            this.labActivityDescription.TabIndex = 18;
            this.labActivityDescription.Text = "ActivityDescription";
            // 
            // labActivityName
            // 
            this.labActivityName.AutoSize = true;
            this.labActivityName.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labActivityName.Location = new System.Drawing.Point(12, 9);
            this.labActivityName.Name = "labActivityName";
            this.labActivityName.Size = new System.Drawing.Size(106, 16);
            this.labActivityName.TabIndex = 17;
            this.labActivityName.Text = "ActivityName";
            // 
            // txtActivityDescription
            // 
            this.txtActivityDescription.Location = new System.Drawing.Point(465, 12);
            this.txtActivityDescription.Multiline = true;
            this.txtActivityDescription.Name = "txtActivityDescription";
            this.txtActivityDescription.Size = new System.Drawing.Size(181, 156);
            this.txtActivityDescription.TabIndex = 16;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(672, 120);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(92, 49);
            this.btnDelete.TabIndex = 15;
            this.btnDelete.Text = "刪除";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(672, 66);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(92, 49);
            this.btnUpdate.TabIndex = 14;
            this.btnUpdate.Text = "修改";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(672, 12);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(92, 49);
            this.btnAdd.TabIndex = 13;
            this.btnAdd.Text = "新增";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // txtActivityName
            // 
            this.txtActivityName.Location = new System.Drawing.Point(93, 34);
            this.txtActivityName.Name = "txtActivityName";
            this.txtActivityName.Size = new System.Drawing.Size(200, 22);
            this.txtActivityName.TabIndex = 12;
            // 
            // DTCEnd
            // 
            this.DTCEnd.Location = new System.Drawing.Point(93, 125);
            this.DTCEnd.Name = "DTCEnd";
            this.DTCEnd.Size = new System.Drawing.Size(200, 22);
            this.DTCEnd.TabIndex = 10;
            // 
            // DTCStart
            // 
            this.DTCStart.Location = new System.Drawing.Point(93, 92);
            this.DTCStart.Name = "DTCStart";
            this.DTCStart.Size = new System.Drawing.Size(200, 22);
            this.DTCStart.TabIndex = 9;
            // 
            // labSelectDate
            // 
            this.labSelectDate.AutoSize = true;
            this.labSelectDate.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labSelectDate.Location = new System.Drawing.Point(12, 72);
            this.labSelectDate.Name = "labSelectDate";
            this.labSelectDate.Size = new System.Drawing.Size(83, 16);
            this.labSelectDate.TabIndex = 8;
            this.labSelectDate.Text = "SelectDate";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(800, 275);
            this.dataGridView1.TabIndex = 0;
            // 
            // Activity
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.SPCActivityDetails);
            this.Name = "Activity";
            this.Text = "Form1";
            this.SPCActivityDetails.Panel1.ResumeLayout(false);
            this.SPCActivityDetails.Panel1.PerformLayout();
            this.SPCActivityDetails.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.SPCActivityDetails)).EndInit();
            this.SPCActivityDetails.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer SPCActivityDetails;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label labActivityDescription;
        private System.Windows.Forms.Label labActivityName;
        private System.Windows.Forms.TextBox txtActivityDescription;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox txtActivityName;
        private System.Windows.Forms.DateTimePicker DTCEnd;
        private System.Windows.Forms.DateTimePicker DTCStart;
        private System.Windows.Forms.Label labSelectDate;
        private System.Windows.Forms.TextBox txtDisCount;
        private System.Windows.Forms.Label labDisCount;
    }
}

