using System;

class Variable
{
    static void Main(String[] args)
    {
        int number = 5;
        Console.WriteLine("number value = {0}", number);

        // 각 타입의 리터럴
        Console.WriteLine("정수 >> {0}", 1234);
        Console.WriteLine("실수 >> {0}", 3.14F);
        Console.WriteLine("문자 >> {0}", 'A');
        Console.WriteLine("문자열 >> {0}", "Hello");


        // 변수 선언
        int i;
        i = 1234;
        Console.WriteLine("변수 i 값 = " + i);


        // 동일 형식 변수를 한 번에 지정
        int a, b, c;
        a = 12;
        b = 13;
        c = 14;
        Console.WriteLine("{0}, {1}, {2}", a, b, c);


        // const 키워드를 이용해 상수 선언
        const int CONST_VALUE = 1000;
        Console.WriteLine(CONST_VALUE);
    }
}