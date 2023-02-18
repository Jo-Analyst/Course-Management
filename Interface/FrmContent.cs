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
            new FrmSaveContent().ShowDialog();
            LoadDataContent();
        }

        Content content = new Content();

        private void FrmContent_Load(object sender, EventArgs e)
        {
            LoadDataContent();
        }

        private void LoadDataContent()
        {
            try
            {
                dgvContent.Rows.Clear();
                DataTable dtContent = !string.IsNullOrWhiteSpace(cbMatter.Text) ? content.FindByMatter(cbMatter.Text.Trim()) :  content.FindAll();

                foreach (DataRow dr in dtContent.Rows)
                {
                    int index = dgvContent.Rows.Add();
                    dgvContent.Rows[index].Cells["id"].Value = dr["id"].ToString();
                    dgvContent.Rows[index].Cells["wording"].Value = dr["wording"].ToString();
                    dgvContent.Rows[index].Cells["classStudent"].Value = dr["class"].ToString();
                    dgvContent.Rows[index].Cells["matter"].Value = dr["matter"].ToString();
                    dgvContent.Rows[index].Cells["date"].Value = dr["date"].ToString();
                    dgvContent.Rows[index].Cells["classId"].Value = dr["class_id"].ToString();
                    dgvContent.Rows[index].Height = 35;
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
                MessageBox.Show("Selecione o conteúdo", "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var saveStudent = new FrmSaveContent(int.Parse(dgvContent.CurrentRow.Cells["id"].Value.ToString()), dgvContent.CurrentRow.Cells["wording"].Value.ToString(), dgvContent.CurrentRow.Cells["matter"].Value.ToString(), dgvContent.CurrentRow.Cells["Date"].Value.ToString(), int.Parse(dgvContent.CurrentRow.Cells["classId"].Value.ToString()), dgvContent.CurrentRow.Cells["classStudent"].Value.ToString());
            saveStudent.ShowDialog();

            contentId = 0;
            dgvContent.ClearSelection();
            if (saveStudent.contentWasSaved)
                LoadDataContent();
        }

        private void dgvStudent_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                contentId = int.Parse(dgvContent.Rows[e.RowIndex].Cells["id"].Value.ToString());
            }
        }

        private void txtField_TextChanged(object sender, EventArgs e)
        {
            LoadDataContent();
        }

        private void rbName_CheckedChanged(object sender, EventArgs e)
        {
            LoadDataContent();
        }

        private void rbClass_CheckedChanged(object sender, EventArgs e)
        {
            LoadDataContent();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (contentId == 0)
            {
                MessageBox.Show("Selecione o conteúdo que deseja excluir", "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

          DialogResult dr = MessageBox.Show($"Deseja mesmo excluir o conteúdo?", "Exclusão", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dr == DialogResult.Yes)
            {
                content.Id = contentId;
                content.Delete();
                LoadDataContent();
            }

            contentId = 0;
            dgvContent.ClearSelection();

        }

        private void cbMatter_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadDataContent();
        }
    }
}
