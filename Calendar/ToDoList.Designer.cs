namespace Calendar
{
    partial class ToDoList
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ToDoList));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnPreviousDay = new System.Windows.Forms.Button();
            this.btnNextDay = new System.Windows.Forms.Button();
            this.dtpkDate = new System.Windows.Forms.DateTimePicker();
            this.pnlJob = new System.Windows.Forms.Panel();
            this.mnsMain = new System.Windows.Forms.MenuStrip();
            this.mnsiAddJob = new System.Windows.Forms.ToolStripMenuItem();
            this.mnsiToday = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.mnsMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.pnlJob);
            this.panel1.Location = new System.Drawing.Point(1, 29);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(675, 622);
            this.panel1.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.Control;
            this.panel3.BackgroundImage = global::Calendar.Properties.Resources.hinh_nen_chill_10;
            this.panel3.Controls.Add(this.btnPreviousDay);
            this.panel3.Controls.Add(this.btnNextDay);
            this.panel3.Controls.Add(this.dtpkDate);
            this.panel3.Location = new System.Drawing.Point(5, 6);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(661, 50);
            this.panel3.TabIndex = 1;
            // 
            // btnPreviousDay
            // 
            this.btnPreviousDay.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPreviousDay.Font = new System.Drawing.Font("Script MT Bold", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPreviousDay.Location = new System.Drawing.Point(26, 5);
            this.btnPreviousDay.Name = "btnPreviousDay";
            this.btnPreviousDay.Size = new System.Drawing.Size(102, 42);
            this.btnPreviousDay.TabIndex = 2;
            this.btnPreviousDay.Text = "<< Ngày trước";
            this.btnPreviousDay.UseVisualStyleBackColor = true;
            this.btnPreviousDay.Click += new System.EventHandler(this.btnPreviousDay_Click);
            // 
            // btnNextDay
            // 
            this.btnNextDay.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNextDay.Font = new System.Drawing.Font("Script MT Bold", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNextDay.Location = new System.Drawing.Point(555, 2);
            this.btnNextDay.Name = "btnNextDay";
            this.btnNextDay.Size = new System.Drawing.Size(94, 45);
            this.btnNextDay.TabIndex = 2;
            this.btnNextDay.Text = "Ngày mai >>";
            this.btnNextDay.UseVisualStyleBackColor = true;
            this.btnNextDay.Click += new System.EventHandler(this.btnNextDay_Click);
            // 
            // dtpkDate
            // 
            this.dtpkDate.Font = new System.Drawing.Font("Script MT Bold", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpkDate.Location = new System.Drawing.Point(236, 13);
            this.dtpkDate.Name = "dtpkDate";
            this.dtpkDate.Size = new System.Drawing.Size(200, 23);
            this.dtpkDate.TabIndex = 1;
            this.dtpkDate.ValueChanged += new System.EventHandler(this.dtpkDate_ValueChanged);
            // 
            // pnlJob
            // 
            this.pnlJob.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pnlJob.BackgroundImage = global::Calendar.Properties.Resources.tai_hinh_nen_dep_nhat_the_gioi_57;
            this.pnlJob.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlJob.Location = new System.Drawing.Point(4, 62);
            this.pnlJob.Name = "pnlJob";
            this.pnlJob.Size = new System.Drawing.Size(662, 557);
            this.pnlJob.TabIndex = 0;
            // 
            // mnsMain
            // 
            this.mnsMain.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.mnsMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnsiAddJob,
            this.mnsiToday});
            this.mnsMain.Location = new System.Drawing.Point(0, 0);
            this.mnsMain.Name = "mnsMain";
            this.mnsMain.Size = new System.Drawing.Size(684, 28);
            this.mnsMain.TabIndex = 1;
            this.mnsMain.Text = "menuStrip1";
            this.mnsMain.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.mnsMain_ItemClicked);
            // 
            // mnsiAddJob
            // 
            this.mnsiAddJob.Name = "mnsiAddJob";
            this.mnsiAddJob.Size = new System.Drawing.Size(90, 24);
            this.mnsiAddJob.Text = "Thêm việc";
            this.mnsiAddJob.Click += new System.EventHandler(this.mnsiAddJob_Click);
            // 
            // mnsiToday
            // 
            this.mnsiToday.Name = "mnsiToday";
            this.mnsiToday.Size = new System.Drawing.Size(83, 24);
            this.mnsiToday.Text = "Hôm nay";
            this.mnsiToday.Click += new System.EventHandler(this.mnsiToday_Click);
            // 
            // ToDoList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 681);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.mnsMain);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.mnsMain;
            this.Name = "ToDoList";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Lịch công việc trong ngày";
            this.Load += new System.EventHandler(this.ToDoList_Load);
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.mnsMain.ResumeLayout(false);
            this.mnsMain.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DateTimePicker dtpkDate;
        private System.Windows.Forms.Panel pnlJob;
        private System.Windows.Forms.MenuStrip mnsMain;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.ToolStripMenuItem mnsiAddJob;
        private System.Windows.Forms.ToolStripMenuItem mnsiToday;
        private System.Windows.Forms.Button btnPreviousDay;
        private System.Windows.Forms.Button btnNextDay;
    }
}