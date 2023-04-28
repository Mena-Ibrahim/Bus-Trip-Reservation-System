using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ODP1_Connected_Start
{
    public class NavigationButtons
    {
        List<Button> buttons;
        Color defaultColor;
        Color selectedColor;

        public NavigationButtons(List<Button> buttons, Color defaultColor, Color selectedColor)
        {
            this.buttons = buttons;
            this.defaultColor = defaultColor;
            this.selectedColor = selectedColor;
            SetButtonColor();
        }

        private void SetButtonColor()
        {
            foreach(Button button in buttons)
            {
                button.BackColor = defaultColor;
            }
        }

        public void Highlight(Button selectedButton)
        {
            foreach(Button button in buttons)
            {
                if(button == selectedButton)
                {
                    selectedButton.BackColor = selectedColor;
                }
                else
                {
                    button.BackColor = defaultColor;
                }
            }
        }
    }
}
