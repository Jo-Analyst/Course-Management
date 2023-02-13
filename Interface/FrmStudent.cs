using DataBase;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Interface
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
        }

        private void LoadDataStudent()
        {
            dgvStudent.Rows.Clear();
            foreach (DataRow dr in student.FindAll().Rows)
            {
                int index = dgvStudent.Rows.Add();
                dgvStudent.Rows[index].Cells["id"].Value = dr["id"].ToString();
                dgvStudent.Rows[index].Cells["name"].Value = dr["name"].ToString();
                dgvStudent.Rows[index].Cells["classStudent"].Value = dr["class"].ToString();
                dgvStudent.Rows[index].Cells["gender"].Value = dr["gender"].ToString();
                dgvStudent.Rows[index].Selected = false;
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (studentId == 0)
            {
                MessageBox.Show("Selecione o dado do aluno que deseja editar", "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var saveStudent = new FrmSaveStudent(int.Parse(dgvStudent.CurrentRow.Cells["id"].Value.ToString()));
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
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (studentId == 0)
            {
                MessageBox.Show("Selecione o dado do aluno que deseja excluir", "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

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
