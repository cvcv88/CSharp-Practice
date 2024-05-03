namespace Project_1
{
	public class Replace_Practice
	{
		static void Main1(string[] args)
		{
			string str1 = "i love C#";
			Console.WriteLine($"Original String : {str1}");
			Console.WriteLine("New String : {0}", str1.Replace('i', 'I'));

			Console.WriteLine();

			string str2 = "I love Python";
			Console.WriteLine($"Original String : {str2}");
			Console.WriteLine("New String : {0}", str2.Replace("Python", "C#"));
		}
	}
}
