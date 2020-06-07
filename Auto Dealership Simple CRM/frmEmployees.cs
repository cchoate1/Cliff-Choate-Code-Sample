using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CustomerResourceManagement
{
    public partial class frmEmployees : Form
    {
        public frmEmployees()
        {
            InitializeComponent();
        }

        private void frmEmployees_Activated(object sender, EventArgs e)
        {
            if (this.Text == "Add New Employees")
            {
                cboEmployees.Visible = false;
                btnAction.Text = "Add";
            }
            else if (this.Text == "Edit Employees")
            {
                cboEmployees.Visible = true;
                btnAction.Text = "Save";
            }
            else if (this.Text == "Delete Employees")
            {
                cboEmployees.Visible = true;
                btnAction.Text = "Delete";
            }
        }

        private void frmEmployees_Load(object sender, EventArgs e)
        {

        }
    }
}
