using Microsoft.Reporting.WinForms;
using System;
using System.Windows.Forms;

namespace CourseManagement
{
    public partial class FrmViewReport : Form
    {
        ReportDataSource rds;
        string pathReport, nameStudent, filteringOption;
        bool listingByStudent;


        public FrmViewReport(ReportDataSource rds, string pathReport, string nameStudent = null, bool listingByStudent = false, string filteringOption = "")
        {
            InitializeComponent();
            this.rds = rds;
            this.pathReport = pathReport;
            this.nameStudent = nameStudent;
            this.listingByStudent = listingByStudent;
            this.filteringOption = filteringOption;
        }

        private void FrmViewReport_Load(object sender, EventArgs e)
        {
            try
            {
                this.reportViewer1.LocalReport.ReportEmbeddedResource = pathReport;
                this.reportViewer1.LocalReport.DataSources.Clear();
                this.reportViewer1.LocalReport.DataSources.Add(rds);

                if (!string.IsNullOrEmpty(nameStudent))
                {
                    ReportParameterCollection rpc = new ReportParameterCollection
                    {
                        new ReportParameter("nameStudent", nameStudent)
                    };

                    reportViewer1.LocalReport.SetParameters(rpc);
                }

                if (!listingByStudent)
                {
                    LocalSubReport.filteringOption = filteringOption;
                    reportViewer1.LocalReport.SubreportProcessing += new SubreportProcessingEventHandler(LocalSubReport.Processing);
                }
                this.reportViewer1.RefreshReport();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
