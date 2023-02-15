using DataBase;
using System;
using System.Windows.Forms;

namespace Interface
{
    public partial class FrmSaveClass : Form
    {

        public bool classWasSaved { get; set; }
        int id;
        Class @class = new Class();

        public FrmSaveClass()
        {
            InitializeComponent();
        }

        public FrmSaveClass(int id, string name, string shift)
        {
            InitializeComponent();
            this.id = id;
            txtClass.Text = name;
            cbShift.Text = shift;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtClass.Text))
            {
                MessageBox.Show("Preencha o nome da turma", "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
           

            try
            {
                @class.Id = id;
                @class.Name = txtClass.Text.Trim();
                @class.Shift = cbShift.Text;
                @class.Save();
                classWasSaved = true;

                if (id == 0)
                {
                    DialogResult dr = MessageBox.Show("Deseja incluir mais um nova turma?", "Mensagem", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (dr == DialogResult.Yes)
                    {
                        txtClass.Clear();
                       txtClass.Focus();
                        return;
                    }
                }

                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FrmSaveStudent_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                btnSave_Click(sender, e);
            }
        }
    }
}