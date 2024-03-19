/*
https://mychrome.info/c-%ea%b5%ac%ec%a1%b0%ec%b2%b4%ec%99%80-%ed%81%b4%eb%9e%98%ec%8a%a4%ec%9d%98-%ea%b0%92-%ec%a0%84%eb%8b%ac-%ec%b0%a8%ec%9d%b4-%ea%b0%92-%ec%a0%84%eb%8b%ac-vs-%ec%b0%b8%ec%a1%b0-%ec%a0%84%eb%8b%ac/
*/

using System;
namespace shop133
{
    namespace Property1
    {
        // shop1 네임스페이스 안에 정의된 MainApp 클래스
        class MainApp
        {
            // 값 형식으로 정의된 구조체 Valuetype
            struct Valuetype
            {
                public int value;

                // 생성자를 통해 초기화하는 Valuetype의 생성자
                public Valuetype(int v)
                {
                    value = v;
                }
            }

            // 테스트 메서드
            static void Test()
            {
                // 값 형식 구조체의 인스턴스 생성
                Valuetype valueType1 = new Valuetype(10);

                // 값 형식의 특성 상, 인스턴스를 그대로 복제 (값에 의한 복사)
                Valuetype valueType2 = valueType1;

                // valueType2의 값을 출력 (기대 결과: 10)
                Console.WriteLine(valueType2.value);

                // valueType2의 값을 변경
                valueType2.value = 20;

                // valueType1의 값을 출력 (기대 결과: 10, 값 형식의 특성 상 원본은 변경되지 않음)
                Console.WriteLine(valueType1.value);
            }

            // 메인 메서드
            static void Main(string[] args)
            {
                // 테스트 메서드 호출
                Test();
            }
        }
    }
}
