using System.Buffers.Text;
using C__Exam.Others;
using C__Exam.Questions;

namespace C__Exam.Exams
{
    public abstract class Exam
    {
        public int TimeOfExam { get; set; }
        public int NumberOfQuestions { get; set; }
        protected int UserTotalMarks {  get; set; }

		public Exam(int datetime, int numberOfQuestion)
        {
            TimeOfExam = datetime;
            NumberOfQuestions = numberOfQuestion;
        }
        public McqQuestion CreateMcqQuestion(int i)
        {

            i++;
            Console.Write($"Enter Body Of Question Number {i} : ");
            string body = Console.ReadLine();
            int mark = Helper.CheckInput($"Enter Mark Of Question Number {i} : ");
            McqQuestion mcqQuestion = new McqQuestion();
            Console.WriteLine($"The Choices Of Question:");

            for (int j = 0; j < 3; j++)
            {
                Console.Write($"Enter The  Choice Number {j + 1} : ");
                string choice = Console.ReadLine();

                mcqQuestion[j] = choice;
            }
            mcqQuestion.Mark = mark;
            mcqQuestion.Body = body;

			int rightAnswerId = Helper.CheckInput(1, 3, "Enter The Right Answer : ");
			Answer answer = new Answer();
            answer.Id = rightAnswerId;

            answer.Text = mcqQuestion[rightAnswerId - 1];
			mcqQuestion.RightAnswer = answer;

            return mcqQuestion;
        }

        public abstract void ShowExam();
        protected abstract void ShowResult();

		public int GetTotalMarks(BaseQuestion[] BaseQuestions)
		{
			int total = 0;

			for (int i = 0; i < BaseQuestions.Length; i++)
			{
				total += BaseQuestions[i].Mark;
			}
			return total;
		}


		public void EvaluateAnswer( BaseQuestion question, int choice)
		{
			Answer answer = new Answer(choice, question[choice - 1]);
			question.ChosenAnswer = answer.Text;
			if (answer.CompareTo(question.RightAnswer) == 0)
			{
				UserTotalMarks += question.Mark;
			}

			Console.WriteLine();
			Console.WriteLine("==========================================");
		}


		// it's implementations will be 
		//different for each exam based on its type.
		public abstract void MangaeQuestions();
    }

}
