using C__Exam.Others;
using C__Exam.Questions;

namespace C__Exam.Exams
{
	public class PracticalExam : Exam
	{
		McqQuestion[] BaseQuestions;
		public PracticalExam(int datetime, int numberOfQuestion) : base(datetime, numberOfQuestion)
		{
			BaseQuestions = new McqQuestion[numberOfQuestion];
		}

		public override void MangaeQuestions()
		{
			for (int i = 0; i < NumberOfQuestions; i++)
			{
				BaseQuestions[i] = CreateMcqQuestion(i);
				Console.WriteLine();
				Console.WriteLine("============================");
			}
		}

		public override void ShowExam()
		{
			for (int i = 0; i < BaseQuestions.Length; i++)
			{
				Console.WriteLine(BaseQuestions[i]);
				Console.WriteLine("------------------------------");
				int choice = Helper.CheckInput(1, 3, "Enter The Answer: ");

				EvaluateAnswer(BaseQuestions[i], choice);
			}

			ShowResult();
		}

		protected override void ShowResult()
		{
			for (int i = 0; i < NumberOfQuestions; i++)
			{
				Console.WriteLine($"Q{i + 1}) {BaseQuestions[i].Body} ,  Right Answer  {BaseQuestions[i].RightAnswer.Text}");
			}
			Console.WriteLine();
		}
	}

}