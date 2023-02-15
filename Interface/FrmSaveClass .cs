using DataBase;
using System;
using System.Data;
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

        public FrmSaveClass(string shift)
        {
            InitializeComponent();
            cbShift.Text = shift;
        }

        public FrmSaveClass(int id, string name, string shift)
        {
            InitializeComponent();
            this.id = id;
            txtClass.Text = name;
            cbShift.Text = shift;
        }

        bool thisClassIsRegistered = false;

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtClass.Text))
            {
                MessageBox.Show("Preencha o nome da turma", "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            if (cbShift.SelectedIndex == -1)
            {
                MessageBox.Show("Selecione o turno", "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }         
           
            try
            {
                @class.Id = id;
                @class.Name = txtClass.Text.Trim();
                @class.Shift = cbShift.Text;
              
                if(id == 0 && @class.FindByClass(txtClass.Text).Rows.Count > 0)
                {
                    MessageBox.Show($"Já existe a turma '{txtClass.Text}' cadastrada no sistema.", "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }

                var dtShifts = @class.FindByClassForShift(cbShift.Text);
                for (int i =0;i < dtShifts.Rows.Count;i++)
                {
                    thisClassIsRegistered = dtShifts.Rows[0]["name"].ToString() == txtClass.Text ? true : false;

                    if (thisClassIsRegistered)
                        break;
                }

                if(thisClassIsRegistered)
                {
                    MessageBox.Show($"Não é possível atualizar o nome da turma para '{txtClass.Text}', pois esta turma já está cadastrado no sistema.", "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }

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