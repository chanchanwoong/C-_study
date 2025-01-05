/*
 * 메서드
 *  - 메서드 사용법이 자바와 거의 유사하나, 다음의 차이점이 있다.
 *      - 매개변수 기본 값을 설정할 수 있다.
 *      - 순서와 상관없이 입력 가능한 명명된 매개변수 기능이 있다.
 *      
 * 전역변수를 사용할 때 static을 사용하거나 지역 변수의 사용 범위 등은 자바와 똑같다.
 * 
 * 화살표 함수(자바에선 람다식) 또한, 사용하는 의도와 방법이 자바와 유사하다.
 *  - 메서드를 간단하게 표기하기 위해 사용한다는 점이 똑같으며, 자바와 다르게 => 기호를 사용한다.
 * 
 * 로컬 함수
 *  - C#에는 자바와 다르게 메서드 안에 메서드를 작성하는 로컬 함수 기능을 제공한다.
 *  - 로컬 함수 기능은 특정 메서드 안에서만 사용하는 코드를 명시하여 코드 가독성을 제공한다.
 */

using System;
using System.Globalization;
using System.Numerics;

class Method
{

    // 전역변수
    static string msg = "전역 변수";

    static void Main()
    {
        Log("디버그", false);
        Log("에러", true, 4);

        Sum(10, 20);
        Sum(first : 12, second : 13, defaultValue : 1000);
        Sum(second: 13, defaultValue : 1000, first: 12);

        Console.WriteLine($"메인 클래스에서의 msg >> {msg}");


        // 화살표 함수
        Hi();
        Multiply(3, 5);


        // 로컬 함수
        // Main 메서드 내부에 로컬 함수들 정의
        int Add(int a, int b) => a + b;
        decimal Subtract(decimal x, decimal y) => x - y;

        Console.WriteLine($"Add(3, 5) >> {Add(3, 5)}");
        Console.WriteLine($"Subtract(34.56 - 12.34) >> {Subtract(34.56M, 12.34M)}");
    }

    // 기본 값을 가지는 매개변수는 필수 매개변수 정의 후에 나와야 한다.
    private static void Log (string message, bool isError, byte level = 1)
    {
        string msg = "지역 변수";
        Console.WriteLine($"msg ==> {msg}");
        Console.WriteLine($"{message}, {level}, {isError}");
    }

    // 명명된 매개변수를 사용하면 매개변수의 순서가 상관없어지고, 코드 가독성이 향상된다.
    private static void Sum(int first, int second, int defaultValue = 100) 
    {
        Console.WriteLine(first + second + defaultValue);
    }

    static void Hi() => Console.WriteLine("Hi 화살표 함수 결과 >> Hi");
    static void Multiply(int a, int b) => Console.WriteLine("Multiply 화살표 함수 결과 >> " + a * b);
}