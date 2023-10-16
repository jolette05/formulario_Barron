using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace formulario_Barron.Formas.Login
{
    public partial class Prueva_matematica : Form
    {
        public Prueva_matematica()
        {
            InitializeComponent();
        }
        private bool CheckTheAnswer()
        {
            if ((numsuma1 + numsuma2 == sum.Value)
                && (numresta1 - numresta2 == resultadoresta.Value)
                && (num1multiplicar* num2multipicar == resultadoresta.Value)
                && (num1dividir / num2dividir == resultadodividir.Value))
                return true;
            else
                return false;
        }
        private void pluslabel_Click(object sender, EventArgs e)
        {
            if (CheckTheAnswer())
            {
                // If CheckTheAnswer() returns true, then the user 
                // got the answer right. Stop the timer  
                // and show a MessageBox.
                timer1.Stop();
                MessageBox.Show("You got all the answers right!",
                                "Congratulations!");
                startButton.Enabled = true;
            }
            else if (timeLeft > 0)
            {
                // If CheckTheAnswer() returns false, keep counting
                // down. Decrease the time left by one second and 
                // display the new time left by updating the 
                // Time Left label.
                timeLeft = timeLeft - 1;
                timeLabel.Text = timeLeft + " seconds";
            }
            else
            {
                // If the user ran out of time, stop the timer, show
                // a MessageBox, and fill in the answers.
                timer1.Stop();
                timeLabel.Text = "Time's up!";
                MessageBox.Show("You didn't finish in time.", "Sorry!");
                sum.Value = addend1 + addend2;
                difference.Value = minuend - subtrahend;
                product.Value = multiplicand * multiplier;
                quotient.Value = dividend / divisor;
                startButton.Enabled = true;
            }
        }

        private void Prueva_matematica_Load(object sender, EventArgs e)
        {
            Random randomizer = new Random();
            int addend1;
            int addend2;

            int minuend;
            int subtrahend;

           
            int multiplicand;
            int multiplier;

           
            int dividend;
            int divisor;
            addend1 = randomizer.Next(51);
            addend2 = randomizer.Next(51);

            // Convert the two randomly generated numbers
            // into strings so that they can be displayed
            // in the label controls.
            numsuma1.Text = addend1.ToString();
            numsuma2.Text = addend2.ToString();

            // 'sum' is the name of the NumericUpDown control.
            // This step makes sure its value is zero before
            // adding any values to it.
            parasumar.Value = 0;

            // Fill in the subtraction problem.
            minuend = randomizer.Next(1, 101);
            subtrahend = randomizer.Next(1, minuend);
            numresta1.Text = minuend.ToString();
            numresta2.Text = subtrahend.ToString();
            resultadoresta.Value = 0;

            // Fill in the multiplication problem.
            multiplicand = randomizer.Next(2, 11);
            multiplier = randomizer.Next(2, 11);
            num1multiplicar.Text = multiplicand.ToString();
            num2multipicar.Text = multiplier.ToString();
            resultadomultiplicar.Value = 0;

            // Fill in the division problem.
            divisor = randomizer.Next(2, 11);
            int temporaryQuotient = randomizer.Next(2, 11);
            dividend = divisor * temporaryQuotient;
            num1dividir.Text = dividend.ToString();
            num2dividir.Text = divisor.ToString();
            resultadodividir.Value = 0;

            // Start the timer.
            timeleft = 30;
            timelabel.Text = "30 seconds";
            timer1.Start();



        }

        private void botonIniciar_Click(object sender, EventArgs e)
        {
            

        }
    }
}
