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
            ghk = new GlobalHotkey(Constants.NOMOD, Keys.O, this);
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
                else SendKeys.Send(Keys.O.ToString().ToLower());
            base.WndProc(ref m);
        }

        private void macroButton_Click(object sender, EventArgs e)
        {
            enabled = !enabled;
            if (enabled)
            {
                macroButton.Text = "Disable Macro";
                activateButton.Enabled = false; macro.Enabled = false;

                WriteLine("Trying to register O");
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
                activateButton.Text = e.KeyCode.ToString();
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
