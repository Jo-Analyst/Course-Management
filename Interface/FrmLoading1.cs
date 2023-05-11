using System;
using System.Windows.Forms;

namespace CourseManagement
{
    public partial class FrmLoading1 : Form
    {
        public FrmLoading1()
        {
            InitializeComponent();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            if (pbLoading.Value < 100)
            {
                pbLoading.Value += 5;
            }
            else
            {
                timer.Stop();
                this.Visible = false;


            }
        }
    }
}
