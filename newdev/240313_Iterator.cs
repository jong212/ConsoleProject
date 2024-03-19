namespace test { 
/*
[반복기Iterator]
자료구조에 저장되어 있는 요소들을 순차적으로 접근
대부분 자료구조는 Iterator를 포함
그렇다는건 자료구조종류와 내부구조와는 무관하게 순회할 수 있다.

[IEnumerable] : 자료구조의 반복기 생성 인터페이스
[IEnumerator] : 자료구ㅜ조의 반복기 객체 인터페이스



메모 : 반복기를 들고있는 애들은 foreach사용이 가능하다

    

*/
    internal class Citer
    {

void Test()
        {
            List<int> list = new List<int>() {0,1,2,3,4,5 };
            IEnumerator<int> iter = list.GetEnumerator();
            Console.WriteLine($"{iter.Current}");
            while( iter.MoveNext())
            {
                Console.WriteLine( iter.Current );
            }
        }

        void Test01()
        {
            int size = 5;
            List<int> list = new List<int>();            
            for( int i = 0; i < size; i++)
            {
                list.Add( i );
            }

            //반복기를 사용 안 하는경우
            for( int i = 0;i < list.Count; i++)
            {
                Console.WriteLine(list[i] );
            }
            Console.WriteLine("=========================");
            //반복기를 사용하는 경우
            for (IEnumerator<int> iter = list.GetEnumerator();iter.MoveNext(); )
            {
                Console.WriteLine(iter.Current);
            }
            Console.WriteLine("=========================");
            LinkedList<int> list2 = new LinkedList<int>();
            for(LinkedListNode<int>node = list2.First; node!= null; node = node.Next )
            {

            }
        }
        void Test02()
        {
            int size = 5;
            int[] array = new int[size];
            List<int> list = new List<int>();
            Stack<int> stack = new Stack<int>();
            Queue<int> queue = new Queue<int>();
            SortedSet<int> set = new SortedSet<int>();
            for (int i = 0; i<size; i++)
            {
                array[i] = i;
                list.Add( i );
                stack.Push( i );
                queue.Enqueue( i );
                set.Add( i );
            }
            foreach(var item in array)
            {
                Console.WriteLine(item); 
            }
            Console.WriteLine("=========================");

            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("=========================");

            foreach (var item in stack)
            {
                Console.WriteLine(item);
            }
        }
        static void Main()
        {
            Citer cIter = new Citer();
            //cIter.Test();
            cIter.Test01();
            cIter.Test02();
            //list와 linkedlist동작


        }
    }

}

