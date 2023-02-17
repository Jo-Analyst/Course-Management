using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace Interface
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
            try { this.reportViewer1.LocalReport.DataSources.Clear();
                this.reportViewer1.LocalReport.DataSources.Add(rds);
                this.reportViewer1.LocalReport.ReportEmbeddedResource = "Interface.ReportListPresence.rdlc";
                this.reportViewer1.RefreshReport();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            }
    }
}
