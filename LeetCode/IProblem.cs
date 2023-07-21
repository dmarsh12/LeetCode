using System;
namespace LeetCode
{
	public interface IProblem
	{
		string? Result { get; set; }
		void DisplayResult() => Console.WriteLine($"{this.GetType()} {Result}");
    }
}

