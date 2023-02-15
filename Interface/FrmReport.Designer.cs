namespace Interface
{
    partial class FrmReport
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmReport));
            this.lblQuantityStudentsRegistered = new System.Windows.Forms.Label();
            this.btnStudent = new System.Windows.Forms.Button();
            this.btnTurma = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // lblQuantityStudentsRegistered
            // 
            this.lblQuantityStudentsRegistered.AutoSize = true;
            this.lblQuantityStudentsRegistered.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuantityStudentsRegistered.Location = new System.Drawing.Point(69, 21);
            this.lblQuantityStudentsRegistered.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblQuantityStudentsRegistered.Name = "lblQuantityStudentsRegistered";
            this.lblQuantityStudentsRegistered.Size = new System.Drawing.Size(238, 17);
            this.lblQuantityStudentsRegistered.TabIndex = 0;
            this.lblQuantityStudentsRegistered.Text = "Quantidade de alunos cadastrados: ";
            // 
            // btnStudent
            // 
            this.btnStudent.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnStudent.BackColor = System.Drawing.Color.White;
            this.btnStudent.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnStudent.FlatAppearance.BorderSize = 0;
            this.btnStudent.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnStudent.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnStudent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStudent.Image = ((System.Drawing.Image)(resources.GetObject("btnStudent.Image")));
            this.btnStudent.Location = new System.Drawing.Point(72, 76);
            this.btnStudent.Name = "btnStudent";
            this.btnStudent.Size = new System.Drawing.Size(124, 68);
            this.btnStudent.TabIndex = 2;
            this.toolTip1.SetToolTip(this.btnStudent, "Aluno");
            this.btnStudent.UseVisualStyleBackColor = false;
            this.btnStudent.Click += new System.EventHandler(this.btnStudent_Click);
            // 
            // btnTurma
            // 
            this.btnTurma.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnTurma.BackColor = System.Drawing.Color.White;
            this.btnTurma.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTurma.FlatAppearance.BorderSize = 0;
            this.btnTurma.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnTurma.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnTurma.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTurma.Image = ((System.Drawing.Image)(resources.GetObject("btnTurma.Image")));
            this.btnTurma.Location = new System.Drawing.Point(213, 76);
            this.btnTurma.Name = "btnTurma";
            this.btnTurma.Size = new System.Drawing.Size(124, 68);
            this.btnTurma.TabIndex = 3;
            this.toolTip1.SetToolTip(this.btnTurma, "Turma");
            this.btnTurma.UseVisualStyleBackColor = false;
            this.btnTurma.Click += new System.EventHandler(this.btnTurma_Click);
            // 
            // FrmReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(428, 205);
            this.Controls.Add(this.btnTurma);
            this.Controls.Add(this.btnStudent);
            this.Controls.Add(this.lblQuantityStudentsRegistered);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmReport";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Relatório";
            this.Load += new System.EventHandler(this.FrmReport_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblQuantityStudentsRegistered;
        private System.Windows.Forms.Button btnStudent;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Button btnTurma;
    }
}