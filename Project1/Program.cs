namespace Project_1
{
	public class Program
	{
		// Project 1. 계산기 만들기
		// 반복문 while, 조건문 if
		// Replace, Contains, Substring, IndexOf

		// "3+3" "3 - 1" 같이 문자열 형식으로 입력하면 자동으로 계산되는 계산기를 만들어보자. 

		static void Main1(string[] args)
		{
			string str = "";
			double result = 0;
			while (true)
			{
				str = InsertStr();
				if (str == "0")
					break;
				result = Split(str);
				Console.WriteLine($"{str} = {result}");
				Console.WriteLine();
			}
		}

		static public string InsertStr()
		{
			Console.WriteLine("계산하고자 하는 식을 입력해주세요. 단, 0 입력 시 프로그램 종료");
			Console.Write(">> ");
			string temp = Console.ReadLine();
			return temp;
		}

		static public double Split(String str)
		{
			List<int> intList = new List<int>();
			str = str.Replace(" ", ""); // 공백 제거
			if (str.Contains("+"))
			{
				intList.Add(int.Parse(str.Substring(0, str.IndexOf("+"))));
				intList.Add(int.Parse(str.Substring(str.IndexOf("+") + 1)));
				return intList[0] + intList[1];
			}
			if (str.Contains("-"))
			{
				intList.Add(int.Parse(str.Substring(0, str.IndexOf("-"))));
				intList.Add(int.Parse(str.Substring(str.IndexOf("-") + 1)));
				return intList[0] - intList[1];
			}
			if (str.Contains("*"))
			{
				intList.Add(int.Parse(str.Substring(0, str.IndexOf("*"))));
				intList.Add(int.Parse(str.Substring(str.IndexOf("*") + 1)));
				return intList[0] * intList[1];
			}
			if (str.Contains("/"))
			{
				intList.Add(int.Parse(str.Substring(0, str.IndexOf("/"))));
				intList.Add(int.Parse(str.Substring(str.IndexOf("/") + 1)));
				return (double)intList[0] / (double)intList[1];
			}
			if (str.Contains("%"))
			{
				intList.Add(int.Parse(str.Substring(0, str.IndexOf("%"))));
				intList.Add(int.Parse(str.Substring(str.IndexOf("%") + 1)));
				return intList[0] % intList[1];
			}
			return 0;
		}
	}
}