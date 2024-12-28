// Hello World 출력

// using은 Java의 import와 유사한 느낌
using System;

namespace HelloWorld
{
    class HelloWorld
    {
        static void Main(String[] args)
        {

            // Java의 System.out.println 유사
            Console.WriteLine("Hello World!");

            // 자리표시자
            // {0 이상의 숫자 인덱스} 를 이용하여 원하는 위치에 문자열 또는 숫자를 삽입 가능
            Console.WriteLine("{0}", "안녕");
            Console.WriteLine("{0}, {1}", "그래\n", "안녕!");
        }
    }
}