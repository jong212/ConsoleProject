//OOP
//객체지향 설계의 5원칙 (솔리드?) 관련 내용 찾아봐야 함 > 단일책임의 원칙?어쩌고 저쩌고 개방페쇠의 원칙어쩌고 저쩌고 https://inpa.tistory.com/entry/OOP-%F0%9F%92%A0-%EA%B0%9D%EC%B2%B4-%EC%A7%80%ED%96%A5-%EC%84%A4%EA%B3%84%EC%9D%98-5%EA%B0%80%EC%A7%80-%EC%9B%90%EC%B9%99-SOLID
namespace shop
{
/*
  객체지향 4대 특징
    1. 캡슐화: 객체를 상태와  기능을로 묶는다. 객체의 내부상태와 기능을 숨기고 허용한 상태와 기능만을 액세스 허용
    2. 상속 : 부모클래스의 모든 기능을 가지는 자식클래스를 만든다.
    3. 추상화 : 관련 특성 및 엔터티의 상호작용을 클래스를 모델링 하여 시스템의 추상적 표현을 정의 
    4. 다형성 : 부뫀르래스의 함수를 자식클래스에서 재정의 하여 자식클래스의 다른 반응을 구현
*/
 
        class Driver
        {
            public string name;
            public Driver(string name)
            {
                this.name = name;
            }
            public void Ride(vehicle vehicle)
            {
                Console.WriteLine($"{this.name}이{vehicle.name}");
            }
        }
        class vehicle
        {
            public string name;
            public int speed;

            public vehicle(string name, int speed = 0)
            {
                this.name = name;
                this.speed = speed;
            }
            public void Move()
            {
                speed -= 10;
                Console.WriteLine($"{name}의 속도가 {speed}만큼 증가함");
            }
        }
    internal class _240306_std
    {
        static void Main(string[] args)
        {
            Driver d = new Driver("경일이");
            vehicle bike = new vehicle("ㅋㅋ", 10);
            d.Ride(bike);
        }
    }
}
