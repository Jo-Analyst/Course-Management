namespace CourseManagement
{
    partial class FrmReportPresenceStudent
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmReportPresenceStudent));
            this.label1 = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.cbNameStudents = new System.Windows.Forms.ComboBox();
            this.cbClass = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvListPresence = new System.Windows.Forms.DataGridView();
            this.presence = new System.Windows.Forms.DataGridViewImageColumn();
            this.date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DetailsAbsence = new System.Windows.Forms.DataGridViewImageColumn();
            this.descriptionReasonForAbsence = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListPresence)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(277, 22);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Aluno(a)";
            // 
            // cbNameStudents
            // 
            this.cbNameStudents.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbNameStudents.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbNameStudents.FormattingEnabled = true;
            this.cbNameStudents.Location = new System.Drawing.Point(277, 51);
            this.cbNameStudents.Margin = new System.Windows.Forms.Padding(4);
            this.cbNameStudents.Name = "cbNameStudents";
            this.cbNameStudents.Size = new System.Drawing.Size(440, 28);
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
            this.cbClass.Size = new System.Drawing.Size(241, 28);
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
            this.label2.Size = new System.Drawing.Size(54, 20);
            this.label2.TabIndex = 11;
            this.label2.Text = "Turma";
            // 
            // dgvListPresence
            // 
            this.dgvListPresence.AllowUserToAddRows = false;
            this.dgvListPresence.AllowUserToDeleteRows = false;
            this.dgvListPresence.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvListPresence.BackgroundColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.ControlDarkDark;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvListPresence.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvListPresence.ColumnHeadersHeight = 40;
            this.dgvListPresence.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvListPresence.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.presence,
            this.date,
            this.DetailsAbsence,
            this.descriptionReasonForAbsence});
            this.dgvListPresence.EnableHeadersVisualStyles = false;
            this.dgvListPresence.Location = new System.Drawing.Point(23, 102);
            this.dgvListPresence.Margin = new System.Windows.Forms.Padding(4);
            this.dgvListPresence.Name = "dgvListPresence";
            this.dgvListPresence.ReadOnly = true;
            this.dgvListPresence.RowHeadersVisible = false;
            this.dgvListPresence.RowHeadersWidth = 51;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            this.dgvListPresence.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvListPresence.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvListPresence.Size = new System.Drawing.Size(698, 397);
            this.dgvListPresence.TabIndex = 13;
            this.dgvListPresence.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvListPresence_CellClick);
            this.dgvListPresence.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvListPresence_CellDoubleClick);
            this.dgvListPresence.CellMouseEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvListPresence_CellMouseEnter);
            // 
            // presence
            // 
            this.presence.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.NullValue = ((object)(resources.GetObject("dataGridViewCellStyle2.NullValue")));
            this.presence.DefaultCellStyle = dataGridViewCellStyle2;
            this.presence.HeaderText = "";
            this.presence.MinimumWidth = 50;
            this.presence.Name = "presence";
            this.presence.ReadOnly = true;
            this.presence.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.presence.Width = 50;
            // 
            // date
            // 
            this.date.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.date.HeaderText = "Data";
            this.date.MinimumWidth = 6;
            this.date.Name = "date";
            this.date.ReadOnly = true;
            this.date.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // DetailsAbsence
            // 
            this.DetailsAbsence.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.DetailsAbsence.HeaderText = "Detalhes da falta";
            this.DetailsAbsence.Name = "DetailsAbsence";
            this.DetailsAbsence.ReadOnly = true;
            this.DetailsAbsence.Width = 136;
            // 
            // descriptionReasonForAbsence
            // 
            this.descriptionReasonForAbsence.HeaderText = "Motivo de Falta";
            this.descriptionReasonForAbsence.Name = "descriptionReasonForAbsence";
            this.descriptionReasonForAbsence.ReadOnly = true;
            // 
            // FrmReportPresenceStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(746, 526);
            this.Controls.Add(this.dgvListPresence);
            this.Controls.Add(this.cbClass);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbNameStudents);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.MinimizeBox = false;
            this.Name = "FrmReportPresenceStudent";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Relatório do Aluno";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmReportStudent_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListPresence)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.ComboBox cbNameStudents;
        private System.Windows.Forms.ComboBox cbClass;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvListPresence;
        private System.Windows.Forms.DataGridViewImageColumn presence;
        private System.Windows.Forms.DataGridViewTextBoxColumn date;
        private System.Windows.Forms.DataGridViewImageColumn DetailsAbsence;
        private System.Windows.Forms.DataGridViewTextBoxColumn descriptionReasonForAbsence;
    }
}