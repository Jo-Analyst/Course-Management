namespace CourseManagement
{
    partial class FrmContent
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmContent));
            this.btnNew = new System.Windows.Forms.Button();
            this.dgvContent = new System.Windows.Forms.DataGridView();
            this.cbMatter = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cbClass = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ColumnEdit = new System.Windows.Forms.DataGridViewImageColumn();
            this.ColumnDelete = new System.Windows.Forms.DataGridViewImageColumn();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.wording = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.matter = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.classStudent = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.classId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvContent)).BeginInit();
            this.SuspendLayout();
            // 
            // btnNew
            // 
            this.btnNew.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNew.ForeColor = System.Drawing.Color.White;
            this.btnNew.Location = new System.Drawing.Point(32, 30);
            this.btnNew.Margin = new System.Windows.Forms.Padding(5);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(149, 55);
            this.btnNew.TabIndex = 0;
            this.btnNew.Text = "Novo";
            this.btnNew.UseVisualStyleBackColor = true;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // dgvContent
            // 
            this.dgvContent.AllowUserToAddRows = false;
            this.dgvContent.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dgvContent.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvContent.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvContent.BackgroundColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.ControlDarkDark;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvContent.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvContent.ColumnHeadersHeight = 40;
            this.dgvContent.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvContent.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnEdit,
            this.ColumnDelete,
            this.id,
            this.wording,
            this.matter,
            this.classStudent,
            this.date,
            this.classId});
            this.dgvContent.EnableHeadersVisualStyles = false;
            this.dgvContent.Location = new System.Drawing.Point(34, 180);
            this.dgvContent.Margin = new System.Windows.Forms.Padding(4);
            this.dgvContent.Name = "dgvContent";
            this.dgvContent.ReadOnly = true;
            this.dgvContent.RowHeadersVisible = false;
            this.dgvContent.RowHeadersWidth = 51;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvContent.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvContent.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvContent.Size = new System.Drawing.Size(1028, 337);
            this.dgvContent.TabIndex = 2;
            this.dgvContent.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvStudent_CellClick);
            this.dgvContent.CellMouseEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvContent_CellMouseEnter);
            // 
            // cbMatter
            // 
            this.cbMatter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbMatter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbMatter.FormattingEnabled = true;
            this.cbMatter.Items.AddRange(new object[] {
            "",
            "Nocões Básicas",
            "Word",
            "Excel",
            "Power Point"});
            this.cbMatter.Location = new System.Drawing.Point(34, 139);
            this.cbMatter.Margin = new System.Windows.Forms.Padding(4);
            this.cbMatter.Name = "cbMatter";
            this.cbMatter.Size = new System.Drawing.Size(262, 28);
            this.cbMatter.TabIndex = 15;
            this.cbMatter.SelectedIndexChanged += new System.EventHandler(this.cbMatter_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(29, 110);
            this.label4.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 20);
            this.label4.TabIndex = 16;
            this.label4.Text = "Matéria";
            // 
            // cbClass
            // 
            this.cbClass.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbClass.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbClass.FormattingEnabled = true;
            this.cbClass.Location = new System.Drawing.Point(304, 139);
            this.cbClass.Margin = new System.Windows.Forms.Padding(4);
            this.cbClass.Name = "cbClass";
            this.cbClass.Size = new System.Drawing.Size(262, 28);
            this.cbClass.TabIndex = 17;
            this.cbClass.SelectedIndexChanged += new System.EventHandler(this.cbClass_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(300, 110);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 20);
            this.label1.TabIndex = 18;
            this.label1.Text = "Turma";
            // 
            // ColumnEdit
            // 
            this.ColumnEdit.HeaderText = "Editar";
            this.ColumnEdit.Name = "ColumnEdit";
            this.ColumnEdit.ReadOnly = true;
            this.ColumnEdit.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ColumnEdit.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // ColumnDelete
            // 
            this.ColumnDelete.HeaderText = "Excluir";
            this.ColumnDelete.Name = "ColumnDelete";
            this.ColumnDelete.ReadOnly = true;
            this.ColumnDelete.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ColumnDelete.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
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
            // wording
            // 
            this.wording.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.wording.DataPropertyName = "name";
            this.wording.HeaderText = "Conteúdo Passado";
            this.wording.MinimumWidth = 6;
            this.wording.Name = "wording";
            this.wording.ReadOnly = true;
            this.wording.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // matter
            // 
            this.matter.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.matter.DefaultCellStyle = dataGridViewCellStyle4;
            this.matter.HeaderText = "Matéria";
            this.matter.MinimumWidth = 6;
            this.matter.Name = "matter";
            this.matter.ReadOnly = true;
            this.matter.Width = 87;
            // 
            // classStudent
            // 
            this.classStudent.HeaderText = "Turma";
            this.classStudent.MinimumWidth = 6;
            this.classStudent.Name = "classStudent";
            this.classStudent.ReadOnly = true;
            this.classStudent.Width = 125;
            // 
            // date
            // 
            this.date.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.date.DataPropertyName = "class";
            this.date.HeaderText = "Data";
            this.date.MinimumWidth = 6;
            this.date.Name = "date";
            this.date.ReadOnly = true;
            this.date.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.date.Width = 50;
            // 
            // classId
            // 
            this.classId.HeaderText = "Class_id";
            this.classId.MinimumWidth = 6;
            this.classId.Name = "classId";
            this.classId.ReadOnly = true;
            this.classId.Visible = false;
            this.classId.Width = 125;
            // 
            // FrmContent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(1075, 530);
            this.Controls.Add(this.cbClass);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbMatter);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dgvContent);
            this.Controls.Add(this.btnNew);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.MinimizeBox = false;
            this.Name = "FrmContent";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Conteúdo";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmContent_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvContent)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.DataGridView dgvContent;
        private System.Windows.Forms.ComboBox cbMatter;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbClass;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewImageColumn ColumnEdit;
        private System.Windows.Forms.DataGridViewImageColumn ColumnDelete;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn wording;
        private System.Windows.Forms.DataGridViewTextBoxColumn matter;
        private System.Windows.Forms.DataGridViewTextBoxColumn classStudent;
        private System.Windows.Forms.DataGridViewTextBoxColumn date;
        private System.Windows.Forms.DataGridViewTextBoxColumn classId;
    }
}