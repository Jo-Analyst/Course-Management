﻿using DataBase;
using System;
using System.Windows.Forms;

namespace CourseManagement
{
    public partial class FrmReport : Form
    {
        public FrmReport()
        {
            InitializeComponent();
        }

        private void btnStudent_Click(object sender, EventArgs e)
        {
            new FrmReportStudent().ShowDialog();
        }

        private void btnClass_Click(object sender, EventArgs e)
        {
            new FrmReportClass().ShowDialog();
        }

        private void FrmReport_Load(object sender, EventArgs e)
        {
            lblQuantityStudentsRegistered.Text += Student.FindAllStudentRegistered().Rows.Count.ToString();
            lblQuantityStudentsActived.Text += new Student().FindAllStudentActive().Rows.Count.ToString();
        }

        private void btnListPresence_Click(object sender, EventArgs e)
        {
            new FrmReportPresenceStudent().ShowDialog();
        }

        private void FrmReport_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.S)
                btnStudent_Click(sender, e);
            else if (e.Control && e.KeyCode == Keys.T)
                btnClass_Click(sender, e);
            else if (e.Control && e.KeyCode == Keys.L)
                btnListPresence_Click(sender, e);
        }
    }
}
