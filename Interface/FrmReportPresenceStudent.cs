using DataBase;
using Microsoft.Reporting.WinForms;
using System;
using System.Data;
using System.Windows.Forms;

namespace CourseManagement
{
    public partial class FrmReportPresenceStudent : Form
    {
        public FrmReportPresenceStudent()
        {
            InitializeComponent();
        }

        Student student = new Student();
        Class @class = new Class();
        ListAttendance listAttendance = new ListAttendance();
        string shift;

        private void CbClass_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                var dtStudent = Student.FindByClass(cbClass.Text).Rows;

                cbNameStudents.Items.Clear();

                foreach (DataRow dr in dtStudent)
                {
                    cbNameStudents.Items.Add(dr["name"].ToString());
                }

                if (dtStudent.Count > 0)
                {
                    cbNameStudents.SelectedIndex = 0;
                    btnPrint.Enabled = true;
                    btnViewReport.Enabled = true;
                    cbxListByStudent.Enabled = true;
                    shift = dtStudent[0]["shift"].ToString();
                }

                if (!cbxListByStudent.Checked)
                {
                    LoadListPresenceStudent(student_id);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadCbClass()
        {
            var dtClasses = @class.FindAll();
            foreach (DataRow dr in dtClasses.Rows)
            {
                cbClass.Items.Add(dr["name"]);
            }
        }

        int student_id;
        private void CbStudents_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (cbClass.Items.Count == 0)
                    return;

                student_id = GetStudentID();

                LoadListPresenceStudent(student_id);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private int GetStudentID()
        {
            return cbxListByStudent.Checked ? int.Parse(student.FindByName(cbNameStudents.Text).Rows[0]["id"].ToString()) : 0;
        }

        DataTable dtGetListPresence;

        private void LoadListPresenceStudent(int student_id)
        {
            dtGetListPresence = cbxListByStudent.Checked ? listAttendance.GetListPresenceStudentByStudentId(student_id) : listAttendance.GetListPresenceClass(cbClass.Text.ToLower() == "todos" ? "" : cbClass.Text);
            LoadDgvListPresence();
        }

        private void LoadDgvListPresence()
        {
            DataTable dt = dtGetListPresenceFilterd(dtGetListPresence);
            dgvListPresence.Rows.Clear();

            foreach (DataRow dr in dt.Rows)
            {
                int index = dgvListPresence.Rows.Add();
                dgvListPresence.Rows[index].Cells["presence"].Value = dr["presence"].ToString() == "1" ? Properties.Resources.Pictogrammers_Material_Checkbox_marked_outline_24 : Properties.Resources.Pictogrammers_Material_Checkbox_blank_outline_24;
                dgvListPresence.Rows[index].Cells["presenceSelect"].Value = dr["presence"].ToString() == "1" ? "true" : "false";
                dgvListPresence.Rows[index].Cells["date"].Value = dr["date"].ToString();
                dgvListPresence.Rows[index].Cells["DetailsAbsence"].Value = dr["presence"].ToString() == "0" ? Properties.Resources.kebad : Properties.Resources.white;
                dgvListPresence.Rows[index].Cells["descriptionReasonForAbsence"].Value = string.IsNullOrEmpty(dr["description"].ToString()) ? "--- Nenhum motivo ---" : dr["description"].ToString();
                dgvListPresence.Rows[index].Cells["ColName"].Value = cbxListByStudent.Checked ? "" : dr["nameStudent"].ToString();
                dgvListPresence.Rows[index].Cells["ColNameClass"].Value = cbxListByStudent.Checked ? "" : dr["class"].ToString();
                dgvListPresence.Rows[index].Height = 35;
            }

            dgvListPresence.ClearSelection();
        }

        DataTable dtListPresenceFilterd = new DataTable();
        DataTable dtListAbsenceFilterd = new DataTable();
        private DataTable dtGetListPresenceFilterd(DataTable dtGetListPresence)
        {

            if (rbAll.Checked)
                return LimitTableRows(dtGetListPresence);

            dtListPresenceFilterd.Columns.Clear();
            dtListPresenceFilterd.Columns.Add("presence", typeof(string));
            dtListPresenceFilterd.Columns.Add("date", typeof(string));
            dtListPresenceFilterd.Columns.Add("description", typeof(string));
            dtListPresenceFilterd.Columns.Add("nameStudent", typeof(string));
            dtListPresenceFilterd.Columns.Add("class", typeof(string));

            dtListAbsenceFilterd.Columns.Clear();
            dtListAbsenceFilterd.Columns.Add("presence", typeof(string));
            dtListAbsenceFilterd.Columns.Add("date", typeof(string));
            dtListAbsenceFilterd.Columns.Add("description", typeof(string));
            dtListAbsenceFilterd.Columns.Add("nameStudent", typeof(string));
            dtListAbsenceFilterd.Columns.Add("class", typeof(string));

            dtListPresenceFilterd.Rows.Clear();
            dtListAbsenceFilterd.Rows.Clear();
            foreach (DataRow row in dtGetListPresence.Rows)
            {
                if (row["presence"].ToString() == "1")
                    dtListPresenceFilterd.Rows.Add("1", row["date"].ToString(), row["description"].ToString(), cbxListByStudent.Checked ? "" : row["nameStudent"].ToString(), cbxListByStudent.Checked ? "" : row["class"].ToString());
                else
                    dtListAbsenceFilterd.Rows.Add("0", row["date"].ToString(), row["description"].ToString(), cbxListByStudent.Checked ? "" : row["nameStudent"].ToString(), cbxListByStudent.Checked ? "" : row["class"].ToString());

            }

            return rbPresence.Checked ? LimitTableRows(dtListPresenceFilterd) : LimitTableRows(dtListAbsenceFilterd);
        }

        private DataTable LimitTableRows(DataTable dtGetListPresence)
        {

            if (cbxListByStudent.Checked)
                return dtGetListPresence;

            var dt = new DataTable();
            dt.Columns.Add("presence", typeof(string));
            dt.Columns.Add("date", typeof(string));
            dt.Columns.Add("description", typeof(string));
            dt.Columns.Add("nameStudent", typeof(string));
            dt.Columns.Add("class", typeof(string));

            int topLimit =  dtGetListPresence.Rows.Count < int.Parse(cbTopLimit.Text) ? dtGetListPresence.Rows.Count :  int.Parse(cbTopLimit.Text);

            for (int i = 0; i < topLimit; i++)
            {
                dt.Rows.Add(dtGetListPresence.Rows[i]["presence"].ToString(), dtGetListPresence.Rows[i]["date"].ToString(), dtGetListPresence.Rows[i]["description"].ToString(), dtGetListPresence.Rows[i]["nameStudent"].ToString(), dtGetListPresence.Rows[i]["class"].ToString());
            }

            return dt;
        }

        private void FrmReportStudent_Load(object sender, EventArgs e)
        {
            LoadCbClass();
        }

        private void DgvListPresence_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1) return;

