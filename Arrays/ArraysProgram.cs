using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Arrays
{
    public partial class ArraysProgram : Form
    {
        public static List<int> a = new List<int>();
        public static List<int> b = new List<int>();
        public static char inputSeperator;
        public static char outputSeperator = ',';
        const char space = ' ';
        string newLine = "\r\n";
        public ArraysProgram()
        {
            InitializeComponent();
            ImportSettings();
        }

        private void ImportSettings()
        {
            string path = "settings.array";
            if (!File.Exists(path)) 
            {
                File.Create(path);
                GettingStart gettingStart = new GettingStart();
                gettingStart.ShowDialog();
                return;
            }

            StreamReader reader = new StreamReader(path);
            string line = reader.ReadLine();
            while (line != null)
            {
                string[] keyValue = line.Split(':');
                switch (keyValue[0])
                {
                    case "inputSeperator":
                        inputSeperator = keyValue[1][0];
                        break;
                    case "outputSeperator":
                        outputSeperator = keyValue[1][0];
                        break;
                }
                line = reader.ReadLine();
            }
            reader.Close();
        }
        private void textBoxInputA_TextChanged(object sender, EventArgs e)
        {
            ClearConsoleCheckBox();

            string text = textBoxInputA.Text;
            if (text == string.Empty)
            {
                textBoxCardinalityA.Text = "0";
                return;
            }
            if (text.EndsWith(" "))
                text = text.Remove(text.Length - 1);

            List<char> chars = new List<char>(){' '};
            if (inputSeperator != default)
                chars.Add(inputSeperator);
            string[] stringArray = text.Split(chars.ToArray(), StringSplitOptions.RemoveEmptyEntries);
            
            try
            {
                a = stringArray.Select(s => Int32.Parse(s)).ToList();
                textBoxCardinalityA.Text = a.Count.ToString();
            }
            catch (FormatException)
            {
                textBoxConsole.Text += "Please enter a valid integer set for A." + newLine;
                textBoxCardinalityA.Text = "invalid";
            }

            if (text == string.Empty)
            {
                textBoxCardinalityA.Text = "0";
                //textBoxConsole.Text.Remove();
            }
        }

        private void textBoxInputB_TextChanged(object sender, EventArgs e)
        {
            ClearConsoleCheckBox();

            string text = textBoxInputB.Text;
            if (text == string.Empty)
            {
                textBoxCardinalityB.Text = "0";
                return;
            }
            if (text.EndsWith(" "))
                text = text.Remove(text.Length - 1);

            List<char> chars = new List<char>() {' '};
            if (inputSeperator != default)
                chars.Add(inputSeperator);
            string[] stringArray = text.Split(chars.ToArray(), StringSplitOptions.RemoveEmptyEntries);
            
            try
            {
                b = stringArray.Select(s => Int32.Parse(s)).ToList();
                textBoxCardinalityB.Text = b.Count.ToString();
            }
            catch (FormatException)
            {
                textBoxConsole.Text += "Please enter a valid integer set for B." + newLine;
                textBoxCardinalityB.Text = "invalid";
            }
        }
        private void ClearConsoleCheckBox()
        {
            if (checkBoxClearOnChange.Checked)
                textBoxConsole.Clear();
        }
        private void PrintList(ref List<int> list)
        {
            ClearConsoleCheckBox();

            foreach (int i in list)
            {
                textBoxConsole.Text += i.ToString() + outputSeperator + space;
            }
            string text = textBoxConsole.Text;
            textBoxConsole.Text = text.Remove(text.Length - 2) + newLine;
        }

        private void buttonUnion_Click(object sender, EventArgs e)
        {
            List<int> union = new List<int>();
            
            foreach (int i in a)
                union.Add(i);
            
            foreach (int j in b)
                if (!union.Contains(j))
                    union.Add(j);
            
            union.Sort();
            PrintList(ref union);
        }

        private void buttonIntersection_Click(object sender, EventArgs e)
        {
            List<int> intersect = new List<int>();

            foreach (int i in a)
                if (b.Contains(i))
                    intersect.Add(i);

            intersect.Sort();
            PrintList(ref intersect);
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void PrintToConsole(string st)
        {
            ClearConsoleCheckBox();
            textBoxConsole.Text += st;
        }

        private void buttonDiffAB_Click(object sender, EventArgs e)
        {
            List<int> diffAB = new List<int>();

            foreach (int i in a)
                if (!b.Contains(i))
                    diffAB.Add(i);

            diffAB.Sort();
            PrintList(ref diffAB);
        }

        private void buttonDiffBA_Click(object sender, EventArgs e)
        {
            List<int> diffBA = new List<int>();

            foreach (int i in b)
                if (!a.Contains(i))
                    diffBA.Add(i);

            diffBA.Sort();
            PrintList(ref diffBA);
        }

        private void buttonDiffSymmetric_Click(object sender, EventArgs e)
        {
            List<int> diffSym = new List<int>();

            foreach (int i in a)
                if (!b.Contains(i))
                    diffSym.Add(i);
            
            foreach (int i in b)
                if (!a.Contains(i))
                    diffSym.Add(i);

            diffSym.Sort();
            PrintList(ref diffSym);
        }

        private void buttonSubsetAB_Click(object sender, EventArgs e)
        {
            bool result = true;
            foreach (int i in a)
                if (!b.Contains(i))
                {
                    result = false;
                    break;
                }
            PrintToConsole(result.ToString());
        }

        private void buttonSubsetBA_Click(object sender, EventArgs e)
        {
            bool result = true;
            foreach (int i in b)
                if (!a.Contains(i))
                {
                    result = false;
                    break;
                }
            PrintToConsole(result.ToString());
        }

        private void buttonProductAB_Click(object sender, EventArgs e)
        {
            StringBuilder sb = new StringBuilder();
            foreach (int i in a)
            {
                foreach(int j in b)
                {
                    sb.Append($"({i}, {j}){outputSeperator} ");
                }
            }
            PrintToConsole(sb.ToString());
        }

        private void buttonProductBA_Click(object sender, EventArgs e)
        {
            StringBuilder sb = new StringBuilder();
            foreach (int i in b)
            {
                foreach (int j in a)
                {
                    sb.Append($"({i}, {j}){outputSeperator} ");
                }
            }
            PrintToConsole(sb.ToString());
        }

        private void gettingStartToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GettingStart gettingStart = new GettingStart();
            gettingStart.ShowDialog();
        }

        private void settingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Settings settings = new Settings();
            settings.ShowDialog();
        }
    }
}
