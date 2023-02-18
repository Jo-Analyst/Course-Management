using DataBase;
using System;
using System.Data;
using System.Windows.Forms;

namespace Interface
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
                dgvClass.Rows[index].Cells["id"].Value = dr["id"].ToString();
                dgvClass.Rows[index].Cells["name"].Value = dr["name"].ToString();
                dgvClass.Rows[index].Cells["shift"].Value = dr["shift"].ToString();
                dgvClass.Rows[index].Height = 35;
            }

            dgvClass.ClearSelection();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (classId == 0)
            {
                MessageBox.Show("Selecione a turma que deseja editar", "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var saveClass = new FrmSaveClass(int.Parse(dgvClass.CurrentRow.Cells["id"].Value.ToString()), dgvClass.CurrentRow.Cells["name"].Value.ToString(), dgvClass.CurrentRow.Cells["shift"].Value.ToString());
            saveClass.ShowDialog();

            classId = 0;
            dgvClass.ClearSelection();
            if (saveClass.classWasSaved)
                LoadDataClass();
        }

        string genderClass, nameClass;
        private void dgvClass_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                classId = int.Parse(dgvClass.Rows[e.RowIndex].Cells["id"].Value.ToString());
                nameClass = dgvClass.Rows[e.RowIndex].Cells["name"].Value.ToString();
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
    }
}
