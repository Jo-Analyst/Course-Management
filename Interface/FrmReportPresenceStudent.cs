using DataBase;
using System;
using System.Data;
using System.Windows.Forms;

namespace CourseManagement
{
    public partial class FrmReportPresenceStudent : Form
    {
        public FrmReportPresenceStudent()
        {
            InitializeComponent();
        }

        Student student = new Student();
        Class @class = new Class();
        ListAttendance listAttendance = new ListAttendance();

        private void cbClass_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                var dtStudent = student.FindByClass(cbClass.Text).Rows;

                cbNameStudents.Items.Clear();

                foreach (DataRow dr in dtStudent)
                {
                    cbNameStudents.Items.Add(dr["name"].ToString());
                }

                if (dtStudent.Count > 0)
                {
                    cbNameStudents.SelectedIndex = 0;
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



        private void cbStudents_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (cbClass.Items.Count == 0)
                    return;

                int student_id = int.Parse(student.FindByName(cbNameStudents.Text).Rows[0]["id"].ToString());
                LoadDgvListPresenceStudent(student_id);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadDgvListPresenceStudent(int student_id)
        {
            var dtGetListPresenceStudentByStudentId = listAttendance.GetListPresenceStudentByStudentId(student_id);
            dgvListPresence.Rows.Clear();
            foreach (DataRow dr in dtGetListPresenceStudentByStudentId.Rows)
            {
                int index = dgvListPresence.Rows.Add();
                dgvListPresence.Rows[index].Cells["presence"].Value = dr["presence"].ToString() == "1" ? Properties.Resources.Pictogrammers_Material_Checkbox_marked_outline_24 : Properties.Resources.Pictogrammers_Material_Checkbox_blank_outline_24;
                dgvListPresence.Rows[index].Cells["date"].Value = dr["date"].ToString();
                dgvListPresence.Rows[index].Cells["DetailsAbsence"].Value = dr["presence"].ToString() == "0" ? Properties.Resources.kebad : Properties.Resources.white;
                dgvListPresence.Rows[index].Cells["descriptionReasonForAbsence"].Value = string.IsNullOrEmpty(dr["description"].ToString()) ? "---" : dr["description"].ToString();
                dgvListPresence.Rows[index].Height = 35;
            }

            dgvListPresence.ClearSelection();
        }

        private void FrmReportStudent_Load(object sender, EventArgs e)
        {
            LoadCbClass();
        }

        private void dgvListPresence_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            dgvListPresence.ClearSelection();
        }

        private void dgvListPresence_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            dgvListPresence.ClearSelection();
        }

        private void SelectDgv(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                dgvListPresence.ClearSelection();
            }
        }

        private void dgvListPresence_CellMouseEnter(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex > -1)
                dgvListPresence.Cursor = e.ColumnIndex == 2 && dgvListPresence.Rows[e.RowIndex].Cells["presence"].Value.ToString() == "false" ? Cursors.Hand : Cursors.Default;
        }
    }
}
