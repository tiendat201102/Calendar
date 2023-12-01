using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;
using System.Drawing;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Tab;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;
using System.Security.Policy;
using Microsoft.Win32;

namespace Calendar
{
    public partial class Form1 : Form
    {

        #region Properties
        private List<List<Button>> matrix;
        public List<List<Button>> Matrix
        {
            get { return matrix; }
            set { matrix = value; }
        }

        private PlanData job;
        public PlanData Job
        {
            get { return job; }
            set { job = value; }
        }

        private List<string> dateOfWeek = new List<string>() { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday" };

        private string filePath = "data.xml";

        private int appTime;
        public int AppTime
        {
            get { return appTime; }
            set { appTime = value; }
        }

        #endregion
        public Form1()
        {
            InitializeComponent();

            RegistryKey regkey = Registry.CurrentUser.CreateSubKey("Software\\Calendar");
            RegistryKey regstart = Registry.CurrentUser.CreateSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run");
            string keyvalue = "1";
            try
            {
                //chen gia tri key
                regkey.SetValue("Index", keyvalue);
                regstart.SetValue("Calender", Application.StartupPath + "\\Calendar.exe");
                ////dong tien trinh ghi key
                //regkey.Close();
            }
            catch (System.Exception ex)
            {
            }

            timerNoti.Start();
            appTime=0;
            LoadMatrix();
           
            try
            {
                Job = DeserializeFromXML(filePath) as PlanData;
            } catch
            {
                //dữ liệu mặc định để test
                SetDefaultJob();
            }
        }

        void SetDefaultJob()
        {
            Job = new PlanData();
            Job.Job = new List<PlanItem>();
            Job.Job.Add(new PlanItem()
            {
                Date = DateTime.Now,
                Job = "test",
                FromTime = new Point(1, 1),
                ToTime = new Point(2, 2),
                Status = PlanItem.ListStatus[(int)EPlanItem.DOING]
            });

            Job.Job.Add(new PlanItem()
            {
                Date = DateTime.Now,
                Job = "test",
                FromTime = new Point(1, 1),
                ToTime = new Point(2, 2),
                Status = PlanItem.ListStatus[(int)EPlanItem.DOING]
            });

            Job.Job.Add(new PlanItem()
            {
                Date = DateTime.Now,
                Job = "test",
                FromTime = new Point(1, 1),
                ToTime = new Point(2, 2),
                Status = PlanItem.ListStatus[(int)EPlanItem.DONE]
            });

            Job.Job.Add(new PlanItem()
            {
                Date = DateTime.Now.AddDays(-1),
                Job = "test",
                FromTime = new Point(1, 1),
                ToTime = new Point(2, 2),
                Status = PlanItem.ListStatus[(int)EPlanItem.DOING]
            });
            
        }

        void LoadMatrix()
        {
            Matrix = new List<List<Button>>();
            Button oldBtn = new Button() { Width = 0, Height = 0, Location = new Point(-Cons.margin, 0) };
            for(int i = 0; i < Cons.LineOfMonth; i++)
            {
                Matrix.Add(new List<Button>());
                for(int j=0; j< Cons.DayOfWeek; j++)
                {
                    Button btn = new Button() { 
                        Width = Cons.dateButtonWidth, 
                        Height= Cons.dateButtonHeight,
                    };
                    btn.Location = new Point(oldBtn.Location.X + oldBtn.Width + Cons.margin, oldBtn.Location.Y);

                    btn.Click += Btn_Click;

                    pnlMatrix.Controls.Add(btn);
                    Matrix[i].Add(btn);

                    oldBtn = btn;
                }
                oldBtn = new Button() { Width = 0, Height = 0, Location = new Point(-Cons.margin, oldBtn.Location.Y + Cons.dateButtonHeight) };
            }
            //AddNumberIntoMatrixByDate(dtpkDate.Value);
            setDefaultDate();
        }

        //mở công vệc ngày được chọn
        private void Btn_Click(object sender, EventArgs e)
        {
            //kiểm tra button, nếu không phải ngày thì ko làm gì cả
            if(String.IsNullOrEmpty((sender as Button).Text))
                return; 
            ToDoList ListJob = new ToDoList(new DateTime(dtpkDate.Value.Year, dtpkDate.Value.Month, Convert.ToInt32((sender as Button).Text) ), Job);

            ListJob.ShowDialog();
        }

        int DayOfMonth(DateTime date)
        {
            switch (date.Month)
            {
                case 1:
                case 3:
                case 5:
                case 7:
                case 8:
                case 10:
                case 12:
                    return 31;
                case 2:
                    if ((date.Year % 4 == 0 && date.Year % 100 != 0) || date.Year % 400 == 0)
                        return 29;
                    else 
                        return 28;
                default:
                    return 30;

            }
        }
        void AddNumberIntoMatrixByDate(DateTime date)
        {
            clearMatrix();
            DateTime useDate = new DateTime(date.Year, date.Month, 1); //mỗi tháng đều bắt đầu từ ngày một

            //var  a = useDate.DayOfWeek.ToString(); //trả về ngày sử dụng của tháng
            

            int line = 0;
            int i;
            for(i =1; i<=DayOfMonth(date); i++)
            {
                int column = dateOfWeek.IndexOf(useDate.DayOfWeek.ToString());
                Button btn = Matrix[line][column];
                btn.Text = i.ToString();
                /*
                if(useDate == DateTime.Now)
                {
                    btn.BackColor = Color.Red;
                }*/

                if (isEqualDate(useDate, DateTime.Now))
                {
                    btn.BackColor = Color.Red;
                }
                
                if (isEqualDate(useDate, date))
                {
                    btn.BackColor = Color.Yellow;
                }

                // Thêm sự kiện MouseEnter
                btn.MouseEnter += (sender, e) =>
                {
                    if (btn.BackColor != Color.Red && btn.BackColor != Color.Yellow)
                    {
                        btn.BackColor = Color.Silver;
                    }
                };
                
                // Thêm sự kiện MouseLeave
                btn.MouseLeave += (sender, e) =>
                {
                    if (btn.BackColor != Color.Red && btn.BackColor != Color.Yellow)
                    {
                        btn.BackColor = Color.WhiteSmoke;
                    }
                };

                if (column >= 6)
                    line++;

                useDate = useDate.AddDays(1);
            }
        }

        bool isEqualDate(DateTime date1, DateTime date2)
        {
            return date1.Day==date2.Day && date1.Month==date2.Month && date1.Year==date2.Year;
        }

        //xoa ma tran (gia tri)
        void clearMatrix()
        {    
            for (int i = 0; i < Matrix.Count; i++)
            {
                for (int j = 0; j < Matrix[i].Count; j++)
                {
                    Button btn = Matrix[i][j];
                    btn.Text = ""; 
                    btn.BackColor = Color.White;
                }
            }
        }

        //Show Ngay hien tai
        void setDefaultDate()
        {
            dtpkDate.Value = DateTime.Now;
        }
        private void dtpkDate_ValueChanged(object sender, EventArgs e)
        {
            AddNumberIntoMatrixByDate((sender as DateTimePicker).Value);

            // Lấy giá trị mới của datetimepicker
            DateTime date = dtpkDate.Value;

            // Đặt giá trị cho textbox
            txtToDay.Text = string.Format("{0}", date.ToString("dd/MM/yyyy"));
        }
        
        //chuyen sang thang truoc va thang sau
        private void btnNextMonth_Click(object sender, EventArgs e)
        {
            dtpkDate.Value = dtpkDate.Value.AddMonths(1);
        }

        private void btnPreviousMonth_Click(object sender, EventArgs e)
        {
            dtpkDate.Value = dtpkDate.Value.AddMonths(-1);
        }

        //chuyển sang ngày hiện tại
        private void btnToday_Click(object sender, EventArgs e)
        {
            dtpkDate.Value = DateTime.Now;
        }

        //lưu dữ liệu xuống file
        private void SerializeToXML(object data, string filePath)
        {
            FileStream fs=new FileStream(filePath, FileMode.OpenOrCreate, FileAccess.Write);
            XmlSerializer sr =new XmlSerializer(typeof(PlanData));
            sr.Serialize(fs,data);

            fs.Close();
        }
        //đưa file lên
        private object DeserializeFromXML(string filePath)
        {
            FileStream fs = new FileStream(filePath, FileMode.Open, FileAccess.Read);
            try
            {
                XmlSerializer sr = new XmlSerializer(typeof(PlanData));
                object result = sr.Deserialize(fs);
                fs.Close();
                return result;
            }
            catch (Exception ex)
            {
                fs.Close();
                throw new NotImplementedException();
            }
        }
        //xử lý trước khi đóng form
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            SerializeToXML(Job, filePath);
        }

