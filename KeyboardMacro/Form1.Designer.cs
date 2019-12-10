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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.activateButton = new System.Windows.Forms.TextBox();
            this.macro = new System.Windows.Forms.TextBox();
            this.macroButton = new System.Windows.Forms.Button();
            this.commentBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(148, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Activation Button\r\n";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "Macro";
            // 
            // activateButton
            // 
            this.activateButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.activateButton.Location = new System.Drawing.Point(167, 25);
            this.activateButton.MaxLength = 1;
            this.activateButton.Name = "activateButton";
            this.activateButton.Size = new System.Drawing.Size(100, 26);
            this.activateButton.TabIndex = 2;
            this.activateButton.KeyDown += new System.Windows.Forms.KeyEventHandler(this.activateButton_KeyDown);
            // 
            // macro
            // 
            this.macro.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.macro.Location = new System.Drawing.Point(167, 74);
            this.macro.Name = "macro";
            this.macro.Size = new System.Drawing.Size(100, 26);
            this.macro.TabIndex = 3;
            // 
            // macroButton
            // 
            this.macroButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.macroButton.Location = new System.Drawing.Point(82, 126);
            this.macroButton.Name = "macroButton";
            this.macroButton.Size = new System.Drawing.Size(158, 59);
            this.macroButton.TabIndex = 4;
            this.macroButton.Text = "Enable Macro";
            this.macroButton.UseVisualStyleBackColor = true;
            this.macroButton.Click += new System.EventHandler(this.macroButton_Click);
            // 
            // commentBox
            // 
            this.commentBox.Location = new System.Drawing.Point(16, 200);
            this.commentBox.Multiline = true;
            this.commentBox.Name = "commentBox";
            this.commentBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.commentBox.Size = new System.Drawing.Size(287, 51);
            this.commentBox.TabIndex = 6;
            // 
            // KeyboardMacros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.ClientSize = new System.Drawing.Size(333, 263);
            this.Controls.Add(this.commentBox);
            this.Controls.Add(this.macroButton);
            this.Controls.Add(this.macro);
            this.Controls.Add(this.activateButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.KeyPreview = true;
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
    }
}

