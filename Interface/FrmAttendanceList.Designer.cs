using System.Windows.Forms;

namespace Interface
{
    partial class FrmAttendanceList
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAttendanceList));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnReport = new System.Windows.Forms.Button();
            this.btnPresence = new System.Windows.Forms.Button();
            this.btnStudent = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(13, 33);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(412, 420);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btnReport);
            this.panel1.Controls.Add(this.btnPresence);
            this.panel1.Controls.Add(this.btnStudent);
            this.panel1.Location = new System.Drawing.Point(432, 33);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(469, 420);
            this.panel1.TabIndex = 1;
            // 
            // btnReport
            // 
            this.btnReport.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnReport.BackColor = System.Drawing.Color.White;
            this.btnReport.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReport.FlatAppearance.BorderSize = 0;
            this.btnReport.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnReport.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReport.Image = ((System.Drawing.Image)(resources.GetObject("btnReport.Image")));
            this.btnReport.Location = new System.Drawing.Point(235, 197);
            this.btnReport.Margin = new System.Windows.Forms.Padding(4);
            this.btnReport.Name = "btnReport";
            this.btnReport.Size = new System.Drawing.Size(128, 84);
            this.btnReport.TabIndex = 3;
            this.toolTip1.SetToolTip(this.btnReport, "Relatório");
            this.btnReport.UseVisualStyleBackColor = false;
            // 
            // btnPresence
            // 
            this.btnPresence.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnPresence.BackColor = System.Drawing.Color.White;
            this.btnPresence.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPresence.FlatAppearance.BorderSize = 0;
            this.btnPresence.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnPresence.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnPresence.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPresence.Image = ((System.Drawing.Image)(resources.GetObject("btnPresence.Image")));
            this.btnPresence.Location = new System.Drawing.Point(100, 197);
            this.btnPresence.Margin = new System.Windows.Forms.Padding(4);
            this.btnPresence.Name = "btnPresence";
            this.btnPresence.Size = new System.Drawing.Size(128, 84);
            this.btnPresence.TabIndex = 2;
            this.toolTip1.SetToolTip(this.btnPresence, "Prensença");
            this.btnPresence.UseVisualStyleBackColor = false;
            this.btnPresence.Click += new System.EventHandler(this.btnPresence_Click);
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
            this.btnStudent.Location = new System.Drawing.Point(100, 107);
            this.btnStudent.Margin = new System.Windows.Forms.Padding(4);
            this.btnStudent.Name = "btnStudent";
            this.btnStudent.Size = new System.Drawing.Size(263, 84);
            this.btnStudent.TabIndex = 1;
            this.toolTip1.SetToolTip(this.btnStudent, "Alunos");
            this.btnStudent.UseVisualStyleBackColor = false;
            this.btnStudent.Click += new System.EventHandler(this.btnStudent_Click);
            // 
            // FrmAttendanceList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(915, 480);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmAttendanceList";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "System Attendance List";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private PictureBox pictureBox1;
        private Panel panel1;
        private Button btnStudent;
        private Button btnReport;
        private ToolTip toolTip1;
        private Button btnPresence;
    }
}