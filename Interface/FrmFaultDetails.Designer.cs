namespace CourseManagement
{
    partial class FrmFaultDetails
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmFaultDetails));
            this.label1 = new System.Windows.Forms.Label();
            this.txtNameStudent = new System.Windows.Forms.TextBox();
            this.txtDateAbcence = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rtbDescriptionReasonForAbsence = new System.Windows.Forms.RichTextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(8, 10);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome:";
            // 
            // txtNameStudent
            // 
            this.txtNameStudent.Location = new System.Drawing.Point(12, 37);
            this.txtNameStudent.Name = "txtNameStudent";
            this.txtNameStudent.ReadOnly = true;
            this.txtNameStudent.Size = new System.Drawing.Size(465, 26);
            this.txtNameStudent.TabIndex = 1;
            this.txtNameStudent.TabStop = false;
            // 
            // txtDateAbcence
            // 
            this.txtDateAbcence.Location = new System.Drawing.Point(483, 37);
            this.txtDateAbcence.Name = "txtDateAbcence";
            this.txtDateAbcence.ReadOnly = true;
            this.txtDateAbcence.Size = new System.Drawing.Size(101, 26);
            this.txtDateAbcence.TabIndex = 3;
            this.txtDateAbcence.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(479, 9);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Data:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rtbDescriptionReasonForAbsence);
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(12, 69);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(572, 215);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = " Detalhes da falta: ";
            // 
            // rtbDescriptionReasonForAbsence
            // 
            this.rtbDescriptionReasonForAbsence.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtbDescriptionReasonForAbsence.Location = new System.Drawing.Point(3, 22);
            this.rtbDescriptionReasonForAbsence.Name = "rtbDescriptionReasonForAbsence";
            this.rtbDescriptionReasonForAbsence.ReadOnly = true;
            this.rtbDescriptionReasonForAbsence.Size = new System.Drawing.Size(566, 190);
            this.rtbDescriptionReasonForAbsence.TabIndex = 1;
            this.rtbDescriptionReasonForAbsence.TabStop = false;
            this.rtbDescriptionReasonForAbsence.Text = "";
            // 
            // FrmFaultDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(596, 314);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtDateAbcence);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtNameStudent);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmFaultDetails";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Detalhes da falta";
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNameStudent;
        private System.Windows.Forms.TextBox txtDateAbcence;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RichTextBox rtbDescriptionReasonForAbsence;
    }
}