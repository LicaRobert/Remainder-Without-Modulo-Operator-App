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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        
        // In ambele textbox-uri se vor putea introduce doar cifre.
        private void FirstNumberTextBox_MouseClick(object sender, MouseEventArgs e)
        {
            // la apasarea pe textbox sa introducem un numar,textul deja existent se va sterge.
            firstNumberTextBox.Text = "";
        }

        private void SecondNumberTextBox_MouseClick(object sender, MouseEventArgs e)
        {
            // la apasarea pe textbox sa introducem un numar,textul deja existent se va sterge.
            secondNumberTextBox.Text = "";
        }

        private void OkBtn_Click(object sender, EventArgs e)
        {
            if (firstNumberTextBox.Text == "" && secondNumberTextBox.Text == "")
            {
                MessageBox.Show("Please introduce the number and the divisor.");
            }
            else if (secondNumberTextBox.Text == "0")
            {
                MessageBox.Show("The divisor cannot be 0.");
            }
            else if(firstNumberTextBox.Text == "")
            {
                MessageBox.Show("Introduce the number.");
            }
            else if(secondNumberTextBox.Text == "")
            {
                MessageBox.Show("Introduce the divisor.");
            }
            else
            {
               try
               {
                 Form2 form = new Form2(this);
                 form.Show();

                 form.quotientTextBox.Text = GetQuotient().ToString();
                 form.reminderTextBox.Text = GetRemainder().ToString();
               }
               catch (Exception)
               {
 
               }
            }   
        }

        //la apasarea butonului Close,se va inchide Form.
        private void CloseBtn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private int GetQuotient()
        {

         int quotient = 0;

         //parsam textul textbox-urilor ca sa ne returneze un int din text(string).
         int num1 = int.Parse(firstNumberTextBox.Text);
         int num2 = int.Parse(secondNumberTextBox.Text);


          //cat timp numarul este mai mare decat divizorul sau.
          while (num1 >= num2) 
          { 
             num1 = num1 - num2; 
             quotient++; 
          }

         return quotient; 
        }

        private int GetRemainder()
        {
            int num = int.Parse(firstNumberTextBox.Text);
            int divisor = int.Parse(secondNumberTextBox.Text);
            int i = 1;
            int product = 0;

            /* 
            daca divizorul este  mai mic sau egal cu 0, atunci variabila divisor va lua
            valoarea negativa. 
            */

            if (divisor <= 0)
                divisor = -divisor;

            //la fel si numarul impartit.
            if (num <= 0)
                num = -num;

          /*
          cat timp variabila product este mai mica sau egala cu numarul impartit,
          atunci product ia valoarea variabilei divisor inmultita cu i,
          dupa care incrementam pe i;
          */
            while (product <= num)
            {
                product = divisor * i;
                i++;
            }

            //memoram restul intr-o variabila de tipul int pe nume reminder.
            int reminder = num - (product - divisor);
            //intoarcem valoarea variabilei reminder.
            return reminder;
        }

        //Vom putea introduce doar int ci nu char ori String.
        private void FirstNumberTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        } 

        private void SecondNumberTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        //la apasarea click pe acest textbox,se va sterge textul cu introdu numarul.
        private void FirstNumberTextBox_MouseClick_1(object sender, MouseEventArgs e)
        {
            firstNumberTextBox.Text = "";
        }

        //la apasarea click pe acest textbox,se va sterge textul cu introdu divizorul.
        private void SecondNumberTextBox_MouseClick_1(object sender, MouseEventArgs e)
        { 
            secondNumberTextBox.Text = "";
        }
    }
}
