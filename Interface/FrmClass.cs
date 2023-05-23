using DataBase;
using System;
using System.Data;
using System.Windows.Forms;

namespace CourseManagement
{
    public partial class FrmClass : Form
    {
        int classId;
        public FrmClass()
        {
            InitializeComponent();
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            new FrmSaveClass().ShowDialog();
            LoadDataClass();
        }

        Class @class = new Class();

        private void FrmClass_Load(object sender, EventArgs e)
        {
            LoadDataClass();
            new ToolTip().SetToolTip(btnNew, "Novo - [CTRL + N]");
        }

        private void LoadDataClass()
        {
            dgvClass.Rows.Clear();
            DataTable dtClass = string.IsNullOrWhiteSpace(txtField.Text)
                ? @class.FindAll()
                : @class.FindByClass(txtField.Text);

            foreach (DataRow dr in dtClass.Rows)
            {
                int index = dgvClass.Rows.Add();
                dgvClass.Rows[index].Cells["edit"].Value = Properties.Resources.Custom_Icon_Design_Flatastic_1_Edit_24;
                dgvClass.Rows[index].Cells["delete"].Value = Properties.Resources.trash_24_icon;
                dgvClass.Rows[index].Cells["id"].Value = dr["id"].ToString();
                dgvClass.Rows[index].Cells["name"].Value = dr["name"].ToString();
                dgvClass.Rows[index].Cells["shift"].Value = dr["shift"].ToString();
                dgvClass.Rows[index].Height = 35;
            }

            dgvClass.ClearSelection();
        }

        string nameClass;
        private void dgvClass_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                classId = int.Parse(dgvClass.Rows[e.RowIndex].Cells["id"].Value.ToString());
                nameClass = dgvClass.Rows[e.RowIndex].Cells["name"].Value.ToString();

                if (e.ColumnIndex == 0)
                {
                    var saveClass = new FrmSaveClass(int.Parse(dgvClass.CurrentRow.Cells["id"].Value.ToString()), dgvClass.CurrentRow.Cells["name"].Value.ToString(), dgvClass.CurrentRow.Cells["shift"].Value.ToString());
                    saveClass.ShowDialog();

                    classId = 0;
                    dgvClass.ClearSelection();
                    if (saveClass.classWasSaved)
                        LoadDataClass();
                }
                else if (e.ColumnIndex == 1)
                {
                    DialogResult dr = MessageBox.Show($"Deseja mesmo excluir a turma {nameClass}? Está ciente que poderá excluir também os alunos relacionados a turma {nameClass}?", "Exclusão", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (dr == DialogResult.Yes)
                    {
                        @class.Id = classId;
                        @class.Delete();
                        LoadDataClass();
                    }

                    classId = 0;
                    dgvClass.ClearSelection();
                }
            }
        }

        private void txtField_TextChanged(object sender, EventArgs e)
        {
            LoadDataClass();
        }

        private void rbName_CheckedChanged(object sender, EventArgs e)
        {
            LoadDataClass();
        }

        private void rbClass_CheckedChanged(object sender, EventArgs e)
        {
            LoadDataClass();
        }

        private void dgvClass_CellMouseEnter(object sender, DataGridViewCellEventArgs e)
        {
            dgvClass.Cursor = e.ColumnIndex == 0 || e.ColumnIndex == 1 ? Cursors.Hand : Cursors.Default;
        }

        private void FrmClass_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.N)
                btnNew_Click(sender, e);
        }
    }
}
