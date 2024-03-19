/*
https://mychrome.info/c-%eb%8d%b8%eb%a6%ac%ea%b2%8c%ec%9d%b4%ed%8a%b8-%ec%82%ac%ec%9a%a9%eb%b2%95-3%ea%b0%80%ec%a7%80%eb%a7%8c-%ea%b8%b0%ec%96%b5%ed%95%98%ec%9e%90/
    델리게이트 : delegate 반환타입 델리게이트이름 (매개변수)
    특정 매개 변수 목록 및 반환형식이 있는 함수에 대한 참조
    대리자 인스턴스를 통해 함수를 호출할수 있음.
    델리게이트는 메소드에 대한 참조이다.
    델리게이트에 메소드의 주소를 할당한후 델리게이트를 호출하면
    델리게이트가 메소드를 호출해준다.
    델리게이트는 메소드에 대한 참조이기 때문에 자신이 참조할
    반환형식과 매개변수를 명시
이 코드는 C#에서 델리게이트(delegate)의 개념을 사용하는 방법을 설명하는 예제입니다. 
델리게이트는 특정 매개변수 목록과 반환 유형을 가진 함수를 참조하기 위한 타입입니다. 
이 예제에서는 델리게이트를 선언하고, 델리게이트를 통해 함수를 호출하는 방법을 보여줍니다.
*/
namespace cs.complete
{
    internal class del
    {
        // 1. 델리게이트 선언
        // MyDel 델리게이트는 int 반환 유형과 두 개의 int 매개변수를 받는 메서드를 참조할 수 있습니다.
        public delegate int MyDel(int a, int b);

        // Mydel2 델리게이트는 string 반환 유형과 한 개의 string 매개변수를 받는 메서드를 참조할 수 있습니다.
        public delegate string Mydel2(string str);

        // 2. 델리게이트에 의해 참조될 메서드 선언
        static int Plus(int a, int b)
        {
            return a + b;
        }
        static int Minus(int a, int b)
        {
            return a - b;
        }
        static string Message(string msg)
        {
            return msg;
        }

        static void Main(string[] args)
        {
            // 3. 델리게이트 인스턴스를 생성하고 델리게이트에 의해 참조될 Plus, Minus 메서드를 매개변수로 전달합니다.
            MyDel callback = new MyDel(Plus);
            MyDel callback2 = new MyDel(Minus);

            // 4. 델리게이트 호출
            // 델리게이트 인스턴스를 통해 Plus, Minus 메서드를 호출하고, 그 결과를 콘솔에 출력합니다.
            Console.WriteLine(callback(10, 5)); // Plus 메서드 호출 결과: 15
            Console.WriteLine(callback2(10, 5)); // Minus 메서드 호출 결과: 5

            // Message 메서드를 참조하는 Mydel2 델리게이트 인스턴스를 생성합니다.
            Mydel2 StrDel = Message;

            // 이 예제에서는 StrDel 델리게이트를 사용하지 않고 "hihi" 문자열을 그대로 콘솔에 출력합니다.
            // 델리게이트를 사용한 예제가 아니라, 추가적인 예제로 Message 메서드를 호출하는 부분을 보여줄 필요가 있습니다.
            Console.WriteLine("hihi"); // 단순히 "hihi" 문자열을 콘솔에 출력
        }
    }
}
