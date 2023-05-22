using System.Windows.Forms;

namespace CourseManagement
{
    partial class FrmCourseManagementt
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCourseManagementt));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.btnContent = new System.Windows.Forms.Button();
            this.btnClass = new System.Windows.Forms.Button();
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
            this.pictureBox1.Location = new System.Drawing.Point(20, 52);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(517, 437);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.btnContent);
            this.panel1.Controls.Add(this.btnClass);
            this.panel1.Controls.Add(this.btnReport);
            this.panel1.Controls.Add(this.btnPresence);
            this.panel1.Controls.Add(this.btnStudent);
            this.panel1.Location = new System.Drawing.Point(549, 52);
            this.panel1.Margin = new System.Windows.Forms.Padding(6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(439, 436);
            this.panel1.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(222, 295);
            this.button1.Margin = new System.Windows.Forms.Padding(6);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(165, 97);
            this.button1.TabIndex = 6;
            this.toolTip1.SetToolTip(this.button1, "Backup e Restauração - [CTRL + SHIFT + B]");
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.btnBackupAndRestore_Click);
            // 
            // btnContent
            // 
            this.btnContent.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnContent.BackColor = System.Drawing.Color.White;
            this.btnContent.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnContent.FlatAppearance.BorderSize = 0;
            this.btnContent.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnContent.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnContent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnContent.Image = ((System.Drawing.Image)(resources.GetObject("btnContent.Image")));
            this.btnContent.Location = new System.Drawing.Point(45, 77);
            this.btnContent.Margin = new System.Windows.Forms.Padding(6);
            this.btnContent.Name = "btnContent";
            this.btnContent.Size = new System.Drawing.Size(165, 97);
            this.btnContent.TabIndex = 5;
            this.toolTip1.SetToolTip(this.btnContent, "Conteúdo - [CTRL + SHIFT + C]");
            this.btnContent.UseVisualStyleBackColor = false;
            this.btnContent.Click += new System.EventHandler(this.btnContent_Click);
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
            this.btnClass.Location = new System.Drawing.Point(45, 186);
            this.btnClass.Margin = new System.Windows.Forms.Padding(6);
            this.btnClass.Name = "btnClass";
            this.btnClass.Size = new System.Drawing.Size(165, 97);
            this.btnClass.TabIndex = 4;
            this.toolTip1.SetToolTip(this.btnClass, "Cadastro Turma - [CTRL + SHIFT + T]");
            this.btnClass.UseVisualStyleBackColor = false;
            this.btnClass.Click += new System.EventHandler(this.btnClass_Click);
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
            this.btnReport.Location = new System.Drawing.Point(45, 295);
            this.btnReport.Margin = new System.Windows.Forms.Padding(6);
            this.btnReport.Name = "btnReport";
            this.btnReport.Size = new System.Drawing.Size(165, 97);
            this.btnReport.TabIndex = 3;
            this.toolTip1.SetToolTip(this.btnReport, "Relatório - [CTRL + SHIFT + R]");
            this.btnReport.UseVisualStyleBackColor = false;
            this.btnReport.Click += new System.EventHandler(this.btnReport_Click);
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
            this.btnPresence.Location = new System.Drawing.Point(222, 186);
            this.btnPresence.Margin = new System.Windows.Forms.Padding(6);
            this.btnPresence.Name = "btnPresence";
            this.btnPresence.Size = new System.Drawing.Size(165, 97);
            this.btnPresence.TabIndex = 2;
            this.toolTip1.SetToolTip(this.btnPresence, "Presença - [CTRL + ALT + P]");
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
            this.btnStudent.Location = new System.Drawing.Point(222, 77);
            this.btnStudent.Margin = new System.Windows.Forms.Padding(6);
            this.btnStudent.Name = "btnStudent";
            this.btnStudent.Size = new System.Drawing.Size(165, 97);
            this.btnStudent.TabIndex = 1;
            this.toolTip1.SetToolTip(this.btnStudent, "Cadastro Alunos - [CTRL + SHIFT + S]");
            this.btnStudent.UseVisualStyleBackColor = false;
            this.btnStudent.Click += new System.EventHandler(this.btnStudent_Click);
            // 
            // FrmCourseManagementt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(1010, 531);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "FrmCourseManagementt";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "System Course Management";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmCourseManagementt_FormClosed);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FrmCourseManagementt_KeyDown);
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
        private Button btnClass;
        private Button btnContent;
        private Button button1;
    }
}