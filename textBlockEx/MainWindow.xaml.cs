using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace textBlockEx
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        static public int correctAnswers { get; set; } = 0;
        static public int sum { get; set; } = 8;
        static public bool question1 { get; set; } = false;
        static public bool question2 { get; set; } = false;
        static public bool question3 { get; set; } = false;
        static public bool question4 { get; set; } = false;
        static public bool question5 { get; set; } = false;
        static public bool question6 { get; set; } = false;
        static public bool question7 { get; set; } = false;
        static public bool question8 { get; set; } = false;







        public MainWindow()
        {
            InitializeComponent();
        }

        private void enter_Click(object sender, RoutedEventArgs e)
        {
            //will call methods to check each question
            
            isQuestion2Correct();
            isQuestion3Correct();
            isQuestion4Correct();
            isQuestion5Correct();
            isQuestion6Correct();
            isQuestion7Correct();
            isQuestion8Correct();
            if (isQuestion1Correct())
            {
                resultQ1box.Text = "Correct";
            }
            else if (isQuestion1Correct() == false)
            {
                resultQ1box.Text = "Incorrect; a";
            }

            if(isQuestion2Correct())
            {
                resultQ2box.Text = "Correct";
            }
            else if (isQuestion2Correct() == false)
            {
                resultQ2box.Text = "Incorrect; a";
            }

            if (isQuestion3Correct())
            {
                resultQ3box.Text = "Correct";
            }
            else if (isQuestion3Correct() == false)
            {
                resultQ3box.Text = "Incorrect; d";
            }

            if (isQuestion4Correct())
            {
                resultQ4box.Text = "Correct";
            }
            else if (isQuestion4Correct() == false)
            {
                resultQ4box.Text = "Incorrect; b";
            }

            if (isQuestion5Correct())
            {
                resultQ5box.Text = "Correct";
            }
            else if (isQuestion5Correct() == false)
            {
                resultQ5box.Text = "Incorrect; d";
            }

            if (isQuestion6Correct())
            {
                resultQ6box.Text = "Correct";
            }
            else if (isQuestion6Correct() == false)
            {
                resultQ6box.Text = "Incorrect; c";
            }

            if (isQuestion7Correct())
            {
                resultQ7box.Text = "Correct";
            }
            else if (isQuestion7Correct() == false)
            {
                resultQ7box.Text = "Incorrect; sequoia";
            }
            if (isQuestion8Correct())
            {
                resultQ8box.Text = "Correct";
            }
            else if (isQuestion8Correct() == false)
            {
                resultQ8box.Text = "Incorrect; >=4";
            }

            Console.WriteLine("Questions right: " + correctAnswers + " out of 8 questions. ");
            

        }

        private bool isQuestion1Correct()
        {
            question1 = false;
            //going to check the answer given
            //will increment correct answer if true, will change questionNumber to true if true
            if (q1a2.IsChecked.Value == true)
            {
                Console.WriteLine("Question 1 is wrong.");
            }
            else if (q1a3.IsChecked.Value == true)
            {
                Console.WriteLine("Question 1 is wrong");
            }
            else if (q1a1.IsChecked.Value == true)
            {
                Console.WriteLine("Question 1 is right.");
                correctAnswers++;
                question1 = true;
            }
            return question1;
        }

        private bool isQuestion2Correct()
        {
            question2 = false;

            if (q2a2.IsChecked.Value == true)
            {
                Console.WriteLine("Question 2 is wrong.");
            }
            else if (q2a1.IsChecked.Value == true)
            {
                Console.WriteLine("Question 2 is right.");
                correctAnswers++;
                question2 = true;
            }
            return question2;
        }
        private bool isQuestion3Correct()
        {
            question3 = false;

            if (question3Answers.SelectedIndex==3)
            {
                correctAnswers++;
                question3 = true;
            }
            return question3;

        }

        private bool isQuestion4Correct()
        {
            question4 = false;

            if (question4Answers.SelectedIndex==1)
            {
                correctAnswers++;
                question4 = true;
            }
            return question4;

        }


        private bool isQuestion5Correct()
        {
            //going to check the answer given
            //will increment correct answer if true, will change questionNumber to true if true
            question5 = false;

            if (q5a1.IsChecked.Value == true)
            {
                Console.WriteLine("Question 5 is wrong.");
            }
            else if (q5a2.IsChecked.Value == true)
            {
                Console.WriteLine("Question 5 is wrong.");
            }
            else if (q5a3.IsChecked.Value == true)
            {
                Console.WriteLine("Question 5 is wrong.");
            }
            else if (q5a4.IsChecked.Value == true)
            {
                Console.WriteLine("Question 5 is right.");
                correctAnswers++;
                question5 = true;
            }
            return question5;

        }

        private bool isQuestion6Correct()
        {
            question6 = false;
            if (q6a3.IsChecked.Value == true)
            {
                Console.WriteLine("Question 6 is right.");
                correctAnswers++;
                question6 = true;
            }
            return question6;

        }

        private bool isQuestion7Correct()
        {
            question7 = false;
            Console.WriteLine(inputBox7.Text);
            if(inputBox7.Text=="sequioa")
            {
                correctAnswers++;
                question7 = true;
            }

            return question7;


        }

        private bool isQuestion8Correct()
        {
            question8 = false;

            int answer;
            if (int.TryParse(inputBox8.Text, out answer))
            {
                if (answer >= 4)
                {
                    correctAnswers++;
                    question8 = true;
                }
            }

            return question8;

        }


        private void comboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void comboBox_DropDownOpened(object sender, EventArgs e)
        {

        }

        private void clearButton_Click(object sender, RoutedEventArgs e)
        {
            question1 = question2 = question3 = question4 = question5 = question6= question7 = question8= false;
            inputBox7.Text = null;
            inputBox8.Text = null;
            question4Answers.SelectedIndex = 0;
            question3Answers.SelectedIndex = 0;
            q1a1.IsChecked = false;
            q1a2.IsChecked = false;
            q1a3.IsChecked = false;
            q2a1.IsChecked = false;
            q2a2.IsChecked = false;
            q5a1.IsChecked = false;
            q5a2.IsChecked = false;
            q5a3.IsChecked = false;
            q5a4.IsChecked = false;
            q6a1.IsChecked = false;
            q6a2.IsChecked = false;
            q6a3.IsChecked = false;
            q6a4.IsChecked = false;
            


        }

        //https://msdn.microsoft.com/en-us/library/system.windows.data.bindinggroup(v=vs.110).aspx
    }
}
