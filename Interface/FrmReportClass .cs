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
                lblQtdClasses.Text = $"Quantidades de aulas prestadas: {attendance.CountPresenceForClass(class_id)}";
                dgvReportClass.ClearSelection();
                btnViewReport.Enabled = dgvReportClass.Rows.Count > 0 ? true : false;
                LoadDataTable();
                if(cbFindAbove75Percentage.Checked || cbFindBellow75Percentage.Checked)
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
                        dataFiltedAbove75Percentage.Rows[indexDataFiltedAbove75Percentage]["numberOfAttendence"] = row["numberOfAttendence"].ToString();
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
                        dataFiltedBellow75Percentage.Rows[indexDataFiltedBellow75Percentage]["numberOfAttendence"] = row["numberOfAttendence"].ToString();
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
                dgvReportClass.Rows[index].Cells["numberOfAttendence"].Value = row["numberOfAttendence"].ToString();
                dgvReportClass.Rows[index].Cells["numberOfAbsences"].Value = row["numberOfAbsences"].ToString();
                dgvReportClass.Rows[index].Cells["percentageStart"].Value = row["percentageStart"].ToString();
                dgvReportClass.Rows[index].Cells["percentageCameIn"].Value = row["percentageCameIn"].ToString();
                dgvReportClass.Rows[index].Height = 35;
            }

            dgvReportClass.ClearSelection();
        }

        private DataTable getDataTableAfterFiltering()
        {
            DataTable dt;
            if (cbFindAbove75Percentage.Checked)
                dt = dataFiltedAbove75Percentage;

            else if (cbFindBellow75Percentage.Checked)
                dt = dataFiltedBellow75Percentage;
            else
                dt = dataTable;

            return dt;
        }

        private void LoadDataTable()
        {
            dataTable.Rows.Clear();
            for (int i = 0; i < dgvReportClass.Rows.Count; i++)
            {
                dataTable.Rows.Add();
                dataTable.Rows[i]["name"] = dgvReportClass.Rows[i].Cells["name"].Value.ToString();
                dataTable.Rows[i]["class"] = dgvReportClass.Rows[i].Cells["classStudent"].Value.ToString();
                dataTable.Rows[i]["shift"] = dgvReportClass.Rows[i].Cells["shift"].Value.ToString();
                dataTable.Rows[i]["numberOfAttendence"] = dgvReportClass.Rows[i].Cells["numberOfAttendence"].Value.ToString();
                dataTable.Rows[i]["numberOfAbsences"] = dgvReportClass.Rows[i].Cells["numberOfAbsences"].Value.ToString();
                dataTable.Rows[i]["percentageStart"] = dgvReportClass.Rows[i].Cells["percentageStart"].Value.ToString();
                dataTable.Rows[i]["percentageCameIn"] = dgvReportClass.Rows[i].Cells["percentageCameIn"].Value.ToString();
            }
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
                new FrmViewReport(rds).ShowDialog();
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

            foreach (DataRow dr in dt.Rows)
            {
                view = new ViewStudentReport();
                view.StudentName = dr["name"].ToString();
                view.StudentClass = dr["class"].ToString();
                view.StudentShift = dr["shift"].ToString();
                view.StudentNumberOfAttendance = int.Parse(dr["numberOfAttendence"].ToString());
                view.StudentNumberOfAbsences = int.Parse(dr["numberOfAbsences"].ToString());
                view.percentageStart = dr["percentageStart"].ToString();
                view.percentageCameIn = dr["percentageCameIn"].ToString();


                lst.Add(view);
            }

            rds.Name = "DataSet1";
            rds.Value = lst;
        }

        private void FrmReportClass_Load(object sender, EventArgs e)
        {
            LoadCbClass();
            CreateColumsDataTable();
            CreateColumsDataTableFiltedData();
        }

        private void CreateColumsDataTable()
        {
            dataTable.Columns.Add("name", typeof(string));
            dataTable.Columns.Add("class", typeof(string));
            dataTable.Columns.Add("shift", typeof(string));
            dataTable.Columns.Add("numberOfAttendence", typeof(string));
            dataTable.Columns.Add("numberOfAbsences", typeof(string));
            dataTable.Columns.Add("percentageStart", typeof(string));
            dataTable.Columns.Add("percentageCameIn", typeof(string));
        }
        
        private void CreateColumsDataTableFiltedData()
        {
            dataFiltedAbove75Percentage.Columns.Add("name", typeof(string));
            dataFiltedAbove75Percentage.Columns.Add("class", typeof(string));
            dataFiltedAbove75Percentage.Columns.Add("shift", typeof(string));
            dataFiltedAbove75Percentage.Columns.Add("numberOfAttendence", typeof(string));
            dataFiltedAbove75Percentage.Columns.Add("numberOfAbsences", typeof(string));
            dataFiltedAbove75Percentage.Columns.Add("percentageStart", typeof(string));
            dataFiltedAbove75Percentage.Columns.Add("percentageCameIn", typeof(string));
           
            dataFiltedBellow75Percentage.Columns.Add("name", typeof(string));
            dataFiltedBellow75Percentage.Columns.Add("class", typeof(string));
            dataFiltedBellow75Percentage.Columns.Add("shift", typeof(string));
            dataFiltedBellow75Percentage.Columns.Add("numberOfAttendence", typeof(string));
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
    }
}