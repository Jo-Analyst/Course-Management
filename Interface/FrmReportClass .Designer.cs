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
            this.cbClasses = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.dgvReportClass = new System.Windows.Forms.DataGridView();
            this.button2 = new System.Windows.Forms.Button();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.classStudent = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numberOfAttendence = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numberOfAbsences = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.percentage = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReportClass)).BeginInit();
            this.SuspendLayout();
            // 
            // cbClasses
            // 
            this.cbClasses.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbClasses.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbClasses.FormattingEnabled = true;
            this.cbClasses.Items.AddRange(new object[] {
            "A1 - Manhã",
            "A2 -Tarde",
            "A3 - Noite",
            "B1- Manhã",
            "B2 -Tarde",
            "B3 - Noite",
            "Todos"});
            this.cbClasses.Location = new System.Drawing.Point(18, 41);
            this.cbClasses.Name = "cbClasses";
            this.cbClasses.Size = new System.Drawing.Size(298, 24);
            this.cbClasses.TabIndex = 12;
            this.cbClasses.SelectedIndexChanged += new System.EventHandler(this.cbClasses_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(15, 20);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 17);
            this.label2.TabIndex = 11;
            this.label2.Text = "Turma";
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(540, 326);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(176, 42);
            this.button1.TabIndex = 13;
            this.button1.Text = "Imprimir Relatório";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // dgvReportClass
            // 
            this.dgvReportClass.AllowUserToAddRows = false;
            this.dgvReportClass.AllowUserToDeleteRows = false;
            this.dgvReportClass.BackgroundColor = System.Drawing.Color.Gray;
            this.dgvReportClass.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvReportClass.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvReportClass.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvReportClass.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvReportClass.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.name,
            this.classStudent,
            this.numberOfAttendence,
            this.numberOfAbsences,
            this.percentage});
            this.dgvReportClass.Location = new System.Drawing.Point(18, 71);
            this.dgvReportClass.Name = "dgvReportClass";
            this.dgvReportClass.ReadOnly = true;
            this.dgvReportClass.RowHeadersVisible = false;
            this.dgvReportClass.RowHeadersWidth = 51;
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black;
            this.dgvReportClass.RowsDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvReportClass.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvReportClass.Size = new System.Drawing.Size(698, 249);
            this.dgvReportClass.TabIndex = 14;
            this.dgvReportClass.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvReportClass_CellClick);
            this.dgvReportClass.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvReportClass_CellDoubleClick);
            // 
            // button2
            // 
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(382, 325);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(152, 42);
            this.button2.TabIndex = 15;
            this.button2.Text = "Visualizar Relatório";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
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
            this.id.Width = 46;
            // 
            // name
            // 
            this.name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.name.DataPropertyName = "name";
            this.name.HeaderText = "Nome";
            this.name.MinimumWidth = 6;
            this.name.Name = "name";
            this.name.ReadOnly = true;
            this.name.Width = 70;
            // 
            // classStudent
            // 
            this.classStudent.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.classStudent.DataPropertyName = "class";
            this.classStudent.HeaderText = "Turma";
            this.classStudent.MinimumWidth = 6;
            this.classStudent.Name = "classStudent";
            this.classStudent.ReadOnly = true;
            this.classStudent.Width = 74;
            // 
            // numberOfAttendence
            // 
            this.numberOfAttendence.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.numberOfAttendence.DataPropertyName = "numberOfAttendence";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.numberOfAttendence.DefaultCellStyle = dataGridViewCellStyle3;
            this.numberOfAttendence.HeaderText = "Número de Presenças";
            this.numberOfAttendence.Name = "numberOfAttendence";
            this.numberOfAttendence.ReadOnly = true;
            this.numberOfAttendence.Width = 174;
            // 
            // numberOfAbsences
            // 
            this.numberOfAbsences.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.numberOfAbsences.DataPropertyName = "numberOfAbsences";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.numberOfAbsences.DefaultCellStyle = dataGridViewCellStyle4;
            this.numberOfAbsences.HeaderText = "Número de Faltas";
            this.numberOfAbsences.Name = "numberOfAbsences";
            this.numberOfAbsences.ReadOnly = true;
            this.numberOfAbsences.Width = 145;
            // 
            // percentage
            // 
            this.percentage.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.percentage.DefaultCellStyle = dataGridViewCellStyle5;
            this.percentage.HeaderText = "%";
            this.percentage.Name = "percentage";
            this.percentage.ReadOnly = true;
            this.percentage.Width = 45;
            // 
            // FrmReportClass
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(735, 382);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.dgvReportClass);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cbClasses);
            this.Controls.Add(this.label2);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmReportClass";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Relatório da Turma";
            ((System.ComponentModel.ISupportInitialize)(this.dgvReportClass)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.ComboBox cbClasses;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dgvReportClass;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn classStudent;
        private System.Windows.Forms.DataGridViewTextBoxColumn numberOfAttendence;
        private System.Windows.Forms.DataGridViewTextBoxColumn numberOfAbsences;
        private System.Windows.Forms.DataGridViewTextBoxColumn percentage;
    }
}