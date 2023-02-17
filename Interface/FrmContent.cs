using DataBase;
using System;
using System.Data;
using System.Windows.Forms;

namespace Interface
{
    public partial class FrmContent : Form
    {
        int contentId;
        public FrmContent()
        {
            InitializeComponent();
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            new FrmSaveStudent().ShowDialog();
            LoadDataStudent();
        }

        Content content = new Content();

        private void FrmStudent_Load(object sender, EventArgs e)
        {
            LoadDataStudent();
        }

        private void LoadDataStudent()
        {
            try
            {
                dgvContent.Rows.Clear();
                DataTable dtContent = content.FindAll();

                foreach (DataRow dr in dtContent.Rows)
                {
                    int index = dgvContent.Rows.Add();
                    dgvContent.Rows[index].Cells["id"].Value = dr["id"].ToString();
                    dgvContent.Rows[index].Cells["name"].Value = dr["name"].ToString();
                    dgvContent.Rows[index].Cells["classStudent"].Value = dr["class"].ToString();
                    dgvContent.Rows[index].Cells["shift"].Value = dr["shift"].ToString();
                    dgvContent.Rows[index].Cells["classId"].Value = dr["class_id"].ToString();
                    dgvContent.Rows[index].Cells["gender"].Value = dr["gender"].ToString();
                }

                dgvContent.ClearSelection();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (contentId == 0)
            {
                MessageBox.Show("Selecione o dado do aluno que deseja editar", "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            //var saveStudent = new FrmSaveContent(int.Parse(dgvContent.CurrentRow.Cells["id"].Value.ToString()), dgvContent.CurrentRow.Cells["wording"].Value.ToString(), dgvContent.CurrentRow.Cells["matter"].Value.ToString(), dgvContent.CurrentRow.Cells["Date"].Value.ToString(), dgvContent.CurrentRow.Cells["gender"].Value.ToString());
            //saveStudent.ShowDialog();

            //studentId = 0;
            //dgvContent.ClearSelection();
            //if (saveStudent.studentWasSaved)
            //    LoadDataStudent();
        }

        string genderStudent, nameStudent;
        private void dgvStudent_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                contentId = int.Parse(dgvContent.Rows[e.RowIndex].Cells["id"].Value.ToString());
                nameStudent = dgvContent.Rows[e.RowIndex].Cells["name"].Value.ToString();
                genderStudent = dgvContent.Rows[e.RowIndex].Cells["gender"].Value.ToString();
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

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (contentId == 0)
            {
                MessageBox.Show("Selecione o conteúdo que deseja excluir", "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

          DialogResult dr = MessageBox.Show($"Deseja mesmo excluir o conteúdo", "Exclusão", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dr == DialogResult.Yes)
            {
                content.Id = contentId;
                content.Delete();
                LoadDataStudent();
            }

            contentId = 0;
            dgvContent.ClearSelection();

        }
    }
}
