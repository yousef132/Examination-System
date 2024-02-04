using C__Exam.Others;

namespace C__Exam.Questions
{
    public class McqQuestion : BaseQuestion
    {


        public McqQuestion(string? header, string? body, int mark, int rightAnswer) :
            base(header, body, mark, rightAnswer)
        {
            Answers = new Answer[3];
        }
        public McqQuestion()
        {
            Answers = new Answer[3];
        }





    }

}
