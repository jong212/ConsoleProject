using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace shop
{
    internal class _240307_std
    {

//  [String]
/* 
    //string은 문자들의 집합으로 표현됨.
    //내부적으로 문자배열을 통해서 구현됨.
    //스트링은 다른 자료형과 달리 크기가 정해져 있지 않음
    //크기는 런타임 다음에 정해지고 크기는 일정하지 않음.
    //결론은 가비지 컬렉터가 부담을 가지지 않는 방법으로 String 쓸 것. 
    static void Main()
    {
        string str = "abc";
        Console.WriteLine(str);
        Console.WriteLine(str[1]);//b
        Console.WriteLine(str[2]);//c
        //str[1] = 'test'  << 문자열의 배열 접근은 읽기전용이기 때문에 수정이 불가능하다.
    }
*/

//  [불변성 Immutable Type]
/* 
    //string은 특징상 다른 기본자료형과 다르게 크기가 정해져 있지 않음
    //char 집합이기 때문에 char의 갯수에 따라 크기가 유동적
    //런타임 시 크기가 결정이 되고 그 크기는 일정하지 않다
    //string은 다른 기본 자료형과 다르게 구조체가 아닌 클래스로 구현이 되어있음.
    // 단, 기본자료형과 같이 값형식을 구현하기 위해 string클래스에 처리를 값형식처럼 동작하도록 구현
    //이를 구현하기 위해 string간의 대입이 있을 경우 참조에 의한 주소값 복사가 아닌 깊은 복사를 진행
    //결과적으로 데이터 자체를 복사하는 값형식으로 사용하지만 힙영역을 사용하기 때문에 string이 설정되면 변경할 수 없도록 하는 불변성을 가지게 된다.

    static void Main()
    {
    string str1 = "abc";//힙영역에 abc를 저장하고 이를 str1이 참조 
    str1 = "abc";//새로운 힙영역에  abc 문자열을 저장하고 이를 str이 참조
    str1 = str1 + "abc123"; //새로운 힙 영역에 abc123을 저장하고 이를 str1이 참조

    string str2 = str1;// 클래스긴 하지만 string은 값형식 처럼 사용되어야 하기 때문에 힙영역에 abc123 을 문자열을 복사하여 str2가 참조 되도록 함.

    //abc,def,abc123,abc123def 아래 하나 버릴려고 좌측의 경우의 수 만큼 가비지 컬렛터가 돈다 그래서 + 사용은 지양하자.
    string str3 = "abc" + 123 + "def" + 456;

    //위 +  로 이으는 방법 보다는 아래 포맷 사용하는게 가비지 컬랙터에게 부담을 덜 줌
    string str4 = string.Format("abc{0},def{1}", 123,456);
    }
*/



//  [스트링과 관련된 메서드들]
/*  
    //indexof : 현재 문자열 내에서 찾고자 하는 지정된 문자 또는 문자열의 위치를 찾는다
    //LastIndexOf() : 현재 문자열 내에서 찾고자 하는 지정된 문자 또는 문자열의 위치를 뒤에서부터 찾는다.
    //StartsWith()   현재 문자열이 지정된 문자열로 시작하는지를 평가한다.
    //EndsWith()
현재 문자열이 지정된 문자열로 끝나는지를 평가한다.
    //Contains() 현재 문자열이 지정된 문자열을 포함하는지를 평가한다.
    //Replace()  현재 문자열에서 지정된 문자열이 다른 지정된 문자열로 모두 바뀐 새 문자열을 반환한다.
    //Equals : 같냐?
    //Trim : 공백제거(앞뒤)
    //Substring : 지정된 인덱스부터 지정된 ? 만큼 문자를 뽑아냄
    //Split : 분할

        
    static void Main(){
        string str = "경일 Game Academy";
        Console.WriteLine("Game이 시작되는 위치는 어인교? :{0}",str.IndexOf("Game"));
        Console.WriteLine("경일 시작하냐:{0}", str.StartsWith("경일"));
        Console.WriteLine("아카데미 시작핮냐:{0}", str.Replace("Game","1111"));

        string str1 = "공백으로 문자열을 잘게 잘 게 조졀볼 까?";
        string[] words = str1.Split(' ');
        foreach(var item in words) {
            Console.WriteLine(item);

        }
    }
*/
//  [스트링 빌더]
/*  
    // 문자열과 관련 된 빌더가 많다면 스트링 빌더를 써야 함
    // 자주 변경 될 것 같으면 스트링 빌더를 사용 : static void Main(){}
    //stringBuilder -> 정리(string vs stringbuilder)
*/





    }

}
