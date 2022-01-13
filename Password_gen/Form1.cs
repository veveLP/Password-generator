using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Password_gen
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string idk = "";
            string output = "";
            if (checkBox1.Checked) { idk += "ABCDEFGHIJKLMNOPQRSTUVWXYZ"; }
            if (checkBox2.Checked) { idk += "abcdefghijklmnopqrstuvwxyz"; }
            if (checkBox3.Checked) { idk += "0123456789"; }
            if (checkBox4.Checked) { idk += "±!@#$%^&*()_+-=§£¢§[]{}"; }
            if (idk == "") { MessageBox.Show("Musíš vybrat checkbox"); return; }
            int numb = (int)numericUpDown1.Value;
            Random rng = new Random();
            for(int i = 0;i<numb;i++)
            {
                output += idk[rng.Next(1, idk.Length)];
            }
            MessageBox.Show("Heslo: "+output);
            //Clipboard.SetText(output);
        }
    }
}
