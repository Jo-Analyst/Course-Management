using System.Windows.Forms;

namespace CourseManagement
{
    public partial class FrmFaultDetails : Form
    {
        public FrmFaultDetails(string nameStudent, string date, string descriptionReasonForAbsence)
        {
            InitializeComponent();
            txtNameStudent.Text = nameStudent;
            txtDateAbcence.Text = date;
            rtbDescriptionReasonForAbsence.Text = descriptionReasonForAbsence;
        }
    }
}
