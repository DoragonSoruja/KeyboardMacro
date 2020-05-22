using System;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using KeyboardMacro.Properties;

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

        private void WriteLine(string text)
        {
            commentBox.Text += text + Environment.NewLine;
        }

        protected override void WndProc(ref Message m)
        {
            if (m.Msg == Constants.WM_HOTKEY_MSG_ID)
                foreach (char letter in macro.Text)
                {
                    SendKeys.Send(letter.ToString());
                }
            base.WndProc(ref m);
        }

        private void macroButton_Click(object sender, EventArgs e)
        {
            enabled = !enabled;
            if (enabled)
            {
                macroButton.Text = "Disable Macro";
                activateButton.Enabled = false; macro.Enabled = false; commentBox.Clear();

                if (macro.Text.ToString().ToLower().Contains(activateButton.Text.ToString().ToLower()))
                {
                    macroButton.Text = "Enable Marco";
                    activateButton.Enabled = true; macro.Enabled = true; WriteLine("Macro cannot contain the same letter as the activation button.");
                    enabled = !enabled;  return;
                }

                if (Char.IsUpper(activateButton.Text.ToCharArray()[0]))
                {
                    ghk = new GlobalHotkey(Constants.SHIFT, (Keys)Enum.Parse(typeof(Keys), activateButton.Text.ToString(), true), this);

                    WriteLine("Trying to register SHIFT+" + activateButton.Text + " as a hotkey");
                }
                else
                {
                    ghk = new GlobalHotkey(Constants.NOMOD, (Keys)Enum.Parse(typeof(Keys), activateButton.Text.ToString(), true), this);

                    WriteLine("Trying to register " + activateButton.Text + " as a hotkey");
                }

                if (ghk.Register())
                    WriteLine("Hotkey registered.");
                else
                    WriteLine("Hotkey failed to register");

            }
            else
            {
                commentBox.Clear();

                if (ghk.Unregister())
                    WriteLine("HotKey unregistered.");
                else
                    WriteLine("Hotkey failed to ungistered");

                macroButton.Text = "Enable Macro";
                activateButton.Enabled = true; macro.Enabled = true;
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

        private void lightMode_CheckedChanged(object sender, EventArgs e)
        {
            BackColor = Color.FromArgb(255, 255, 255);
            promptLabel.ForeColor = Color.Black;
            macroLabel.ForeColor = Color.Black;
            oneButtonLabel.ForeColor = Color.Black;
            consoleLabel.ForeColor = Color.Black;
            darkMode.ForeColor = Color.Black;
            lightMode.ForeColor = Color.Black;
            macroButton.BackColor = Color.White;
            macroButton.ForeColor = Color.Black;
            macroButton.FlatAppearance.BorderColor = Color.FromArgb(40, 40, 40);
        }

        private void darkMode_CheckedChanged(object sender, EventArgs e)
        {
            BackColor = Color.FromArgb(40, 40, 40);
            promptLabel.ForeColor = Color.White;
            macroLabel.ForeColor = Color.White;
            oneButtonLabel.ForeColor = Color.White;
            consoleLabel.ForeColor = Color.White;
            darkMode.ForeColor = Color.White;
            lightMode.ForeColor = Color.White;
            macroButton.BackColor = Color.FromArgb(40, 40, 40);
            macroButton.ForeColor = Color.White;
            macroButton.FlatAppearance.BorderColor = Color.White;
        }
    }   
}
