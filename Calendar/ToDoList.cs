using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calendar
{
    public partial class ToDoList : Form
    {
        private DateTime date;
        public DateTime Date
        {
            get { return date; }
            set { date = value; }
        }

        private PlanData job;
        public PlanData Job
        {
            get { return job; }
            set { job = value; }
        }
        FlowLayoutPanel fPanel = new FlowLayoutPanel(); 
        public ToDoList(DateTime date, PlanData job)
        {
            InitializeComponent();

            this.Date = date;
            this.Job = job;

            //đặt lại thuộc tính kích thước
            fPanel.Width = pnlJob.Width;
            fPanel.Height = pnlJob.Height;
            pnlJob.Controls.Add(fPanel);

            //hiện công việc ngày được chọn
            dtpkDate.Value = Date;


        }//trả về số công việc trong ngày
        List<PlanItem> JobInDay(DateTime date)
        {
            return Job.Job.Where(p => p.Date.Year == date.Year && p.Date.Month == date.Month && p.Date.Day==date.Day).ToList();
        }

        void ShowJobByDate (DateTime date)
        {
            fPanel.Controls.Clear();
            if (Job != null && Job.Job != null)
            {
                List<PlanItem> ToDayJob = JobInDay(date);
                for (int i = 0; i < ToDayJob.Count; i++)
                {
                    AddJob(ToDayJob[i]);
                    /*AJob aJob = new AJob(ToDayJob[i]);
                    aJob.Update += AJob_Update;
                    aJob.Delete += AJob_Delete;
                    fPanel.Controls.Add(aJob);*/
                }
            }
        }

        void AddJob(PlanItem job)
        {
            AJob aJob = new AJob(job);
            aJob.Update += AJob_Update;
            aJob.Delete += AJob_Delete;
            fPanel.Controls.Add(aJob);
        }

        private void AJob_Delete(object sender, EventArgs e)
        {
            AJob uc = sender as AJob;
            PlanItem job = uc.Job;

            fPanel.Controls.Remove(uc);
            Job.Job.Remove(job);
        }

        private void AJob_Update(object sender, EventArgs e)
        {
            
        }

        private void dtpkDate_ValueChanged(object sender, EventArgs e)
        {
            ShowJobByDate((sender as DateTimePicker).Value);
        }

        private void btnPreviousDay_Click(object sender, EventArgs e)
        {
            dtpkDate.Value = dtpkDate.Value.AddDays(-1);
        }

        private void btnNextDay_Click(object sender, EventArgs e)
        {
            dtpkDate.Value = dtpkDate.Value.AddDays(1);
        }

        private void mnsiAddJob_Click(object sender, EventArgs e)
        {
            PlanItem item = new PlanItem() { Date = dtpkDate.Value };
            Job.Job.Add(item);
            AddJob(item);
        }

        private void mnsiToday_Click(object sender, EventArgs e)
        {
            dtpkDate.Value = DateTime.Now; 
        }

        private void ToDoList_Load(object sender, EventArgs e)
        {
            
        }

        private void mnsMain_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}
