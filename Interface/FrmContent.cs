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
            LoadClass();
            new ToolTip().SetToolTip(btnNew, "Novo - [CTRL + N]");
        }

        Class @class = new Class();

        private void LoadClass()
        {
            try
            {
                var dtClasses = @class.FindAll();
                cbClass.Items.Add("");
                foreach (DataRow dr in dtClasses.Rows)
                {
                    cbClass.Items.Add(dr["name"]);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Question);
            }
        }

        private void LoadDataContent()
        {
            try
            {
                dgvContent.Rows.Clear();
                DataTable dtContent = !string.IsNullOrWhiteSpace(cbMatter.Text) || !string.IsNullOrWhiteSpace(cbClass.Text) ? content.FindByMatter(cbMatter.Text.Trim(), cbClass.Text) : content.FindAll();

                foreach (DataRow dr in dtContent.Rows)
                {
                    int index = dgvContent.Rows.Add();
                    dgvContent.Rows[index].Cells["ColEdit"].Value = Properties.Resources.Custom_Icon_Design_Flatastic_1_Edit_24;
                    dgvContent.Rows[index].Cells["ColDelete"].Value = Properties.Resources.trash_24_icon;
                    dgvContent.Rows[index].Cells["ColId"].Value = dr["id"].ToString();
                    dgvContent.Rows[index].Cells["ColWording"].Value = dr["wording"].ToString();
                    dgvContent.Rows[index].Cells["ColClass"].Value = dr["class"].ToString();
                    dgvContent.Rows[index].Cells["ColMatter"].Value = dr["matter"].ToString();
                    dgvContent.Rows[index].Cells["ColDate"].Value = dr["date"].ToString();
                    dgvContent.Rows[index].Cells["ColClassId"].Value = dr["class_id"].ToString();
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
            var saveStudent = new FrmSaveContent(int.Parse(dgvContent.CurrentRow.Cells["ColId"].Value.ToString()), dgvContent.CurrentRow.Cells["ColWording"].Value.ToString(), dgvContent.CurrentRow.Cells["ColMatter"].Value.ToString(), dgvContent.CurrentRow.Cells["ColDate"].Value.ToString(), int.Parse(dgvContent.CurrentRow.Cells["ColClassId"].Value.ToString()), dgvContent.CurrentRow.Cells["ColClass"].Value.ToString());
            saveStudent.ShowDialog();

            contentId = 0;
            dgvContent.ClearSelection();
            if (saveStudent.contentWasSaved)
                LoadDataContent();
        }

        private void dgvContent_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                contentId = int.Parse(dgvContent.Rows[e.RowIndex].Cells["ColId"].Value.ToString());

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

        private void cbClass_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadDataContent();
        }

        private void FrmContent_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.N)
                btnNew_Click(sender, e);
        }
    }
}
