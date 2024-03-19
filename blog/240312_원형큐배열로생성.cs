public class Queue<T>
{
    private int last = 0;
    private int first = 0;
    private int count = 0;
    private int maxLenght;
    private T[] queue;

    public Queue(int _size)
    {
        queue = new T[_size];
        maxLenght = _size;
    }

    public bool Dequeue()
    {
        first = (first + 1) % maxLenght;
        count--;
        return true;
    }

    public bool Enqueue(T item)
    {
        if (IsFull())
        {
            Console.WriteLine("배열 초과상태로 삽입이 불가능합니다");
            return false;
        }
        else
        {
            queue[last] = item;
            last = (last + 1) % maxLenght;
            count++;
            return true;
        }
    }

    public bool IsFull()
    {
        return count >= maxLenght;
    }

    public bool IsEmpty()
    {
        return count == 0;
    }

    public void Print()
    {
        if (IsEmpty())
        {
            Console.WriteLine("큐가 비어 있습니다.");
            return;
        }

        int i = first;
        do
        {
            Console.Write(queue[i] + " ");
            i = (i + 1) % maxLenght;
        } while (i != last);
        Console.WriteLine(IsFull() ? " IsFull★" : "NoFull");
    }
}

public class Test
{
    public static void Main(string[] args)
    {
        Queue<int> queue = new Queue<int>(8);
        // 큐에 숫자 20부터 80까지 10씩 증가하는 숫자를 추가
        queue.Enqueue(20);
        queue.Enqueue(30);
        queue.Enqueue(40);
        queue.Enqueue(50);
        queue.Enqueue(60);
        queue.Enqueue(70);
        queue.Enqueue(80);
        queue.Print(); // 큐의 상태를 출력 (20부터 80까지)

        queue.Dequeue(); // 큐의 첫 번째 요소를 제거 (30부터 80까지 남음)
        queue.Print(); // 변경된 큐의 상태를 출력

        // 큐에 10과 20을 추가
        queue.Enqueue(10);
        queue.Enqueue(20);
        queue.Print(); // 최종 큐의 상태를 출력
    }
}
