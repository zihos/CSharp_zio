using System;
using System.Collections.Generic;


namespace HelloCSharp
{
    class Program
    {
        //유일하게 하나만있는 특별한 함수, 모든 프로그램이 시작할때 가장먼저 시행되는 함수
        //운영체제에 의해서 호출되는 유일한 함수
        //Program안에 함수가 여러개 있을 수 있는데, 메인 함수만 운영체제가 직접 호출하고 나머지 함수들은 운영체제가 직접 호출하지 않음
        //나머지 함수들은 메인함수에서 프로그래머가 직접 호출
        static void Main(string[] args)//함수의 프로토타입, 메인함수가 기능을 하기 위해서는 무언가를 받아야 할 경우가 있음 -> 그걸 받는게 string[] args : 필수는 아님
        {
            //이안에다가 프로그램을 작성
            //콘솔에다 hello world 찍기
            //도화지 = Console 안에 .Write 이라는 함수
            Console.WriteLine("Hello C#");

            Console.WriteLine("Hello " + args[0]);

            //Console.ReadKey(); //누가 키보드 칠때까지 기다렸다가 받아라->커서가 깜빡거림
        }
        //메인이 끝나면 프로그램도 종료
    }
}