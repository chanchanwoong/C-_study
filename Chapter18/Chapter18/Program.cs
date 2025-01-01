/*
 * C#에서의 배열 관련 문법은 자바와 거의 유사하다.
 * 그러나, 다차원 배열을 생성하는 방법은 약간 다르다.
 *  - C#에서 배열을 선언할 때 콤마를 기준으로 차원을 구부한다.
 *  - 다차원 배열 중 특정 차원의 길이(크기)를 구하고 싶다면, array.GetLength(원하는 차원) 를 진행하면 된다.
 *  - 특정 차원의 인덱스에 해당되는 값을 저장 또는 가져올 때, array[첫 차원의 인덱스, 둘 째 차원의 인덱스 ,,,] 로 진행한다.
 */

using System;

class Array
{
    static void Main()
    {
        // 2행 3열의 2차원 배열 선언
        int[,] intArray;
        intArray = new int[2, 3];

        // 각 인덱스에 값 할당
        intArray[0, 0] = 1;
        intArray[0, 1] = 2;
        intArray[0, 2] = 3;
        intArray[1, 0] = 4;
        intArray[1, 1] = 5;
        intArray[1, 2] = 6;

        foreach(int data in intArray)
        {

            Console.WriteLine(data);
        }

        for (int r = 0; r < intArray.GetLength(0); r++)
        {
            for (int c = 0; c < intArray.GetLength(1); c++)
            {
                Console.WriteLine(intArray[r, c]);
            }
        }

        // 3차원 배열
        int[,,] arr3 = new int[2, 3, 4]
        {
            { {1, 2, 3, 4 }, {5, 6, 7, 8 }, {9, 10, 11, 12 } },
            { {13, 14, 15, 16 }, {17, 18, 19, 20 }, {21, 22, 23, 24 } }
        };

        for (int i = 0; i < arr3.GetLength(0); i++)
        {
            for (int j = 0; j < arr3.GetLength(1); j++)
            {
                for (int k = 0; k < arr3.GetLength(2); k++)
                {
                    Console.Write("{0, 2} ", arr3[i, j, k]);
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }
    }
}