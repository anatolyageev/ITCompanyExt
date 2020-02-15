using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ITCompanyExt.UI
{
    public partial class RegisterUserForm : Form
    {
        public RegisterUserForm()
        {
            InitializeComponent();
            DepartmentsComboBox.Items.AddRange(
                new string[] { "Designers", "Developers", "Managers" });
        }

        private void textBox1_Validating(object sender, CancelEventArgs e)
        {

        }

        private bool IsValidEmail(string strIn)
            {
                     // Return true if strIn is in valid e-mail format.
                 return Regex.IsMatch(strIn, @"^([\w-\.]+)@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([\w-]+\.)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$");
            }

        private void DepartmentsComboBox_Validating(object sender, CancelEventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }
    }

   
}
