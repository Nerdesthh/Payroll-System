using Microsoft.Win32.SafeHandles;
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
    public partial class Selection : Form
    {
        public Selection()
        {
            InitializeComponent();
        }

        private void teacher_Click(object sender, EventArgs e)
        {
            this.Hide();
            if (CommonClass.teacherslogin == null || CommonClass.teacherslogin.IsDisposed)
            {
                CommonClass.teacherslogin = new Teachers();
            }
            CommonClass.teacherslogin.Show();
            CommonClass.teacherslogin.BringToFront();
        }

        private void Selection_Load(object sender, EventArgs e)
        {

        }

        private void admin_Click(object sender, EventArgs e)
        {
            this.Hide();
            if (CommonClass.adminlogin == null || CommonClass.adminlogin.IsDisposed)
            {
                CommonClass.adminlogin = new Login();
            }
            CommonClass.adminlogin.Show();
            CommonClass.adminlogin.BringToFront();

        }

        private void Credits_Click(object sender, EventArgs e)
        {
            this.Hide();
            if (CommonClass.credits == null || CommonClass.credits.IsDisposed)
            {
                CommonClass.credits = new Credits();
            }
            CommonClass.credits.Show();
            CommonClass.credits.BringToFront();
        }
    }
}
