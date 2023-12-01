namespace Calendar
{
    partial class AJob
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.ckbDone = new System.Windows.Forms.CheckBox();
            this.txtJob = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.nmEndMinute = new System.Windows.Forms.NumericUpDown();
            this.nmEndHour = new System.Windows.Forms.NumericUpDown();
            this.nmStartMinute = new System.Windows.Forms.NumericUpDown();
            this.nmStartHour = new System.Windows.Forms.NumericUpDown();
            this.cbStatus = new System.Windows.Forms.ComboBox();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.flowLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmEndMinute)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmEndHour)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmStartMinute)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmStartHour)).BeginInit();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.ckbDone);
            this.flowLayoutPanel1.Controls.Add(this.txtJob);
            this.flowLayoutPanel1.Controls.Add(this.panel1);
            this.flowLayoutPanel1.Controls.Add(this.cbStatus);
            this.flowLayoutPanel1.Controls.Add(this.btnEdit);
            this.flowLayoutPanel1.Controls.Add(this.btnDelete);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(3, 5);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(859, 38);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // ckbDone
            // 
            this.ckbDone.AutoSize = true;
            this.ckbDone.Location = new System.Drawing.Point(3, 3);
            this.ckbDone.Name = "ckbDone";
            this.ckbDone.Size = new System.Drawing.Size(18, 17);
            this.ckbDone.TabIndex = 0;
            this.ckbDone.UseVisualStyleBackColor = true;
            this.ckbDone.CheckedChanged += new System.EventHandler(this.ckbDone_CheckedChanged);
            // 
            // txtJob
            // 
            this.txtJob.Location = new System.Drawing.Point(27, 3);
            this.txtJob.Name = "txtJob";
            this.txtJob.Size = new System.Drawing.Size(345, 22);
            this.txtJob.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.nmEndMinute);
            this.panel1.Controls.Add(this.nmEndHour);
            this.panel1.Controls.Add(this.nmStartMinute);
            this.panel1.Controls.Add(this.nmStartHour);
            this.panel1.Location = new System.Drawing.Point(378, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(231, 31);
            this.panel1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(99, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "đến";
            // 
            // nmEndMinute
            // 
            this.nmEndMinute.Location = new System.Drawing.Point(181, 3);
            this.nmEndMinute.Name = "nmEndMinute";
            this.nmEndMinute.Size = new System.Drawing.Size(41, 22);
            this.nmEndMinute.TabIndex = 0;
            // 
            // nmEndHour
            // 
            this.nmEndHour.Location = new System.Drawing.Point(134, 4);
            this.nmEndHour.Name = "nmEndHour";
            this.nmEndHour.Size = new System.Drawing.Size(41, 22);
            this.nmEndHour.TabIndex = 0;
            // 
            // nmStartMinute
            // 
            this.nmStartMinute.Location = new System.Drawing.Point(51, 4);
            this.nmStartMinute.Name = "nmStartMinute";
            this.nmStartMinute.Size = new System.Drawing.Size(41, 22);
            this.nmStartMinute.TabIndex = 0;
            // 
            // nmStartHour
            // 
            this.nmStartHour.Location = new System.Drawing.Point(4, 4);
            this.nmStartHour.Name = "nmStartHour";
            this.nmStartHour.Size = new System.Drawing.Size(41, 22);
            this.nmStartHour.TabIndex = 0;
            // 
            // cbStatus
            // 
            this.cbStatus.FormattingEnabled = true;
            this.cbStatus.Location = new System.Drawing.Point(615, 3);
            this.cbStatus.Name = "cbStatus";
            this.cbStatus.Size = new System.Drawing.Size(115, 24);
            this.cbStatus.TabIndex = 3;
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(736, 3);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(53, 23);
            this.btnEdit.TabIndex = 4;
            this.btnEdit.Text = "Sửa";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(795, 3);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(53, 23);
            this.btnDelete.TabIndex = 4;
            this.btnDelete.Text = "Xóa";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // AJob
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.flowLayoutPanel1);
            this.Name = "AJob";
            this.Size = new System.Drawing.Size(873, 49);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmEndMinute)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmEndHour)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmStartMinute)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmStartHour)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.CheckBox ckbDone;
        private System.Windows.Forms.TextBox txtJob;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown nmEndMinute;
        private System.Windows.Forms.NumericUpDown nmEndHour;
        private System.Windows.Forms.NumericUpDown nmStartMinute;
        private System.Windows.Forms.NumericUpDown nmStartHour;
        private System.Windows.Forms.ComboBox cbStatus;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnDelete;
    }
}
