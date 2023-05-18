namespace CourseManagement
{
    partial class Form1
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvListPresence = new System.Windows.Forms.DataGridView();
            this.presence = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.imageCheck = new System.Windows.Forms.DataGridViewImageColumn();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gender = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.classStudent = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.shift = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.reasonForAbsence = new System.Windows.Forms.DataGridViewImageColumn();
            this.descriptionReasonForAbsence = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.reasonForAbsenceId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.listAttendance_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListPresence)).BeginInit();
            this.SuspendLayout();
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
            this.imageCheck,
            this.id,
            this.name,
            this.gender,
            this.classStudent,
            this.shift,
            this.reasonForAbsence,
            this.descriptionReasonForAbsence,
            this.reasonForAbsenceId,
            this.listAttendance_id});
            this.dgvListPresence.EnableHeadersVisualStyles = false;
            this.dgvListPresence.Location = new System.Drawing.Point(122, 63);
            this.dgvListPresence.Margin = new System.Windows.Forms.Padding(4);
            this.dgvListPresence.Name = "dgvListPresence";
            this.dgvListPresence.RowHeadersVisible = false;
            this.dgvListPresence.RowHeadersWidth = 51;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvListPresence.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvListPresence.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvListPresence.Size = new System.Drawing.Size(942, 325);
            this.dgvListPresence.TabIndex = 5;
            // 
            // presence
            // 
            this.presence.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.NullValue = false;
            this.presence.DefaultCellStyle = dataGridViewCellStyle2;
            this.presence.HeaderText = "";
            this.presence.MinimumWidth = 50;
            this.presence.Name = "presence";
            this.presence.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.presence.Visible = false;
            this.presence.Width = 50;
            // 
            // imageCheck
            // 
            this.imageCheck.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.imageCheck.HeaderText = "";
            this.imageCheck.MinimumWidth = 50;
            this.imageCheck.Name = "imageCheck";
            this.imageCheck.Width = 50;
            // 
            // id
            // 
            this.id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.id.DataPropertyName = "id";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.id.DefaultCellStyle = dataGridViewCellStyle3;
            this.id.HeaderText = "ID";
            this.id.MinimumWidth = 6;
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.id.Visible = false;
            this.id.Width = 32;
            // 
            // name
            // 
            this.name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.name.DataPropertyName = "name";
            this.name.HeaderText = "Nome";
            this.name.MinimumWidth = 6;
            this.name.Name = "name";
            this.name.ReadOnly = true;
            this.name.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // gender
            // 
            this.gender.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.gender.DefaultCellStyle = dataGridViewCellStyle4;
            this.gender.HeaderText = "Gênero";
            this.gender.MinimumWidth = 6;
            this.gender.Name = "gender";
            this.gender.ReadOnly = true;
            this.gender.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.gender.Width = 69;
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
            this.classStudent.Width = 60;
            // 
            // shift
            // 
            this.shift.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.shift.HeaderText = "Turno";
            this.shift.MinimumWidth = 6;
            this.shift.Name = "shift";
            this.shift.ReadOnly = true;
            this.shift.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.shift.Width = 56;
            // 
            // reasonForAbsence
            // 
            this.reasonForAbsence.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.reasonForAbsence.HeaderText = "M. F.";
            this.reasonForAbsence.MinimumWidth = 50;
            this.reasonForAbsence.Name = "reasonForAbsence";
            this.reasonForAbsence.ToolTipText = "Motivo da falta";
            this.reasonForAbsence.Width = 50;
            // 
            // descriptionReasonForAbsence
            // 
            this.descriptionReasonForAbsence.HeaderText = "Motivo da falta";
            this.descriptionReasonForAbsence.Name = "descriptionReasonForAbsence";
            // 
            // reasonForAbsenceId
            // 
            this.reasonForAbsenceId.HeaderText = "reasonForAbsenceId";
            this.reasonForAbsenceId.Name = "reasonForAbsenceId";
            // 
            // listAttendance_id
            // 
            this.listAttendance_id.HeaderText = "listAttendance_id";
            this.listAttendance_id.MinimumWidth = 6;
            this.listAttendance_id.Name = "listAttendance_id";
            this.listAttendance_id.Visible = false;
            this.listAttendance_id.Width = 125;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1186, 450);
            this.Controls.Add(this.dgvListPresence);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dgvListPresence)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvListPresence;
        private System.Windows.Forms.DataGridViewCheckBoxColumn presence;
        private System.Windows.Forms.DataGridViewImageColumn imageCheck;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn gender;
        private System.Windows.Forms.DataGridViewTextBoxColumn classStudent;
        private System.Windows.Forms.DataGridViewTextBoxColumn shift;
        private System.Windows.Forms.DataGridViewImageColumn reasonForAbsence;
        private System.Windows.Forms.DataGridViewTextBoxColumn descriptionReasonForAbsence;
        private System.Windows.Forms.DataGridViewTextBoxColumn reasonForAbsenceId;
        private System.Windows.Forms.DataGridViewTextBoxColumn listAttendance_id;
    }
}