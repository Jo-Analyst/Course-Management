using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
    }
}
