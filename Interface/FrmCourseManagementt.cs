using DataBase;
using System;
using System.Windows.Forms;

namespace CourseManagement
{
    public partial class FrmCourseManagementt : Form
    {
        public FrmCourseManagementt()
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

        Content content = new Content();
        private void btnContent_Click(object sender, EventArgs e)
        {
            if (content.FindAll().Rows.Count > 0)
                new FrmContent().ShowDialog();
            else
            {
                var saveContent = new FrmSaveContent();
                saveContent.ShowDialog();
                if (saveContent.contentWasSaved)
                {
                    new FrmContent().ShowDialog();
                }
            }

        }

        private void btnBackupAndRestore_Click(object sender, EventArgs e)
        {
            new FrmBackupAndRestore().ShowDialog();
        }

        private void FrmCourseManagementt_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void FrmCourseManagementt_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.Control && e.Shift && e.KeyCode == Keys.C)
                btnContent_Click((Control)sender, e);
            else if(e.Control && e.Shift && e.KeyCode == Keys.S)
                btnStudent_Click((Control)sender, e);
            else if(e.Control && e.Shift && e.KeyCode == Keys.T)
                btnClass_Click((Control)sender, e);
            else if(e.Control && e.Alt && e.KeyCode == Keys.P)
                btnPresence_Click((Control)sender, e);
            else if(e.Control && e.Shift && e.KeyCode == Keys.R)
                btnReport_Click((Control)sender, e);
            else if(e.Control && e.Shift && e.KeyCode == Keys.B)
                btnBackupAndRestore_Click((Control)sender, e);
        }
    }
}
