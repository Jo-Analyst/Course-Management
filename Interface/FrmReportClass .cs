using DataBase;
using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace CourseManagement
{
    public partial class FrmReportClass : Form
    {
        public FrmReportClass()
        {
            InitializeComponent();
        }

        int class_id;
        Student student = new Student();
        ListAttendance listAttendance = new ListAttendance();
        Attendance attendance = new Attendance();
        DataTable dataTable = new DataTable();
        Class @class = new Class();
        DataTable dataFiltedAbove75Percentage = new DataTable();
        DataTable dataFiltedBellow75Percentage = new DataTable();

        private void cbClasses_SelectedIndexChanged(object sender, EventArgs e)
        {
            ShowReport();
        }

        private void ShowReport()
        {
            try
            {
                DataTable dtStudents = cbClass.Text.ToLower() == "todos" ? student.FindAll() : student.FindByClass(cbClass.Text);
                dgvReportClass.Rows.Clear();
                DataTable dtStudent;
                int index = 0;
                foreach (DataRow dr in dtStudents.Rows)
                {
                    class_id = int.Parse(dr["class_id"].ToString());

                    int numberOfClasses = int.Parse(listAttendance.ObtainStudentAttendanceValueSinceTheBeginningOfTheCourse(class_id).Rows[0]["count_attendance"].ToString());

                    dtStudent = listAttendance.GetStudentAttendanceValueSinceJoined(int.Parse(dr["id"].ToString()));

                    if (dtStudent.Rows.Count == 0)
                        dgvReportClass.Rows.Add(dtStudents.Rows[index]["name"], dtStudents.Rows[index]["class"], dtStudents.Rows[index]["shift"], "0", "0", "0%", "0%");

                    else
                    {
                        int resultPercentageStart = Utils.CalculateAttendancePercentageFromStart(int.Parse(dtStudent.Rows[0]["number_attendance"].ToString()), numberOfClasses);

                        int resultPercentageCameIn = Utils.CalculatePercentageOfAttendanceSinceJoined(int.Parse(dtStudent.Rows[0]["number_attendance"].ToString()), int.Parse(dtStudent.Rows[0]["number_absences"].ToString()));

                        dgvReportClass.Rows.Add(dtStudent.Rows[0]["name"], dtStudent.Rows[0]["class"], dtStudent.Rows[0]["shift"], dtStudent.Rows[0]["number_attendance"], dtStudent.Rows[0]["number_absences"], $"{resultPercentageStart}%", $"{resultPercentageCameIn}%");
                    }

                    dgvReportClass.Rows[index].Height = 35;
                    index++;
                }
                lblQtdClasses.Visible = cbClass.SelectedIndex != cbClass.Items.Count - 1 ? true : false;
                lblQuantityStudentList.Visible = true;
                lblQtdClasses.Text = $"Quantidades de aulas prestadas: {attendance.CountPresenceForClass(class_id)}";
                dgvReportClass.ClearSelection();
                btnViewReport.Enabled = dgvReportClass.Rows.Count > 0 ? true : false;
                btnPrint.Enabled = dgvReportClass.Rows.Count > 0 ? true : false;
                dataTable = LoadDataTable();
                FilterDataClassForPercentage();

                if (cbClass.Text.ToLower() != "todos")
                    class_id = int.Parse(@class.FindByClass(cbClass.Text).Rows[0]["id"].ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FilterDataClassForPercentage()
        {
            try
            {
                int indexDataFiltedAbove75Percentage = 0, indexDataFiltedBellow75Percentage = 0;
                dataFiltedAbove75Percentage.Rows.Clear();
                dataFiltedBellow75Percentage.Rows.Clear();

                foreach (DataRow row in dataTable.Rows)
                {
                    string[] numberPercentageStart = row["percentageStart"].ToString().Split('%');
                    string[] numberPercentageCameIn = row["percentageCameIn"].ToString().Split('%');

                    if (int.Parse(numberPercentageStart[0]) >= 75 || int.Parse(numberPercentageCameIn[0]) >= 75)
                    {
                        dataFiltedAbove75Percentage.Rows.Add();
                        dataFiltedAbove75Percentage.Rows[indexDataFiltedAbove75Percentage]["name"] = row["name"].ToString();
                        dataFiltedAbove75Percentage.Rows[indexDataFiltedAbove75Percentage]["class"] = row["class"].ToString();
                        dataFiltedAbove75Percentage.Rows[indexDataFiltedAbove75Percentage]["shift"] = row["shift"].ToString();
                        dataFiltedAbove75Percentage.Rows[indexDataFiltedAbove75Percentage]["numberOfAttendance"] = row["numberOfAttendance"].ToString();
                        dataFiltedAbove75Percentage.Rows[indexDataFiltedAbove75Percentage]["numberOfAbsences"] = row["numberOfAbsences"].ToString();
                        dataFiltedAbove75Percentage.Rows[indexDataFiltedAbove75Percentage]["percentageStart"] = row["percentageStart"].ToString();
                        dataFiltedAbove75Percentage.Rows[indexDataFiltedAbove75Percentage]["percentageCameIn"] = row["percentageCameIn"].ToString();
                        indexDataFiltedAbove75Percentage++;
                    }
                    else
                    {
                        dataFiltedBellow75Percentage.Rows.Add();
                        dataFiltedBellow75Percentage.Rows[indexDataFiltedBellow75Percentage]["name"] = row["name"].ToString();
                        dataFiltedBellow75Percentage.Rows[indexDataFiltedBellow75Percentage]["class"] = row["class"].ToString();
                        dataFiltedBellow75Percentage.Rows[indexDataFiltedBellow75Percentage]["shift"] = row["shift"].ToString();
                        dataFiltedBellow75Percentage.Rows[indexDataFiltedBellow75Percentage]["numberOfAttendance"] = row["numberOfAttendance"].ToString();
                        dataFiltedBellow75Percentage.Rows[indexDataFiltedBellow75Percentage]["numberOfAbsences"] = row["numberOfAbsences"].ToString();
                        dataFiltedBellow75Percentage.Rows[indexDataFiltedBellow75Percentage]["percentageStart"] = row["percentageStart"].ToString();
                        dataFiltedBellow75Percentage.Rows[indexDataFiltedBellow75Percentage]["percentageCameIn"] = row["percentageCameIn"].ToString();
                        indexDataFiltedBellow75Percentage++;
                    }
                }

                LoadDataGridView();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }



        private void LoadDataGridView()
        {
            dgvReportClass.Rows.Clear();

            var dt = getDataTableAfterFiltering();

            foreach (DataRow row in dt.Rows)
            {
                int index = dgvReportClass.Rows.Add();
                dgvReportClass.Rows[index].Cells["name"].Value = row["name"].ToString();
                dgvReportClass.Rows[index].Cells["classStudent"].Value = row["class"].ToString();
                dgvReportClass.Rows[index].Cells["shift"].Value = row["shift"].ToString();
                dgvReportClass.Rows[index].Cells["numberOfAttendance"].Value = row["numberOfAttendance"].ToString();
                dgvReportClass.Rows[index].Cells["numberOfAbsences"].Value = row["numberOfAbsences"].ToString();
                dgvReportClass.Rows[index].Cells["percentageStart"].Value = row["percentageStart"].ToString();
                dgvReportClass.Rows[index].Cells["percentageCameIn"].Value = row["percentageCameIn"].ToString();
                dgvReportClass.Rows[index].Height = 35;
            }

            dgvReportClass.ClearSelection();
        }

        private DataTable getDataTableAfterFiltering()
        {
            string description;
            DataTable dt;
            if (cbFindAbove75Percentage.Checked)
            {
                dt = dataFiltedAbove75Percentage;
                description = "Quantidade de alunos na lista acima de 75%";
            }
            else if (cbFindBellow75Percentage.Checked)
            {
                dt = dataFiltedBellow75Percentage;
                description = "Quantidade de alunos na lista abaixo de 75%";
            }
            else
            {
                dt = dataTable;
                description = "Quantidade de alunos na lista";
            }

            lblQuantityStudentList.Text = $"{description}: {dt.Rows.Count}";
            return dt;
        }

        private DataTable LoadDataTable()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("name", typeof(string));
            dt.Columns.Add("class", typeof(string));
            dt.Columns.Add("shift", typeof(string));
            dt.Columns.Add("numberOfAttendance", typeof(string));
            dt.Columns.Add("numberOfAbsences", typeof(string));
            dt.Columns.Add("percentageStart", typeof(string));
            dt.Columns.Add("percentageCameIn", typeof(string));

            dt.Rows.Clear();
            for (int i = 0; i < dgvReportClass.Rows.Count; i++)
            {
                dt.Rows.Add();
                dt.Rows[i]["name"] = dgvReportClass.Rows[i].Cells["name"].Value.ToString();
                dt.Rows[i]["class"] = dgvReportClass.Rows[i].Cells["classStudent"].Value.ToString();
                dt.Rows[i]["shift"] = dgvReportClass.Rows[i].Cells["shift"].Value.ToString();
                dt.Rows[i]["numberOfAttendance"] = dgvReportClass.Rows[i].Cells["numberOfAttendance"].Value.ToString();
                dt.Rows[i]["numberOfAbsences"] = dgvReportClass.Rows[i].Cells["numberOfAbsences"].Value.ToString();
                dt.Rows[i]["percentageStart"] = dgvReportClass.Rows[i].Cells["percentageStart"].Value.ToString();
                dt.Rows[i]["percentageCameIn"] = dgvReportClass.Rows[i].Cells["percentageCameIn"].Value.ToString();
            }

            return dt;
        }

        private void dgvReportClass_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            ClearSelectionDGV(e);
        }

        private void ClearSelectionDGV(DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                dgvReportClass.ClearSelection();
            }
        }

        private void dgvReportClass_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            ClearSelectionDGV(e);
        }

        private void btnViewReport_Click(object sender, EventArgs e)
        {
            try
            {
                PrintReport();
                new FrmViewReport(rds, "CourseManagement.ReportListPresence.rdlc").ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        ReportDataSource rds = new ReportDataSource();
        ViewStudentReport view = new ViewStudentReport();

        private void PrintReport()
        {
            List<ViewStudentReport> lst = new List<ViewStudentReport>();
            lst.Clear();

            var dt = getDataTableAfterFiltering();

            foreach (DataGridViewRow dr in dgvReportClass.Rows)
            {
                view = new ViewStudentReport();
                view.name = dr.Cells[0].Value.ToString();
                view.@class = dr.Cells[1].Value.ToString();
                view.shift = dr.Cells[2].Value.ToString();
                view.numberOfAttendance = int.Parse(dr.Cells[3].Value.ToString());
                view.numberOfAbsences = int.Parse(dr.Cells[4].Value.ToString());
                view.percentageStart = dr.Cells[5].Value.ToString();
                view.percentageCameIn = dr.Cells[6].Value.ToString();


                lst.Add(view);
            }

            rds.Name = "dtListPresence";
            rds.Value = lst;
        }

        private void FrmReportClass_Load(object sender, EventArgs e)
        {
            LoadCbClass();
            CreateColumsDataTableFiltedData();
        }

        private void CreateColumsDataTableFiltedData()
        {
            dataFiltedAbove75Percentage.Columns.Add("name", typeof(string));
            dataFiltedAbove75Percentage.Columns.Add("class", typeof(string));
            dataFiltedAbove75Percentage.Columns.Add("shift", typeof(string));
            dataFiltedAbove75Percentage.Columns.Add("numberOfAttendance", typeof(string));
            dataFiltedAbove75Percentage.Columns.Add("numberOfAbsences", typeof(string));
            dataFiltedAbove75Percentage.Columns.Add("percentageStart", typeof(string));
            dataFiltedAbove75Percentage.Columns.Add("percentageCameIn", typeof(string));

            dataFiltedBellow75Percentage.Columns.Add("name", typeof(string));
            dataFiltedBellow75Percentage.Columns.Add("class", typeof(string));
            dataFiltedBellow75Percentage.Columns.Add("shift", typeof(string));
            dataFiltedBellow75Percentage.Columns.Add("numberOfAttendance", typeof(string));
            dataFiltedBellow75Percentage.Columns.Add("numberOfAbsences", typeof(string));
            dataFiltedBellow75Percentage.Columns.Add("percentageStart", typeof(string));
            dataFiltedBellow75Percentage.Columns.Add("percentageCameIn", typeof(string));
        }

        private void LoadCbClass()
        {
            var dtClasses = @class.FindAll();
            foreach (DataRow dr in dtClasses.Rows)
            {
                cbClass.Items.Add(dr["name"]);
            }

            cbClass.Items.Add("Todos");
        }

        private void cbFindAbove75Percentage_CheckedChanged(object sender, EventArgs e)
        {
            if (cbFindAbove75Percentage.Checked)
                cbFindBellow75Percentage.Checked = false;

            FilterDataClassForPercentage();
        }

        private void cbFindBellow75Percentage_CheckedChanged(object sender, EventArgs e)
        {
            if (cbFindBellow75Percentage.Checked)
                cbFindAbove75Percentage.Checked = false;

            FilterDataClassForPercentage();
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
           var rds =  new ReportDataSource("dtListPresence", LoadDataTable());
            ReportViewerPrint.PrintDirecty(rds, "CourseManagement.ReportListPresence.rdlc");
        }

        private void FrmReportClass_KeyDown(object sender, KeyEventArgs e)
        {
            if(btnPrint.Enabled && e.Control && e.KeyCode == Keys.P) 
                btnPrint_Click(sender, e);
            else if(btnViewReport.Enabled && e.Shift && e.KeyCode == Keys.P)
                btnViewReport_Click(sender, e);
        }
    }
}