using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace LifeIsMiserable
{
    public partial class MainUI : Form
    {
        public MainUI()
        {
            InitializeComponent();
        }

        readonly string comma = ", ";
        readonly string quote = "'";
        readonly string zero = "0";

        readonly List<String> finalList = new List<String>();

        private void AddToList(string line)
        {
            if (checkOneLine.Checked)
            {
                finalList.Add(line);
            }
            else
            {
                finalList.Add(line + "\r\n");
            }

        }


        private void CreateOutString(bool isVarchar, bool isPrefixZero)
        {
            AddToList("(");

            int validLinesCount = 0;

            for (var i = 0; i < inputBox.Lines.Count(); i++)
            {
                string line = inputBox.Lines[i].Trim();

                if (!string.IsNullOrWhiteSpace(line))
                {

                    validLinesCount++;
                }
            }

            for (var i = 0; i < validLinesCount; i++)
            {
                string line = inputBox.Lines[i].Trim();

                if (!string.IsNullOrWhiteSpace(line))
                {

                    // Add zero prefix
                    if (isPrefixZero)
                    {
                        line = zero + line;
                    }

                    // Add single quotes around
                    if (isVarchar)
                    {
                        line = quote + line + quote;
                    }

                    // last entry, so no comma
                    if (i == validLinesCount - 1)
                    {
                        AddToList(line);
                    }
                    else
                    {
                        AddToList(line + comma);
                    }
                    
                }
            }

            AddToList(")");
        }

        private void MainUI_MouseMove(object sender, MouseEventArgs e)
        {
            if (btnGenerate.Text.Equals("Output copied to clipboard, you can paste it"))
            {

                btnGenerate.Text = "Save Da time";
            }
        }

        private void BtnGenerate_Click(object sender, EventArgs e)
        {

            CreateOutString(isVarchar: radioButtonVarchar.Checked, isPrefixZero: checkPrefixZero.Checked);

            Clipboard.SetText(String.Join(" ", finalList));

            finalList.Clear();

            btnGenerate.Text = "Output copied to clipboard, you can paste it";
        }
    }
}
