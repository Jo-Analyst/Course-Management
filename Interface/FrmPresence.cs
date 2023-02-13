using DataBase;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Interface
{
    public partial class FrmPresence : Form
    {
        public FrmPresence()
        {
            InitializeComponent();
            student._connectionString = $@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename={Path.GetDirectoryName(Application.ExecutablePath)}\dbAttendanceList.mdf;Integrated Security=True";
        }

        Student student = new Student();
        private void cbClass_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                var lengthStudents = student.FindByClass(cbClass.Text).Rows.Count;
                var dataStudent = student.FindByClass(cbClass.Text).Rows;
                if (lengthStudents > 0)
                {
                    dgvStudent.Rows.Clear();

                    foreach (DataRow dr in dataStudent)
                    {
                        int index = dgvStudent.Rows.Add();
                        dgvStudent.Rows[index].Cells["presence"].Value = false;
                        dgvStudent.Rows[index].Cells["id"].Value = dr["id"].ToString();
                        dgvStudent.Rows[index].Cells["name"].Value = dr["name"].ToString();
                        dgvStudent.Rows[index].Cells["classStudent"].Value = dr["class"].ToString();
                        dgvStudent.Rows[index].Cells["gender"].Value = dr["gender"].ToString();
                    }
                }
                else
                {
                    MessageBox.Show("Não há alunos cadastrado nesta turma", "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    dgvStudent.Rows.Clear();

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Question);
            }
        }
    }
}
