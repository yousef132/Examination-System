using C__Exam.Others;

namespace C__Exam.Questions
{
    public class TrueOrFalseQuestion : BaseQuestion
    {
        public TrueOrFalseQuestion( string? body, int mark, int rightAnswerid)
            : base( body, mark, rightAnswerid)
        {
            Answers = new[]
            {
                new Answer{ Id = 1, Text= "True"},
                new Answer{ Id = 2, Text= "False"}
            };
            Header = "True Or False Question";
        }
        public TrueOrFalseQuestion()
        {
            Answers = new Answer[]
            {
                new Answer{ Id = 1, Text= "True"},
                new Answer{ Id = 2, Text= "False"}
            };
        }
    }

}
