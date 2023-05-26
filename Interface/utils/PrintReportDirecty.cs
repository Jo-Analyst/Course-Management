using Microsoft.Reporting.WinForms;

namespace CourseManagement
{
    class ReportViewerPrint
    {
        static public void PrintDirecty(ReportDataSource rds, string pathReport, string nameStudent = null, bool listingByStudent = false, string filteringOption = null)
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

            if (!listingByStudent)
            {
                LocalSubReport.filteringOption = filteringOption;
                localReport.SubreportProcessing += new SubreportProcessingEventHandler(LocalSubReport.Processing);
            }
            localReport.PrintToPrinter();
        }
    }
}
