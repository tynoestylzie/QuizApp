using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuizApp
{
    public partial class Form1 : Form
    {

        int correctAnswer;
        int questionNum = 1;
        int score;
        int percentage;
        int totalQues; 

        public Form1()
        {
            InitializeComponent();
            askQuestion(questionNum);

            totalQues = 15; 
        }

        private void checkAnswerEvent(object sender, EventArgs e)
        {
            var senderObject = (Button)sender;
            int buttonTag = Convert.ToInt32(senderObject.Tag); 
            
            if(buttonTag == correctAnswer)
            {
                score++; 
            }

            if(questionNum == totalQues)
            {
                percentage = (int)Math.Round((double)(score * 100) / totalQues);

                MessageBox.Show("End of test!" + Environment.NewLine +
                    "You have answered " + score + " questions correctly ." + Environment.NewLine +
                    "Your total percentange is " + percentage + "%" + Environment.NewLine + 
                    "Click OK to write test again");

                score = 0;
                questionNum = 0;
                askQuestion(questionNum); 
            }
            questionNum++;
            askQuestion(questionNum); 
        }

        private void askQuestion(int qnum)
        {
            switch (qnum)
            {
                case 1:

                    pctBx.Image = Properties.Resources._1;
                    lblQues.Text = "Click below button to answer the above question";

                    button1.Text = "A";
                    button2.Text = "B";
                    button3.Text = "C";
                    button4.Text = "D";

                    correctAnswer = 3; 
                    break;

                case 2:

                    pctBx.Image = Properties.Resources._2;
                    lblQues.Text = "Click below button to answer the above question";

                    button1.Text = "A";
                    button2.Text = "B";
                    button3.Text = "C";
                    button4.Text = "D";

                    correctAnswer = 2;
                    break;

                case 3:

                    pctBx.Image = Properties.Resources._3;
                    lblQues.Text = "Click below button to answer the above question";

                    button1.Text = "A";
                    button2.Text = "B";
                    button3.Text = "C";
                    button4.Text = "D";

                    correctAnswer = 1;
                    break;

                case 4:

                    pctBx.Image = Properties.Resources._4;
                    lblQues.Text = "Click below button to answer the above question";

                    button1.Text = "A";
                    button2.Text = "B";
                    button3.Text = "C";
                    button4.Text = "D";

                    correctAnswer = 3;
                    break;

                case 5:

                    pctBx.Image = Properties.Resources._5;
                    lblQues.Text = "Click below button to answer the above question";

                    button1.Text = "A";
                    button2.Text = "B";
                    button3.Text = "C";
                    button4.Text = "D";

                    correctAnswer = 2;
                    break;

                case 6:

                    pctBx.Image = Properties.Resources._6;
                    lblQues.Text = "Click below button to answer the above question";

                    button1.Text = "A";
                    button2.Text = "B";
                    button3.Text = "C";
                    button4.Text = "D";

                    correctAnswer = 4;
                    break;

                case 7:

                    pctBx.Image = Properties.Resources._7;
                    lblQues.Text = "Click below button to answer the above question";

                    button1.Text = "A";
                    button2.Text = "B";
                    button3.Text = "C";
                    button4.Text = "D";

                    correctAnswer = 3;
                    break;

                case 8:

                    pctBx.Image = Properties.Resources._8;
                    lblQues.Text = "Click below button to answer the above question";

                    button1.Text = "A";
                    button2.Text = "B";
                    button3.Text = "C";
                    button4.Text = "D";

                    correctAnswer = 3;
                    break;

                case 9:

                    pctBx.Image = Properties.Resources._9;
                    lblQues.Text = "Click below button to answer the above question";

                    button1.Text = "A";
                    button2.Text = "B";
                    button3.Text = "C";
                    button4.Text = "D";

                    correctAnswer = 2;
                    break;

                case 10:

                    pctBx.Image = Properties.Resources._10;
                    lblQues.Text = "Click below button to answer the above question";

                    button1.Text = "A";
                    button2.Text = "B";
                    button3.Text = "C";
                    button4.Text = "D";

                    correctAnswer = 4;
                    break;

                case 11:

                    pctBx.Image = Properties.Resources._11;
                    lblQues.Text = "Click below button to answer the above question";

                    button1.Text = "A";
                    button2.Text = "B";
                    button3.Text = "C";
                    button4.Text = "D";

                    correctAnswer = 2;
                    break;

                case 12:

                    pctBx.Image = Properties.Resources._12;
                    lblQues.Text = "Click below button to answer the above question";

                    button1.Text = "A";
                    button2.Text = "B";
                    button3.Text = "C";
                    button4.Text = "D";

                    correctAnswer = 3;
                    break;

                case 13:

                    pctBx.Image = Properties.Resources._13;
                    lblQues.Text = "Click below button to answer the above question";

                    button1.Text = "A";
                    button2.Text = "B";
                    button3.Text = "C";
                    button4.Text = "D";

                    correctAnswer = 2;
                    break;

                case 14:

                    pctBx.Image = Properties.Resources._14;
                    lblQues.Text = "Click below button to answer the above question";

                    button1.Text = "A";
                    button2.Text = "B";
                    button3.Text = "C";
                    button4.Text = "D";

                    correctAnswer = 4;
                    break;

                case 15:

                    pctBx.Image = Properties.Resources._15;
                    lblQues.Text = "Click below button to answer the above question";

                    button1.Text = "A";
                    button2.Text = "B";
                    button3.Text = "C";
                    button4.Text = "D";

                    correctAnswer = 3;
                    break;
            }

        }

        private void button5_Click(object sender, EventArgs e)
        {
            Close(); 
        }

        private void pctBx_Click(object sender, EventArgs e)
        {

        }

        /*private void pictureBox1_Click(object sender, EventArgs e)
        {

        }*/
    }
}
