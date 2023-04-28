using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace ODP1_Connected_Start
{
    static class Program
    {

        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Login());
        }
    }
}
