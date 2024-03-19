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
/* Array =========================================================================*/

    //C#에서의 배열은 array라는 클래스를 통해 사용 가능 // array 클래스의 정적 함수를 통해 다양한 기능 사용 가능
    //Array 클래스를 통해 구현되어 있음 > 그렇다는 건Array 클래스의 모든 메서드들을 사용 가능하다는 것
    // array도 빌트인 메서드가 많음 ↓
    // sort : 정렬
    // Reverse : 반전
    // IndexOf : 탐색
    // Copy : 다른 배열로 복사  
    // Clear : 지정된 값으로 초기화
    // Resize : 크기를 조정
        static void Main()
        {
            int[] scores = new int[5];
            int[] array = { 1, 3, 6, 6, 8 };
            
            int length = array.Length;//ㅂ 크기
            Console.WriteLine(length);//5

            int max = array.Max();
            Console.WriteLine(max);//8

            int[] shallow = array; //배열의 얕은 복사 : 동일한 인스터스 참조
            int[] deep = new int[array.Length];//깊은 복사 : 새로운인스턴스 생성하고 복사

            //array[0] = 0;
            int[,] matrix = new int [3,4];
            //[0,0] [0,1] [0,2] [0,3]
            //[1,0] [1,1] [1,2] [2,3]
            //[2,0] [2,1] [2,2] [2,3]

            Console.WriteLine(matrix.GetLength(0));
            Console.WriteLine(matrix.GetLength(1));

            int[,] tile = { { 1, 2, 3 }, { 4, 5, 6 } };
            for (int i = 0; i < tile.GetLength(0); i++) { 
                for (int j = 0; j < tile.GetLength(1); j++)
                {
                    Console.Write(tile[i,j]);
                }
                Console.WriteLine();
            }
/* ArrReverse =========================================================================================*/

            //문자열 뒤집기 
            //abcd 입력이 되면 dcba로 나와야 한다
            string str;
            str = Console.ReadLine();
            char[] charArray = str.ToCharArray();
            Console.WriteLine(charArray);           
            Array.Reverse(charArray);
            foreach (var a in charArray)
            {
                Console.Write(a);
            }


                    

        }


        /*
        static void Main()
        {

        }

        static void Main()
        {

        }

        static void Main()
        {

        }

        static void Main()
        {

        }
        */
    }
}
