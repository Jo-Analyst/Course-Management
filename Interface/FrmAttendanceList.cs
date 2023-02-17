using DataBase;
using System;
using System.Windows.Forms;

namespace Interface
{
    public partial class FrmAttendanceList : Form
    {
        public FrmAttendanceList()
        {
            InitializeComponent();
        }

        Student student = new Student();
        Class @class = new Class();

        private void btnStudent_Click(object sender, EventArgs e)
        {
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

        private void btnReport_Click(object sender, EventArgs e)
        {
            new FrmReport().ShowDialog();
        }

        private void btnClass_Click(object sender, EventArgs e)
        {
            Class @class = new Class();


            if (@class.FindAll().Rows.Count > 0)
            {
                new FrmClass().ShowDialog();
                return;
            }

            var saveClass = new FrmSaveClass();
            saveClass.ShowDialog();
            if (saveClass.classWasSaved)
            {
                new FrmClass().ShowDialog();
            }
        }
    }
}
