using DataBase;
using System;
using System.Data;
using System.Windows.Forms;

namespace Interface
{
    public partial class FrmSaveContent : Form
    {
        int class_id, id;
        Class @class = new Class();

        public FrmSaveContent()
        {
            InitializeComponent();
        }

        Student student = new Student();
        private void cbClass_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                class_id = int.Parse(@class.FindByClass(cbClass.Text).Rows[0]["id"].ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Question);
            }
        }      

        

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (!ValidateFields()) return;

                 new Content() { Id = id, Wording = txtContent.Text.Trim(), Matter = cbMatter.Text, Date = dtDateContent.Value.ToShortDateString(), Class_id = class_id}.Save();

                this.Close();
            }   
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Question);
            }
        }

        private bool ValidateFields()
        {
            bool fieldValidated = false;

            if (cbClass.SelectedIndex == -1)
            {
                MessageBox.Show("Selecione a turma.", "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else if (cbMatter.SelectedIndex == -1)
            {
                MessageBox.Show("Selecione a matéria.", "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else if(string.IsNullOrEmpty(txtContent.Text))
            {
                MessageBox.Show("Preencha o conteúdo.", "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
                fieldValidated = true;

            return fieldValidated;
        }

        private void FrmContent_Load(object sender, EventArgs e)
        {
            try
            {
                var dtClasses = @class.FindAll();
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
    }
}