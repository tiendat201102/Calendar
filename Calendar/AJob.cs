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
    public partial class AJob : UserControl
    {
        private PlanItem job;
        public PlanItem Job
        {
            get { return job; }
            set { job = value; }
        }
        public AJob(PlanItem job)
        {
            InitializeComponent();

            cbStatus.DataSource = PlanItem.ListStatus;

            this.Job = job;
            Show();
        }

        void Show()
        {
            txtJob.Text = Job.Job;
            nmStartHour.Value = Job.FromTime.X;
            nmStartMinute.Value = Job.FromTime.Y;
            nmEndHour.Value = Job.ToTime.X;
            nmEndMinute.Value = Job.ToTime.Y;
            cbStatus.SelectedIndex = PlanItem.ListStatus.IndexOf(Job.Status);
            //khi công việc Done thì checkbox tự check
            ckbDone.Checked = PlanItem.ListStatus.IndexOf(Job.Status) == (int)EPlanItem.DONE ? true : false;

        }

        private event EventHandler update;
        public event EventHandler Update
        {
            add { update += value; } 
            remove {update -= value;  }
        }

        private event EventHandler delete;
        public event EventHandler Delete
        {
            add { delete += value; }
            remove { delete -= value; }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            Job.Job = txtJob.Text;
            Job.FromTime = new Point((int)nmStartHour.Value, (int)nmStartMinute.Value);
            Job.ToTime = new Point((int)nmEndHour.Value, (int)nmEndMinute.Value);
            Job.Status = PlanItem.ListStatus[cbStatus.SelectedIndex];
            if (update != null)
            {
                update(this,new EventArgs());
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

            if(delete != null)
            {
                delete(this,new EventArgs() );
            }
        }

        private void ckbDone_CheckedChanged(object sender, EventArgs e)
        {
            cbStatus.SelectedIndex = ckbDone.Checked ? (int)EPlanItem.DONE : (int)EPlanItem.DOING;   
        }
    }
}
