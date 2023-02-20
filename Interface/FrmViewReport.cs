using Microsoft.Reporting.WinForms;
using System;
using System.Windows.Forms;

namespace CourseManagement
{
    public partial class FrmViewReport : Form
    {
        ReportDataSource rds;

        public FrmViewReport(ReportDataSource rds)
        {
            InitializeComponent();
            this.rds = rds;
        }

        private void FrmViewReport_Load(object sender, EventArgs e)
        {
            try
            {
                this.reportViewer1.LocalReport.DataSources.Clear();
                this.reportViewer1.LocalReport.DataSources.Add(rds);
                this.reportViewer1.LocalReport.ReportEmbeddedResource = "CourseManagement.ReportListPresence.rdlc";
                this.reportViewer1.RefreshReport();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
