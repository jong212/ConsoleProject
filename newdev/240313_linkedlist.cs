namespace test { 
/*
[LinkedList]
데이터를 포함하는 노드들을 연결식으로 만든구조
데이터와 다른 데이터 지점의 참조변수를 가진 노드를 기본단위사용
삽입 : 새로 추가하는 노두가 이전/이후 노드를 참조한 뒤 이전 노드가 새로 추가하는 노드를 참조한다.

*/

    internal class CLinkedList
    {
        static void Main(string[] args)
        {
            LinkedList<string> linkedlist = new LinkedList<string> ();
            linkedlist.AddLast("d");
            linkedlist.AddLast("d");
            linkedlist.AddLast("d");
            linkedlist.AddLast("d");
            linkedlist.AddLast("d");
            linkedlist.AddLast("d");


            LinkedListNode<string> node0 = linkedlist.AddFirst("0번 데이터"); //특정 노드에 접근하고 싶을 때 
            LinkedListNode<string> node1 = linkedlist.AddFirst("1번 데이터");
            LinkedListNode<string> node2 = linkedlist.AddLast("2번 데이터");
            LinkedListNode<string> node3 = linkedlist.AddLast("3번 데이터");
            LinkedListNode<string> node4 = linkedlist.AddBefore(node0,"4번 데이터");
            LinkedListNode<string> node5 = linkedlist.AddAfter(node0, "5번 데이터");

            foreach (var item in linkedlist)
            {
                Console.Write(item+ "- >");
            }
            linkedlist.Remove("1번 데이터");
            linkedlist.Remove(node3);
            linkedlist.RemoveFirst();
            linkedlist.RemoveLast();

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            foreach (var item in linkedlist)
            {
                Console.Write(item + "- >");
            }
            Console.WriteLine();

            //Linkedlist 접근방법 인덱스 접근이 아님
            LinkedListNode<string> firstnode = linkedlist.First;
            LinkedListNode<string> secondnode = linkedlist.Last;
            LinkedListNode<string> preveNode= node0.Previous;
            LinkedListNode<string> nextnode = node0.Previous;

            Console.WriteLine(firstnode.Value);
            Console.WriteLine(secondnode.Value);
            Console.WriteLine(preveNode.Value);

            LinkedListNode<string> findNode = linkedlist.Find("5번 데이터");



        }
    }

}

