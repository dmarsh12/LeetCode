namespace LeetCode
{
    public class Problem : IProblem
	{
		public Problem()
		{
		}

		public string? Result { get; set; }

        public void DisplayResult()
        {
            Console.WriteLine($"{this.GetType()} {Result}");
        }
    }
}

