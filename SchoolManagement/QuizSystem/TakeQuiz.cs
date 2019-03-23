using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace SchoolManagement.QuizSystem
{
    public partial class TakeQuiz : UserControl
    {
        private string isCorrect;


        public TakeQuiz()
        {
            InitializeComponent();
        }

        private void txt_Class_Click(object sender, EventArgs e)
        {
            combo_Class.Items.Clear();
            DbClient.FillCombo(combo_Class, "Class", "name");
        }

        private void AvailableQuiz_Click(object sender, EventArgs e)
        {
            AvailableQuiz.Items.Clear();
            string classid = combo_Class.Text.Trim().ToString();
            DirectoryInfo d = new DirectoryInfo(@"Quiz/" + classid + "/");
            FileInfo[] Files = d.GetFiles("*.txt"); //Getting Text files
            List<string> str = new List<string>();
            foreach (FileInfo file in Files)
            {
                str.Add(file.Name);

            }

            foreach (string quizez in str)
            {
                AvailableQuiz.Items.Add(quizez);
            }


        }

        private void AvailableQuiz_SelectedValueChanged(object sender, EventArgs e)
        {

            string[] fileName = AvailableQuiz.Text.Split('.');
            lbl_QuizTitle.Text = fileName[0];
            txt_QuestionNo.Text = "1";


            fetchData();







        }



        public void fetchData()
        {
            string classid = combo_Class.Text.Trim().ToString();
            using (FileStream fs = new FileStream("Quiz/" + classid + "/" + AvailableQuiz.Text, FileMode.Open, FileAccess.Read))
            {
                StreamReader sr = new StreamReader(fs);
                string check;
                int count = 0;
                while ((check = sr.ReadLine()) != null)
                {
                    string[] arr = check.Split(',');

                    lbl_TotalQuestion.Text = arr[0];


                    if (arr[1] == txt_QuestionNo.Text)
                    {
                        txt_Question.Text = arr[2];
                        radioButton_OptionA.Text = arr[3];
                        radioButton_OptionB.Text = arr[4];
                        radioButton_OptionC.Text = arr[5];
                        radioButton_OptionD.Text = arr[6];
                        isCorrect = arr[7];

                        count++;
                    }
                }
            }
        }


        public int CheckScore(string choice, string answer)
        {
            if (choice == answer)
            {
                return 1;
            }
            else
            {
                return 0;
            }
        }


        int countScore = 1;


        private void btn_Next_Click(object sender, EventArgs e)
        {
            if (txt_QuestionNo.Text != lbl_TotalQuestion.Text)
            {
                int nextQuestion = int.Parse(txt_QuestionNo.Text) + 1;
                txt_QuestionNo.Text = nextQuestion.ToString();
                string atempt = getAtempt();

                if (CheckScore(atempt, isCorrect) == 1)
                {
                    lbl_Score.Text = countScore.ToString();
                    countScore++;

                }
                else
                {

                }


                fetchData();

            }
            else
            {
                btn_Next.Enabled = false;
                btn_SubmitQuiz.Enabled = true;
            }


        }


        // For getting user clicked choice

        public string getAtempt()
        {
            string attemptChoice = "";

            if (radioButton_OptionA.Checked == true)
            {
                attemptChoice = radioButton_OptionA.Text;
            }

            else if (radioButton_OptionB.Checked == true)
            {
                attemptChoice = radioButton_OptionB.Text;
            }

            else if (radioButton_OptionC.Checked == true)
            {
                attemptChoice = radioButton_OptionC.Text;
            }

            else if (radioButton_OptionD.Checked == true)
            {
                attemptChoice = radioButton_OptionD.Text;
            }

            return attemptChoice;

        }

        private void btn_SubmitQuiz_Click(object sender, EventArgs e)
        {
            string atempt = getAtempt();
            if (CheckScore(atempt, isCorrect) == 1)
            {
                lbl_Score.Text = countScore.ToString();
                countScore++;

            }
            else
            {

            }

            Student student = new Student(4, "One");
            student.TakeQuiz(new FileQuizSystem(student.Id, lbl_QuizTitle.Text.ToString(), countScore));
            MessageBox.Show("Your Score Submitted Sucessfully");
        }
    }
}
