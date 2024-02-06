using C__Exam.Exams;

namespace C__Exam.Others
{
    public class Subject
    {
        public int Id { get; set; }

        public string? Name { get; set; }

        public Exam? exam { get; set; }

        public Subject(int id, string name)
        {
            Id = id;
            Name = name;
        }
        private void SpecifyExamType()
        {

            int choice = Helper.CheckInput(1, 2, "Please Enter Type Of Exam You Want To Create " +
                "(1 for Practical & 2 for Final)");

            int numberofquestions = Helper.CheckInput("Enter Number Of Questions");
            int dt = Helper.CheckInput("Enter time of Exam");

            if (choice == 1)
            {
                exam = new PracticalExam(dt, numberofquestions);
            }
            else
            {
                exam = new FinalExam(dt, numberofquestions);
            }
        }

        public void CreateExam()
        {
            SpecifyExamType();
            exam?.ManageQuestions();
        }
    }
}
