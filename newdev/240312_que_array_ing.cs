using System;

public class ArrayQueue
{
    private int[] queue;
    private int head = -1;
    private int tail = -1;
    private int size;

    public ArrayQueue(int size)
    {
        this.size = size;
        queue = new int[size];
    }

    public bool Enqueue(int item)
    {
        if (IsFull())
        {
            Console.WriteLine("Queue is full!");
            return false;
        }

        tail = (tail + 1) % size;
        queue[tail] = item;

        if (head == -1)
        {
            head = tail;
        }

        return true;
    }

    public int Dequeue()
    {
        if (IsEmpty())
        {
            Console.WriteLine("Queue is empty!");
            return -1;
        }

        int item = queue[head];
        if (head == tail)
        {
            head = tail = -1;
        }
        else
        {
            head = (head + 1) % size;
        }

        return item;
    }

    public bool IsFull()
    {
        return (tail + 1) % size == head;
    }

    public bool IsEmpty()
    {
        return head == -1;
    }

    public void Print()
    {
        if (IsEmpty())
        {
            Console.WriteLine("Queue is empty!");
            return;
        }

        int current = head;
        while (true)
        {
            Console.Write(queue[current] + " ");
            if (current == tail)
                break;
            current = (current + 1) % size;
        }
        Console.WriteLine();
    }
}

public class Program
{
    public static void Main()
    {
        ArrayQueue queue = new ArrayQueue(5);

        queue.Enqueue(1);
        queue.Enqueue(2);
        queue.Enqueue(3);
        queue.Print();

        Console.WriteLine(queue.Dequeue());
        queue.Print();

        queue.Enqueue(4);
        queue.Enqueue(5);
        queue.Enqueue(6);
        queue.Print();

        Console.WriteLine("Is Full: " + queue.IsFull());
        Console.WriteLine("Is Empty: " + queue.IsEmpty());
    }
}
