/*
 * LINQ(Language INtegrated Query)
 *  - C#에서 사용되는 데이터 가공, 필터링, 집계 기능을 제공하는 메서드 집합이다.
 *  - 대부분 for문을 이용해서 할 수 있지만, LINQ를 사용하면 코드 가독성과 개발 편의성에서 이점이 있다.
 *  - 메서드처럼 사용할 수 있는 메서드 구문과 쿼리처럼 사용할 수 있는 쿼리 구문이 있다.
 *  - 대부분의 제네릭 컬렉션 타입에 사용이 된다.
 *  ex ) list.Sum(); list.Where(num > 10);
 *  - All()은 모든 요소가 조건을 만족하는 경우 해당 결과를 반환
 *  - ANY()는 하나의 요소라도 조건을 만족하는 경우 해당 결과를 반환(하나라도 있는지 확인하는 용도)
 *  - Take(n)은 앞에서 n개로 한정한다.
 *  - Skip(n)은 앞에서 n개를 제외(필터링)한다.
 *  - Distinct()는 순서를 유지하면서 중복 요소를 제거한다.
 *  - OrderBy() or OrderByDescending()은 오름차순 정렬 또는 내림차순 정렬
 *  - Single() or SingleOrDefault()는 쿼리 조건에 맞는 결과가 하나일 때, 해당 값을 반환한다. 결과가 여러 개면 에러 발생한다. 없는 경우 Single()은 에러를, SingleOrDefault()는 null을 반환한다.
 *  - First() or FirstOrDefault()는 쿼리 조건에 맞는 결과가 하나 이상일 때, 첫 값을 반환한다. 없는 경우 First()는 에러를, FirstOrDefault()는 null을 반환한다.
 *  
 */

using System;

class Linq
{
    static void Main()
    {
        int[] numbers = { 10, 23, 15, 6, 47, 50 };
        int sum = numbers.Sum();
        double average1 = numbers.Average();
        double average2 = numbers.Sum() / numbers.Length;
        int max = numbers.Max();
        int min = numbers.Min();

        Console.WriteLine($"합계 > {sum}");
        Console.WriteLine($"평균1 > {average1}, 평균2 > {average2}");
        Console.WriteLine($"최댓값 > {max}, 최솟값 > {min}\n");


        // Where() 메서드
        List<int> newNumbers = numbers.Where(num => num > 10).ToList();   // IEnumerable<int> newNumbers = numbers.Where(number => number > 10); 를 List로 바꾼 형태
        foreach (var num in newNumbers) Console.WriteLine(num);

        Console.WriteLine();

        newNumbers = numbers.Where(num => num % 2 == 0 && num > 20).ToList();
        foreach (var num in newNumbers) Console.WriteLine(num);

        Console.WriteLine();


        // All() 메서드
        bool[] bools = { true, true, true };
        Console.WriteLine(bools.All(b => b == true));   // true
        bools = new bool[] { true, true, false };
        Console.WriteLine(bools.All(b => b == true));   // false

        Console.WriteLine();


        // Any() 메서드
        Console.WriteLine(bools.Any(b => b == true));   // true
        bools = new bool[] { false, false, false };
        Console.WriteLine(bools.Any(b => b == true));   // false

        Console.WriteLine();


        // OrderBy() 메서드
        newNumbers = numbers.OrderBy(x => x).Take(3).ToList();
        foreach (var num in newNumbers) Console.Write(num + " ");
        Console.WriteLine();

        newNumbers = numbers.Take(3).OrderBy(x => x).ToList();
        foreach (var num in newNumbers) Console.Write(num + " ");
        Console.WriteLine();

        newNumbers = numbers.OrderByDescending(x => x).ToList();
        foreach (var num in newNumbers) Console.Write(num + " ");

        Console.WriteLine();



        // 쿼리 구문
        // select가 실제 SQL과 다르게 맨 뒤에 온다.
        var newNumbers2 = (
            from n in numbers 
            where n % 2 == 0 
            orderby n descending 
            select n
            ).ToList();

        newNumbers2.ForEach(n => Console.Write(n + " "));
    }
}