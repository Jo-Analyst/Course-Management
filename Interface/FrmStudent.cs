using DataBase;
using Microsoft.Reporting.WinForms;
using System;
using System.Data;
using System.Reflection;
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
            cbFilter.SelectedIndex = 0;
            LoadDataStudent();
            new ToolTip().SetToolTip(btnNew, "Novo - [CTRL + N]");
        }

        DataTable dtStudent;

        ReportDataSource reportDataSource;
        private void LoadDataStudent()
        {
            try
            {
                dgvStudent.Rows.Clear();
                string option = rbName.Checked ? "nome" : "class";
                bool filtredFieldByClass = cbFilter.SelectedIndex <= 0 ? false : true;
                dtStudent = string.IsNullOrWhiteSpace(txtField.Text)
                    ? student.FindAll(filtredFieldByClass, cbActivesStudents.Checked)
                    : student.FindByName(txtField.Text, option, filtredFieldByClass, cbActivesStudents.Checked);

                foreach (DataRow dr in dtStudent.Rows)
                {
                    int index = dgvStudent.Rows.Add();
                    dgvStudent.Rows[index].Cells["Edit"].Value = Properties.Resources.Custom_Icon_Design_Flatastic_1_Edit_24;
                    dgvStudent.Rows[index].Cells["delete"].Value = Properties.Resources.trash_24_icon;
                    dgvStudent.Rows[index].Cells["id"].Value = dr["id"].ToString();
                    dgvStudent.Rows[index].Cells["name"].Value = dr["name"].ToString();
                    dgvStudent.Rows[index].Cells["classStudent"].Value = dr["class"].ToString();
                    dgvStudent.Rows[index].Cells["shift"].Value = dr["shift"].ToString();
                    dgvStudent.Rows[index].Cells["CPF"].Value = string.IsNullOrEmpty(dr["CPF"].ToString()) ? string.Empty : Security.Dry(dr["CPF"].ToString());
                    dgvStudent.Rows[index].Cells["Level"].Value = dr["level"].ToString();
                    dgvStudent.Rows[index].Cells["classId"].Value = dr["class_id"].ToString();
                    dgvStudent.Rows[index].Cells["gender"].Value = dr["gender"].ToString();
                    dgvStudent.Rows[index].Cells["active"].Value = dr["active"].ToString() == "1" ? "True" : "False";
                    dgvStudent.Rows[index].Cells["activeImage"].Value = dr["active"].ToString() == "1" ? Properties.Resources.Pictogrammers_Material_Checkbox_marked_outline_24 : Properties.Resources.Pictogrammers_Material_Checkbox_blank_outline_24;
                    dgvStudent.Rows[index].Cells["created_at"].Value = dr["created_at"].ToString();
                    dgvStudent.Rows[index].Cells["updated_at"].Value = dr["updated_at"].ToString();
                    dgvStudent.Rows[index].Height = 35;
                }

                dgvStudent.ClearSelection();
                txtField.Focus();
                btnPrint.Enabled = dtStudent.Rows.Count == 0 ? false : true;
                btnViewList.Enabled = dtStudent.Rows.Count == 0 ? false : true;
                reportDataSource = NewReportDataSource();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void EditStudent()
        {
            var saveStudent = new FrmSaveStudent(int.Parse(dgvStudent.CurrentRow.Cells["id"].Value.ToString()), dgvStudent.CurrentRow.Cells["name"].Value.ToString(), dgvStudent.CurrentRow.Cells["shift"].Value.ToString(), dgvStudent.CurrentRow.Cells["classStudent"].Value.ToString(), dgvStudent.CurrentRow.Cells["gender"].Value.ToString(), dgvStudent.CurrentRow.Cells["CPF"].Value.ToString(), dgvStudent.CurrentRow.Cells["Level"].Value.ToString());
            saveStudent.ShowDialog();

            studentId = 0;
            dgvStudent.ClearSelection();
            if (saveStudent.studentWasSaved)
                LoadDataStudent();
        }

        string genderStudent, nameStudent;
        private void dgvStudent_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex > -1)
                {
                    studentId = int.Parse(dgvStudent.Rows[e.RowIndex].Cells["id"].Value.ToString());
                    nameStudent = dgvStudent.Rows[e.RowIndex].Cells["name"].Value.ToString();
                    genderStudent = dgvStudent.Rows[e.RowIndex].Cells["gender"].Value.ToString();
                    dgvStudent.Rows[e.RowIndex].Cells["activeImage"].Value = !Convert.ToBoolean(dgvStudent.Rows[e.RowIndex].Cells["active"].Value) ? Properties.Resources.Pictogrammers_Material_Checkbox_marked_outline_24 : Properties.Resources.Pictogrammers_Material_Checkbox_blank_outline_24;
                    dgvStudent.Rows[e.RowIndex].Cells["active"].Value = !Convert.ToBoolean(dgvStudent.Rows[e.RowIndex].Cells["active"].Value) ? "True" : "False";

                    if (e.ColumnIndex == 0)
                        EditStudent();
                    else if (e.ColumnIndex == 1)
                        Delete();
                    else if (e.ColumnIndex == 12)
                        Student.ToggleActiveStudent(studentId, Convert.ToBoolean(dgvStudent.Rows[e.RowIndex].Cells["active"].Value));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtField_TextChanged(object sender, EventArgs e)
        {
            LoadDataStudent();
        }

        private void rbName_CheckedChanged(object sender, EventArgs e)
        {
            txtField.Focus();
            if (!string.IsNullOrEmpty(txtField.Text))
                LoadDataStudent();
        }

        private void rbClass_CheckedChanged(object sender, EventArgs e)
        {
            txtField.Focus();
            if (!string.IsNullOrEmpty(txtField.Text))
                LoadDataStudent();
        }

        private void dgvStudent_CellMouseEnter(object sender, DataGridViewCellEventArgs e)
        {
            dgvStudent.Cursor = e.ColumnIndex == 0 || e.ColumnIndex == 1 || e.ColumnIndex == 12 ? Cursors.Hand : Cursors.Default;
        }

        private void FrmStudent_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.N)
                btnNew_Click(sender, e);
            else if (btnViewList.Enabled && e.Control && e.Shift && e.KeyCode == Keys.P)
                btnViewList_Click(sender, e);
            else if (btnPrint.Enabled && e.Control && e.KeyCode == Keys.P)
                btnPrint_Click(sender, e);
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            ReportViewerPrint.PrintDirecty(reportDataSource, "CourseManagement.Lista de Alunos.rdlc");
        }

        private ReportDataSource NewReportDataSource()
        {
            return new ReportDataSource("dtStudents", getStudents(dtStudent));
        }

        private DataTable getStudents(DataTable dtStudents)
        {
            var ds = dtStudents;
            int index = 0;
            foreach (DataRow dr in dtStudents.Rows)
            {
                ds.Rows[index]["CPF"] = string.IsNullOrEmpty(dr["CPF"].ToString()) ? "" : Security.Dry(dr["CPF"].ToString());
                index++;
            }

            return ds;
        }

        private void btnViewList_Click(object sender, EventArgs e)
        {
            new FrmViewReport(reportDataSource, "CourseManagement.Lista de Alunos.rdlc").ShowDialog();
        }

        private void cbFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadDataStudent();
        }

        private void cbActivesStudents_CheckedChanged(object sender, EventArgs e)
        {
            FrmStudent_Load(sender, e);
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
