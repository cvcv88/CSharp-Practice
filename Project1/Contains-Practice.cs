namespace Project_1
{
	public class Contains_Practice
	{
		static void Main1(string[] args)
		{
			string str1 = "We might even be falling in love";
			string str2 = "Love";
			bool b = str1.Contains(str2);
			Console.WriteLine("'{0}' is in the string '{1}' : {2}", str2, str1, b);

			if (b)
			{
				int index = str1.IndexOf(str2);
				if(index >= 0)
				{
					Console.WriteLine("'{0}' begins at character position {1}", str2, index + 1);
				}
			}
		}
	}
}
