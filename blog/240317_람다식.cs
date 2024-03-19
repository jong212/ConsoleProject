using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace blog
{
    internal class _240317_람다식
    {
        // 'Calculate'라는 대리자(delegate)를 정의합니다. 이 대리자는 두 개의 int 매개변수를 받고 int를 반환합니다.
        delegate int Calculate(int a, int b);

        static void Main(string[] args)
        {
            // 'cal'이라는 'Calculate' 대리자의 인스턴스를 생성합니다.
            Calculate cal;

        // 람다식으로 무명함수 정의하기 !!
            // 'cal'에 익명 메서드(delegate)를 할당합니다. 이 익명 메서드는 두 정수의 합을 계산하여 반환합니다.
            cal = delegate (int a, int b)
            {
                return a + b;
            };
            // 'cal' 대리자를 호출하고, 3과 4를 매개변수로 전달한 다음, 결과를 콘솔에 출력합니다.
            Console.WriteLine("{0}", cal(3, 4));
              
        //문 형식의 람다식 !!
            // 'cal1'이라는 'Calculate' 대리자의 인스턴스를 생성하고, 람다식을 이용해 정의합니다. 람다식은 'a'와 'b'를 매개변수로 받아 그 합을 반환합니다.
            Calculate cal1 = (a, b) => a + b;

            // 'cal1' 대리자를 호출하고, 3과 4를 매개변수로 전달한 다음, 그 결과를 콘솔에 출력합니다.
            Console.WriteLine("{0}", cal1(3, 4));
        }
    }
}
// 무명함수: 람다식으로 만드는 익명 메소드
// 무명함수를 저장하기 위해서는 먼저 대리자로 무명함수의 모습을 결정