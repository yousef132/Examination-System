namespace C__Exam.Others
{
    public class Answer : IComparable<Answer>
    {
        public int Id { get; set; }
        public string? Text { get; set; }

        public Answer(int id, string? text)
        {
            Id = id;
            Text = text;
        }
        public override string ToString()
        {
            return $"{Id}.{Text} ";
        }
        public Answer()
        {
            
        }

        public int CompareTo(Answer otherAnswer) => Id.CompareTo(otherAnswer.Id);
 
	}
}
