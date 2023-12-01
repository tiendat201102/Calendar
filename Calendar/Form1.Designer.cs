namespace Calendar
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.nmNotify = new System.Windows.Forms.NumericUpDown();
            this.ckbNotify = new System.Windows.Forms.CheckBox();
            this.btnToday = new System.Windows.Forms.Button();
            this.dtpkDate = new System.Windows.Forms.DateTimePicker();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.txtToDay = new System.Windows.Forms.TextBox();
            this.pnlMatrix = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnNextMonth = new System.Windows.Forms.Button();
            this.btnPreviousMonth = new System.Windows.Forms.Button();
            this.btnMon = new System.Windows.Forms.Button();
            this.btnSun = new System.Windows.Forms.Button();
            this.btnSat = new System.Windows.Forms.Button();
            this.btnFri = new System.Windows.Forms.Button();
            this.btnThu = new System.Windows.Forms.Button();
            this.btnWed = new System.Windows.Forms.Button();
            this.btnTue = new System.Windows.Forms.Button();
            this.timerNoti = new System.Windows.Forms.Timer(this.components);
            this.Notify = new System.Windows.Forms.NotifyIcon(this.components);
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmNotify)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(0, 5);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(869, 445);
            this.panel1.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.BackgroundImage = global::Calendar.Properties.Resources.hinh_nen_vu_tru;
            this.panel3.Controls.Add(this.panel6);
            this.panel3.Controls.Add(this.btnToday);
            this.panel3.Controls.Add(this.dtpkDate);
            this.panel3.Location = new System.Drawing.Point(11, 2);
            this.panel3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(855, 37);
            this.panel3.TabIndex = 1;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.nmNotify);
            this.panel6.Controls.Add(this.ckbNotify);
            this.panel6.Location = new System.Drawing.Point(3, 4);
            this.panel6.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(165, 25);
            this.panel6.TabIndex = 2;
            // 
            // nmNotify
            // 
            this.nmNotify.Enabled = false;
            this.nmNotify.Location = new System.Drawing.Point(103, 2);
            this.nmNotify.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.nmNotify.Maximum = new decimal(new int[] {
            3600,
            0,
            0,
            0});
            this.nmNotify.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nmNotify.Name = "nmNotify";
            this.nmNotify.Size = new System.Drawing.Size(53, 22);
            this.nmNotify.TabIndex = 1;
            this.nmNotify.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nmNotify.ValueChanged += new System.EventHandler(this.nmNotify_ValueChanged);
            // 
            // ckbNotify
            // 
            this.ckbNotify.AutoSize = true;
            this.ckbNotify.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ckbNotify.Font = new System.Drawing.Font("Script MT Bold", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckbNotify.Location = new System.Drawing.Point(4, 2);
            this.ckbNotify.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ckbNotify.Name = "ckbNotify";
            this.ckbNotify.Size = new System.Drawing.Size(84, 19);
            this.ckbNotify.TabIndex = 0;
            this.ckbNotify.Text = "Thông báo";
            this.ckbNotify.UseVisualStyleBackColor = true;
            this.ckbNotify.CheckedChanged += new System.EventHandler(this.ckbNotify_CheckedChanged);
            // 
            // btnToday
            // 
            this.btnToday.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnToday.Font = new System.Drawing.Font("Script MT Bold", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnToday.Location = new System.Drawing.Point(548, 4);
            this.btnToday.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnToday.Name = "btnToday";
            this.btnToday.Size = new System.Drawing.Size(89, 31);
            this.btnToday.TabIndex = 1;
            this.btnToday.Text = "Hôm nay";
            this.btnToday.UseVisualStyleBackColor = true;
            this.btnToday.Click += new System.EventHandler(this.btnToday_Click);
            // 
            // dtpkDate
            // 
            this.dtpkDate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dtpkDate.Font = new System.Drawing.Font("Script MT Bold", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpkDate.Location = new System.Drawing.Point(335, 6);
            this.dtpkDate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtpkDate.Name = "dtpkDate";
            this.dtpkDate.Size = new System.Drawing.Size(200, 23);
            this.dtpkDate.TabIndex = 0;
            this.dtpkDate.ValueChanged += new System.EventHandler(this.dtpkDate_ValueChanged);
            // 
            // panel2
            // 
            this.panel2.BackgroundImage = global::Calendar.Properties.Resources.hinh_nen_vu_tru;
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.txtToDay);
            this.panel2.Controls.Add(this.pnlMatrix);
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Location = new System.Drawing.Point(11, 46);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(855, 383);
            this.panel2.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(206, 336);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Ngày bạn đang chọn:";
            // 
            // txtToDay
            // 
            this.txtToDay.Enabled = false;
            this.txtToDay.Location = new System.Drawing.Point(367, 333);
            this.txtToDay.Name = "txtToDay";
            this.txtToDay.ReadOnly = true;
            this.txtToDay.Size = new System.Drawing.Size(114, 22);
            this.txtToDay.TabIndex = 2;
            this.txtToDay.TextChanged += new System.EventHandler(this.txtToDay_TextChanged);
            // 
            // pnlMatrix
            // 
            this.pnlMatrix.Location = new System.Drawing.Point(148, 62);
            this.pnlMatrix.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnlMatrix.Name = "pnlMatrix";
            this.pnlMatrix.Size = new System.Drawing.Size(560, 254);
            this.pnlMatrix.TabIndex = 1;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.btnNextMonth);
            this.panel4.Controls.Add(this.btnPreviousMonth);
            this.panel4.Controls.Add(this.btnMon);
            this.panel4.Controls.Add(this.btnSun);
            this.panel4.Controls.Add(this.btnSat);
            this.panel4.Controls.Add(this.btnFri);
            this.panel4.Controls.Add(this.btnThu);
            this.panel4.Controls.Add(this.btnWed);
            this.panel4.Controls.Add(this.btnTue);
            this.panel4.Location = new System.Drawing.Point(5, 9);
            this.panel4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(847, 47);
            this.panel4.TabIndex = 0;
            // 
            // btnNextMonth
            // 
            this.btnNextMonth.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNextMonth.Font = new System.Drawing.Font("Script MT Bold", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNextMonth.Location = new System.Drawing.Point(739, 2);
            this.btnNextMonth.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnNextMonth.Name = "btnNextMonth";
            this.btnNextMonth.Size = new System.Drawing.Size(105, 41);
            this.btnNextMonth.TabIndex = 0;
            this.btnNextMonth.Text = "Tháng sau >>";
            this.btnNextMonth.UseVisualStyleBackColor = true;
            this.btnNextMonth.Click += new System.EventHandler(this.btnNextMonth_Click);
            // 
            // btnPreviousMonth
            // 
            this.btnPreviousMonth.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPreviousMonth.Font = new System.Drawing.Font("Script MT Bold", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPreviousMonth.Location = new System.Drawing.Point(3, 2);
            this.btnPreviousMonth.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnPreviousMonth.Name = "btnPreviousMonth";
            this.btnPreviousMonth.Size = new System.Drawing.Size(120, 41);
            this.btnPreviousMonth.TabIndex = 0;
            this.btnPreviousMonth.Text = "<< Tháng trước";
            this.btnPreviousMonth.UseVisualStyleBackColor = true;
            this.btnPreviousMonth.Click += new System.EventHandler(this.btnPreviousMonth_Click);
            // 
            // btnMon
            // 
            this.btnMon.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMon.Font = new System.Drawing.Font("Script MT Bold", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMon.Location = new System.Drawing.Point(143, 2);
            this.btnMon.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnMon.Name = "btnMon";
            this.btnMon.Size = new System.Drawing.Size(75, 41);
            this.btnMon.TabIndex = 0;
            this.btnMon.Text = "Thứ 2";
            this.btnMon.UseVisualStyleBackColor = true;
            this.btnMon.Click += new System.EventHandler(this.btnMon_Click);
            // 
            // btnSun
            // 
            this.btnSun.BackColor = System.Drawing.Color.Red;
            this.btnSun.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSun.Font = new System.Drawing.Font("Script MT Bold", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSun.Location = new System.Drawing.Point(623, 2);
            this.btnSun.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSun.Name = "btnSun";
            this.btnSun.Size = new System.Drawing.Size(90, 41);
            this.btnSun.TabIndex = 0;
            this.btnSun.Text = "Chủ Nhật";
            this.btnSun.UseVisualStyleBackColor = false;
            this.btnSun.Click += new System.EventHandler(this.btnSun_Click);
            // 
            // btnSat
            // 
            this.btnSat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnSat.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSat.Font = new System.Drawing.Font("Script MT Bold", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSat.Location = new System.Drawing.Point(543, 2);
            this.btnSat.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSat.Name = "btnSat";
            this.btnSat.Size = new System.Drawing.Size(75, 41);
            this.btnSat.TabIndex = 0;
            this.btnSat.Text = "Thứ 7";
            this.btnSat.UseVisualStyleBackColor = false;
            this.btnSat.Click += new System.EventHandler(this.btnSat_Click);
            // 
            // btnFri
            // 
            this.btnFri.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFri.Font = new System.Drawing.Font("Script MT Bold", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFri.Location = new System.Drawing.Point(463, 2);
            this.btnFri.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnFri.Name = "btnFri";
            this.btnFri.Size = new System.Drawing.Size(75, 41);
            this.btnFri.TabIndex = 0;
            this.btnFri.Text = "Thứ 6";
            this.btnFri.UseVisualStyleBackColor = true;
            this.btnFri.Click += new System.EventHandler(this.btnFri_Click);
            // 
            // btnThu
            // 
            this.btnThu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnThu.Font = new System.Drawing.Font("Script MT Bold", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThu.Location = new System.Drawing.Point(383, 2);
            this.btnThu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnThu.Name = "btnThu";
            this.btnThu.Size = new System.Drawing.Size(75, 41);
            this.btnThu.TabIndex = 0;
            this.btnThu.Text = "Thứ 5";
            this.btnThu.UseVisualStyleBackColor = true;
            this.btnThu.Click += new System.EventHandler(this.btnThu_Click);
            // 
            // btnWed
            // 
            this.btnWed.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnWed.Font = new System.Drawing.Font("Script MT Bold", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnWed.Location = new System.Drawing.Point(303, 2);
            this.btnWed.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnWed.Name = "btnWed";
            this.btnWed.Size = new System.Drawing.Size(75, 41);
            this.btnWed.TabIndex = 0;
            this.btnWed.Text = "Thứ 4";
            this.btnWed.UseVisualStyleBackColor = true;
            this.btnWed.Click += new System.EventHandler(this.btnWed_Click);
            // 
            // btnTue
            // 
            this.btnTue.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTue.Font = new System.Drawing.Font("Script MT Bold", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTue.Location = new System.Drawing.Point(223, 2);
            this.btnTue.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnTue.Name = "btnTue";
            this.btnTue.Size = new System.Drawing.Size(75, 41);
            this.btnTue.TabIndex = 0;
            this.btnTue.Text = "Thứ 3";
            this.btnTue.UseVisualStyleBackColor = true;
            this.btnTue.Click += new System.EventHandler(this.btnTue_Click);
            // 
            // timerNoti
            // 
            this.timerNoti.Enabled = true;
            this.timerNoti.Interval = 3600000;
            this.timerNoti.Tick += new System.EventHandler(this.timerNoti_Tick);
            // 
            // Notify
            // 
            this.Notify.Icon = ((System.Drawing.Icon)(resources.GetObject("Notify.Icon")));
            this.Notify.Text = "Lịch làm việc";
            this.Notify.Visible = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(871, 464);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Location = new System.Drawing.Point(5000, 50);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lịch";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmNotify)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel pnlMatrix;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btnToday;
        private System.Windows.Forms.DateTimePicker dtpkDate;
        private System.Windows.Forms.Button btnMon;
        private System.Windows.Forms.Button btnPreviousMonth;
        private System.Windows.Forms.Button btnSun;
        private System.Windows.Forms.Button btnSat;
        private System.Windows.Forms.Button btnFri;
        private System.Windows.Forms.Button btnThu;
        private System.Windows.Forms.Button btnWed;
        private System.Windows.Forms.Button btnTue;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.CheckBox ckbNotify;
        private System.Windows.Forms.NumericUpDown nmNotify;
        private System.Windows.Forms.Button btnNextMonth;
        private System.Windows.Forms.Timer timerNoti;
        private System.Windows.Forms.NotifyIcon Notify;
        private System.Windows.Forms.TextBox txtToDay;
        private System.Windows.Forms.Label label1;
    }
}

