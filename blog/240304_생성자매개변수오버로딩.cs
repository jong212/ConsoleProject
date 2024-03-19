/*
이 코드는 C# 프로그래밍 언어를 사용하여 Unit 클래스의 여러 생성자를 정의하고 사용하는 예시입니다. 
Unit 클래스는 두 개의 멤버 변수, name과 age를 가지고 있으며, 다양한 방식으로 인스턴스를 생성할 수 있는 여러 생성자를 제공합니다. 
또한, Print 메서드를 통해 객체의 상태를 콘솔에 출력할 수 있습니다.
*/
namespace test
{
    internal class test
    {
        // Unit 클래스 정의
        class Unit
        {
            string name; // 이름을 저장하는 필드
            int age;     // 나이를 저장하는 필드

            // 기본 생성자: 아무 매개변수도 받지 않음
            public Unit()
            {
            }

            // 이름을 매개변수로 받는 생성자
            public Unit(string name)
            {
                this.name = name; // 매개변수로 받은 이름을 필드에 할당
                Console.WriteLine($"나의 이름은 {name} 입니다"); // 콘솔에 이름 출력
            }

            // 이름과 나이를 매개변수로 받는 생성자
            public Unit(string name, int age)
            {
                this.name = name; // 매개변수로 받은 이름을 필드에 할당
                this.age = age;   // 매개변수로 받은 나이를 필드에 할당
                Console.WriteLine($"나의 이름은 {name} 입니다"); // 콘솔에 이름 출력
                Console.WriteLine($"나의 나이는 {age} 입니다"); // 콘솔에 나이 출력
            }

            // 객체의 상태를 콘솔에 출력하는 메서드
            public void Print()
            {
                Console.WriteLine($"나의 이름은 {name} 입니다");
                Console.WriteLine($"나의 나이는 {age} 입니다");
            }
        }

        // 메인 메서드: 프로그램의 진입점
        static void Main(string[] args)
        {
            // 기본 생성자를 사용하여 Unit 객체 생성
            Unit unit1 = new Unit();
            // 이름을 매개변수로 받는 생성자를 사용하여 Unit 객체 생성
            Unit unit2 = new Unit("Tom");
            // 이름과 나이를 매개변수로 받는 생성자를 사용하여 Unit 객체 생성
            Unit unit3 = new Unit("Jerry", 5);

            // 각 객체는 생성될 때, 해당 생성자에 정의된 콘솔 출력이 실행됩니다.
            // unit1은 출력하지 않음(기본 생성자는 출력 코드가 없음)
            // unit2와 unit3는 각각 생성 시 이름과 나이(해당되는 경우)를 출력
        }
    }
}
