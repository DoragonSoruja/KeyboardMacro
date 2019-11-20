using System;
using System.Windows.Forms;

namespace KeyboardMacro
{
    public partial class KeyboardMacros : Form
    {
        bool enabled = false;
        public KeyboardMacros()
        {
            InitializeComponent();
        }

        private void KeyboardMacros_KeyDown(object sender, KeyEventArgs e)
        {
            if (enabled)
            {
                if (e.KeyCode.ToString() == activateButton.Text.ToUpper())
                {
                    activateMacro();
                }
                else if (activateButton.Text == "U_Arrow" && e.KeyCode == Keys.Up)
                {
                    activateMacro();
                }
                else if (activateButton.Text == "D_Arrow" && e.KeyCode == Keys.Down)
                {
                    activateMacro();
                }
                else if (activateButton.Text == "L_Arrow" && e.KeyCode == Keys.Left)
                {
                    activateMacro();
                }
                else if (activateButton.Text == "R_Arrow" && e.KeyCode == Keys.Right)
                {
                    activateMacro();
                }
            }
        }

        private void activateMacro()
        {
            foreach (char letter in macro.Text)
            {
                SendKeys.Send(letter.ToString());
            }
            return; 
        }

        private void macroButton_Click(object sender, EventArgs e)
        {
            enabled = !enabled;
            if (enabled)
            {
                macroButton.Text = "Disable Macro";
                activateButton.Enabled = false;
                macro.Enabled = false;
            }
            else
            {
                macroButton.Text = "Enable Marco";
                activateButton.Enabled = true;
                macro.Enabled = true;
            }
        }
        
        private void activateButton_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up)
            {
                activateButton.Text = "U_Arrow";
            }
            else if (e.KeyCode == Keys.Down)
            {
                activateButton.Text = "D_Arrow";
            }
            else if (e.KeyCode == Keys.Right)
            {
                activateButton.Text = "R_Arrow";
            }
            else if (e.KeyCode == Keys.Left)
            {
                activateButton.Text = "L_Arrow";
            }
            else
            {
                activateButton.Clear();
            } 
        }
    }
}
