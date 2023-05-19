namespace CourseManagement
{
    partial class FrmReportClass
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmReportClass));
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.cbClass = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvReportClass = new System.Windows.Forms.DataGridView();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.classStudent = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.shift = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numberOfAttendance = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numberOfAbsences = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.percentageStart = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.percentageCameIn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnViewReport = new System.Windows.Forms.Button();
            this.lblQtdClasses = new System.Windows.Forms.Label();
            this.cbFindAbove75Percentage = new System.Windows.Forms.CheckBox();
            this.cbFindBellow75Percentage = new System.Windows.Forms.CheckBox();
            this.lblQuantityStudentList = new System.Windows.Forms.Label();
            this.btnPrint = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReportClass)).BeginInit();
            this.SuspendLayout();
            // 
            // cbClass
            // 
            this.cbClass.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbClass.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbClass.FormattingEnabled = true;
            this.cbClass.Location = new System.Drawing.Point(13, 47);
            this.cbClass.Margin = new System.Windows.Forms.Padding(4);
            this.cbClass.Name = "cbClass";
            this.cbClass.Size = new System.Drawing.Size(357, 28);
            this.cbClass.TabIndex = 12;
            this.cbClass.SelectedIndexChanged += new System.EventHandler(this.cbClasses_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(9, 21);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 20);
            this.label2.TabIndex = 11;
            this.label2.Text = "Turma";
            // 
            // dgvReportClass
            // 
            this.dgvReportClass.AllowUserToAddRows = false;
            this.dgvReportClass.AllowUserToDeleteRows = false;
            this.dgvReportClass.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvReportClass.BackgroundColor = System.Drawing.Color.Gray;
            this.dgvReportClass.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvReportClass.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.ControlDarkDark;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvReportClass.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvReportClass.ColumnHeadersHeight = 40;
            this.dgvReportClass.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvReportClass.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.name,
            this.classStudent,
            this.shift,
            this.numberOfAttendance,
            this.numberOfAbsences,
            this.percentageStart,
            this.percentageCameIn});
            this.dgvReportClass.EnableHeadersVisualStyles = false;
            this.dgvReportClass.Location = new System.Drawing.Point(13, 85);
            this.dgvReportClass.Margin = new System.Windows.Forms.Padding(4);
            this.dgvReportClass.Name = "dgvReportClass";
            this.dgvReportClass.ReadOnly = true;
            this.dgvReportClass.RowHeadersVisible = false;
            this.dgvReportClass.RowHeadersWidth = 51;
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvReportClass.RowsDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvReportClass.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvReportClass.Size = new System.Drawing.Size(1169, 291);
            this.dgvReportClass.TabIndex = 14;
            this.dgvReportClass.TabStop = false;
            this.dgvReportClass.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvReportClass_CellClick);
            this.dgvReportClass.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvReportClass_CellDoubleClick);
            // 
            // name
            // 
            this.name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.name.DataPropertyName = "name";
            this.name.HeaderText = "Nome";
            this.name.MinimumWidth = 6;
            this.name.Name = "name";
            this.name.ReadOnly = true;
            // 
            // classStudent
            // 
            this.classStudent.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.classStudent.DataPropertyName = "class";
            this.classStudent.HeaderText = "Turma";
            this.classStudent.MinimumWidth = 6;
            this.classStudent.Name = "classStudent";
            this.classStudent.ReadOnly = true;
            this.classStudent.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // shift
            // 
            this.shift.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.shift.HeaderText = "Turno";
            this.shift.MinimumWidth = 6;
            this.shift.Name = "shift";
            this.shift.ReadOnly = true;
            this.shift.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.shift.Width = 55;
            // 
            // numberOfAttendance
            // 
            this.numberOfAttendance.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.numberOfAttendance.DataPropertyName = "numberOfAttendance";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.numberOfAttendance.DefaultCellStyle = dataGridViewCellStyle2;
            this.numberOfAttendance.HeaderText = "Número de Presenças";
            this.numberOfAttendance.MinimumWidth = 6;
            this.numberOfAttendance.Name = "numberOfAttendance";
            this.numberOfAttendance.ReadOnly = true;
            this.numberOfAttendance.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.numberOfAttendance.Width = 171;
            // 
            // numberOfAbsences
            // 
            this.numberOfAbsences.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.numberOfAbsences.DataPropertyName = "numberOfAbsences";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.numberOfAbsences.DefaultCellStyle = dataGridViewCellStyle3;
            this.numberOfAbsences.HeaderText = "Número de Faltas";
            this.numberOfAbsences.MinimumWidth = 6;
            this.numberOfAbsences.Name = "numberOfAbsences";
            this.numberOfAbsences.ReadOnly = true;
            this.numberOfAbsences.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.numberOfAbsences.Width = 140;
            // 
            // percentageStart
            // 
            this.percentageStart.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.percentageStart.DefaultCellStyle = dataGridViewCellStyle4;
            this.percentageStart.HeaderText = "% desde o início";
            this.percentageStart.MinimumWidth = 6;
            this.percentageStart.Name = "percentageStart";
            this.percentageStart.ReadOnly = true;
            this.percentageStart.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.percentageStart.Width = 128;
            // 
            // percentageCameIn
            // 
            this.percentageCameIn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.percentageCameIn.DefaultCellStyle = dataGridViewCellStyle5;
            this.percentageCameIn.HeaderText = "% desde que entrou";
            this.percentageCameIn.MinimumWidth = 6;
            this.percentageCameIn.Name = "percentageCameIn";
            this.percentageCameIn.ReadOnly = true;
            this.percentageCameIn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.percentageCameIn.Width = 157;
            // 
            // btnViewReport
            // 
            this.btnViewReport.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnViewReport.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnViewReport.Enabled = false;
            this.btnViewReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnViewReport.Location = new System.Drawing.Point(990, 384);
            this.btnViewReport.Margin = new System.Windows.Forms.Padding(4);
            this.btnViewReport.Name = "btnViewReport";
            this.btnViewReport.Size = new System.Drawing.Size(192, 52);
            this.btnViewReport.TabIndex = 15;
            this.btnViewReport.TabStop = false;
            this.btnViewReport.Text = "Visualizar Relatório";
            this.toolTip1.SetToolTip(this.btnViewReport, "Visualizar Relatório  - [SHIFT + P]");
            this.btnViewReport.UseVisualStyleBackColor = true;
            this.btnViewReport.Click += new System.EventHandler(this.btnViewReport_Click);
            // 
            // lblQtdClasses
            // 
            this.lblQtdClasses.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblQtdClasses.AutoSize = true;
            this.lblQtdClasses.Location = new System.Drawing.Point(12, 398);
            this.lblQtdClasses.Name = "lblQtdClasses";
            this.lblQtdClasses.Size = new System.Drawing.Size(239, 20);
            this.lblQtdClasses.TabIndex = 16;
            this.lblQtdClasses.Text = "Quantidade de aulas prestadas: ";
            this.lblQtdClasses.Visible = false;
            // 
            // cbFindAbove75Percentage
            // 
            this.cbFindAbove75Percentage.AutoSize = true;
            this.cbFindAbove75Percentage.Location = new System.Drawing.Point(453, 47);
            this.cbFindAbove75Percentage.Name = "cbFindAbove75Percentage";
            this.cbFindAbove75Percentage.Size = new System.Drawing.Size(230, 24);
            this.cbFindAbove75Percentage.TabIndex = 17;
            this.cbFindAbove75Percentage.Text = "Buscar dados acima de 75%";
            this.cbFindAbove75Percentage.UseVisualStyleBackColor = true;
            this.cbFindAbove75Percentage.CheckedChanged += new System.EventHandler(this.cbFindAbove75Percentage_CheckedChanged);
            // 
            // cbFindBellow75Percentage
            // 
            this.cbFindBellow75Percentage.AutoSize = true;
            this.cbFindBellow75Percentage.Location = new System.Drawing.Point(751, 47);
            this.cbFindBellow75Percentage.Name = "cbFindBellow75Percentage";
            this.cbFindBellow75Percentage.Size = new System.Drawing.Size(234, 24);
            this.cbFindBellow75Percentage.TabIndex = 18;
            this.cbFindBellow75Percentage.Text = "Buscar dados abaixo de 75%";
            this.cbFindBellow75Percentage.UseVisualStyleBackColor = true;
            this.cbFindBellow75Percentage.CheckedChanged += new System.EventHandler(this.cbFindBellow75Percentage_CheckedChanged);
            // 
            // lblQuantityStudentList
            // 
            this.lblQuantityStudentList.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblQuantityStudentList.AutoSize = true;
            this.lblQuantityStudentList.Location = new System.Drawing.Point(12, 424);
            this.lblQuantityStudentList.Name = "lblQuantityStudentList";
            this.lblQuantityStudentList.Size = new System.Drawing.Size(227, 20);
            this.lblQuantityStudentList.TabIndex = 19;
            this.lblQuantityStudentList.Text = "Quantidade de alunos na lista: ";
            this.lblQuantityStudentList.Visible = false;
            // 
            // btnPrint
            // 
            this.btnPrint.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPrint.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPrint.Enabled = false;
            this.btnPrint.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrint.Location = new System.Drawing.Point(852, 384);
            this.btnPrint.Margin = new System.Windows.Forms.Padding(4);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(133, 52);
            this.btnPrint.TabIndex = 20;
            this.btnPrint.TabStop = false;
            this.btnPrint.Text = "Imprimir";
            this.toolTip1.SetToolTip(this.btnPrint, "Imprimir - [CTRL + P]");
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // FrmReportClass
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(1195, 453);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.lblQuantityStudentList);
            this.Controls.Add(this.cbFindBellow75Percentage);
            this.Controls.Add(this.cbFindAbove75Percentage);
            this.Controls.Add(this.lblQtdClasses);
            this.Controls.Add(this.btnViewReport);
            this.Controls.Add(this.dgvReportClass);
            this.Controls.Add(this.cbClass);
            this.Controls.Add(this.label2);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.MinimizeBox = false;
            this.Name = "FrmReportClass";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Relatório da Turma";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmReportClass_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FrmReportClass_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.dgvReportClass)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.ComboBox cbClass;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvReportClass;
        private System.Windows.Forms.Button btnViewReport;
        private System.Windows.Forms.Label lblQtdClasses;
        private System.Windows.Forms.CheckBox cbFindAbove75Percentage;
        private System.Windows.Forms.CheckBox cbFindBellow75Percentage;
        private System.Windows.Forms.Label lblQuantityStudentList;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn classStudent;
        private System.Windows.Forms.DataGridViewTextBoxColumn shift;
        private System.Windows.Forms.DataGridViewTextBoxColumn numberOfAttendance;
        private System.Windows.Forms.DataGridViewTextBoxColumn numberOfAbsences;
        private System.Windows.Forms.DataGridViewTextBoxColumn percentageStart;
        private System.Windows.Forms.DataGridViewTextBoxColumn percentageCameIn;
    }
}