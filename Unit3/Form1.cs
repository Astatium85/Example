using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
namespace Unit3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void richTextBox5_TextChanged(object sender, EventArgs e)
        {
            IncorrectNumbers(label1, richTextBox5);


        }
        void IncorrectNumbers(Label lbl, RichTextBox rtb)
        {
            Regex reg = new Regex(@"\D");
            if (rtb.Text.Length > 0)
            {
                if (reg.IsMatch(rtb.Text))
                {
                    rtb.Text = reg.Replace(rtb.Text, "");
                    ShowErrorLabel(lbl, "Разрешены только цифры");
                    Timer1.Start();
                }
            }
        }
    }
    

}
