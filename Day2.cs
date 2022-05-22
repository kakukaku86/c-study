using System;

namespace Day2
{
	class Program
	{
		public static void Main(string[] args)
		{
			//배열
			int []arrayNum = new int [10]; //10개 짜리 int형 배열을 만든다.
			int []arrayNum2 = new int []{0,1,2,3}; //0,1,2,3 으로 채워진 4칸 짜리 배열을 만든다.
			
			int number = 0;
			
			//연산자
			number++; //연산자 number를 1씩 증가시킨다.
			++number; //연산자 number를 계산전에 1씩 증가시킨다.
			
			number = number + number; //더하기
			number += number; //위와 같다.
			
			number = number - number; //뺴기
			number -= number; //위와 같다.
			
			number = number * number; //곱하기
			number *= number; //위와 같다.
			
			number = number / number; //나누기
			number /= number; //위와 같다.
			
			number = number % 2; //% 나머지 연산
				
			//비교 연산자
			if(number < 0) //작으면
			if(number > 0) //크면			
			if(number == 0) //같으면			
			if(number != 0) //다르면			
			if(number <= 0) //작거나 같으면		
			if(number >= 0) //크거나 같으면
			
			//조건문		
			
			if(number < 0) //number가 0보다 작을 경우 true 아니면 false
			{
				
			}
			else if (number > 0) //위에 if 문이 false이면 esle if 문으로...
			{
				//....
			}
			else //if ~ else if 까지다 false 이면...
			{
				//....
			}
			
			//반복문			
			while(number < 10) //조건이 true일 경우 계속 반복한다.
			{
				
			}
			
			//변수 , 종료 조건, 증가 연산 형식이다.
			for(int i =0; i < 10; i++)
			{
				
			}
			
			for(int i =0; i < 10; i++) //이렇게 2개도 가능
			{
				for(int j =0; j < 10; j++)
				{
					
				}
			}
			
			for(int i= 0; i < 10; ) //<--이렇게 중간에 조건을 뺄수도 있다.
			{
				
			}
			
			for(int i, j = 0; i < 10; j++) //<--이렇게 혼합도 가능하다.
			{
				
			}
			
			
			//반복문 안에 빠져나오기
			while(number < 10) //조건이 true일 경우 계속 반복한다.
			{
				if(number % 2 == 0)//
					continue;
					
					
				if(number < 5)
					break; //즉시 반복문을 종료한다.
			}
			
			//반복문 안에 빠져나오기
			while(number < 10) //조건이 true일 경우 계속 반복한다.
			{
				
				if(number < 5)
					break; //즉시 반복문을 종료한다.
			}
						
			Random random = new Random();
			int ran = random.Next(0,10);//0~9까지 랜덤 숫자			
		
			Console.ReadKey(true);//지우지 말기
		}
	}
}