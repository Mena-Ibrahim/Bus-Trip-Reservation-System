using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ODP1_Connected_Start
{
    public partial class UserForm : Form
    {
        public UserForm()
        {
            InitializeComponent();
            MessageBox.Show("Logged in user has id: " + LoginForm.loggedInID);

        }
    }
}
