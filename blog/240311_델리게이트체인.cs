//https://mychrome.info/c-%eb%8d%b8%eb%a6%ac%ea%b2%8c%ec%9d%b4%ed%8a%b8-%ec%b2%b4%ec%9d%b8/
using System;

namespace cs.complete
{
    // TestDel 델리게이트 선언: 두 개의 int 매개변수를 받고 void를 반환하는 메서드를 참조할 수 있습니다.
    public delegate void TestDel(int a, int b);

    internal class del
    {
        // SumNumber: 두 정수의 합을 콘솔에 출력하는 메서드
        public static void SumNumber(int a, int b)
        {
            Console.WriteLine($"Add {a + b}");
        }

        // MulNumber: 두 정수의 곱을 콘솔에 출력하는 메서드
        public static void MulNumber(int a, int b)
        {
            Console.WriteLine($"Multiply {a * b}");
        }

        static void Main()
        {
            // testDel 델리게이트 인스턴스 생성 및 SumNumber 메서드 참조
            TestDel testDel = SumNumber; // new 연산자 사용 없이 메서드를 직접 할당

            // MulNumber 메서드를 델리게이트 체인에 추가
            testDel += MulNumber; // += 연산자를 사용해 체인 생성

            // Invoke 메서드를 사용하여 델리게이트 체인에 등록된 모든 메서드 순차적 실행
            // 여기서는 먼저 합을 계산한 후 곱을 계산합니다.
            testDel.Invoke(10, 20); // 결과: "Add 30" 다음 줄에 "Multiply 200"
        }
    }
}
