/*
 * static
 *  - static 키워드를 사용하면 해당 클래스나 필드, 메서드가 정적으로 변한다.
 *  - 정적 클래스는 인스턴스를 만들 수 없다.
 *      - 그렇기 때문에, 정적 클래스를 사용하기 위해서 필드나 메서드가 static 키워드를 가지고 있어야 한다.
 *  - static이 붙지 않은 클래스는 인스턴스(객체)를 만들어서 사용해야 한다.
 */

using System;
using System.Diagnostics;

class ClassNote
{
    static void Main()
    {
        Square square = new Square();
        Console.WriteLine(Square.GetNameByStatic());    // GetNameByStatic() 메서드는 정적 메서드이므로 클래스명.메서드명()으로 호출한다.
        Console.WriteLine(square.GetNameByInstance());    // GetNameByObject() 메서드는 인스턴스 메서드이므로 객체명.메서드명()으로 호출한다.

        Class1.Method1();


        // 프로그램 실행 시간 확인
        Stopwatch timer = new Stopwatch();
        timer.Start();
        Thread.Sleep(3000);
        timer.Stop();

        Console.WriteLine("경과 시간 : {0}ms", timer.Elapsed.TotalMilliseconds);
        Console.WriteLine("경과 시간 : {0}s", timer.Elapsed.Seconds);
    }
}

public class Square
{
    public static string GetNameByStatic() => "static 메서드로 호출한 결과 >>> 정사각형";
   

    public string GetNameByInstance() => "객체로 호출한 결과 >>> 정사각형";
}

public static class Class1
{
    public static void Method1() => Console.WriteLine("클래스1의 메서드1");
}