/*
 * C# 에서는 부호가 있냐 없냐로 데이터 타입을 따로 지정
 * 부호가 있으면 접두사 s(signed), 부호가 없으면 접두사 u(unsigned)를 사용한다.
 * 
 * 사용하는 이유는 개발자 사이에 코드 가독성과 데이터 범위 관리에 용이하다고 한다.
 *  그러나, 부호를 고려하면서 프로그래밍에 의의는 모르겠다. 다른 로직에 더 신경을 쓸 듯 하다.
 *  
 *  C#에서 임의의 NULL 처리를 위한 nullable type를 제공한다.
 *  타입 뒤에 ? 기호를 붙이면 해당 변수에는 null이 할당되더라도 에러가 발생하지 않는다.
 */

using System;

class Integer
{
    static void Main()
    {
        int signedMin = int.MinValue;
        int signedMax = int.MaxValue;
        Console.WriteLine("signedMin = {0}, signedMax = {1}", signedMin, signedMax);

        uint unsignedMin = uint.MinValue;
        uint unsignedMax = uint.MaxValue;
        Console.WriteLine("unsignedMin = {0}, unsignedMax = {1}", unsignedMin, unsignedMax);


        // nullable 확인
        double? NULL_DATA = null;
        Console.WriteLine("NULL_DATA = " + NULL_DATA);
    }
}