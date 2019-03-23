using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SchoolManagement.QuizSystem
{
    public partial class TeacherQuiz : UserControl
    {
        public TeacherQuiz()
        {
            InitializeComponent();

        }



        int count = 1;


        private void combo_Class_Click(object sender, EventArgs e)
        {
            combo_Class.Items.Clear();
            DbClient.FillCombo(combo_Class, "Class", "name");
        }

        private void btn_CreateQuiz_Click_1(object sender, EventArgs e)
        {
            if (txt_QuestionNo.Text != "" && txt_TotalQuestions.Text != "" && txt_Question.Text != "" && txt_OptionA.Text != "" && txt_OptionB.Text != "" && txt_OptionC.Text != "" && txt_OptionD.Text != "" && txt_Correct.Text != "")
            {
                if (txt_Correct.Text == txt_OptionA.Text || txt_Correct.Text == txt_OptionB.Text || txt_Correct.Text == txt_OptionC.Text || txt_Correct.Text == txt_OptionD.Text)
                {
                    //code here
                    string[] options = new string[4];
                    options[0] = txt_OptionA.Text; options[1] = txt_OptionB.Text;
                    options[2] = txt_OptionC.Text; options[3] = txt_OptionD.Text;

                    string classids = combo_Class.Text.Trim().ToString();
                    Staff quizcreate = new Staff();
                    quizcreate.CreateQuiz(new FileQuizSystem(txt_QuizTitle.Text, classids, int.Parse(txt_TotalQuestions.Text), int.Parse(txt_QuestionNo.Text), txt_Question.Text, options, txt_Correct.Text)
);

                    MessageBox.Show("Question Added Sucessfully");

                    //clear fileds
                    txt_OptionA.Text = null; txt_OptionB.Text = null; txt_OptionC.Text = null; txt_OptionD.Text = null;
                    txt_Question.Text = null; txt_Correct.Text = null;

                    // Next question

                    int totalquestions = int.Parse(txt_TotalQuestions.Text);

                    if (count != totalquestions)
                    {
                        count++;
                        txt_QuestionNo.Text = count.ToString();
                        txt_TotalQuestions.Enabled = false;
                        txt_QuizTitle.Enabled = false;
                    }
                    else
                    {


                        txt_TotalQuestions.Enabled = true;
                        txt_QuizTitle.Enabled = true;
                        txt_QuizTitle.Text = ""; txt_QuestionNo.Text = "1";
                        txt_TotalQuestions.Text = "";
                    }


                }
                else
                {
                    MessageBox.Show("Plz Enter Correct Answer from given Options");
                }
            }



            else
            {
                MessageBox.Show("Plz Enter question with required information");
            }

        }
    }
}
