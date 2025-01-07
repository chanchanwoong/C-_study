/*
 * namespace
 *  - 클래스명 충돌 방지와 각 파일들의 계층화, 조직화를 위해 사용된다.
 *  - 자바의 package와 거의 유사하다.
 *  - 지정한 namespace 안의 클래스들을 사용하고 싶을 때는, using 키워드를 이용하여 사용한다.
 */

using System;
using System.Threading.Channels;

namespace Foo
{
    public class Car
    {
        public void Go() => Console.WriteLine("Foo namespace's Car Class");
    }
}

namespace Bar
{
    public class Car
    {
        public void Go() => Console.WriteLine("Bar namespace's Car Class");
    }
}

class Namespace
{
    static void Main()
    {
        Foo.Car fooCar = new Foo.Car();
        Bar.Car barCar = new Bar.Car();
        fooCar.Go();
        barCar.Go();
    }
}