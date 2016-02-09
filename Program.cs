using System;

//각 변수가 표현할 수 있는 최소음수와 최댓값을 나타낸 것이다.  

namespace int_example
{
	class Program
	{
		public static void Main (string[] args)
		{
			byte a = 255;
			sbyte b = (sbyte)a;

			Console.WriteLine (a);
			Console.WriteLine (b);
		}
	}
}
