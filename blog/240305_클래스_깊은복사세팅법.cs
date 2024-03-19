/*
이 코드는 C#에서 깊은 복사와 얕은 복사의 차이를 보여주는 예시입니다. 주석을 통해 각 부분이 어떻게 동작하는지 설명하겠습니다.
*/
namespace shop
{
    // 'shall' 클래스 정의
    class shall
    {
        public int num;
        public int num1;

        // 깊은 복사를 위한 메서드
        // 이 메서드는 'shall' 객체의 새 인스턴스를 생성하고, 현재 인스턴스의 필드 값을 새 인스턴스에 복사하여 반환합니다.
        public shall DeepCopy()
        {
            shall newCopy = new shall(); // 새 'shall' 객체 생성
            newCopy.num = num; // 현재 객체의 'num' 값을 새 객체에 복사
            newCopy.num1 = num1; // 현재 객체의 'num1' 값을 새 객체에 복사
            return newCopy; // 깊은 복사된 객체 반환
        }
    }

    internal class test
    {
        static void Main(string[] args)
        {
            // 얕은 복사 예제
            shall t_1 = new shall(); // 'shall' 객체 생성
            t_1.num = 10; // 'num' 필드에 10 할당
            t_1.num1 = 20; // 'num1' 필드에 20 할당
            shall b_1 = t_1; // 'b_1'은 't_1'을 참조하므로 얕은 복사 발생
            b_1.num1 = 30; // 'b_1'의 'num1' 값을 변경하면, 't_1'의 'num1' 값도 변경됩니다. (얕은 복사 때문에 같은 객체를 참조)

            // 얕은 복사 결과 출력
            Console.WriteLine("얕은 복사");
            Console.WriteLine("{0}, {1}", t_1.num, t_1.num1); // t_1의 값도 변경됨
            Console.WriteLine("{0}, {1}", b_1.num, b_1.num1);

            // 깊은 복사 예제
            Console.WriteLine("깊은 복사");
            shall deepTest = new shall(); // 새 'shall' 객체 생성
            deepTest.num = 10; // 'num' 필드에 10 할당
            deepTest.num1 = 20; // 'num1' 필드에 20 할당

            // 깊은 복사를 사용하여 'deepTest'의 복사본을 생성
            shall deepTest1 = deepTest.DeepCopy();
            deepTest1.num = 30; // 복사본의 'num' 값을 변경

            // 깊은 복사 결과 출력
            // 'deepTest'와 'deepTest1'은 서로 독립적인 객체이므로, 'deepTest1'의 변경이 'deepTest'에 영향을 미치지 않습니다.
            Console.WriteLine("{0},{1}", deepTest.num, deepTest.num1); // 원본 객체의 값은 변경되지 않음
            Console.WriteLine("{0},{1}", deepTest1.num, deepTest1.num1); // 복사된 객체의 'num' 값은 변경됨
        }
    }
}
