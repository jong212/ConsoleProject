//https://mychrome.info/?p=1115&preview=true
namespace cs.blog
{
    #region 학원 yield 예제 1
    /*
    internal class Program01
    {
        public IEnumerable<string> GetNumber()
        {
            yield return "안녕"; //첫번째 루프에서 리턴되는 값.
            yield return "하세요"; //두번째 루프에서 리턴되는 값..
            yield return "나는 세 번쨰.."; //두번째 루프에서 리턴되는 값..
        }

        public void Test()
        {
            foreach (var item in GetNumber())
            {
                Console.WriteLine(item);    
            }
        }

        static void Main() 
        {
            Program01 program01=new Program01();
            program01.Test(); 
        }
    }*/
    #endregion
    #region 학원 yield 예제 2
    /*
    internal class Program01
    {
        public IEnumerable<int> UntilPlus(IEnumerable<int> numbers)
        {
            foreach (var item in numbers)
            {
                if (item > 0)
                {
                    yield return item;
                }
                else
                {
                    yield break; //음수가 나오면 하지마
                }
            }
        }
        public void Test01()
        {
            foreach (var item in UntilPlus(new int[5] { 1, 3, 5, -1, 4 }))
            {
                Console.WriteLine(item);
            }
        }
        static void Main()
        {
            Program01 program01 = new Program01();
            program01.Test01();
        }
    }
    */
    #endregion
    #region 학원 yield 예제 3

    /*
    internal class example3 {
       public IEnumerable<int> GetRandomNumber()
       {
           Random random = new Random();

           while (true)
           {
               yield return random.Next();
           }
       }
       void Test02()
       {
           foreach (var item in GetRandomNumber())
           {
               Console.WriteLine(item);
               Console.WriteLine("다음 난수를 원한다면..");
               if (Console.ReadLine().ToLower() != "y") break;
           }
       }
       static void Main()
       {
           example3 program01 = new example3();
           program01.Test02();
       }
   }*/

    #endregion
}
