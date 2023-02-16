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

        int studentId;
        Student student = new Student();
        ListAttendance listAttendance = new ListAttendance();
        

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
                        dgvReportClass.Rows.Add(dtStudents.Rows[dtStudents.Rows.Count -1]["id"], dtStudents.Rows[dtStudents.Rows.Count - 1]["name"], dtStudents.Rows[dtStudents.Rows.Count - 1]["class"], "0", "0", "0%");
                        
                    else
                        dgvReportClass.Rows.Add(dtStudent.Rows[0]["id"], dtStudent.Rows[0]["name"], dtStudent.Rows[0]["class"], dtStudent.Rows[0]["number_attendance"], dtStudent.Rows[0]["number_absences"], $"{Utils.CalculatePercentage(int.Parse(dtStudent.Rows[0]["number_attendance"].ToString()), int.Parse(dtStudent.Rows[0]["number_absences"].ToString()))}%");
                }
             
                dgvReportClass.ClearSelection();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void FrmReportClass_Load(object sender, EventArgs e)
        {
            LoadCbClass();
        }

        Class @class= new Class();

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
