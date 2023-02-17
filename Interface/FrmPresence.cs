using DataBase;
using System;
using System.Data;
using System.Windows.Forms;

namespace Interface
{
    public partial class FrmPresence : Form
    {
        int class_id;
        Class @class = new Class();

        public FrmPresence()
        {
            InitializeComponent();
        }

        Student student = new Student();
        private void cbClass_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                class_id = int.Parse(@class.FindByClass(cbClass.Text).Rows[0]["id"].ToString());

                if (ThereIsMarkedAttendanceList())
                {
                    LoadListPresence();
                    btnConfirmPresence.Text = "Editar Presença";
                }
                else
                {
                    LoadStudents();
                    btnConfirmPresence.Text = "Confirmar Presença";
                }

                dgvListPresence.ClearSelection();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Question);
            }
        }


        private bool ThereIsMarkedAttendanceList()
        {
            bool listIsChecked = false;

            if (new ListAttendance().FindAll(dtDatePresence.Text, cbClass.Text).Rows.Count > 0)
                listIsChecked = true;

            return listIsChecked;
        }

        private void LoadStudents()
        {
            var lengthStudents = student.FindByClass(cbClass.Text).Rows.Count;
            var listPresence = student.FindByClass(cbClass.Text).Rows;
            if (lengthStudents > 0)
            {
                dgvListPresence.Rows.Clear();

                foreach (DataRow dr in listPresence)
                {
                    int index = dgvListPresence.Rows.Add();
                    dgvListPresence.Rows[index].Cells["presence"].Value = "false";
                    dgvListPresence.Rows[index].Cells["id"].Value = dr["id"].ToString();
                    dgvListPresence.Rows[index].Cells["name"].Value = dr["name"].ToString();
                    dgvListPresence.Rows[index].Cells["classStudent"].Value = dr["class"].ToString();
                    dgvListPresence.Rows[index].Cells["shift"].Value = dr["shift"].ToString();
                    dgvListPresence.Rows[index].Cells["gender"].Value = dr["gender"].ToString();
                }

                dgvListPresence.ClearSelection();
            }
            else
            {
                MessageBox.Show("Não há alunos cadastrado nesta turma", "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                btnConfirmPresence.Text = "Confirmar Presença";
                dgvListPresence.Rows.Clear();

            }
        }

        ListAttendance listAttendance = new ListAttendance();
        private void LoadListPresence()
        {
            DataTable dtListAttendance = listAttendance.FindAll(dtDatePresence.Text, cbClass.Text);
            dgvListPresence.Rows.Clear();
            foreach (DataRow dr in dtListAttendance.Rows)
            {
                var index = dgvListPresence.Rows.Add();
                dgvListPresence.Rows[index].Cells["presence"].Value = dr["presence"].ToString() == "0" ? "false" : "true";
                dgvListPresence.Rows[index].Cells["id"].Value = dr["student_id"].ToString();
                dgvListPresence.Rows[index].Cells["name"].Value = dr["name"].ToString();
                dgvListPresence.Rows[index].Cells["classStudent"].Value = dr["class"].ToString();
                dgvListPresence.Rows[index].Cells["shift"].Value = dr["shift"].ToString();
                dgvListPresence.Rows[index].Cells["gender"].Value = dr["gender"].ToString();
                dgvListPresence.Rows[index].Cells["listAttendance_id"].Value = dr["listAttendance_id"].ToString();
            }
        }

        Attendance attendance = new Attendance();
        private void btnConfirmPresence_Click(object sender, EventArgs e)
        {
            if (dgvListPresence.Rows.Count == 0)
            {
                MessageBox.Show("Selecione a turma para a marcação da presença", "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            if (btnConfirmPresence.Text == "Confirmar Presença")
                ConfirmPresence();
            else
                UpdatePresence();

            dgvListPresence.ClearSelection();
        }

        private void UpdatePresence()
        {

            try
            {
                DataTable dtListPresence = new DataTable();
                dtListPresence.Columns.Add("id", typeof(int));
                dtListPresence.Columns.Add("presence", typeof(bool));

                foreach (DataGridViewRow row in dgvListPresence.Rows)
                {
                    dtListPresence.Rows.Add(row.Cells["listAttendance_id"].Value, row.Cells["presence"].Value);
                }

                listAttendance.UpdatePresence(dtListPresence);
                MessageBox.Show($"Lista de presença atualizada com sucesso.", "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ConfirmPresence()
        {
            try
            {
                DataTable dataTable = new DataTable();
                dataTable.Columns.Add("presence", typeof(string));
                dataTable.Columns.Add("student_id", typeof(string));

                foreach (DataGridViewRow dgvRow in dgvListPresence.Rows)
                {
                    dataTable.Rows.Add(dgvRow.Cells["presence"].Value.ToString(), dgvRow.Cells["id"].Value.ToString());
                }

                attendance.Class_id = class_id;
                attendance.Date = dtDatePresence.Text;
                attendance.Save(dataTable);
                MessageBox.Show($"Lista de presença confirmada com sucesso.", "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Information);
                btnConfirmPresence.Text = "Editar Presença";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dtDatePresence_ValueChanged(object sender, EventArgs e)
        {
            cbClass_SelectedIndexChanged(sender, e);
        }


        private void FrmPresence_Load(object sender, EventArgs e)
        {
            var dtClasses = @class.FindAll();
            foreach (DataRow dr in dtClasses.Rows)
            {
                cbClass.Items.Add(dr["name"]);
            }
        }
    }
}