        private void timerNoti_Tick(object sender, EventArgs e)
        {
            if (!ckbNotify.Checked)
                return;
            AppTime++;

            if(AppTime < Cons.TimeNoti)
            {
                return;
            }
            if(Job == null || Job.Job==null)
            {
                return;
            }
            List<PlanItem> ToDayJob = Job.Job.Where(p => p.Date.Year == DateTime.Now.Year && p.Date.Month==DateTime.Now.Month && p.Date.Day==DateTime.Now.Day).ToList();
            Notify.ShowBalloonTip(Cons.NotifyTimeOut,
                                string.Format("Hôm nay là ngày: {0}", DateTime.Now.ToString("dd/MM/yyyy")),
                                string.Format("Hôm nay bạn có {0} công việc", ToDayJob.Count),
                                ToolTipIcon.Info);
            AppTime = 0;
        }


        private void nmNotify_ValueChanged(object sender, EventArgs e)
        {
            Cons.TimeNoti = (int) nmNotify.Value;
        }

        private void ckbNotify_CheckedChanged(object sender, EventArgs e)
        {
            nmNotify.Enabled = ckbNotify.Checked;
        }

        private void btnMon_Click(object sender, EventArgs e)
        {
            // Lấy tất cả các button trong cột thứ nhất
            List<Button> buttons = Matrix.Select(row => row[0]).ToList();

            // Bôi đen tất cả các button
            foreach (Button button in buttons)
            {
                button.BackColor = Color.DarkGray;
            }
            // Bỏ bôi đen tất cả các button trong các cột khác
            for (int i = 0; i < Cons.DayOfWeek; i++)
            {
                if (i != 0)
                {
                    for (int j = 0; j < Cons.LineOfMonth; j++)
                    {
                        if (Matrix[j][i].BackColor == Color.Yellow)
                        {
                            continue;
                        }
                        if (Matrix[j][i].BackColor == Color.Red)
                        {
                            continue;
                        }
                        Matrix[j][i].BackColor = Color.WhiteSmoke;
                    }
                }
            }
        }

