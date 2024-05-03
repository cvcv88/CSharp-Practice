namespace Project_1
{
	public class IndexOf_Practice
	{
		static void Main(string[] arg)
		{
			string str = "We might even be falling in love";
			Console.WriteLine("str : {0}", str);

			Console.WriteLine("지정된 위치에서 지정된 문자의 수만큼 특정 문자열 검색 might / 0 / str.Length: {0}" ,str.IndexOf("might", 0, str.Length));
			Console.WriteLine("지정된 위치에서 지정된 문자의 수만큼 특정 문자열 검색 might / 5 / 10 : {0}", str.IndexOf("might", 5, 10));
			
			Console.WriteLine();

			Console.WriteLine("지정된 위치에서 지정된 문자의 수만큼 특정 문자 검색 i / 0 / str.Length : {0}", str.IndexOf('i', 0, str.Length));
			Console.WriteLine("지정된 위치에서 지정된 문자의 수만큼 특정 문자 검색 i / 10 / 20 : {0}", str.IndexOf('i', 10, 20));

			Console.WriteLine();

			Console.WriteLine("첫 번째 위치에서 문자열의 마지막까지 특정 문자열 검색, 검색 규칙 설정 LOVE / 대소문자 무시 : {0}", str.IndexOf("LOVE", StringComparison.OrdinalIgnoreCase));
			Console.WriteLine("첫 번째 위치에서 문자열의 마지막까지 특정 문자 검색, 검색 규칙 설정 I / 대소문자 무시 : {0}" ,str.IndexOf("I", StringComparison.OrdinalIgnoreCase));

			Console.WriteLine();

			Console.WriteLine("지정된 위치에서 문자열의 마지막까지 특정 문자열 검색 be / 0 : {0}", str.IndexOf("be", 0));
			Console.WriteLine("지정된 위치에서 문자열의 마지막까지 특정 문자 검색 b / 0 : {0}", str.IndexOf('b', 0));

			Console.WriteLine();

			Console.WriteLine("첫 번째 위치에서 마지막까지 특정 문자열 검색 in : {0}", str.IndexOf("in"));
			Console.WriteLine("첫 번째 위치에서 마지막까지 특정 문자 검색 n : {0}", str.IndexOf('n'));
		}
	}
}
