using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Arrays
{
    public partial class Settings : Form
    {
        public static bool printSaved = false;
        public Settings()
        {
            InitializeComponent();
            textBoxSettingsInputInput.Text = ArraysProgram.inputSeperator.ToString();
            textBoxSettingsOutputInput.Text = ArraysProgram.outputSeperator.ToString();
        }

        private void textBoxSettingsInputInput_TextChanged(object sender, EventArgs e)
        {
            if (textBoxSettingsInputInput.Text.Length != 0)
                ArraysProgram.inputSeperator = textBoxSettingsInputInput.Text[0];
            else
                ArraysProgram.inputSeperator = default;
        }

        private void textBoxSettingsOutputInput_TextChanged(object sender, EventArgs e)
        {
            if (textBoxSettingsOutputInput.Text.Length != 0)
                ArraysProgram.outputSeperator = textBoxSettingsOutputInput.Text[0];
            else
                ArraysProgram.outputSeperator = ',';
        }

        private void buttonSettingsSave_Click(object sender, EventArgs e)
        {
            string path = "settings.array";
            StreamWriter reader = new StreamWriter(path);
            StringBuilder a = new StringBuilder();

            a.Append("inputSeperator:");
            a.Append(ArraysProgram.inputSeperator);
            a.Append("\r\n");
            a.Append("outputSeperator:");
            a.Append(ArraysProgram.outputSeperator);

            reader.Write(a.ToString());
            reader.Close();

            Close();
        }
    }
}
