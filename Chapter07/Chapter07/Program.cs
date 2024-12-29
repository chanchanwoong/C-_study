/*
 * char, string, boolean, 래퍼 클래스 등 자바와 거의 유사하다.
 * 
 * string 클래스의 @ 기호를 이용한 멀티라인 문법은 생소하다.
 *  자바스크립트 코드 블록 같은 경우에 사용하는 듯
 *  
 * 인덱스를 이용한 숫자 삽입처럼 string을 넣는 방법이 있다.
 *  $ 키워드와 {변수명}을 조합해 사용한다.
 */

using System;

class StringExam
{
    static void Main()
    {
        // 멀티라인
        string multiLines = @"
            안녕하세요.
            @를 이용한 멀티라인 입니다.
            ";

        Console.WriteLine(multiLines);

        string nonMultiLines = "안녕하세요." +
            "멀티라인이 아닙니다.";
        Console.WriteLine(nonMultiLines);


        // string 보간법
        int number = 3;
        string str = "이것은 삼이라고 읽습니다.";

        Console.WriteLine($"{number}, {str}");
    }
}