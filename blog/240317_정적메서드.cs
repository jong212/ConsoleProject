/*
정적메서드
인스턴스 메서드
*/ 
namespace AS
{
    class MyClass
    {
        private int val = 1;
        public int temp = 4;
        // 인스턴스 메서드
        public int InstRun()
        {
            return val;
        }
        // 정적(static) 메서드
        public static int Run()
        {
            WriteLine("hoi");

            return 1;
        }
    }
    class MainApp
    {
        public static void Main(string[] args)
        {
            // 인스턴스 메서드 호출
            MyClass myClass = new MyClass();
            int i = myClass.InstRun();

            // 정적 메서드 호출
            int j = MyClass.Run();
        }
    }
}