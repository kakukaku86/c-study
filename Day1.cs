
using System;

namespace Day1
{
	class Program
	{
		public static void Main(string[] args)
		{
			//변수란? 변할수 있는 수를 말한다.
			//종류
			//[정수형] 예: 1,2,10,200,300
			//int(4바이트) - -2,147,483,648 ~ 2,147,483,647 [2^32 - 1]
			//long(8바이트) -  -9,223,372,036,854,775,808 - 9,223,372,036,854,775,807 [2^64 - 1]
			
			//[실수형] 예: 0.1, 0.5, 3.14, 15.5
			//float(4바이트) - 대략 6 ~ 7 자리 소수
			//double(8바이트) -대략 15 ~ 16 자리 소수
			
			//[문자형]
			//단일문자 - char (1바이트) - 단일 문자
			//문자열 - string - 2바이트 크기의 문자의 모음(묶음)
			
			//[논리형]
			//bool - (1바이트) - true(참), false(거짓)
			
			//사용 예)
			//int a = 2; // 정수
			//float b = 3.56f; // 부동소수
			//double c = 7.89d; // 부동소수
			//char d = 'a'; // 단일문자
			//bool e = true; // 참거짓
			//string f = "Neo"; // 문자열
			
			int result = 0;

			TestFunc1();
			
			result = TestFunc2(5);
			
			Console.WriteLine(result);
				
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
		
		//함수 - 어떤 행동을 하고 결과를 반환해줄수 있는 것
		//[형식]
		//반환형 함수이름 인자값(매개변수)
		static void TestFunc1()
		{
			Console.WriteLine("Hello World!");
		}
		
		static int TestFunc2(int number)
		{
			return number + number;
		}
	}
}