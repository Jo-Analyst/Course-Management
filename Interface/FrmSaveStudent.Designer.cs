namespace Interface
{
    partial class FrmSaveStudent
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmSaveStudent));
            this.label1 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.btnsave = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.cbClass = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.rbFeminine = new System.Windows.Forms.RadioButton();
            this.rbMasculine = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(9, 16);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(12, 36);
            this.txtName.MaxLength = 100;
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(494, 26);
            this.txtName.TabIndex = 0;
            // 
            // btnsave
            // 
            this.btnsave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnsave.ForeColor = System.Drawing.Color.White;
            this.btnsave.Location = new System.Drawing.Point(323, 134);
            this.btnsave.Name = "btnsave";
            this.btnsave.Size = new System.Drawing.Size(183, 37);
            this.btnsave.TabIndex = 2;
            this.btnsave.TabStop = false;
            this.btnsave.Text = "Salvar";
            this.btnsave.UseVisualStyleBackColor = true;
            this.btnsave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(9, 69);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Turma";
            // 
            // cbClass
            // 
            this.cbClass.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbClass.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbClass.FormattingEnabled = true;
            this.cbClass.Items.AddRange(new object[] {
            "A1 - Manhã",
            "A2 -Tarde",
            "A3 - Noite",
            "B1- Manhã",
            "B2 -Tarde",
            "B3 - Noite"});
            this.cbClass.Location = new System.Drawing.Point(12, 90);
            this.cbClass.Name = "cbClass";
            this.cbClass.Size = new System.Drawing.Size(494, 28);
            this.cbClass.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(13, 127);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Gênero";
            // 
            // rbFeminine
            // 
            this.rbFeminine.AutoSize = true;
            this.rbFeminine.ForeColor = System.Drawing.Color.White;
            this.rbFeminine.Location = new System.Drawing.Point(128, 147);
            this.rbFeminine.Name = "rbFeminine";
            this.rbFeminine.Size = new System.Drawing.Size(98, 24);
            this.rbFeminine.TabIndex = 9;
            this.rbFeminine.Text = "Feminino";
            this.rbFeminine.UseVisualStyleBackColor = true;
            // 
            // rbMasculine
            // 
            this.rbMasculine.AutoSize = true;
            this.rbMasculine.Checked = true;
            this.rbMasculine.ForeColor = System.Drawing.Color.White;
            this.rbMasculine.Location = new System.Drawing.Point(16, 147);
            this.rbMasculine.Name = "rbMasculine";
            this.rbMasculine.Size = new System.Drawing.Size(106, 24);
            this.rbMasculine.TabIndex = 8;
            this.rbMasculine.TabStop = true;
            this.rbMasculine.Text = "Masculino";
            this.rbMasculine.UseVisualStyleBackColor = true;
            // 
            // FrmSaveStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(529, 186);
            this.Controls.Add(this.rbFeminine);
            this.Controls.Add(this.rbMasculine);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cbClass);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnsave);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmSaveStudent";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro Aluno";
            this.Load += new System.EventHandler(this.FrmSaveStudent_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FrmSaveStudent_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Button btnsave;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbClass;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton rbFeminine;
        private System.Windows.Forms.RadioButton rbMasculine;
    }
}