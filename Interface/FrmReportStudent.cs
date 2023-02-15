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
    public partial class FrmReportStudent : Form
    {
        public FrmReportStudent()
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
                var dtStudent = student.FindByClass(cbClasses.Text).Rows;

                cbNameStudents.Items.Clear();

                foreach (DataRow dr in dtStudent)
                {
                    cbNameStudents.Items.Add(dr["name"].ToString());
                }

                InitialFields();

                if (dtStudent.Count > 0)
                {
                    cbNameStudents.SelectedIndex = 0;
                    GenerateReport();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void InitialFields()
        {
            lblNumberAttendance.Text = "0";
            lblNumberLack.Text = "0";
            pbPercentage.Value = 0;
            lblPercentage.Text = "0%";
        }

        private void GenerateReport()
        {
            try
            {
                studentId = student.FindByNameForClass(cbNameStudents.Text, cbClasses.Text);
                DataTable dtListAttendance = listAttendance.GetStudentAttendanceAmount(studentId);
               
                lblNumberAttendance.Text = dtListAttendance.Rows.Count > 0 ? dtListAttendance.Rows[0]["number_attendance"].ToString() : "0";
                lblNumberLack.Text = dtListAttendance.Rows.Count > 0 ? dtListAttendance.Rows[0]["number_absences"].ToString() : "0";
               
                int percentage =  Utils.CalculatePercentage(int.Parse(lblNumberAttendance.Text), int.Parse(lblNumberLack.Text));
                lblPercentage.Text = $"{percentage}%";
                pbPercentage.Value = percentage;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

       private void cbStudents_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbClasses.Items.Count == 0)
                return;

            GenerateReport();
        }
    }
}