        private void btnTue_Click(object sender, EventArgs e)
        {
            // Lấy tất cả các button trong cột đầu thứ 2
            List<Button> buttons = Matrix.Select(row => row[1]).ToList();

            // Bôi đen tất cả các button
            foreach (Button button in buttons)
            {
                button.BackColor = Color.DarkGray;
            }
            // Bỏ bôi đen tất cả các button trong các cột khác
            for (int i = 0; i < Cons.DayOfWeek; i++)
            {
                if (i != 1)
                {
                    for (int j = 0; j < Cons.LineOfMonth; j++)
                    {
                        if (Matrix[j][i].BackColor == Color.Yellow)
                        {
                            continue;
                        }
                        if (Matrix[j][i].BackColor == Color.Red)
                        {
                            continue;
                        }
                        Matrix[j][i].BackColor = Color.WhiteSmoke;
                    }
                }
            }
        }

        private void btnWed_Click(object sender, EventArgs e)
        {
            // Lấy tất cả các button trong cột thứ 3
            List<Button> buttons = Matrix.Select(row => row[2]).ToList();

            // Bôi đen tất cả các button
            foreach (Button button in buttons)
            {
                button.BackColor = Color.DarkGray;
            }
            // Bỏ bôi đen tất cả các button trong các cột khác
            for (int i = 0; i < Cons.DayOfWeek; i++)
            {
                if (i != 2)
                {
                    for (int j = 0; j < Cons.LineOfMonth; j++)
                    {
                        if (Matrix[j][i].BackColor == Color.Yellow)
                        {
                            continue;
                        }
                        if (Matrix[j][i].BackColor == Color.Red)
                        {
                            continue;
                        }
                        Matrix[j][i].BackColor = Color.WhiteSmoke;
                    }
                }
            }
        }

