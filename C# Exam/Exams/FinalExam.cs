using C__Exam.Others;
using C__Exam.Questions;

namespace C__Exam.Exams
{
    public class FinalExam : Exam
    {

        BaseQuestion[] BaseQuestions;
        public FinalExam(int datetime, int numberOfQuestion) : base(datetime, numberOfQuestion)
        {
            BaseQuestions = new BaseQuestion[numberOfQuestion];
        }
        private TrueOrFalseQuestion CreateTrueOrFalseQuestion(int i)
        {
            i++;

            Console.WriteLine($"Enter Body Of Question Number {i} : ");
            string body = Console.ReadLine();
            int mark = Helper.CheckInput($"Enter Mark Of Question Number {i} : ");

            Console.WriteLine();
            int rightAnswer = Helper.CheckInput(1, 2, $"Enter The Right Ansewr For Question Number {i} (1 For True & 2 For False)");


			Answer answer = new Answer();
			answer.Id = rightAnswer;

			answer.Text = (rightAnswer == 1) ? "True" : "False";
			return new TrueOrFalseQuestion( body, mark, answer);
        }


        // Manage T|F  and Mcq Questions
        public override void MangaeQuestions()
        {
            for (int i = 0; i < NumberOfQuestions; i++)
            {
                int Type = Helper.CheckInput(1, 2, $"Enter Type Of Question Number {i + 1} (1 for True Or False & 2 For Mcq)");
                if (Type == 1)
                {
                    BaseQuestions[i] = CreateTrueOrFalseQuestion(i);
                }
                else
                {
                    BaseQuestions[i] = CreateMcqQuestion(i);
                }
                Console.WriteLine();
                Console.WriteLine("============================");
            }
        }
        public BaseQuestion this[int index]
        {
            get
            {
                if (index >= 0 && index < NumberOfQuestions)
                {
                    return BaseQuestions[index];
                }
                return new BaseQuestion();
            }
            set
            {
                if (index >= 0 && index < NumberOfQuestions)
                {
                    BaseQuestions[index] = value;
                }

            }
        }
        public override void ShowExam()
        {
            Console.Clear();
            for (int i = 0; i < BaseQuestions.Length; i++)
            {
                Console.WriteLine(BaseQuestions[i]);
                Console.WriteLine("------------------------------");
                int choice;
                if (BaseQuestions[i]?.Answers?.Length == 2)
                {
                    // T||F Question
                    choice = Helper.CheckInput(1, 2, "Enter The Answer: ");
                }
                else
                {
                    // Mcq Question
                    choice = Helper.CheckInput(1, 3, "Enter The Answer: ");
                }

				EvaluateAnswer(BaseQuestions[i], choice);
			}
			ShowResult();
        }

		protected override void ShowResult()
		{
			Console.WriteLine("Your Answers :");
            Console.WriteLine();
            for (int i = 0;i < NumberOfQuestions;i++)
            {
               Console.WriteLine($"Q{i+1}) {BaseQuestions[i].Body}   ,   Your Answer : {BaseQuestions[i].ChosenAnswer}");
            }
            Console.WriteLine();    
            Console.WriteLine($"Your Exam Grade is {UserTotalMarks} From {GetTotalMarks(BaseQuestions)}");
        }
	}

}
