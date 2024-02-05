namespace C__Exam.Others
{
    public static class Helper
    {
        public static int CheckInput(int low, int high, string Message)
        {
            while (true)
            {

                Console.Write("* " + Message);
                Console.WriteLine();
                if (int.TryParse(Console.ReadLine(), out int Choice))
                {
                    if (Choice >= low && Choice <= high)
                    {
                        return Choice;
                    }
                }
                Console.WriteLine($"Invalid choice. Input must be Between {low} , {high} Inclusive");

            }
        }

        //overloading
        public static int CheckInput(string Message)
        {
            while (true)
            {
                Console.Write("* " + Message);
                Console.WriteLine();
                if (int.TryParse(Console.ReadLine(), out int Choice))
                    return Choice;
                Console.WriteLine("Input must be Number.");
            }
        }
	}

}
