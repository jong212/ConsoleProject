/* study
 정적필드
*/

namespace shop
{
    class Person
    {
        public static int count;//정적 필드 //멤버변수
        public Person(string name) //생성자
        {
            count++;
        }

    }
    internal class test
    {
        static void Main(string[] args)
        {
            Person p = new Person("경일이");
            //Console.WriteLine(p.count); //인스턴스가 생성 된 횟수를 보고 싶음 // new 로 생성한 인스턴스는 고유의 메모리를 생성하기 때문에 

            Person p1 = new Person("멍충이");
            //Console.WriteLine(p1.count);     
            Console.WriteLine(Person.count); // 2


        }
    }
}