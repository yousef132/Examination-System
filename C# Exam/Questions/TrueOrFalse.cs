using C__Exam.Others;

namespace C__Exam.Questions
{
    public class TrueOrFalseQuestion : BaseQuestion
    {
        public TrueOrFalseQuestion(string? header, string? body, int mark, int rightAnswerid)
            : base(header, body, mark, rightAnswerid)
        {
            Answers = new[]
            {
                new Answer{ Id = 1, Text= "True"},
                new Answer{ Id = 2, Text= "False"}
            };
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
