using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SDEV265___Layout
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void Price_range_Connector_Click(object sender, EventArgs e)
        {

        }

        private void LinkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void TextBox17_TextChanged(object sender, EventArgs e)
        {

        }

        private void MyRecord_Click(object sender, EventArgs e)
        {
            // If not manager/HR/ should not have access to others' records, set to visible
            // and employee search to invisible
        }

        private void ViewEmployee_Click(object sender, EventArgs e)
        {
            // If user should have access to other employee records, set this and employee
            // search to visible, else, only "MyRecord" is visible
        }

        private void EmployeeList_SelectedIndexChanged(object sender, EventArgs e)
        {
            // only visible if user should have access to other employee records
        }

        private void Customer_Name_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // opens customer's record

        }
    }
}
