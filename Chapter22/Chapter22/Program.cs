/*
 * 구조체
 *  - 구조체는 자바에는 없는 구조로 여러 타입의 데이터를 묶어놓은 그릇이다.
 *  - 클래스와 다르게 상속은 불가능하다.
 *  - 구조체는 값 타입이며, 클래스는 참조 타입인 점이 다르다.
 */

using System;

struct Point
{
    public int X;
    public int Y;

    public Point(int X, int Y)
    {
        this.X = X;
        this.Y = Y;
    }
}

class Program
{
    static void Main()
    {
        Point point1;
        point1.X = 100;
        point1.Y = 200;
        
        Point point1Copy = point1;
        point1Copy.X = 1000;
        point1Copy.Y = 2000;
        Console.WriteLine($"point1의 X >> {point1.X}, Y >> {point1.Y}");
        Console.WriteLine($"point1Copy의 X >> {point1Copy.X}, Y >> {point1Copy.Y}");


        Point point2 = new Point(300, 400);

        Point point2Copy = point2;
        point2Copy.X = 3000;
        point2Copy.Y = 4000;
        Console.WriteLine($"point2의 X >> {point2.X}, Y >> {point2.Y}");
        Console.WriteLine($"point2Copy의 X >> {point2Copy.X}, Y >> {point2Copy.Y}");


        // 구조체를 매개변수로 전달
        LogPoint(point2);
    }

    private static void LogPoint(Point point)
    {
        Console.WriteLine("LogPoint(point2) 결과");
        Console.WriteLine($"point.X >> {point.X}, point.Y >> {point.Y}");
    }
}