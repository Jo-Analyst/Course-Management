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
    public partial class FrmSaveStudent : Form
    {

        public bool studentWasSaved { get; set; }
        int id;

        public FrmSaveStudent()
        {
            InitializeComponent();
        } 
        
        public FrmSaveStudent(int id)
        {
            InitializeComponent();
            this.id = id;
            try
            {
                Student student = new Student() { _id = id };
                var dataStudent = student.FindById().Rows[0];
                txtName.Text = dataStudent["name"].ToString();
                cbClass.Text = dataStudent["class"].ToString();
                if (dataStudent["gender"].ToString() == "F")
                    rbFeminine.Checked = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtName.Text))
            {
                MessageBox.Show("Preencha o nome da turma", "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            if (cbClass.SelectedIndex == -1)
            {
                MessageBox.Show("Selecione a turma", "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            try
            {
                Student student = new Student() {_id = id, _name = txtName.Text.Trim(), _class = cbClass.Text.Trim(), _gender = rbMasculine.Checked ? "M" : "F"  };
                student.Save();
                studentWasSaved = true;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}