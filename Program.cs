using System;

//각 변수가 표현할 수 있는 최소음수와 최댓값을 나타낸 것이다.  

namespace int_example
{
	class Program
	{
		public static void Main (string[] args)
		{
			byte a = 255;//1111 1111
			sbyte b = (sbyte)a;//sbyte 형식으로 변환

			Console.WriteLine (a);
			Console.WriteLine (b);
		}
	}
}
