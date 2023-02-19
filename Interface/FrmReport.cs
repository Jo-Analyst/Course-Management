using DataBase;
using System;
using System.Windows.Forms;

namespace CourseManagement
{
    public partial class FrmReport : Form
    {
        public FrmReport()
        {
            InitializeComponent();
        }

        private void btnStudent_Click(object sender, EventArgs e)
        {
            new FrmReportStudent().ShowDialog();
        }

        private void btnClass_Click(object sender, EventArgs e)
        {
            new FrmReportClass().ShowDialog();
        }

        private void FrmReport_Load(object sender, EventArgs e)
        {
            lblQuantityStudentsRegistered.Text += new Student().FindAll().Rows.Count.ToString();
        }

        private void btnListPresence_Click(object sender, EventArgs e)
        {
            new FrmReportPresenceStudent().ShowDialog();
        }
    }
}
