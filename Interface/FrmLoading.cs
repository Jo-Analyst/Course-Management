using System;
using System.Windows.Forms;

namespace CourseManagement
{
    public partial class FrmLoading : Form
    {
        public FrmLoading()
        {
            InitializeComponent();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            if (pbLoading.Value < 100)
            {
                pbLoading.Value += 5;
                return;
            }

            timer.Stop();
            this.Visible = false;

            new FrmCourseManagementt().ShowDialog();
        }
    }
}
