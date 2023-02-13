using DataBase;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
            Student student= new Student();
            student._connectionString = $@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename={Path.GetDirectoryName(Application.ExecutablePath)}\dbAttendanceList.mdf;Integrated Security=True";
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
    }
}