        private void btnThu_Click(object sender, EventArgs e)
        {
            // Lấy tất cả các button trong cột thứ 4
            List<Button> buttons = Matrix.Select(row => row[3]).ToList();

            // Bôi đen tất cả các button
            foreach (Button button in buttons)
            {
                button.BackColor = Color.DarkGray;
            }
            // Bỏ bôi đen tất cả các button trong các cột khác
            for (int i = 0; i < Cons.DayOfWeek; i++)
            {
                if (i != 3)
                {
                    for (int j = 0; j < Cons.LineOfMonth; j++)
                    {
                        if (Matrix[j][i].BackColor == Color.Yellow)
                        {
                            continue;
                        }
                        if (Matrix[j][i].BackColor == Color.Red)
                        {
                            continue;
                        }
                        Matrix[j][i].BackColor = Color.WhiteSmoke;
                    }
                }
            }
        }

        private void btnFri_Click(object sender, EventArgs e)
        {
            // Lấy tất cả các button trong cột thứ 5
            List<Button> buttons = Matrix.Select(row => row[4]).ToList();

            // Bôi đen tất cả các button
            foreach (Button button in buttons)
            {
                button.BackColor = Color.DarkGray;
            }
            // Bỏ bôi đen tất cả các button trong các cột khác
            for (int i = 0; i < Cons.DayOfWeek; i++)
            {
                if (i != 4 )
                {
                    for (int j = 0; j < Cons.LineOfMonth; j++)
                    {
                        if (Matrix[j][i].BackColor == Color.Yellow)
                        {
                            continue;
                        }
                        if (Matrix[j][i].BackColor == Color.Red)
                        {
                            continue;
                        }
                        Matrix[j][i].BackColor = Color.WhiteSmoke;
                    }
                }
            }
        }

        private void btnSat_Click(object sender, EventArgs e)
        {
            // Lấy tất cả các button trong cột thứ 6
            List<Button> buttons = Matrix.Select(row => row[5]).ToList();

            // Bôi đen tất cả các button
            foreach (Button button in buttons)
            {
                button.BackColor = Color.DarkGray;
            }
            // Bỏ bôi đen tất cả các button trong các cột khác
            for (int i = 0; i < Cons.DayOfWeek; i++)
            {
                if (i != 5)
                {
                    for (int j = 0; j < Cons.LineOfMonth; j++)
                    {
                        if (Matrix[j][i].BackColor == Color.Yellow)
                        {
                            continue;
                        }
                        if (Matrix[j][i].BackColor == Color.Red)
                        {
                            continue;
                        }
                        Matrix[j][i].BackColor = Color.WhiteSmoke;
                    }
                }
            }
        }

        private void btnSun_Click(object sender, EventArgs e)
        {
            // Lấy tất cả các button trong cột thứ 7
            List<Button> buttons = Matrix.Select(row => row[6]).ToList();

            // Bôi đen tất cả các button
            foreach (Button button in buttons)
            {
                button.BackColor = Color.DarkGray;
            }
            // Bỏ bôi đen tất cả các button trong các cột khác
            for (int i = 0; i < Cons.DayOfWeek; i++)
            {
                if (i != 6)
                {
                    for (int j = 0; j < Cons.LineOfMonth; j++)
                    {
                        if (Matrix[j][i].BackColor == Color.Yellow)
                        {
                            continue;
                        }
                        if (Matrix[j][i].BackColor == Color.Red)
                        {
                            continue;
                        }
                        Matrix[j][i].BackColor = Color.WhiteSmoke;
                    }
                }
            }
        }

        private void txtToDay_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }
    }
}
