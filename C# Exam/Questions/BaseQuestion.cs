using C__Exam.Others;

namespace C__Exam.Questions
{
    public class BaseQuestion
    {
        public string Header { get; set; }

        public string Body { get; set; }

        public int Mark { get; set; }
        public int RightAnswerId { get; set; }
        public string ChosenAnswer { get; set; }

        public Answer[] Answers;
        public BaseQuestion( string body, int mark, int rightAnswerid)
        {
            Body = body;
            Mark = mark;
            RightAnswerId = rightAnswerid;
        }

		// Indexer for answers of question
		public string this[int index]
		{
			get
			{
				if (index >= 0 && index < Answers.Length)
				{
					return Answers[index].Text ?? "No Answer!!";
				}
				return "No Asnwer";
			}
			set
			{
				if (index >= 0 && index < Answers.Length)
				{
					Answers[index] = new Answer { Id = index + 1, Text = value };
				}
			}
		}
		public BaseQuestion()
        {

        }
        public override string ToString()
        {

            string Answers = "";
            for (int i = 0; i < this.Answers.Length; i++)
            {
                Answers += this.Answers[i] + "    ";
            }
            return $"\n{Header}    Mark({Mark}) \n\n{Body}  \nChoices :\n\n{Answers}";
        }
    }

}
