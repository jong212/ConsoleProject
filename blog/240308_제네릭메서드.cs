namespace cs
{
    //블로그 포스팅 완료 https://mychrome.info/%ec%a0%9c%eb%84%a4%eb%a6%ad-%eb%a9%94%ec%84%9c%eb%93%9c-vs-%ec%9d%bc%eb%b0%98%ec%a0%81%ec%9d%b8-%eb%a9%94%ec%84%9c%eb%93%9c/
    #region 학원 : int float > 일반화 메서드
    /*
    internal class Generic
    {
        public static void SwapValue<T>(ref T a, ref T b)
        {
            T temp = a;
            a = b;
            b = temp;
        }

        static void Main(string[] args)
        {
            int x = 10;
            int y = 20;
            SwapValue(ref x, ref y);
            Console.Write("예제1");
            Console.WriteLine($"{x},{y}");

            double a = 1.1213;
            double b = 2.6546;

            SwapValue(ref a, ref b);
            Console.Write("예제1");
            Console.WriteLine($"{a},{b}");

        }
    }
    */
    #endregion
    #region 학원 : 배열의 int,string > 제네릭
    /*
        internal class Generic
    {
        public static void ArrayCopy(int[] source, int[] output)
        {
            for (int i = 0; i < source.Length; i++)
            {
                output[i] = source[i];
            }
        }
        public static void ArrayCopy<T>(T[] source, T[] output)
        {
            for (int i = 0; i < source.Length; i++)
            {
                output[i] = source[i];
            }
        }
        static void Main(string[] args)
        {

            int[] iSrc = { 1, 2, 3, 4, 5 };
            int[] iDst = new int[iSrc.Length];
            ArrayCopy<int>(iSrc, iDst);
            foreach (int i in iDst)
            {
                Console.WriteLine(i);
            }
            string[] sSrc = { "야호", "즐거운 금요일" };
            string[] sDst = new string[sSrc.Length];
            ArrayCopy<string>(sSrc, sDst);
            foreach (var item in sDst)
            {
                Console.Write(item);
            }
            Console.WriteLine();
        }
    }*/
    #endregion
    #region 블로그 예제1 : int, string > 출력
    /* 
     using System;

     class Program
     {
         // 제네릭 메서드 정의
         static void Swap<T>(ref T lhs, ref T rhs)
         {
             T temp;
             temp = lhs;
             lhs = rhs;
             rhs = temp;
         }

         static void Main(string[] args)
         {
             int a = 1, b = 2;
             Console.WriteLine($"Before swap: a = {a}, b = {b}");

             // 제네릭 메서드 호출
             Swap<int>(ref a, ref b);

             Console.WriteLine($"After swap: a = {a}, b = {b}");

             // 타입 추론을 이용한 제네릭 메서드 호출
             string x = "hello", y = "world";
             Swap(ref x, ref y);
             Console.WriteLine($"After swap: x = {x}, y = {y}");
         }
     }
     */
    #endregion
    #region 블로그 예제2 문자열로 변환
    /* 
    using System;

    public class Program
    {
        // 제네릭 타입 매개변수를 받는 PrintValue 함수
        public static void PrintValue<T>(T a, T b)
        {
            Console.WriteLine("첫 번째 값: " + a.ToString());
            Console.WriteLine("두 번째 값: " + b.ToString());
        }

        public static void Main(string[] args)
        {
            // int 타입의 매개변수로 PrintValue 함수 호출
            PrintValue<int>(3, 5);

            // double 타입의 매개변수로 PrintValue 함수 호출
            PrintValue<double>(3.14, 2.71);
        }
    }
    */
    #endregion
    #region 연산자 > 더함
    /*
    public class DynamicExample
    {
        public dynamic Add(dynamic a, dynamic b)
        {
            return a + b;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            DynamicExample example = new DynamicExample();

            dynamic result = example.Add(10, 20);
            Console.WriteLine($"10 + 20 = {result}");

            result = example.Add(10.5, 20.3);
            Console.WriteLine($"10.5 + 20.3 = {result}");

            result = example.Add("Hello, ", "world!");
            Console.WriteLine($"\"Hello, \" + \"world!\" = {result}");
        }
    }
    */
    #endregion
}