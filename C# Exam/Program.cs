using C__Exam.Others;
using C__Exam.Questions;
using System.Diagnostics;

namespace C__Exam
{
    public class Program
	{
		static void Main(string[] args)
		{
			Subject subject = new Subject(10, "C#");
			subject.CreateExam();

			Console.Clear();

			int choice = Helper.CheckInput(1, 2, "Do You Want to Start The Exam (1 for Yes & 2 To End The Program)");

			if (choice == 1)
			{
				Stopwatch stopwatch = new Stopwatch();
				stopwatch.Start();
				subject?.exam?.ShowExam();

                Console.WriteLine($"The Elapsed Time = {stopwatch.Elapsed}");
            }
		}

	}
		
}
