using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace KeyboardMacro
{
    public partial class KeyboardMacros : Form
    {
        private GlobalHotkey ghk;

        bool enabled = false;
        public KeyboardMacros()
        {
            InitializeComponent();
        }

        private void activateMacro()
        {
            foreach (char letter in macro.Text)
            {
                SendKeys.Send(letter.ToString());
            }
            return;
        }

        protected override void WndProc(ref Message m)
        {
            if (m.Msg == Constants.WM_HOTKEY_MSG_ID)
                if (enabled) activateMacro();
                else SendKeys.Send(activateButton.Text.ToString());
            base.WndProc(ref m);
        }

        private void macroButton_Click(object sender, EventArgs e)
        {
            enabled = !enabled;
            textBox1.Clear();
            if (enabled)
            {
                macroButton.Text = "Disable Macro";
                activateButton.Enabled = false; macro.Enabled = false;

                if(macro.Text.ToString().ToLower().Contains(activateButton.Text.ToString().ToLower()))
                {
                    macroButton.Text = "Enable Marco";
                    activateButton.Enabled = true; macro.Enabled = true; WriteLine("Macro cannot contain the same letter as the activate button.");
                    enabled = !enabled;  return;
                }

                if (Char.IsUpper(activateButton.Text.ToCharArray()[0]))
                {
                    ghk = new GlobalHotkey(Constants.SHIFT, (Keys)Enum.Parse(typeof(Keys), activateButton.Text.ToString(), true), this);

                    WriteLine("Trying to register SHIFT + " + activateButton.Text);
                }
                else
                {
                    ghk = new GlobalHotkey(Constants.NOMOD, (Keys)Enum.Parse(typeof(Keys), activateButton.Text.ToString(), true), this);

                    WriteLine("Trying to register " + activateButton.Text);
                }

                if (ghk.Register())
                    WriteLine("Hotkey registered.");
                else
                    WriteLine("Hotkey failed to register");

            }
            else
            {
                macroButton.Text = "Enable Marco";
                activateButton.Enabled = true; macro.Enabled = true; textBox1.Clear();
            }
        }

        private void activateButton_KeyDown(object sender, KeyEventArgs e)
        {
            Keys[] keys = { Keys.Up, Keys.Down, Keys.Right, Keys.Left };

            if (Array.IndexOf(keys, e.KeyCode) != -1)
            {
                activateButton.Text = e.KeyCode.ToString().ToLower();
            }
            else
            {
                activateButton.Clear();
            }
        }

        private void WriteLine(string text)
        {
            textBox1.Text += text + Environment.NewLine;
        }
    }   
}
