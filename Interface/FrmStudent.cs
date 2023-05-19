using DataBase;
using System;
using System.Data;
using System.Windows.Forms;

namespace CourseManagement
{
    public partial class FrmStudent : Form
    {
        int studentId;
        public FrmStudent()
        {
            InitializeComponent();
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            new FrmSaveStudent().ShowDialog();
            LoadDataStudent();
        }

        Student student = new Student();

        private void FrmStudent_Load(object sender, EventArgs e)
        {
            LoadDataStudent();
            new ToolTip().SetToolTip(btnNew, "Novo - [CTRL + N]");
        }

        private void LoadDataStudent()
        {
            try
            {
                dgvStudent.Rows.Clear();
                string option = rbName.Checked ? "nome" : "class";
                DataTable dtStudent = string.IsNullOrWhiteSpace(txtField.Text)
                    ? student.FindAll()
                    : student.FindByName(txtField.Text, option);

                foreach (DataRow dr in dtStudent.Rows)
                {
                    int index = dgvStudent.Rows.Add();
                    dgvStudent.Rows[index].Cells["Edit"].Value = Properties.Resources.Custom_Icon_Design_Flatastic_1_Edit_24;
                    dgvStudent.Rows[index].Cells["delete"].Value = Properties.Resources.trash_24_icon;
                    dgvStudent.Rows[index].Cells["id"].Value = dr["id"].ToString();
                    dgvStudent.Rows[index].Cells["name"].Value = dr["name"].ToString();
                    dgvStudent.Rows[index].Cells["classStudent"].Value = dr["class"].ToString();
                    dgvStudent.Rows[index].Cells["shift"].Value = dr["shift"].ToString();
                    dgvStudent.Rows[index].Cells["classId"].Value = dr["class_id"].ToString();
                    dgvStudent.Rows[index].Cells["gender"].Value = dr["gender"].ToString();
                    dgvStudent.Rows[index].Cells["created_at"].Value = dr["created_at"].ToString();
                    dgvStudent.Rows[index].Cells["updated_at"].Value = dr["updated_at"].ToString();
                    dgvStudent.Rows[index].Height = 35;
                }

                dgvStudent.ClearSelection();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void EditStudent()
        {
            var saveStudent = new FrmSaveStudent(int.Parse(dgvStudent.CurrentRow.Cells["id"].Value.ToString()), dgvStudent.CurrentRow.Cells["name"].Value.ToString(), dgvStudent.CurrentRow.Cells["shift"].Value.ToString(), dgvStudent.CurrentRow.Cells["classStudent"].Value.ToString(), dgvStudent.CurrentRow.Cells["gender"].Value.ToString());
            saveStudent.ShowDialog();

            studentId = 0;
            dgvStudent.ClearSelection();
            if (saveStudent.studentWasSaved)
                LoadDataStudent();
        }

        string genderStudent, nameStudent;
        private void dgvStudent_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                studentId = int.Parse(dgvStudent.Rows[e.RowIndex].Cells["id"].Value.ToString());
                nameStudent = dgvStudent.Rows[e.RowIndex].Cells["name"].Value.ToString();
                genderStudent = dgvStudent.Rows[e.RowIndex].Cells["gender"].Value.ToString();

                if (e.ColumnIndex == 0)
                    EditStudent();
                else if (e.ColumnIndex == 1)
                    Delete();
            }
        }

        private void txtField_TextChanged(object sender, EventArgs e)
        {
            LoadDataStudent();
        }

        private void rbName_CheckedChanged(object sender, EventArgs e)
        {
            LoadDataStudent();
        }

        private void rbClass_CheckedChanged(object sender, EventArgs e)
        {
            LoadDataStudent();
        }

        private void dgvStudent_CellMouseEnter(object sender, DataGridViewCellEventArgs e)
        {
            dgvStudent.Cursor = e.ColumnIndex == 0 || e.ColumnIndex == 1 ? Cursors.Hand : Cursors.Default;
        }

        private void FrmStudent_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.Control && e.KeyCode == Keys.N) {

                btnNew_Click(sender, e);
            }
        }

        private void Delete()
        {
            string article = genderStudent == "M" ? "o" : "a";
            string studentMorF = genderStudent == "M" ? "aluno" : "aluna";

            DialogResult dr = MessageBox.Show($"Deseja mesmo excluir {article} {studentMorF} {nameStudent} da base de dados?", "Exclusão", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dr == DialogResult.Yes)
            {
                student._id = studentId;
                student.Delete();
                LoadDataStudent();
            }

            studentId = 0;
            dgvStudent.ClearSelection();

        }
    }
}
