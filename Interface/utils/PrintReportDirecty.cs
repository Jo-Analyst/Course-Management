using Microsoft.Reporting.WinForms;

namespace CourseManagement
{
    class ReportViewerPrint
    {
        static public void PrintDirecty(ReportDataSource rds, string pathReport, string nameStudent = null)
        {
            LocalReport localReport = new LocalReport();
            localReport.ReportEmbeddedResource = pathReport;
            localReport.DataSources.Clear();
            localReport.DataSources.Add(rds);

            if (!string.IsNullOrEmpty(nameStudent))
            {
                ReportParameterCollection parameters = new ReportParameterCollection
                {
                    new ReportParameter("nameStudent", nameStudent)
                };

                localReport.SetParameters(parameters);
            }

            localReport.PrintToPrinter();
        }
    }
}
