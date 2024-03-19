/*
  참고 주소 : https://iqzero.tistory.com/3
  $this란? this() 자기 자신의 생성자? 
*/

#region 학원
namespace cs.blog
{
    class Player
    {
        private string name;
        private int hp;
        public void SetName(string name)
        {
            this.name = name;
        }
    }

    class MyClass01
    {
        int a, b, c;
        public MyClass01()
        {
            a = 1;
            Console.WriteLine("MyClasss01");
        }
        public MyClass01(int b) : this()
        {
            this.b = b;
            Console.WriteLine("MyClasss01{0}", b);
        }
        public MyClass01(int b, int c) : this(b)
        {
            this.c = c;
            Console.WriteLine("MyClasss01 {0},{1}", b, c);
        }
        public void print()
        {
            Console.WriteLine("a : {0},b : {1},c : {2},", a, b, c);
        }

    }
    internal class _240312_std
    {
        static void Main(string[] args)
        {
            MyClass01 a = new MyClass01(10, 20);

        }
    }
}
#endregion
