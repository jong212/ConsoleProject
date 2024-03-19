
//https://mychrome.info/c-%ec%9d%bc%eb%b0%98%ed%99%94-%ed%81%b4%eb%9e%98%ec%8a%a4-%ec%9d%bc%eb%b0%98%ed%99%94-%eb%a9%94%ec%84%9c%eb%93%9c-%ed%98%95%ec%8b%9d-%eb%a7%a4%ea%b0%9c-%eb%b3%80%ec%88%98-%ec%a0%9c%ec%95%bd-%ec%a0%95/
namespace CSharp005
{
    internal class Generic01
    {
        //형식 매개변수 제약하기
        //일반화 자료형을 선언할때 제약조건은 걸어줌으로써 사용당시 쓸수 있는 자료형을 제한
        #region 제약조건
        /*
         where T : struct { }//struct로 제한(값 형식)
         where T : class { }//클래스로 제한(참조 형식)
         where T : new() { }//매개변수가 없는 생성자가 있는 자료형
         where T : 기반클래스 { }//파생클래스로 제한
         where T : 인터페이스 { }//인터페이스를 포함한 자료형만...
         */
        #endregion

        //다음과 같은 형식이 있다고 가정한다면
        //해딩 일반화 메서드는 매개변수 T에 값 형식이어야 함.(구조체는 값 형식)

        #region where T : struct
        public static void ArrayCopy<T>(T[] source, T[] output) where T : struct
        {
            for (int i = 0; i < source.Length; i++)
            {
                output[i] = source[i];
            }
        }
        #endregion
        #region  where T : class

        class MyClass<T> where T : class
        {
            private T data;

            public MyClass(T data)
            {
                this.data = data;
            }  
            public void Show()
            {
                if (data !=null) Console.WriteLine(data);
                else
                {
                    Console.WriteLine("ddd");
                }
            }
        }


        #endregion
        #region where T : 인터페이스
        
        //class InterfaceT<T> where T: IComparable<T>
        //{

        //}

        public static T Bigger<T>(T left, T right) where T: IComparable<T>
        {
            if (left.CompareTo(right) > 0)
            {
                return left;
            }
            else
            {
                return right;
            }
        }

        #endregion

        static void Main(string[] args)
        {

            ///////////////////////////////////////////////////////////////
            int[] iSrc = { 1, 2, 3 };
            int[] iDst = new int[iSrc.Length];
            ArrayCopy<int>(iSrc, iDst);

            string[] sSrc = { "파묘", "카리나", "헤어져..흑흑.." };
            string[] sDst = new string[sSrc.Length];

            // ArrayCopy<string>(sSrc, sDst);->에러..클래스는 참조형식이기 때문

            ///////////////////////////////////////////////////////////////
            MyClass<string> str = new MyClass<string>("오태식이..돌아왔구나");
            str.Show();
            //MyClass<int> my = new MyClass<int>(1);->값형식이기때문에...에러..


            ///////////////////////////////////////////////////////////////

            //  InterfaceT<int> interT = new InterfaceT<int>();

            int test = Bigger(5, 10);
            Console.Write(test);
        }
    }
}
