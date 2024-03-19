//https://cherry22.tistory.com/entry/C-%EC%97%B0%EC%82%B0%EC%9E%90-%EC%98%A4%EB%B2%84%EB%A1%9C%EB%94%A9-%EC%9D%BC-%EC%9D%BC-%EA%B7%80%EC%9A%94%EB%AF%B8
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
이 코드는 C#에서 연산자 오버로딩(operator overloading)의 개념을 구현한 예시입니다. 
연산자 오버로딩을 통해 사용자 정의 타입(여기서는 point 구조체)에 대한 기본 연산자(+ 연산자)의 동작을 재정의할 수 있습니다. 
이를 통해 point 인스턴스 간에 + 연산자를 사용하여 덧셈 연산을 수행할 수 있게 됩니다.
*/
namespace shop
{
    internal class _240307_std
    {
        //연산자 오버로딩
        //사용자정의 자료형이니 클래스 같은 경우해당 타입에 맞게 재정의 함
        //기본 연산자의 연산을 재정의하여 구현
        public struct point
        {
            public int x;
            public int y;

            public point(int x, int y)
            {
                this.x = x;
                this.y = y;
            }
            //연산자 재정의를 해서 기본적인 연산자를 사용합시다.
            public static point operator +(point left, point right)
            {
                return new point(left.x + right.x, left.y + right.y);
            }
            public override string ToString()
            {
                return $"({x},{y})";
            }
        }
        static void Main()
        {
      point point = new point(3,3)+new point(2,5);
            Console.WriteLine(point.ToString()); //5 8
        }
    }
}
