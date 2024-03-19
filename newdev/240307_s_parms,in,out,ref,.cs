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
        
        /// 디폴트 매개변수에 대한 설명
        /// 초기값이 있는 매개변수는 뒤부터 할당을 해준다고 함 // 그냥 매개변수를 뒤에서 부터 넣어줘야 한다는 뜻
        static void addStudent(string name, string home, int age = 10)
        {

        }

      
        /// params
        /// 매개변수의 갯수를 유동적으로 사용
        /// 동적으로 크기가 변하는 변수를 전달할 때
        /// 배열 형태로 전달할 때
        static int sum(params int[] value)
        {
            int sum = 0;
            for (int i = 0; i < value.Length; i++)
            {
                sum += value[i];
            }
            return sum;
        }

        //[in ] 
        //매개변수를 입력전용으로  설정
        //in으로 설정된 매개변수는 해당 값을 읽을 수만 있고 수정이 불가능하다
        static int plus(in int left, int right)
        {
            //left = 10; << 주석 제거 하면 오류남 읽기전용 변수이기 때문에 할당이 불가
            return left + right;
        }

        //[out]
        //함수의 리턴값 이외의 추가적으로 뭔가가 필요할 경우
        //매개변수를 출력전용으로 설정

        static void Divide(int left, int right, out int quoient, out int remainder)
        {
            quoient = left / right;
            remainder = left % quoient;
        }

        //아래 두 개 함수는 차이가 없다고 함?
        static int Num(int a, int b)
        {
            return a + b;
        }
        static void Num1(int a, int b, out int sum)
        {
            sum = a + b;
        }

        //ref 키워드 : 매개변수를 참조의 형태로 인식
        //매개변수가 valueType인 경우에도 함수를 통해서 원본값을 변경하고 싶을 때
        //참조타입인 경우에는 쓸 일이 없을 듯
        static void Swap(ref int left, ref int right)
        {
            int temp;
            temp = left;
            left = right;
            right = temp;

        }
        static void Num2(ref int a)
        {

        }

        static void Main()
        {
            int a = _240307_std.sum(1, 3, 4, 5, 6, 7);
            int b = _240307_std.sum(1, 3);
            Console.WriteLine(a);
            Console.WriteLine(b);
            ////////////////////////////////////
            int c;
            Divide(5, 3, out c, out int d);
            Console.WriteLine($"{c},{d}");
            ////////////////////////////////////
            int left = 1;
            int right = 2;
            Swap(ref left, ref right);
            Console.WriteLine($"{left},{right}");

        }


    }
}
