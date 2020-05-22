using System.Drawing;
using System.Windows.Forms;

namespace KeyboardMacro
{
    partial class KeyboardMacros
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(KeyboardMacros));
            this.promptLabel = new System.Windows.Forms.Label();
            this.macroLabel = new System.Windows.Forms.Label();
            this.activateButton = new System.Windows.Forms.TextBox();
            this.macro = new System.Windows.Forms.TextBox();
            this.macroButton = new System.Windows.Forms.Button();
            this.commentBox = new System.Windows.Forms.TextBox();
            this.oneButtonLabel = new System.Windows.Forms.Label();
            this.consoleLabel = new System.Windows.Forms.Label();
            this.lightMode = new System.Windows.Forms.RadioButton();
            this.darkMode = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // promptLabel
            // 
            this.promptLabel.AutoSize = true;
            this.promptLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.promptLabel.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.promptLabel.Location = new System.Drawing.Point(19, 37);
            this.promptLabel.Name = "promptLabel";
            this.promptLabel.Size = new System.Drawing.Size(174, 25);
            this.promptLabel.TabIndex = 0;
            this.promptLabel.Text = "Activation Button\r\n";
            // 
            // macroLabel
            // 
            this.macroLabel.AutoSize = true;
            this.macroLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.macroLabel.ForeColor = System.Drawing.SystemColors.Control;
            this.macroLabel.Location = new System.Drawing.Point(114, 84);
            this.macroLabel.Name = "macroLabel";
            this.macroLabel.Size = new System.Drawing.Size(72, 25);
            this.macroLabel.TabIndex = 1;
            this.macroLabel.Text = "Macro";
            // 
            // activateButton
            // 
            this.activateButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.activateButton.Location = new System.Drawing.Point(199, 36);
            this.activateButton.MaxLength = 1;
            this.activateButton.Name = "activateButton";
            this.activateButton.Size = new System.Drawing.Size(29, 26);
            this.activateButton.TabIndex = 2;
            this.activateButton.KeyDown += new System.Windows.Forms.KeyEventHandler(this.activateButton_KeyDown);
            // 
            // macro
            // 
            this.macro.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.macro.Location = new System.Drawing.Point(199, 85);
            this.macro.Name = "macro";
            this.macro.Size = new System.Drawing.Size(100, 26);
            this.macro.TabIndex = 3;
            // 
            // macroButton
            // 
            this.macroButton.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.macroButton.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.macroButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.macroButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.macroButton.Location = new System.Drawing.Point(119, 142);
            this.macroButton.Name = "macroButton";
            this.macroButton.Size = new System.Drawing.Size(146, 52);
            this.macroButton.TabIndex = 4;
            this.macroButton.Text = "Enable Macro";
            this.macroButton.UseVisualStyleBackColor = false;
            this.macroButton.Click += new System.EventHandler(this.macroButton_Click);
            // 
            // commentBox
            // 
            this.commentBox.Location = new System.Drawing.Point(48, 226);
            this.commentBox.Multiline = true;
            this.commentBox.Name = "commentBox";
            this.commentBox.Size = new System.Drawing.Size(287, 51);
            this.commentBox.TabIndex = 6;
            // 
            // oneButtonLabel
            // 
            this.oneButtonLabel.AutoSize = true;
            this.oneButtonLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.oneButtonLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.oneButtonLabel.Location = new System.Drawing.Point(234, 42);
            this.oneButtonLabel.Name = "oneButtonLabel";
            this.oneButtonLabel.Size = new System.Drawing.Size(81, 18);
            this.oneButtonLabel.TabIndex = 7;
            this.oneButtonLabel.Text = "One button";
            // 
            // consoleLabel
            // 
            this.consoleLabel.AutoSize = true;
            this.consoleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.consoleLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.consoleLabel.Location = new System.Drawing.Point(45, 205);
            this.consoleLabel.Name = "consoleLabel";
            this.consoleLabel.Size = new System.Drawing.Size(64, 18);
            this.consoleLabel.TabIndex = 8;
            this.consoleLabel.Text = "Console";
            // 
            // lightMode
            // 
            this.lightMode.AutoSize = true;
            this.lightMode.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lightMode.Location = new System.Drawing.Point(48, 289);
            this.lightMode.Name = "lightMode";
            this.lightMode.Size = new System.Drawing.Size(78, 17);
            this.lightMode.TabIndex = 9;
            this.lightMode.TabStop = true;
            this.lightMode.Text = "Light Mode";
            this.lightMode.UseVisualStyleBackColor = true;
            this.lightMode.CheckedChanged += new System.EventHandler(this.lightMode_CheckedChanged);
            // 
            // darkMode
            // 
            this.darkMode.AutoSize = true;
            this.darkMode.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.darkMode.Location = new System.Drawing.Point(48, 312);
            this.darkMode.Name = "darkMode";
            this.darkMode.Size = new System.Drawing.Size(78, 17);
            this.darkMode.TabIndex = 10;
            this.darkMode.Text = "Dark Mode";
            this.darkMode.UseVisualStyleBackColor = true;
            this.darkMode.CheckedChanged += new System.EventHandler(this.darkMode_CheckedChanged);
            // 
            // KeyboardMacros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.ClientSize = new System.Drawing.Size(372, 341);
            this.Controls.Add(this.darkMode);
            this.Controls.Add(this.lightMode);
            this.Controls.Add(this.consoleLabel);
            this.Controls.Add(this.oneButtonLabel);
            this.Controls.Add(this.commentBox);
            this.Controls.Add(this.macroButton);
            this.Controls.Add(this.macro);
            this.Controls.Add(this.activateButton);
            this.Controls.Add(this.macroLabel);
            this.Controls.Add(this.promptLabel);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(388, 380);
            this.MinimumSize = new System.Drawing.Size(388, 380);
            this.Name = "KeyboardMacros";
            this.Text = "Keyboard Macros";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label promptLabel;
        private System.Windows.Forms.Label macroLabel;
        private System.Windows.Forms.TextBox activateButton;
        private System.Windows.Forms.TextBox macro;
        private System.Windows.Forms.Button macroButton;
        private System.Windows.Forms.TextBox commentBox;
        private System.Windows.Forms.Label oneButtonLabel;
        private Label consoleLabel;
        private RadioButton lightMode;
        private RadioButton darkMode;
    }
}

