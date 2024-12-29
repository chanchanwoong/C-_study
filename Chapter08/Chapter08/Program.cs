/*
 * 입력받기
 *  - Console 클래스의 ReadLine() 메서드를 이용하여 "Enter" 직전까지의 문자열을 입력받을 수 있다.
 *  
 * 캐스팅
 *  - 보다 큰 단위의 타입으로는 자동으로 캐스팅이 된다. int -> long 가능
 *    그러나, 작은 단위로 캐스팅할려면 변환할려는 타입으로 명시해줘야 한다. long -> (int) int 타입 
 *    
 * 형변환 클래스
 *  - 캐스팅 방식 이외에 Conver 클래스를 이용해서 형변환이 가능하다.
 *  - 캐스팅 과정에서 휴먼 에러를 줄이기 위해 사용할만하다고 생각된다.
 *  
 * var 키워드
 *  - var 키워드를 사용하면 컴파일러를 통해 알아서 타입을 지정해준다.
 *  - 타입을 명시하지 않고 선언할 때, var 키워드를 사용하는 듯 하다.
 *  - 자바에서는 Object라는 최상위 클래스가 받아줬는데, C#은 그런게 없나?
 *      - C#도 object 최상위 클래스가 있다. 그러나, 컴파일 이후에도 object를 유지하므로 타입 안정성이 떨어진다고 판단된다.
 */

using System;

class Program
{
    static void Main()
    {
        // 입력
        string readStr = Console.ReadLine();
        Console.WriteLine($"입력 데이터는 {readStr} 입니다.");


        // 자동 캐스팅
        int number1 = int.MaxValue;
        long number2 = number1;
        Console.WriteLine(number1 + " " + number2);

        // 명시적 캐스팅
        long number3 = long.MaxValue;
        int number4 = (int) number3;
        Console.WriteLine(number3 + " " + number4); // 캐스팅 후, 범위를 벗어나면 -1이 출력된다.

        long number5 = 150L;
        int number6 = (int)number5;
        Console.WriteLine(number5 + " " + number6);


        // Conver 클래스
        double d = 12.34D;
        Console.WriteLine("Convert.ToString(d) = " + $"{Convert.ToString(d)}, {Convert.ToString(d).GetType()}" +
        "\nConvert.ToInt32(d) = " + $"{Convert.ToInt32(d)}, {Convert.ToInt32(d).GetType()}" +
        "\nConvert.ToDouble(15) = " + $"{Convert.ToDouble(15)}, {Convert.ToDouble(15).GetType()}" +
        "\nConvert.ToChar(100) = " + $"{Convert.ToChar(100)}, {Convert.ToChar(100).GetType()}");


        // var 키워드
        var var1 = "string!";
        Console.WriteLine($"var1의 타입은 {var1.GetType()}");
    }
}