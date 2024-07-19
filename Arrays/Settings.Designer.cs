namespace Arrays
{
    partial class Settings
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
            this.textBoxSettingsInputBoard = new System.Windows.Forms.TextBox();
            this.textBoxSettingsOutputBoard = new System.Windows.Forms.TextBox();
            this.textBoxSettingsInputInput = new System.Windows.Forms.TextBox();
            this.textBoxSettingsOutputInput = new System.Windows.Forms.TextBox();
            this.buttonSettingsSave = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxSettingsInputBoard
            // 
            this.textBoxSettingsInputBoard.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxSettingsInputBoard.Location = new System.Drawing.Point(66, 72);
            this.textBoxSettingsInputBoard.Multiline = true;
            this.textBoxSettingsInputBoard.Name = "textBoxSettingsInputBoard";
            this.textBoxSettingsInputBoard.ReadOnly = true;
            this.textBoxSettingsInputBoard.Size = new System.Drawing.Size(304, 22);
            this.textBoxSettingsInputBoard.TabIndex = 1;
            this.textBoxSettingsInputBoard.TabStop = false;
            this.textBoxSettingsInputBoard.Text = "Input Seperator:";
            // 
            // textBoxSettingsOutputBoard
            // 
            this.textBoxSettingsOutputBoard.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxSettingsOutputBoard.Location = new System.Drawing.Point(66, 123);
            this.textBoxSettingsOutputBoard.Multiline = true;
            this.textBoxSettingsOutputBoard.Name = "textBoxSettingsOutputBoard";
            this.textBoxSettingsOutputBoard.ReadOnly = true;
            this.textBoxSettingsOutputBoard.Size = new System.Drawing.Size(304, 21);
            this.textBoxSettingsOutputBoard.TabIndex = 2;
            this.textBoxSettingsOutputBoard.TabStop = false;
            this.textBoxSettingsOutputBoard.Text = "Output Seperator:";
            // 
            // textBoxSettingsInputInput
            // 
            this.textBoxSettingsInputInput.Location = new System.Drawing.Point(209, 69);
            this.textBoxSettingsInputInput.Name = "textBoxSettingsInputInput";
            this.textBoxSettingsInputInput.Size = new System.Drawing.Size(100, 20);
            this.textBoxSettingsInputInput.TabIndex = 3;
            this.textBoxSettingsInputInput.TextChanged += new System.EventHandler(this.textBoxSettingsInputInput_TextChanged);
            // 
            // textBoxSettingsOutputInput
            // 
            this.textBoxSettingsOutputInput.Location = new System.Drawing.Point(209, 120);
            this.textBoxSettingsOutputInput.Name = "textBoxSettingsOutputInput";
            this.textBoxSettingsOutputInput.Size = new System.Drawing.Size(100, 20);
            this.textBoxSettingsOutputInput.TabIndex = 4;
            this.textBoxSettingsOutputInput.TextChanged += new System.EventHandler(this.textBoxSettingsOutputInput_TextChanged);
            // 
            // buttonSettingsSave
            // 
            this.buttonSettingsSave.Location = new System.Drawing.Point(66, 184);
            this.buttonSettingsSave.Name = "buttonSettingsSave";
            this.buttonSettingsSave.Size = new System.Drawing.Size(75, 23);
            this.buttonSettingsSave.TabIndex = 5;
            this.buttonSettingsSave.Text = "Save";
            this.buttonSettingsSave.UseVisualStyleBackColor = true;
            this.buttonSettingsSave.Click += new System.EventHandler(this.buttonSettingsSave_Click);
            // 
            // Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonSettingsSave);
            this.Controls.Add(this.textBoxSettingsOutputInput);
            this.Controls.Add(this.textBoxSettingsInputInput);
            this.Controls.Add(this.textBoxSettingsOutputBoard);
            this.Controls.Add(this.textBoxSettingsInputBoard);
            this.Name = "Settings";
            this.Text = "Settings";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxSettingsInputBoard;
        private System.Windows.Forms.TextBox textBoxSettingsOutputBoard;
        private System.Windows.Forms.TextBox textBoxSettingsInputInput;
        private System.Windows.Forms.TextBox textBoxSettingsOutputInput;
        private System.Windows.Forms.Button buttonSettingsSave;
    }
}