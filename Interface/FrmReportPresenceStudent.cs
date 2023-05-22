using DataBase;
using Microsoft.Reporting.WinForms;
using Microsoft.ReportingServices.Diagnostics.Internal;
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

        private void CbClass_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                var dtStudent = student.FindByClass(cbClass.Text).Rows;

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

        private void CbStudents_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (cbClass.Items.Count == 0)
                    return;

                int student_id = int.Parse(student.FindByName(cbNameStudents.Text).Rows[0]["id"].ToString());
                LoadDgvListPresenceStudent(student_id);               
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadDgvListPresenceStudent(int student_id)
        {
            var dtGetListPresenceStudentByStudentId = listAttendance.GetListPresenceStudentByStudentId(student_id);
            dgvListPresence.Rows.Clear();
            foreach (DataRow dr in dtGetListPresenceStudentByStudentId.Rows)
            {
                int index = dgvListPresence.Rows.Add();
                dgvListPresence.Rows[index].Cells["presence"].Value = dr["presence"].ToString() == "1" ? Properties.Resources.Pictogrammers_Material_Checkbox_marked_outline_24 : Properties.Resources.Pictogrammers_Material_Checkbox_blank_outline_24;
                dgvListPresence.Rows[index].Cells["presenceSelect"].Value = dr["presence"].ToString() == "1" ? "true" : "false";
                dgvListPresence.Rows[index].Cells["date"].Value = dr["date"].ToString();
                dgvListPresence.Rows[index].Cells["DetailsAbsence"].Value = dr["presence"].ToString() == "0" ? Properties.Resources.kebad : Properties.Resources.white;
                dgvListPresence.Rows[index].Cells["descriptionReasonForAbsence"].Value = string.IsNullOrEmpty(dr["description"].ToString()) ? "--- Nenhum motivo ---" : dr["description"].ToString();
                dgvListPresence.Rows[index].Height = 35;
            }

            dgvListPresence.ClearSelection();
        }

        private void FrmReportStudent_Load(object sender, EventArgs e)
        {
            LoadCbClass();
        }

        private void DgvListPresence_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (Convert.ToBoolean(dgvListPresence.Rows[e.RowIndex].Cells["presenceSelect"].Value))
                return;

            new FrmFaultDetails(cbNameStudents.Text, dgvListPresence.Rows[e.RowIndex].Cells["date"].Value.ToString(), dgvListPresence.Rows[e.RowIndex].Cells["descriptionReasonForAbsence"].Value.ToString()).ShowDialog();
        }

        private void dgvListPresence_CellMouseEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
                dgvListPresence.Cursor = e.ColumnIndex == 3 && dgvListPresence.Rows[e.RowIndex].Cells["presenceSelect"].Value.ToString() == "false" ? Cursors.Hand : Cursors.Default;
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
            return new ReportDataSource("dtListPresenceAndAbsenceStudent", ListPresenceStudent());
        }

        private void btnViewReport_Click(object sender, EventArgs e)
        {
            new FrmViewReport(GetDataListPresenceAndAbsenceStudent(), "CourseManagement.reportPresenceAndAbsence.rdlc", cbNameStudents.Text).ShowDialog();
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            ReportViewerPrint.PrintDirecty(GetDataListPresenceAndAbsenceStudent(), "CourseManagement.reportPresenceAndAbsence.rdlc", cbNameStudents.Text);
        }

        private void FrmReportPresenceStudent_KeyDown(object sender, KeyEventArgs e)
        {
            if (btnViewReport.Enabled && e.Control && e.Shift && e.KeyCode == Keys.P)
                btnViewReport_Click(sender, e);
            else if (btnPrint.Enabled && e.Control && e.KeyCode == Keys.P)
                btnPrint_Click(sender, e);
        }
    }
}
