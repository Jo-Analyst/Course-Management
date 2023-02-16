using DataBase;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Interface
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
        DataTable dataTable = new DataTable();
        Class @class = new Class();

        private void cbClasses_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                DataTable dtStudents = cbClass.Text.ToLower() == "todos" ? student.FindAll() : student.FindByClass(cbClass.Text);
                dgvReportClass.Rows.Clear();
                DataTable dtStudent;
                foreach (DataRow dr in dtStudents.Rows)
                {
                    dtStudent = listAttendance.GetStudentAttendanceAmount(int.Parse(dr["id"].ToString()));
                    if (dtStudent.Rows.Count == 0)
                        dgvReportClass.Rows.Add(dtStudents.Rows[dtStudents.Rows.Count - 1]["id"], dtStudents.Rows[dtStudents.Rows.Count - 1]["name"], dtStudents.Rows[dtStudents.Rows.Count - 1]["class"], dtStudents.Rows[dtStudents.Rows.Count - 1]["shift"], "0", "0", "0%");

                    else
                        dgvReportClass.Rows.Add(dtStudent.Rows[0]["id"], dtStudent.Rows[0]["name"], dtStudent.Rows[0]["class"], dtStudent.Rows[0]["shift"], dtStudent.Rows[0]["number_attendance"], dtStudent.Rows[0]["number_absences"], $"{Utils.CalculatePercentage(int.Parse(dtStudent.Rows[0]["number_attendance"].ToString()), int.Parse(dtStudent.Rows[0]["number_absences"].ToString()))}%");
                }

                dgvReportClass.ClearSelection();
                btnViewReport.Enabled = dgvReportClass.Rows.Count > 0 ? true : false;
                btnPrintReport.Enabled = dgvReportClass.Rows.Count > 0 ? true : false;
                LoadDataTable();
                class_id = int.Parse(@class.FindByClass(cbClass.Text).Rows[0]["id"].ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadDataTable()
        {         
            dataTable.Rows.Clear();
            for (int i = 0; i < dgvReportClass.Rows.Count; i++)
            {
                dataTable.Rows.Add();
                dataTable.Rows[i]["id"] = dgvReportClass.Rows[i].Cells["id"].Value.ToString();
                dataTable.Rows[i]["name"] = dgvReportClass.Rows[i].Cells["name"].Value.ToString();
                dataTable.Rows[i]["class"] = dgvReportClass.Rows[i].Cells["classStudent"].Value.ToString();
                dataTable.Rows[i]["shift"] = dgvReportClass.Rows[i].Cells["shift"].Value.ToString();
                dataTable.Rows[i]["numberOfAttendence"] = dgvReportClass.Rows[i].Cells["numberOfAttendence"].Value.ToString();
                dataTable.Rows[i]["numberOfAbsences"] = dgvReportClass.Rows[i].Cells["numberOfAbsences"].Value.ToString();
                dataTable.Rows[i]["percentage"] = dgvReportClass.Rows[i].Cells["percentage"].Value.ToString();
            }
        }

        private void GenerateReport()
        {
            try
            {

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            new FrmViewReport(dataTable).ShowDialog();
        }

        private void FrmReportClass_Load(object sender, EventArgs e)
        {
            LoadCbClass();
            CreateColumsDataTable();
        }

        private void CreateColumsDataTable()
        {
            dataTable.Columns.Add("id", typeof(string));
            dataTable.Columns.Add("name", typeof(string));
            dataTable.Columns.Add("class", typeof(string));
            dataTable.Columns.Add("shift", typeof(string));
            dataTable.Columns.Add("numberOfAttendence", typeof(string));
            dataTable.Columns.Add("numberOfAbsences", typeof(string));
            dataTable.Columns.Add("percentage", typeof(string));
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
    }
}
