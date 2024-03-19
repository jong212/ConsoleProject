using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace blog
{
    internal class _240317_대리자이벤트2
    {


        //1. 대리자 선언 
        public delegate void MyEventHandler();
        public class EventTest01
        {
            //2. 대리자 이벤트 선언 >> 위에서 선언한 대리자의 인스턴스는 MyEventHandler 이벤트이름 MyEvent를 event한정자로 수식

            public event MyEventHandler MyEvent;
            public void sum()
            {
                MyEvent();
            }

        }

        //3. 이벤트 처리기 선언 > 대리자의 반환타입과 매개변수 데이터타입이
        public static void MyEventFunc()
            {
                Console.WriteLine("이벤트 발생");

            }
          

        static void Main(string[] args)
        {
            //4. 클래스의 인스턴스 생성
            EventTest01 instance01 = new EventTest01();
            //5. 위에서 생성한 인스턴스(instance01)의 이벤트(MyEvent)에  이벤트처리기(MyEventFunc) 연결

            instance01.MyEvent += new MyEventHandler(MyEventFunc);
            instance01.sum();

        }

    }
}
 