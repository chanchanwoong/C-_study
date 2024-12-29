/*
 * 조건문, 반복문, switch문이 자바의 것들과 똑같다.
 *  - foreach문만 형태가 약간 다르다.
 *  - goto문은 가독성 측면에서 불편하다 판단된다. 
 *      - 차라리 메서드 호출하는 방식이 가독성은 더 좋을 듯
 */

using System;

class Program
{
    static void Main()
    {
        string[] names = { "C#", "공부", "한다." };

        foreach (string name in names)
        {
            Console.WriteLine(name);
        }

        for (int i = 0; i < 10; i++)
        {
            for (int j = 0; j < 10; j++)
            {
                // break문은 가장 근접한 반복문만 탈출한다.
                if (i == j) break;
                Console.WriteLine($"i = {i}, j = {j}");
            }
        }
    }
}