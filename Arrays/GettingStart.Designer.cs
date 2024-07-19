namespace Arrays
{
    partial class GettingStart
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GettingStart));
            this.textBoxGettingStart1 = new System.Windows.Forms.TextBox();
            this.textBoxGettingStart2 = new System.Windows.Forms.TextBox();
            this.buttonGettingStartClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxGettingStart1
            // 
            this.textBoxGettingStart1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxGettingStart1.Location = new System.Drawing.Point(27, 39);
            this.textBoxGettingStart1.Multiline = true;
            this.textBoxGettingStart1.Name = "textBoxGettingStart1";
            this.textBoxGettingStart1.ReadOnly = true;
            this.textBoxGettingStart1.Size = new System.Drawing.Size(304, 48);
            this.textBoxGettingStart1.TabIndex = 0;
            this.textBoxGettingStart1.TabStop = false;
            this.textBoxGettingStart1.Text = "You see this page either because:\r\n1. This is the first time you opened this prog" +
    "ram.\r\n2. You selected the \"Getting Start\" option.";
            // 
            // textBoxGettingStart2
            // 
            this.textBoxGettingStart2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxGettingStart2.Location = new System.Drawing.Point(72, 105);
            this.textBoxGettingStart2.Multiline = true;
            this.textBoxGettingStart2.Name = "textBoxGettingStart2";
            this.textBoxGettingStart2.ReadOnly = true;
            this.textBoxGettingStart2.Size = new System.Drawing.Size(278, 220);
            this.textBoxGettingStart2.TabIndex = 1;
            this.textBoxGettingStart2.TabStop = false;
            this.textBoxGettingStart2.Text = resources.GetString("textBoxGettingStart2.Text");
            // 
            // buttonGettingStartClose
            // 
            this.buttonGettingStartClose.Location = new System.Drawing.Point(72, 356);
            this.buttonGettingStartClose.Name = "buttonGettingStartClose";
            this.buttonGettingStartClose.Size = new System.Drawing.Size(136, 35);
            this.buttonGettingStartClose.TabIndex = 2;
            this.buttonGettingStartClose.Text = "Close";
            this.buttonGettingStartClose.UseVisualStyleBackColor = true;
            this.buttonGettingStartClose.Click += new System.EventHandler(this.buttonGettingStartClose_Click);
            // 
            // GettingStart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonGettingStartClose);
            this.Controls.Add(this.textBoxGettingStart2);
            this.Controls.Add(this.textBoxGettingStart1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "GettingStart";
            this.Text = "Arrays Program/Getting Start";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxGettingStart1;
        private System.Windows.Forms.TextBox textBoxGettingStart2;
        private System.Windows.Forms.Button buttonGettingStartClose;
    }
}