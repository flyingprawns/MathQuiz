using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsForms_MathQuiz
{
    public partial class mathQuiz_Forms : Form
    {
        // -------
        // Fields
        // -------
        private const int quizTime = 15;
        private int timeLeft;
        private Random randomizer = new Random();
        private int plusLeft; private int plusRight;
        private int minusLeft; private int minusRight;
        private int multLeft; private int multRight;
        private int divLeft; private int divRight;

        // --------
        // Methods
        // --------
        /// <summary>
        /// Fill in all the problems
        /// and start the quiz timer
        /// </summary>
        private void StartTheQuiz()
        {
            //Fill in the 'plus' row
            plusLeft = randomizer.Next(51);
            plusRight = randomizer.Next(51);
            plusLeft_Label.Text = plusLeft.ToString();
            plusRight_Label.Text = plusRight.ToString();
            plusSum_NumericUpDown.Value = 0;

            //Fill in the 'minus' row
            minusLeft = randomizer.Next(1, 101);
            minusRight = randomizer.Next(1, minusLeft);
            minusLeft_Label.Text = minusLeft.ToString();
            minusRight_Label.Text = minusRight.ToString();
            minusDifference_NumericUpDown.Value = 0;

            //Fill in the 'mult' row
            multLeft = randomizer.Next(2, 11);
            multRight = randomizer.Next(2, 11);
            multLeft_Label.Text = multLeft.ToString();
            multRight_Label.Text = multRight.ToString();
            multProduct_NumericUpDown.Value = 0;

            //Fill in the 'div' row
            int tempQuotient = randomizer.Next(2, 11);
            divRight = randomizer.Next(2, 11);
            divLeft = divRight * tempQuotient;
            divLeft_Label.Text = divLeft.ToString();
            divRight_Label.Text = divRight.ToString();
            divQuotient_NumericUpDown.Value = 0;

            //Start the timer
            timeLeft = quizTime;
            time_Label.BackColor = SystemColors.Control;
            time_Label.Text = timeLeft + " seconds";
            time_Timer.Start();
        }

        /// <summary>
        /// Check user's answers for correctness.
        /// </summary>
        /// <returns>true if answers are correct, false otherwise.</returns>
        private bool CheckTheAnswer()
        {
            bool plusCorrect = plusLeft + plusRight == plusSum_NumericUpDown.Value;
            bool minusCorrect = minusLeft - minusRight == minusDifference_NumericUpDown.Value;
            bool multCorrect = multLeft * multRight == multProduct_NumericUpDown.Value;
            bool divCorrect = divLeft / divRight == divQuotient_NumericUpDown.Value;
            if(plusCorrect && minusCorrect && multCorrect && divCorrect)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        // --------------
        // Windows Forms
        // --------------
        public mathQuiz_Forms()
        {
            InitializeComponent();
        }

        private void startQuiz_Button_Click(object sender, EventArgs e)
        {
            StartTheQuiz();
            startQuiz_Button.Enabled = false;
        }

        private void time_Timer_Tick(object sender, EventArgs e)
        {
            if(CheckTheAnswer() == true)
            {
                //Answers are correct!
                //Stop timer, show congratulations message, re-enable 'startQuiz_Button'
                time_Timer.Stop();
                MessageBox.Show("You got all the answers right!!!", ":D");
                startQuiz_Button.Enabled = true;
            }

            if(timeLeft > 0)
            {
                //Decrease timer by 1 every second
                timeLeft -= 1;
                time_Label.Text = timeLeft + " seconds";

                if(timeLeft < 5)
                {
                    //Change background red if less than 5 seconds left
                    time_Label.BackColor = Color.Red;
                }
            }
            else
            {
                //Time is up.
                //Stop timer, display failure message, reveal solutions, re-enable 'startQuiz_Button'
                time_Timer.Stop();
                time_Label.Text = "Time is up.";
                MessageBox.Show("You didn't finish in time.", ":(");
                plusSum_NumericUpDown.Value = plusLeft + plusRight;
                minusDifference_NumericUpDown.Value = minusLeft - minusRight;
                multProduct_NumericUpDown.Value = multLeft * multRight;
                divQuotient_NumericUpDown.Value = divLeft / divRight;
                startQuiz_Button.Enabled = true;
            }
        }

        private void answer_NumericUpDown_Enter(object sender, EventArgs e)
        {
            //Select the whole answer when user selects the answer box
            NumericUpDown answerBox = sender as NumericUpDown;
            if (answerBox != null)
            {
                int lengthOfAnswer = answerBox.Value.ToString().Length;
                answerBox.Select(0, lengthOfAnswer);
            }
        }

        private void tip_CheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (tip_CheckBox.Checked == true)
            {
                tip_Label.Visible = true;
            }
            else
            {
                tip_Label.Visible = false;
            }
        }


    }//END class Form_mathQuiz
}//END namespace WindowsForms_MathQuiz
