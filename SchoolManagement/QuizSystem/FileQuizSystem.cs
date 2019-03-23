using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace SchoolManagement.QuizSystem
{
    public class FileQuizSystem : IQuiz
    {

        private string quizTitle;
        private int studentId;
        private string classId;
        private string choiceSelect;
        private int totalQuestions;
        private int questionNo;
        private string question;
        private string[] choices = new string[4];
        private string correct;
        private int score;
        public FileQuizSystem()
        {

        }

        public FileQuizSystem(int id, string quizid, int score)
        {
            this.studentId = id;
            this.quizTitle = quizid;
            this.score = score;

        }

        //Constructor used for creating Quiz
        public FileQuizSystem(string quizid, string classid, int totalquestions, int questionno, string question, string[] choice, string correct)
        {
            this.quizTitle = quizid;
            this.classId = classid;
            this.totalQuestions = totalquestions;
            this.questionNo = questionno;
            this.question = question;
            this.correct = correct;
            this.choices = choice;

        }


        public void CreateQuiz()
        {
            using (var sw = new StreamWriter(@"Quiz/" + classId + "/" + quizTitle + ".txt", true))
            {
                sw.WriteLine(totalQuestions + "," + questionNo + "," + question + "," +
                choices[0] + "," + choices[1] + ","
                + choices[2] + "," + choices[3] + "," + correct
                                    );
            }
        }

        public void TakeQuiz()
        {
            using (var sw = new StreamWriter(@"Quiz/Score/" + studentId + ".txt", true))
            {
                sw.WriteLine(quizTitle + "," + score
                                    );
            }
        }



    }
}
