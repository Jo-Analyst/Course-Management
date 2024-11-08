﻿using DataBase;
using System;
using System.Data;
using System.Windows.Forms;

namespace CourseManagement
{
    public partial class FrmReportStudent : Form
    {
        public FrmReportStudent()
        {
            InitializeComponent();
        }

        int studentId;
        Student student = new Student();
        Class @class = new Class();
        ListAttendance listAttendance = new ListAttendance();

        private void cbClass_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                var dtStudent = Student.FindByClass(cbClass.Text).Rows;

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

        private void LoadCbClass()
        {
            var dtClasses = @class.FindAll();
            foreach (DataRow dr in dtClasses.Rows)
            {
                cbClass.Items.Add(dr["name"]);
            }
        }

        private void InitialFields()
        {
            lblNumberAttendance.Text = "0";
            lblNumberLack.Text = "0";
            pbPercentageCameIn.Value = 0;
            lblPercentageCameIn.Text = "0%";
        }

        private void GenerateReport()
        {
            try
            {
                studentId = int.Parse(student.FindByNameForClass(cbNameStudents.Text, cbClass.Text).Rows[0]["id"].ToString());
                DataTable dtListAttendance = listAttendance.GetStudentAttendanceValueSinceJoined(studentId);

                lblNumberAttendance.Text = dtListAttendance.Rows.Count > 0 ? dtListAttendance.Rows[0]["number_attendance"].ToString() : "0";
                lblNumberLack.Text = dtListAttendance.Rows.Count > 0 ? dtListAttendance.Rows[0]["number_absences"].ToString() : "0";


                int numberOfClasses = int.Parse(listAttendance.ObtainStudentAttendanceValueSinceTheBeginningOfTheCourse(class_id).Rows[0]["count_attendance"].ToString());

                CalculateAttendancePercentageFromStart(numberOfClasses);
                CalculatePercentageOfAttendanceSinceJoined(numberOfClasses);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CalculatePercentageOfAttendanceSinceJoined(int numberOfClasses) // Desde que entrou
        {
            int percentage = numberOfClasses > 0 ? Percentage.CalculatePercentageOfAttendanceSinceJoined(int.Parse(lblNumberAttendance.Text), int.Parse(lblNumberLack.Text)) : 0;
            lblPercentageCameIn.Text = $"{percentage}%";
            pbPercentageCameIn.Value = percentage;
        }

        private void CalculateAttendancePercentageFromStart(int numberOfClasses) // Desde o começo
        {
            int percentage = numberOfClasses > 0 ? Percentage.CalculateAttendancePercentageFromStart(int.Parse(lblNumberAttendance.Text), numberOfClasses) : 0;
            lblPercentageStart.Text = $"{percentage}%";
            pbPercentageStart.Value = percentage;
        }

        int class_id;

        private void cbStudents_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (cbClass.Items.Count == 0)
                    return;

                class_id = int.Parse(student.FindByNameForClass(cbNameStudents.Text, cbClass.Text).Rows[0]["class_id"].ToString());
                GenerateReport();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FrmReportStudent_Load(object sender, EventArgs e)
        {
            LoadCbClass();
        }
    }
}
