using DataBase;
using System;
using System.IO;
using System.Windows.Forms;

namespace Interface
{
    public partial class FrmAttendanceList : Form
    {
        public FrmAttendanceList()
        {
            InitializeComponent();
        }

        private void btnStudent_Click(object sender, EventArgs e)
        {
            Student student = new Student();


            if (student.FindAll().Rows.Count > 0)
            {
                new FrmStudent().ShowDialog();
                return;
            }

            var saveStudent = new FrmSaveStudent();
            saveStudent.ShowDialog();
            if (saveStudent.studentWasSaved)
            {
                new FrmStudent().ShowDialog();
            }
        }

        private void btnPresence_Click(object sender, EventArgs e)
        {
            new FrmPresence().ShowDialog();
        }
    }
}
