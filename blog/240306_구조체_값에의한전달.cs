/*
https://mychrome.info/c-%ea%b5%ac%ec%a1%b0%ec%b2%b4%ec%99%80-%ed%81%b4%eb%9e%98%ec%8a%a4%ec%9d%98-%ea%b0%92-%ec%a0%84%eb%8b%ac-%ec%b0%a8%ec%9d%b4-%ea%b0%92-%ec%a0%84%eb%8b%ac-vs-%ec%b0%b8%ec%a1%b0-%ec%a0%84%eb%8b%ac/
*/

using System;

namespace shop.complete
{
    class MainApp1
    {
        // 값 형식 정의
        struct Valuetype
        {
            public int value;

            // 값 형식의 생성자
            public Valuetype(int v)
            {
                value = v;
            }
        }

        // 구조체를 변경하는 메서드
        static void Swap(Valuetype left, Valuetype right)
        {
            // left와 right를 교환하는 코드
            int temp = left.value;
            left.value = right.value;
            right.value = temp;
        }

        // 테스트 메서드
        static void Test01()
        {
            // 값 형식의 인스턴스 생성
            Valuetype leftValue = new Valuetype(10);
            Valuetype rightValue = new Valuetype(20);

            // Swap 메서드 호출 (값에 의한 전달)
            Swap(leftValue, rightValue);

            // 원본 값 형식의 내용 출력
            Console.WriteLine($"{leftValue.value},{rightValue.value}");
        }

        // 메인 메서드
        static void Main(string[] args)
        {
            // 테스트 메서드 호출
            Test01();
        }
    }
}