            if (bool.Parse(dgvListPresence.Rows[e.RowIndex].Cells["presenceSelect"].Value.ToString()))
                return;

            string date = dgvListPresence.Rows[e.RowIndex].Cells["date"].Value.ToString(), descriptionReasonForAbsence =
            dgvListPresence.Rows[e.RowIndex].Cells["descriptionReasonForAbsence"].Value == null ? "" : dgvListPresence.Rows[e.RowIndex].Cells["descriptionReasonForAbsence"].Value.ToString();

            if (e.ColumnIndex == 5)
                new FrmFaultDetails(dgvListPresence.CurrentRow.Cells["ColName"].Value.ToString(), date, descriptionReasonForAbsence).ShowDialog();
        }

        private void dgvListPresence_CellMouseEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
                dgvListPresence.Cursor = e.ColumnIndex == 5 && dgvListPresence.Rows[e.RowIndex].Cells["presenceSelect"].Value.ToString() == "false" ? Cursors.Hand : Cursors.Default;
        }

        private DataTable ListPresenceStudent()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("date", typeof(string));
            dt.Columns.Add("presence", typeof(string));
            dt.Columns.Add("reasonForAbsence", typeof(string));


            foreach (DataGridViewRow row in dgvListPresence.Rows)
            {
                string descriptionReasonForAbsence = bool.Parse(row.Cells["presenceSelect"].Value.ToString()) ? "---" : row.Cells["descriptionReasonForAbsence"].Value.ToString();

                dt.Rows.Add(row.Cells["date"].Value.ToString(), bool.Parse(row.Cells["presenceSelect"].Value.ToString()) ? "PRESENTE" : "FALTA", descriptionReasonForAbsence);
            }

            return dt;
        }

        private ReportDataSource GetDataListPresenceAndAbsenceStudent()
        {
            return cbxListByStudent.Checked ? new ReportDataSource("dtListPresenceAndAbsenceStudent", ListPresenceStudent()) : new ReportDataSource("dtStudents", Student.FindByClass(cbClass.Text));
        }

        string path, nameStudent;

        private void btnViewReport_Click(object sender, EventArgs e)
        {
            if (dgvListPresence.Rows.Count == 0)
            {
                MessageBox.Show("Não há lista para ser exibido!", "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            
            path = cbxListByStudent.Checked ? "CourseManagement.reportPresenceAndAbsence.rdlc" : "CourseManagement.ReportListPresenceByClass.rdlc";
            nameStudent = cbxListByStudent.Checked ? $"{cbNameStudents.Text} - {cbClass.Text} - {shift}" : string.Empty;

            new FrmViewReport(GetDataListPresenceAndAbsenceStudent(), path, nameStudent, cbxListByStudent.Checked, FilteringOption()).ShowDialog();
        }        

        private void btnPrint_Click(object sender, EventArgs e)
        {
            if (dgvListPresence.Rows.Count == 0)
            {
                MessageBox.Show("Não há lista para ser exibido!", "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            
            path = cbxListByStudent.Checked ? "CourseManagement.reportPresenceAndAbsence.rdlc" : "CourseManagement.ReportListPresenceByClass.rdlc";
            nameStudent = cbxListByStudent.Checked ? $"{cbNameStudents.Text} - {cbClass.Text} - {shift}" : string.Empty;

            ReportViewerPrint.PrintDirecty(GetDataListPresenceAndAbsenceStudent(), path, nameStudent, cbxListByStudent.Checked, FilteringOption());
        }

        private string FilteringOption()
        {
            if (rbAll.Checked)
                return string.Empty;

            return rbPresence.Checked ? "1" : "0";
        }

        private void FrmReportPresenceStudent_KeyDown(object sender, KeyEventArgs e)
        {
            if (btnViewReport.Enabled && e.Control && e.Shift && e.KeyCode == Keys.P)
                btnViewReport_Click(sender, e);
            else if (btnPrint.Enabled && e.Control && e.KeyCode == Keys.P)
                btnPrint_Click(sender, e);
        }

        private void cbxListByStudent_CheckedChanged(object sender, EventArgs e)
        {
            if (cbxListByStudent.Checked && cbClass.SelectedIndex > -1)
            {
                cbNameStudents.Enabled = true;
                dgvListPresence.Columns["ColName"].Visible = false;
                dgvListPresence.Columns["ColNameClass"].Visible = false;
                this.ColName.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                this.date.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                cbTopLimit.Visible = false;
            }
            else if (!cbxListByStudent.Checked && cbClass.SelectedIndex > -1)
            {
                cbNameStudents.Enabled = false;
                dgvListPresence.Columns["ColName"].Visible = true;
                this.ColName.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                this.date.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                dgvListPresence.Columns["ColNameClass"].Visible = true;
                cbTopLimit.Visible = true;
                cbTopLimit.SelectedIndex = 0;
            }

            student_id = GetStudentID();
            LoadListPresenceStudent(student_id);
        }

        private void rbPresence_CheckedChanged(object sender, EventArgs e)
        {
            LoadListPresenceStudent(student_id);
        }

        private void rbAbsence_CheckedChanged(object sender, EventArgs e)
        {
            LoadListPresenceStudent(student_id);
        }

        private void rbAll_CheckedChanged(object sender, EventArgs e)
        {
            LoadListPresenceStudent(student_id);
        }

        private void cbTopLimit_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadListPresenceStudent(student_id);
        }
    }
}
