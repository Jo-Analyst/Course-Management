using DataBase;
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

            try
            {
                if (!DB.ExistsDataBase())
                {
                    DB.CreateDatabase();
                    DB.CreateTables();
                    DB.InsertIntoClassTable();
                }

                this.Visible = false;

                new FrmCourseManagementt().ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Application.Exit();
            }
        }

        private void lbClose_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Application.Exit();
        }
    }
}
