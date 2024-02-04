using C__Exam.Others;

namespace C__Exam.Questions
{
    public class McqQuestion : BaseQuestion
    {


        public McqQuestion( string body, int mark, Answer rightAnswer) :
            base(body, mark, rightAnswer)
        {
            Header = "MCQ Question";
            Answers = new Answer[3];
        }
        public McqQuestion()
        {
			Header = "MCQ Question";
			Answers = new Answer[3];
        }





    }

}
