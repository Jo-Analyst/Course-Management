using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace Interface
{
    public partial class FrmViewReport : Form
    {
        ReportDataSource rds = new ReportDataSource();
        ViewStudentReport view;
        DataTable dt;

        public FrmViewReport(DataTable dataTable)
        {
            InitializeComponent();
            dt = dataTable;
        }

        private void FrmViewReport_Load(object sender, EventArgs e)
        {

            List<ViewStudentReport> lst = new List<ViewStudentReport>();
            lst.Clear();

            foreach (DataRow dr in dt.Rows)
            {
                view = new ViewStudentReport();
                view.StudenId = int.Parse(dr["id"].ToString());
                view.StudentName = dr["name"].ToString();
                view.StudentClass = dr["class"].ToString();
                view.StudentShift = dr["shift"].ToString();
                view.StudentNumberOfAttendance = int.Parse(dr["numberOfAttendence"].ToString());
                view.StudentNumberOfAbsences = int.Parse(dr["numberOfAbsences"].ToString());
                view.percentage = dr["percentage"].ToString();

                lst.Add(view);
            }

            rds.Name = "DataSet1";
            rds.Value = lst;

            this.reportViewer1.LocalReport.DataSources.Clear();
            this.reportViewer1.LocalReport.DataSources.Add(rds);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Interface.ReportListPresence.rdlc";
            this.reportViewer1.RefreshReport();
        }
    }
}
