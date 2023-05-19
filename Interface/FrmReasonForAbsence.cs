using System;
using System.Windows.Forms;

namespace CourseManagement
{
    public partial class FrmReasonForAbsence : Form
    {
        public string description;

        public FrmReasonForAbsence(string description)
        {
            InitializeComponent();
            rtbDescription.Text = description;
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(rtbDescription.Text))
            {
                MessageBox.Show("Descreva o motivo da falta do aluno!", "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            description = rtbDescription.Text.Trim();
            this.Close();
        }

        private void FrmReasonForAbsence_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                btnConfirm_Click(sender, e);
        }
    }
}
