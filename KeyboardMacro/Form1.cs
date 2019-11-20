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
                if (e.KeyCode.ToString().ToUpper() == activateButton.Text.ToUpper()) { activateMacro(); }
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
                activateButton.Enabled = false; macro.Enabled = false;
            }
            else
            {
                macroButton.Text = "Enable Marco";
                activateButton.Enabled = true; macro.Enabled = true;
            }
        }
        
        private void activateButton_KeyDown(object sender, KeyEventArgs e)
        {
            Keys[] keys = { Keys.Up, Keys.Down, Keys.Right, Keys.Left };

            if (Array.IndexOf(keys, e.KeyCode) != -1)
            {
                activateButton.Text = e.KeyCode.ToString();
            }
            else
            {
                activateButton.Clear();
            }
        }
    }
}
