using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
[List 개념설명]
 - C++과 C#의 List 개념은 서로 다르다고 하는데 간략하게 알아봐야 할 듯
 - List 와 Linked list 차이점 알아야함.
 - List는 배열 Array 기반이라 ... 동적으로 크기가 변하는 장점이 있다.
 - 데이터를 중간에 삽입하거나 삭제하면 인덱스가 자동으로 밀어내고 채워진다
 - list와 linked list는 다름 차이점이 있다고 함 링크드 리스트는 double 기반이고 덩어리 노드기반  ((이전노드 가리키는 포인터 : data value : 다음 노트를 가리키는 포인터 )) 

[List] 
- 동적 배열 기반 자료 구조
- 삽입 : 중간에 데이터를 추가하기 위해 이후 데이어를 밀어내고 삽입 한다.
- 삭제 : 중간에 데이터를 삭제한뒤 빈자리를 채우기 위해 이후 데이터들을 앞으로 당긴다.

[링크드리스트]
중간 삽입 삭제 처리가 빈번하게 일어나면 리스트 보단 링크드 리스트가 좋음 ((1. 참조 : value : 참조  <-> 2.참조:value:참조 <-> 3.참조:value:참조   ))여기서 2가 끊기면 1 뒷참조 주소랑 3 앞참조 주소가 이어지기 때문에 리스트 보단 링크드 리스트가 좋다.
 */
namespace csd
{
    internal class _240313_list
    {
        static void Main(string[] args)
        {
            List<string> list = new List<string>();
            list.Add("0번 데이터 ");
            list.Add("1번 데이터 ");
            list.Add("2번 데이터 ");
            list.Add("3번 데이터 ");
            list.Add("4번 데이터 ");
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("=============");


            list.Insert(1, "중간 데이터 1번 ");
            list.Insert(3, "중간 데이터 2번 ");
            list.Insert(5, "이힛");

            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("=============");



            /*
            list.Remove("1번 데이터");
            list.RemoveAt(1);
            foreach (var item in list)
            {
                Console.Write(item + " -> ");
            }
            list[0] = "데이터1";
            string value = list[0];
            int indexOf = list.IndexOf("2번 데이터");
            Console.WriteLine(indexOf);
            */
        }
    }

    /*
        internal class _240313_list
        {
            static void Main(string[] args)
            {
                List<string> list = new List<string>();
                list.Add("0번 데이터");
                list.Add("1번 데이터");
                list.Add("2번 데이터");
                list.Add("3번 데이터");
                list.Add("4번 데이터");
            }
        }
    */
}
