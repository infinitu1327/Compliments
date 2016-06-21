using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        Array s;

        public Form1()
        {
            InitializeComponent();
            s = File.ReadAllLines("words.txt");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox2.Text = "";
            foreach (char letter in textBox1.Text)
            {
                foreach (string word in s)
                {
                    if (word[0] == letter && !textBox2.Text.Contains(word))
                    {
                        textBox2.Text += Environment.NewLine + $"{letter.ToString().ToUpper()} {word}";
                        break;
                    }
                }
            }            
        }

        private void textBox2_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(textBox2.Text);
        }
    }
}
