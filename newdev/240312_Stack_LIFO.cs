using System;
using System.Diagnostics;
namespace aa
{
    #region 학원 예제 1 입력 받은 string 거꾸로 출력
    /*
    class Stack<T>
    {
        private const int MAX_VALUES = 3;
        private int top;
        private T[] values;

        public Stack()
        {
            top = -1;
            values = new T[MAX_VALUES];
            Array.Clear(values, 0, MAX_VALUES);
        }

        public void Push(T val)
        {
            // Debug.Assert(top + 1 < MAX_VALUES);
            if (top + 1 < MAX_VALUES)
            {
                values[++top] = val;
            }
            else
            {
                Console.WriteLine("오버플로우! 스택이 가득 찼습니다.");
            }
        }

        public T Pop()
        {
            if (!Empty())
            {
                T val = values[top];
                values[top--] = default(T);
                return val;
            }
            else
            {
                Console.WriteLine("스택이 비어 있습니다.");
                return default(T);
            }
        }

        public T Top()
        {
            return values[top];
        }

        public bool Empty()
        {
            return top < 0;
        }
    }

    internal class Test3
    {
        static void Main(string[] args)
        {
            Stack<char> stack = new Stack<char>(); // 문자열을 저장할 때 char 타입의 스택을 사용합니다.
            string input = Console.ReadLine(); // 문자열 입력을 받습니다.

            foreach (char c in input)
            {
                stack.Push(c); // 입력받은 문자열을 스택에 순서대로 저장합니다.
            }

            while (!stack.Empty())
            {
                Console.Write(stack.Pop()); // 스택에서 역순으로 문자를 꺼내어 출력합니다.
            }
        }
    }
    */
    #endregion 
    #region 학원 예제 2
    /*
internal class StackClass
{
    static void Main()
    {
        Stack<int> stack = new Stack<int>();
        stack.Push(10);

        stack.Push(20);
        stack.Push(20);
        stack.Push(20);
        stack.Push(60);
        // stack.Push(40);

        int topValue = stack.Peek();
        Console.WriteLine(topValue);

        int Count = stack.Count;
        Console.WriteLine(Count);

        bool isValue = stack.Contains(60);
        Console.WriteLine(isValue);

        stack.Clear();

        Queue<int> queue = new Queue<int>();

        queue.Enqueue(30);
        queue.Enqueue(40);
        queue.Enqueue(50);
    }
}
    */
    #endregion
}
