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
namespace _111
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            int count = 1;
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                StreamReader sr = new StreamReader(openFileDialog1.FileName);
                string str = sr.ReadToEnd();
                foreach(char i in str)
                {
                    if(i == ' ')
                    {
                        count++;
                    }
                   
                }
                label1.Text = "Слова: " + count.ToString();
                sr.Close();
            }
        }
    }
}
