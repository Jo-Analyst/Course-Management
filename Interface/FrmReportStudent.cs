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
                lblNumberAttendance.Text = listAttendance.GetStudentAttendanceAmount(studentId).ToString();
                lblNumberLack.Text = listAttendance.GetNumberOfAbsencesFromTheStudent(studentId).ToString();
                CalculatePercentage(int.Parse(lblNumberAttendance.Text), int.Parse(lblNumberLack.Text));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CalculatePercentage(int numberAttendance, int numberLack)
        {
            int numberOfClasses = numberAttendance + numberLack;
            int percentage = (numberAttendance * 100) / numberOfClasses;
            lblPercentage.Text = $"{percentage}%";
            pbPercentage.Value = percentage;
        }

        private void cbStudents_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbClasses.Items.Count == 0)
                return;

            GenerateReport();
        }
    }
}
