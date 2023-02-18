namespace Interface
{
    partial class FrmReportStudent
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmReportStudent));
            this.label1 = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.lblNumberLack = new System.Windows.Forms.Label();
            this.lblNumberAttendance = new System.Windows.Forms.Label();
            this.cbNameStudents = new System.Windows.Forms.ComboBox();
            this.cbClass = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblPercentageCameIn = new System.Windows.Forms.Label();
            this.pbPercentageCameIn = new System.Windows.Forms.ProgressBar();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblPercentageStart = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.pbPercentageStart = new System.Windows.Forms.ProgressBar();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(277, 22);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Aluno(a)";
            // 
            // lblNumberLack
            // 
            this.lblNumberLack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblNumberLack.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumberLack.ForeColor = System.Drawing.Color.White;
            this.lblNumberLack.Location = new System.Drawing.Point(301, 130);
            this.lblNumberLack.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNumberLack.Name = "lblNumberLack";
            this.lblNumberLack.Padding = new System.Windows.Forms.Padding(6);
            this.lblNumberLack.Size = new System.Drawing.Size(165, 37);
            this.lblNumberLack.TabIndex = 2;
            this.lblNumberLack.Text = "0";
            this.lblNumberLack.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblNumberAttendance
            // 
            this.lblNumberAttendance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.lblNumberAttendance.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumberAttendance.ForeColor = System.Drawing.Color.White;
            this.lblNumberAttendance.Location = new System.Drawing.Point(27, 130);
            this.lblNumberAttendance.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNumberAttendance.Name = "lblNumberAttendance";
            this.lblNumberAttendance.Padding = new System.Windows.Forms.Padding(6);
            this.lblNumberAttendance.Size = new System.Drawing.Size(186, 37);
            this.lblNumberAttendance.TabIndex = 3;
            this.lblNumberAttendance.Text = "0";
            this.lblNumberAttendance.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cbNameStudents
            // 
            this.cbNameStudents.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbNameStudents.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbNameStudents.FormattingEnabled = true;
            this.cbNameStudents.Location = new System.Drawing.Point(277, 51);
            this.cbNameStudents.Margin = new System.Windows.Forms.Padding(4);
            this.cbNameStudents.Name = "cbNameStudents";
            this.cbNameStudents.Size = new System.Drawing.Size(440, 33);
            this.cbNameStudents.TabIndex = 4;
            this.cbNameStudents.SelectedIndexChanged += new System.EventHandler(this.cbStudents_SelectedIndexChanged);
            // 
            // cbClass
            // 
            this.cbClass.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbClass.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbClass.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbClass.FormattingEnabled = true;
            this.cbClass.Location = new System.Drawing.Point(22, 51);
            this.cbClass.Margin = new System.Windows.Forms.Padding(4);
            this.cbClass.Name = "cbClass";
            this.cbClass.Size = new System.Drawing.Size(241, 33);
            this.cbClass.TabIndex = 12;
            this.cbClass.SelectedIndexChanged += new System.EventHandler(this.cbClass_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(18, 25);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 25);
            this.label2.TabIndex = 11;
            this.label2.Text = "Turma";
            // 
            // lblPercentageCameIn
            // 
            this.lblPercentageCameIn.AutoSize = true;
            this.lblPercentageCameIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPercentageCameIn.Location = new System.Drawing.Point(666, 239);
            this.lblPercentageCameIn.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblPercentageCameIn.Name = "lblPercentageCameIn";
            this.lblPercentageCameIn.Size = new System.Drawing.Size(35, 20);
            this.lblPercentageCameIn.TabIndex = 9;
            this.lblPercentageCameIn.Text = "0%";
            // 
            // pbPercentageCameIn
            // 
            this.pbPercentageCameIn.Location = new System.Drawing.Point(405, 234);
            this.pbPercentageCameIn.Margin = new System.Windows.Forms.Padding(4);
            this.pbPercentageCameIn.Name = "pbPercentageCameIn";
            this.pbPercentageCameIn.Size = new System.Drawing.Size(252, 29);
            this.pbPercentageCameIn.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(29, 201);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(264, 25);
            this.label3.TabIndex = 7;
            this.label3.Text = "% desde  o começo do curso";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(18, 105);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(202, 25);
            this.label4.TabIndex = 13;
            this.label4.Text = "Número de Presença:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(301, 105);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(165, 25);
            this.label5.TabIndex = 14;
            this.label5.Text = "Número de faltas:";
            // 
            // lblPercentageStart
            // 
            this.lblPercentageStart.AutoSize = true;
            this.lblPercentageStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPercentageStart.Location = new System.Drawing.Point(293, 237);
            this.lblPercentageStart.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblPercentageStart.Name = "lblPercentageStart";
            this.lblPercentageStart.Size = new System.Drawing.Size(35, 20);
            this.lblPercentageStart.TabIndex = 17;
            this.lblPercentageStart.Text = "0%";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(400, 201);
            this.label7.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(192, 25);
            this.label7.TabIndex = 16;
            this.label7.Text = "% desde  que entrou";
            // 
            // pbPercentageStart
            // 
            this.pbPercentageStart.Location = new System.Drawing.Point(32, 232);
            this.pbPercentageStart.Margin = new System.Windows.Forms.Padding(4);
            this.pbPercentageStart.Name = "pbPercentageStart";
            this.pbPercentageStart.Size = new System.Drawing.Size(252, 29);
            this.pbPercentageStart.TabIndex = 15;
            // 
            // FrmReportStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(730, 276);
            this.Controls.Add(this.lblPercentageStart);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.pbPercentageStart);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cbClass);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblPercentageCameIn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pbPercentageCameIn);
            this.Controls.Add(this.cbNameStudents);
            this.Controls.Add(this.lblNumberAttendance);
            this.Controls.Add(this.lblNumberLack);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmReportStudent";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Relatório do Aluno";
            this.Load += new System.EventHandler(this.FrmReportStudent_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Label lblNumberLack;
        private System.Windows.Forms.Label lblNumberAttendance;
        private System.Windows.Forms.ComboBox cbNameStudents;
        private System.Windows.Forms.ComboBox cbClass;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblPercentageCameIn;
        private System.Windows.Forms.ProgressBar pbPercentageCameIn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblPercentageStart;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ProgressBar pbPercentageStart;
    }
}