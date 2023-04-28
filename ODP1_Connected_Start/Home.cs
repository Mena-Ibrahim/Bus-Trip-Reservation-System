using NavigationView.UserControls;
using ODP1_Connected_Start.UserControls;
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
    public partial class Home : Form
    {
        NavigationControl navigationControl;
        NavigationButtons navigationButtons;

        static int userId;
        // Change the color of your buttons if you want
        Color btnDefaultColor = Color.FromKnownColor(KnownColor.ControlLight);
        Color btnSelectedtColor = Color.FromKnownColor(KnownColor.ControlDark);

        public Home(int id)
        {
            userId = id;
            InitializeComponent();
            InitializeNavigationControl();
            InitializeNavigationButtons();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void InitializeNavigationControl()
        {
            List<UserControl> userControls = new List<UserControl>() // Your UserControl list
            { new Trips(), new UserControl2(userId), new UserControl3(userId)};

            navigationControl = new NavigationControl(userControls, panel2); // create an instance of NavigationControl class
            navigationControl.Display(0); // display UserControl1 as default
        }

        private void InitializeNavigationButtons()
        {
            List<Button> buttons = new List<Button>()
            { button1, button2, button3 };

            // create a NavigationButtons instance
            navigationButtons = new NavigationButtons(buttons, btnDefaultColor, btnSelectedtColor);
            // Make a default selected button
            navigationButtons.Highlight(button1);
        }


        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            navigationControl.Display(0);
            navigationButtons.Highlight(button1);
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            navigationControl.Display(1);
            navigationButtons.Highlight(button2);
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            navigationControl.Display(2);
            navigationButtons.Highlight(button3);
        }
    }
}
