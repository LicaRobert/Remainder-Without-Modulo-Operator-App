using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AlgoritmTask3
{
    public partial class Form2 : Form
    {
        Form1 parent;

        public Form2(Form1 p)
        {
            InitializeComponent();

            parent = p;
            
            //facem textbox-urile read only adica doar sa le putem citi informatia nu sa le putem modifica.
            reminderTextBox.ReadOnly = true;
            quotientTextBox.ReadOnly = true;
        }

        private void NoBtn_Click(object sender, EventArgs e)
        {
            parent.Close();
        }

        private void YesBtn_Click(object sender, EventArgs e)
        {
            parent.firstNumberTextBox.Text = "Introduce the first number";
            parent.secondNumberTextBox.Text = "Introduce the divisor";

            Close();
        }
    }
}
