namespace Interface
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
            this.btnViewReport = new System.Windows.Forms.Button();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.classStudent = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.shift = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numberOfAttendence = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numberOfAbsences = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.percentageStart = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.percentageCameIn = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.cbClass.Size = new System.Drawing.Size(357, 33);
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
            this.label2.Size = new System.Drawing.Size(69, 25);
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
            this.id,
            this.name,
            this.classStudent,
            this.shift,
            this.numberOfAttendence,
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
            this.dgvReportClass.RowsDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvReportClass.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvReportClass.Size = new System.Drawing.Size(1169, 291);
            this.dgvReportClass.TabIndex = 14;
            this.dgvReportClass.TabStop = false;
            this.dgvReportClass.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvReportClass_CellClick);
            this.dgvReportClass.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvReportClass_CellDoubleClick);
            // 
            // btnViewReport
            // 
            this.btnViewReport.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnViewReport.Enabled = false;
            this.btnViewReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnViewReport.Location = new System.Drawing.Point(851, 384);
            this.btnViewReport.Margin = new System.Windows.Forms.Padding(4);
            this.btnViewReport.Name = "btnViewReport";
            this.btnViewReport.Size = new System.Drawing.Size(331, 52);
            this.btnViewReport.TabIndex = 15;
            this.btnViewReport.TabStop = false;
            this.btnViewReport.Text = "Visualizar e Imprimir Relatório";
            this.btnViewReport.UseVisualStyleBackColor = true;
            this.btnViewReport.Click += new System.EventHandler(this.btnViewReport_Click);
            // 
            // id
            // 
            this.id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.id.DataPropertyName = "id";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            this.id.DefaultCellStyle = dataGridViewCellStyle2;
            this.id.HeaderText = "ID";
            this.id.MinimumWidth = 6;
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.id.Width = 36;
            // 
            // name
            // 
            this.name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.name.DataPropertyName = "name";
            this.name.HeaderText = "Nome";
            this.name.MinimumWidth = 6;
            this.name.Name = "name";
            this.name.ReadOnly = true;
            this.name.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.name.Width = 69;
            // 
            // classStudent
            // 
            this.classStudent.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.classStudent.DataPropertyName = "class";
            this.classStudent.HeaderText = "Turma";
            this.classStudent.MinimumWidth = 6;
            this.classStudent.Name = "classStudent";
            this.classStudent.ReadOnly = true;
            this.classStudent.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.classStudent.Width = 74;
            // 
            // shift
            // 
            this.shift.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.shift.HeaderText = "Turno";
            this.shift.MinimumWidth = 6;
            this.shift.Name = "shift";
            this.shift.ReadOnly = true;
            this.shift.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.shift.Width = 69;
            // 
            // numberOfAttendence
            // 
            this.numberOfAttendence.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.numberOfAttendence.DataPropertyName = "numberOfAttendence";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.numberOfAttendence.DefaultCellStyle = dataGridViewCellStyle3;
            this.numberOfAttendence.HeaderText = "Número de Presenças";
            this.numberOfAttendence.MinimumWidth = 6;
            this.numberOfAttendence.Name = "numberOfAttendence";
            this.numberOfAttendence.ReadOnly = true;
            this.numberOfAttendence.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.numberOfAttendence.Width = 211;
            // 
            // numberOfAbsences
            // 
            this.numberOfAbsences.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.numberOfAbsences.DataPropertyName = "numberOfAbsences";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.numberOfAbsences.DefaultCellStyle = dataGridViewCellStyle4;
            this.numberOfAbsences.HeaderText = "Número de Faltas";
            this.numberOfAbsences.MinimumWidth = 6;
            this.numberOfAbsences.Name = "numberOfAbsences";
            this.numberOfAbsences.ReadOnly = true;
            this.numberOfAbsences.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.numberOfAbsences.Width = 171;
            // 
            // percentageStart
            // 
            this.percentageStart.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.percentageStart.HeaderText = "% desde o início";
            this.percentageStart.MinimumWidth = 6;
            this.percentageStart.Name = "percentageStart";
            this.percentageStart.ReadOnly = true;
            this.percentageStart.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.percentageStart.Width = 159;
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
            this.percentageCameIn.Width = 192;
            // 
            // FrmReportClass
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(1195, 453);
            this.Controls.Add(this.btnViewReport);
            this.Controls.Add(this.dgvReportClass);
            this.Controls.Add(this.cbClass);
            this.Controls.Add(this.label2);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.MinimizeBox = false;
            this.Name = "FrmReportClass";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Relatório da Turma";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmReportClass_Load);
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
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn classStudent;
        private System.Windows.Forms.DataGridViewTextBoxColumn shift;
        private System.Windows.Forms.DataGridViewTextBoxColumn numberOfAttendence;
        private System.Windows.Forms.DataGridViewTextBoxColumn numberOfAbsences;
        private System.Windows.Forms.DataGridViewTextBoxColumn percentageStart;
        private System.Windows.Forms.DataGridViewTextBoxColumn percentageCameIn;
    }
}