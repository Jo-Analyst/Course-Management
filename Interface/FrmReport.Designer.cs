namespace CourseManagement
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
            this.btnClass = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.btnListPresence = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblQuantityStudentsRegistered
            // 
            this.lblQuantityStudentsRegistered.AutoSize = true;
            this.lblQuantityStudentsRegistered.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuantityStudentsRegistered.Location = new System.Drawing.Point(135, 28);
            this.lblQuantityStudentsRegistered.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
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
            this.btnStudent.Location = new System.Drawing.Point(18, 88);
            this.btnStudent.Margin = new System.Windows.Forms.Padding(4);
            this.btnStudent.Name = "btnStudent";
            this.btnStudent.Size = new System.Drawing.Size(149, 85);
            this.btnStudent.TabIndex = 2;
            this.toolTip1.SetToolTip(this.btnStudent, "Relatório do Aluno - [CTRL + S]");
            this.btnStudent.UseVisualStyleBackColor = false;
            this.btnStudent.Click += new System.EventHandler(this.btnStudent_Click);
            // 
            // btnClass
            // 
            this.btnClass.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnClass.BackColor = System.Drawing.Color.White;
            this.btnClass.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClass.FlatAppearance.BorderSize = 0;
            this.btnClass.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnClass.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnClass.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClass.Image = ((System.Drawing.Image)(resources.GetObject("btnClass.Image")));
            this.btnClass.Location = new System.Drawing.Point(188, 88);
            this.btnClass.Margin = new System.Windows.Forms.Padding(4);
            this.btnClass.Name = "btnClass";
            this.btnClass.Size = new System.Drawing.Size(149, 85);
            this.btnClass.TabIndex = 3;
            this.toolTip1.SetToolTip(this.btnClass, "Relatório da Classe - [CTRL + T]");
            this.btnClass.UseVisualStyleBackColor = false;
            this.btnClass.Click += new System.EventHandler(this.btnClass_Click);
            // 
            // btnListPresence
            // 
            this.btnListPresence.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnListPresence.BackColor = System.Drawing.Color.White;
            this.btnListPresence.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnListPresence.FlatAppearance.BorderSize = 0;
            this.btnListPresence.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnListPresence.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnListPresence.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnListPresence.Image = ((System.Drawing.Image)(resources.GetObject("btnListPresence.Image")));
            this.btnListPresence.Location = new System.Drawing.Point(359, 88);
            this.btnListPresence.Margin = new System.Windows.Forms.Padding(4);
            this.btnListPresence.Name = "btnListPresence";
            this.btnListPresence.Size = new System.Drawing.Size(149, 85);
            this.btnListPresence.TabIndex = 4;
            this.toolTip1.SetToolTip(this.btnListPresence, "Lista de presenca - [CTRL + L]");
            this.btnListPresence.UseVisualStyleBackColor = false;
            this.btnListPresence.Click += new System.EventHandler(this.btnListPresence_Click);
            // 
            // FrmReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(525, 256);
            this.Controls.Add(this.btnListPresence);
            this.Controls.Add(this.btnClass);
            this.Controls.Add(this.btnStudent);
            this.Controls.Add(this.lblQuantityStudentsRegistered);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmReport";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Relatório";
            this.Load += new System.EventHandler(this.FrmReport_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FrmReport_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblQuantityStudentsRegistered;
        private System.Windows.Forms.Button btnStudent;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Button btnClass;
        private System.Windows.Forms.Button btnListPresence;
    }
}