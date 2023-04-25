using DataBase;
using System;
using System.Data;
using System.Windows.Forms;

namespace CourseManagement
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
                DataTable dtContent = !string.IsNullOrWhiteSpace(cbMatter.Text) ? content.FindByMatter(cbMatter.Text.Trim()) : content.FindAll();

                foreach (DataRow dr in dtContent.Rows)
                {
                    int index = dgvContent.Rows.Add();
                    dgvContent.Rows[index].Cells["edit"].Value = Properties.Resources.Custom_Icon_Design_Flatastic_1_Edit_24;
                    dgvContent.Rows[index].Cells["delete"].Value = Properties.Resources.trash_24_icon;
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

        private void Edit()
        {
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

                if (e.ColumnIndex == 0)
                    Edit();
                else if (e.ColumnIndex == 1)
                    Delete();
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

        private void Delete()
        {
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

        private void dgvContent_CellMouseEnter(object sender, DataGridViewCellEventArgs e)
        {
            dgvContent.Cursor = e.ColumnIndex == 0 || e.ColumnIndex == 1 ? Cursors.Hand : Cursors.Default;
        }
    }
}
