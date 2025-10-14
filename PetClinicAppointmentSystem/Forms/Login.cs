using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PetClinicAppointmentSystem.Forms
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void eyeOpn_Click(object sender, EventArgs e)
        {
            if (textBox2.PasswordChar == '*')
            {
                eyeOpn.BringToFront();
                textBox2.PasswordChar = '\0';
            }
        }

        private void eyeClse_Click(object sender, EventArgs e)
        {
            if (textBox2.PasswordChar == '\0')
            {
                eyeClse.BringToFront();
                textBox2.PasswordChar = '*';
            }
        }

       
    }
}
