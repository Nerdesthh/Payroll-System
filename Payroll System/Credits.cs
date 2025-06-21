using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Payroll_System
{
    public partial class Credits : Form
    {
        public Credits()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {

        }

        private void label23_Click(object sender, EventArgs e)
        {

        }
        private void label24_Click(object sender, EventArgs e)
        {

        }

        private void label22_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            if (CommonClass.Selection == null || CommonClass.Selection.IsDisposed)
            {
                CommonClass.Selection = new Selection();
            }
            CommonClass.Selection.Show();
            CommonClass.Selection.BringToFront();
        }

        private void Credits_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            if (CommonClass.Selection == null || CommonClass.Selection.IsDisposed)
            {
                CommonClass.Selection = new Selection();
            }
            CommonClass.Selection.Show();
            CommonClass.Selection.BringToFront();
        }
    }
}
