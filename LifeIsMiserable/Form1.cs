using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace LifeIsMiserable
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string comma = ", ";
        string quote = "'";

        List<String> finalList = new List<String>();


        private void button1_Click(object sender, EventArgs e)
        {
            if (radioButtonVarchar.Checked) //varchar processing
            {
                CreateOutString(isVarchar: true);

               // MessageBox.Show(String.Join(" ", finalList));
                
            }
            else //numbers processing
            {
                 CreateOutString(isVarchar: false);
            }
           
              
            System.Windows.Forms.Clipboard.SetText(String.Join(" ", finalList));
            
            finalList.Clear();

            button1.Text = "Output copied to clipboard, you can paste it";

        }

        private void addToList(string line)
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


        private void CreateOutString(bool isVarchar)
        {
            addToList("(");

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

                    if (i == validLinesCount - 1) //last entry, so no comma. 
                    {
                        if (isVarchar)
                        {
                            addToList(quote + line + quote);
                        }
                        else
                        {
                            addToList(line);
                        }
                    }
                    else
                    {
                        if (isVarchar)
                        {
                            addToList(quote + line + quote + comma);
                        }
                        else
                        {
                            addToList(line + comma);
                        }
                        
                    }

                }
            }

            addToList(")");
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if (button1.Text.Equals("Output copied to clipboard, you can paste it")){

                button1.Text = "Save Da time";
            }
        }
    }
}
