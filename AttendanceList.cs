using DataBase;

namespace Attendance_List
{
    public partial class FrmAttendanceList : Form
    {
        public FrmAttendanceList()
        {
            InitializeComponent();
        }

        Student student = new Student();

        private void btnStudent_Click(object sender, EventArgs e)
        {
            if (student.FindAll().Rows.Count == 0)
            {
                MessageBox.Show("Não há cadastro");
            }
        }
    }
}