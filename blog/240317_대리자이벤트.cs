
//https://www.youtube.com/watch?v=0MhAFzZKaJk&list=PLVsNizTWUw7GN8wPRhclbKuQa9aI9Cj2V&index=14
namespace CSharp006
{
    //이벤트
    //일련의 사건이 발생했다~는 사실은 다른 객체한테 전달
    //델리게이트 선언
    //클래스 내에서 선언한 델리게이트 인스턴스를 event한정자로 선언
    //이벤트 핸들러 작성
    //이벤트 핸들러는 선언한 델리게이트와 일치하면 OK
    //클래스의 인스턴스를 생성하고 이 객체의 이벤트에 이벤트 핸들러 등록
    //이벤트가 발생하면 이벤트 핸들러가 호출
    //Func, Action
    //델리게이트와 이벤트차이


    //1. 대리자 선언 >> 여기서 대리자 이름은 EventHandler
    delegate void EventHandler(string str);
    class EventTest
    {
        //2. 대리자 이벤트 선언 >> 위에서 선언한 대리자의 인스턴스는 EventHandler이고 이벤트이름 eve를 event한정자로 수식
        public event EventHandler eve;

        public void func(int num)
        {
            int temp = num % 10;
            if (temp != 0 && temp % 3 == 0)
            {
                //3,6,9으로 끝날때마다 이벤트가 발생
                eve($"{num}");
            }
        }
    }
    internal class event01
    {
        //3. 이벤트 처리기 선언 > 대리자의 반환타입과 매개변수 데이터타입이
        public static void MyHandler(string str)
        {
            Console.WriteLine(str);
        }

        static void Main()
        {
            //4. 클래스의 인스턴스 생성
            EventTest eventTest = new EventTest();
            //5. 위에서 생성한 인스턴스(eventtest)의 이벤트(eve)에  이벤트처리기(Myhandler) 연결 >>>> 이벤트명 : eve , 대리자명 EventHandler, 이벤트처리기:Myhandler
            eventTest.eve += new EventHandler(MyHandler);

            for (int i = 0; i < 30; i++)
            {
                eventTest.func(i);
            }
        }
    }
}
