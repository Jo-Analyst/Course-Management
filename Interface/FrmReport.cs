using DataBase;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Interface
{
    public partial class FrmReport : Form
    {
        public FrmReport()
        {
            InitializeComponent();
        }

        private void btnStudent_Click(object sender, EventArgs e)
        {
            new FrmReportStudent().ShowDialog();
        }

        private void btnTurma_Click(object sender, EventArgs e)
        {

        }

        private void FrmReport_Load(object sender, EventArgs e)
        {
            lblQuantityStudentsRegistered.Text += new Student().FindAll().Rows.Count.ToString();
        }
    }
}
