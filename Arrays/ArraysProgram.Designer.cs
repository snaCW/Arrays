namespace Arrays
{
    partial class ArraysProgram
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
            this.textBoxBoardArrayA = new System.Windows.Forms.TextBox();
            this.textBoxBoardArrayB = new System.Windows.Forms.TextBox();
            this.textBoxInputA = new System.Windows.Forms.TextBox();
            this.textBoxInputB = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gettingStartToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.textBoxCardinality = new System.Windows.Forms.TextBox();
            this.textBoxCardinalityB = new System.Windows.Forms.TextBox();
            this.textBoxCardinalityA = new System.Windows.Forms.TextBox();
            this.textBoxConsole = new System.Windows.Forms.TextBox();
            this.buttonUnion = new System.Windows.Forms.Button();
            this.buttonDiffAB = new System.Windows.Forms.Button();
            this.buttonIntersection = new System.Windows.Forms.Button();
            this.buttonDiffSymmetric = new System.Windows.Forms.Button();
            this.buttonDiffBA = new System.Windows.Forms.Button();
            this.buttonSubsetAB = new System.Windows.Forms.Button();
            this.buttonSubsetBA = new System.Windows.Forms.Button();
            this.buttonProductAB = new System.Windows.Forms.Button();
            this.buttonProductBA = new System.Windows.Forms.Button();
            this.checkBoxClearOnChange = new System.Windows.Forms.CheckBox();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBoxBoardArrayA
            // 
            this.textBoxBoardArrayA.BackColor = System.Drawing.SystemColors.ControlDark;
            this.textBoxBoardArrayA.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxBoardArrayA.Location = new System.Drawing.Point(70, 56);
            this.textBoxBoardArrayA.Name = "textBoxBoardArrayA";
            this.textBoxBoardArrayA.ReadOnly = true;
            this.textBoxBoardArrayA.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.textBoxBoardArrayA.Size = new System.Drawing.Size(100, 13);
            this.textBoxBoardArrayA.TabIndex = 1000;
            this.textBoxBoardArrayA.TabStop = false;
            this.textBoxBoardArrayA.Text = "Array A:";
            // 
            // textBoxBoardArrayB
            // 
            this.textBoxBoardArrayB.BackColor = System.Drawing.SystemColors.ControlDark;
            this.textBoxBoardArrayB.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxBoardArrayB.Location = new System.Drawing.Point(70, 89);
            this.textBoxBoardArrayB.Name = "textBoxBoardArrayB";
            this.textBoxBoardArrayB.ReadOnly = true;
            this.textBoxBoardArrayB.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.textBoxBoardArrayB.Size = new System.Drawing.Size(100, 13);
            this.textBoxBoardArrayB.TabIndex = 1000;
            this.textBoxBoardArrayB.TabStop = false;
            this.textBoxBoardArrayB.Text = "Array B:";
            // 
            // textBoxInputA
            // 
            this.textBoxInputA.Location = new System.Drawing.Point(139, 53);
            this.textBoxInputA.Name = "textBoxInputA";
            this.textBoxInputA.Size = new System.Drawing.Size(389, 20);
            this.textBoxInputA.TabIndex = 0;
            this.textBoxInputA.TextChanged += new System.EventHandler(this.textBoxInputA_TextChanged);
            // 
            // textBoxInputB
            // 
            this.textBoxInputB.Location = new System.Drawing.Point(139, 86);
            this.textBoxInputB.Name = "textBoxInputB";
            this.textBoxInputB.Size = new System.Drawing.Size(389, 20);
            this.textBoxInputB.TabIndex = 1;
            this.textBoxInputB.TextChanged += new System.EventHandler(this.textBoxInputB_TextChanged);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(742, 24);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exportToolStripMenuItem,
            this.settingsToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // exportToolStripMenuItem
            // 
            this.exportToolStripMenuItem.Name = "exportToolStripMenuItem";
            this.exportToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.exportToolStripMenuItem.Text = "Export";
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.settingsToolStripMenuItem.Text = "Settings";
            this.settingsToolStripMenuItem.Click += new System.EventHandler(this.settingsToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gettingStartToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // gettingStartToolStripMenuItem
            // 
            this.gettingStartToolStripMenuItem.Name = "gettingStartToolStripMenuItem";
            this.gettingStartToolStripMenuItem.Size = new System.Drawing.Size(140, 22);
            this.gettingStartToolStripMenuItem.Text = "Getting Start";
            this.gettingStartToolStripMenuItem.Click += new System.EventHandler(this.gettingStartToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(140, 22);
            this.aboutToolStripMenuItem.Text = "About";
            // 
            // textBoxCardinality
            // 
            this.textBoxCardinality.BackColor = System.Drawing.SystemColors.ControlDark;
            this.textBoxCardinality.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxCardinality.Location = new System.Drawing.Point(545, 37);
            this.textBoxCardinality.Name = "textBoxCardinality";
            this.textBoxCardinality.ReadOnly = true;
            this.textBoxCardinality.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.textBoxCardinality.Size = new System.Drawing.Size(100, 13);
            this.textBoxCardinality.TabIndex = 1010;
            this.textBoxCardinality.TabStop = false;
            this.textBoxCardinality.Text = "Cardinality";
            this.textBoxCardinality.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBoxCardinalityB
            // 
            this.textBoxCardinalityB.BackColor = System.Drawing.SystemColors.ControlDark;
            this.textBoxCardinalityB.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxCardinalityB.Location = new System.Drawing.Point(545, 89);
            this.textBoxCardinalityB.Name = "textBoxCardinalityB";
            this.textBoxCardinalityB.ReadOnly = true;
            this.textBoxCardinalityB.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.textBoxCardinalityB.Size = new System.Drawing.Size(100, 13);
            this.textBoxCardinalityB.TabIndex = 1011;
            this.textBoxCardinalityB.TabStop = false;
            this.textBoxCardinalityB.Text = "0";
            this.textBoxCardinalityB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBoxCardinalityA
            // 
            this.textBoxCardinalityA.BackColor = System.Drawing.SystemColors.ControlDark;
            this.textBoxCardinalityA.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxCardinalityA.Location = new System.Drawing.Point(545, 56);
            this.textBoxCardinalityA.Name = "textBoxCardinalityA";
            this.textBoxCardinalityA.ReadOnly = true;
            this.textBoxCardinalityA.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.textBoxCardinalityA.Size = new System.Drawing.Size(100, 13);
            this.textBoxCardinalityA.TabIndex = 1012;
            this.textBoxCardinalityA.TabStop = false;
            this.textBoxCardinalityA.Text = "0";
            this.textBoxCardinalityA.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBoxConsole
            // 
            this.textBoxConsole.Location = new System.Drawing.Point(113, 182);
            this.textBoxConsole.Multiline = true;
            this.textBoxConsole.Name = "textBoxConsole";
            this.textBoxConsole.Size = new System.Drawing.Size(544, 81);
            this.textBoxConsole.TabIndex = 1015;
            // 
            // buttonUnion
            // 
            this.buttonUnion.Location = new System.Drawing.Point(12, 153);
            this.buttonUnion.Name = "buttonUnion";
            this.buttonUnion.Size = new System.Drawing.Size(75, 23);
            this.buttonUnion.TabIndex = 1016;
            this.buttonUnion.Text = "A∪B";
            this.buttonUnion.UseVisualStyleBackColor = true;
            this.buttonUnion.Click += new System.EventHandler(this.buttonUnion_Click);
            // 
            // buttonDiffAB
            // 
            this.buttonDiffAB.Location = new System.Drawing.Point(12, 211);
            this.buttonDiffAB.Name = "buttonDiffAB";
            this.buttonDiffAB.Size = new System.Drawing.Size(75, 23);
            this.buttonDiffAB.TabIndex = 1017;
            this.buttonDiffAB.Text = "A-B";
            this.buttonDiffAB.UseVisualStyleBackColor = true;
            this.buttonDiffAB.Click += new System.EventHandler(this.buttonDiffAB_Click);
            // 
            // buttonIntersection
            // 
            this.buttonIntersection.Location = new System.Drawing.Point(12, 182);
            this.buttonIntersection.Name = "buttonIntersection";
            this.buttonIntersection.Size = new System.Drawing.Size(75, 23);
            this.buttonIntersection.TabIndex = 1018;
            this.buttonIntersection.Text = "A∩B";
            this.buttonIntersection.UseVisualStyleBackColor = true;
            this.buttonIntersection.Click += new System.EventHandler(this.buttonIntersection_Click);
            // 
            // buttonDiffSymmetric
            // 
            this.buttonDiffSymmetric.Location = new System.Drawing.Point(12, 269);
            this.buttonDiffSymmetric.Name = "buttonDiffSymmetric";
            this.buttonDiffSymmetric.Size = new System.Drawing.Size(75, 23);
            this.buttonDiffSymmetric.TabIndex = 1019;
            this.buttonDiffSymmetric.Text = "AΔB";
            this.buttonDiffSymmetric.UseVisualStyleBackColor = true;
            this.buttonDiffSymmetric.Click += new System.EventHandler(this.buttonDiffSymmetric_Click);
            // 
            // buttonDiffBA
            // 
            this.buttonDiffBA.Location = new System.Drawing.Point(12, 240);
            this.buttonDiffBA.Name = "buttonDiffBA";
            this.buttonDiffBA.Size = new System.Drawing.Size(75, 23);
            this.buttonDiffBA.TabIndex = 1020;
            this.buttonDiffBA.Text = "B-A";
            this.buttonDiffBA.UseVisualStyleBackColor = true;
            this.buttonDiffBA.Click += new System.EventHandler(this.buttonDiffBA_Click);
            // 
            // buttonSubsetAB
            // 
            this.buttonSubsetAB.Location = new System.Drawing.Point(12, 298);
            this.buttonSubsetAB.Name = "buttonSubsetAB";
            this.buttonSubsetAB.Size = new System.Drawing.Size(75, 23);
            this.buttonSubsetAB.TabIndex = 1021;
            this.buttonSubsetAB.Text = "A⊆B";
            this.buttonSubsetAB.UseVisualStyleBackColor = true;
            this.buttonSubsetAB.Click += new System.EventHandler(this.buttonSubsetAB_Click);
            // 
            // buttonSubsetBA
            // 
            this.buttonSubsetBA.Location = new System.Drawing.Point(12, 327);
            this.buttonSubsetBA.Name = "buttonSubsetBA";
            this.buttonSubsetBA.Size = new System.Drawing.Size(75, 23);
            this.buttonSubsetBA.TabIndex = 1022;
            this.buttonSubsetBA.Text = "B⊆A";
            this.buttonSubsetBA.UseVisualStyleBackColor = true;
            this.buttonSubsetBA.Click += new System.EventHandler(this.buttonSubsetBA_Click);
            // 
            // buttonProductAB
            // 
            this.buttonProductAB.Location = new System.Drawing.Point(12, 356);
            this.buttonProductAB.Name = "buttonProductAB";
            this.buttonProductAB.Size = new System.Drawing.Size(75, 23);
            this.buttonProductAB.TabIndex = 1023;
            this.buttonProductAB.Text = "A×B";
            this.buttonProductAB.UseVisualStyleBackColor = true;
            this.buttonProductAB.Click += new System.EventHandler(this.buttonProductAB_Click);
            // 
            // buttonProductBA
            // 
            this.buttonProductBA.Location = new System.Drawing.Point(12, 385);
            this.buttonProductBA.Name = "buttonProductBA";
            this.buttonProductBA.Size = new System.Drawing.Size(75, 23);
            this.buttonProductBA.TabIndex = 1024;
            this.buttonProductBA.Text = "B×A";
            this.buttonProductBA.UseVisualStyleBackColor = true;
            this.buttonProductBA.Click += new System.EventHandler(this.buttonProductBA_Click);
            // 
            // checkBoxClearOnChange
            // 
            this.checkBoxClearOnChange.AutoSize = true;
            this.checkBoxClearOnChange.Checked = true;
            this.checkBoxClearOnChange.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxClearOnChange.Location = new System.Drawing.Point(113, 153);
            this.checkBoxClearOnChange.Name = "checkBoxClearOnChange";
            this.checkBoxClearOnChange.Size = new System.Drawing.Size(146, 17);
            this.checkBoxClearOnChange.TabIndex = 1025;
            this.checkBoxClearOnChange.Text = "Clear Console on Change";
            this.checkBoxClearOnChange.UseVisualStyleBackColor = true;
            // 
            // ArraysProgram
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(742, 450);
            this.Controls.Add(this.checkBoxClearOnChange);
            this.Controls.Add(this.buttonProductBA);
            this.Controls.Add(this.buttonProductAB);
            this.Controls.Add(this.buttonSubsetBA);
            this.Controls.Add(this.buttonSubsetAB);
            this.Controls.Add(this.buttonDiffBA);
            this.Controls.Add(this.buttonDiffSymmetric);
            this.Controls.Add(this.buttonIntersection);
            this.Controls.Add(this.buttonDiffAB);
            this.Controls.Add(this.buttonUnion);
            this.Controls.Add(this.textBoxConsole);
            this.Controls.Add(this.textBoxCardinalityA);
            this.Controls.Add(this.textBoxCardinalityB);
            this.Controls.Add(this.textBoxCardinality);
            this.Controls.Add(this.textBoxInputB);
            this.Controls.Add(this.textBoxInputA);
            this.Controls.Add(this.textBoxBoardArrayB);
            this.Controls.Add(this.textBoxBoardArrayA);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "ArraysProgram";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.RightToLeftLayout = true;
            this.Text = "Arrays Program";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxBoardArrayA;
        private System.Windows.Forms.TextBox textBoxBoardArrayB;
        private System.Windows.Forms.TextBox textBoxInputA;
        private System.Windows.Forms.TextBox textBoxInputB;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gettingStartToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.TextBox textBoxCardinality;
        private System.Windows.Forms.TextBox textBoxCardinalityB;
        private System.Windows.Forms.TextBox textBoxCardinalityA;
        private System.Windows.Forms.TextBox textBoxConsole;
        private System.Windows.Forms.Button buttonUnion;
        private System.Windows.Forms.Button buttonDiffAB;
        private System.Windows.Forms.Button buttonIntersection;
        private System.Windows.Forms.Button buttonDiffSymmetric;
        private System.Windows.Forms.Button buttonDiffBA;
        private System.Windows.Forms.Button buttonSubsetAB;
        private System.Windows.Forms.Button buttonSubsetBA;
        private System.Windows.Forms.Button buttonProductAB;
        private System.Windows.Forms.Button buttonProductBA;
        private System.Windows.Forms.CheckBox checkBoxClearOnChange;
    }
}

