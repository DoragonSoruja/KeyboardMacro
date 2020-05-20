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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.activateButton = new System.Windows.Forms.TextBox();
            this.macro = new System.Windows.Forms.TextBox();
            this.macroButton = new System.Windows.Forms.Button();
            this.commentBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.consoleLabel = new System.Windows.Forms.Label();
            this.replace = new System.Windows.Forms.RadioButton();
            this.dontReplace = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label1.Location = new System.Drawing.Point(19, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(174, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Activation Button\r\n";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(114, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Macro";
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
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(234, 42);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 18);
            this.label3.TabIndex = 7;
            this.label3.Text = "One button";
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
            // replace
            // 
            this.replace.AutoSize = true;
            this.replace.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.replace.Location = new System.Drawing.Point(48, 289);
            this.replace.Name = "replace";
            this.replace.Size = new System.Drawing.Size(186, 17);
            this.replace.TabIndex = 9;
            this.replace.TabStop = true;
            this.replace.Text = "Replace Button Press With Macro";
            this.replace.UseVisualStyleBackColor = true;
            // 
            // dontReplace
            // 
            this.dontReplace.AutoSize = true;
            this.dontReplace.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.dontReplace.Location = new System.Drawing.Point(48, 312);
            this.dontReplace.Name = "dontReplace";
            this.dontReplace.Size = new System.Drawing.Size(148, 17);
            this.dontReplace.TabIndex = 10;
            this.dontReplace.Text = "Activation Button + Macro";
            this.dontReplace.UseVisualStyleBackColor = true;
            // 
            // KeyboardMacros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.ClientSize = new System.Drawing.Size(372, 341);
            this.Controls.Add(this.dontReplace);
            this.Controls.Add(this.replace);
            this.Controls.Add(this.consoleLabel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.commentBox);
            this.Controls.Add(this.macroButton);
            this.Controls.Add(this.macro);
            this.Controls.Add(this.activateButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "KeyboardMacros";
            this.Text = "Keyboard Macros";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox activateButton;
        private System.Windows.Forms.TextBox macro;
        private System.Windows.Forms.Button macroButton;
        private System.Windows.Forms.TextBox commentBox;
        private System.Windows.Forms.Label label3;
        private Label consoleLabel;
        private RadioButton replace;
        private RadioButton dontReplace;
    }
}

