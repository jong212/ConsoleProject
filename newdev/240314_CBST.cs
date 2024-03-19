using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp009
{
    internal class CBST
    {
        /*
         이진탐색트리(BinarySearchTree)

         이진속성, 탐색속성을 적용한 트리
         이진 탐색을 통한 탐색영역을 절반으로 줄여가며 탐색가능
         이진  : 부모노드는 최대 2개의 자식노드를 가질수 있다.
         탐색  : 자신의 노드보다 작은 값은 왼쪽, 큰값들은 오른쪽에 위치 

         [구현]
         //
         //            23
        //      ┌──────┴──────┐
        //      11            38
        //   ┌──┴──┐       ┌──┴──┐
        //   3     19      31    65
        //   └─┐ ┌─┴─┐   ┌─┘     └─┐
        //     6 17  22  24        87
        ////////////////////////////////////////////////////
        [탐색]
        //17을 탐색?
        //루트노드부터 시작하여 탐색하는 값과 비교
        //작은경우 왼쪽자식노드로..큰 경우라면 오른쪽으로 감.
        //1)23과 17을 비교 ==> (17 < 23) ->왼쪽으로감.
        // ㄴ이제 오른쪽 서브트리는 탐색할 필요가 없음
        //2)11과 17을 비교  ==>(11 < 17) ->오른쪽감
        //3)19와 17을 비교  ==>(19 > 17) ->왼쪽감
        //4)17이랑 17 비교 ==>같음!(찾음)
        //            23(↙)     ↘
        //      ┌──────┴──────┐
        //      11(↘)        38
        //   ┌──┴──┐       ┌──┴──┐
        //   3     19(↙)  31    65
        //   └─┐ ┌─┴─┐   ┌─┘     └─┐
        //     6 (17)  22  24        87
          ////////////////////////////////////////////////////
        [삽입]
        // ex)35를 삽입
        // 탐색이랑 비슷함.
        //루트 노드부터 시작해서 삽입하는 값과 비교
        // 작은 경우는 왼쪽 자식노드로, 큰 경우 오른쪽 자식노드로 이동
        // 1)23과 35를 비교 ==> 23<35(오른쪽으로 이동)
        //2) 38이랑 35를 비교==> 35 < 38(왼쪽으로 이동)
        //3) 31이랑 35를 비교 ==> 35 > 31(오른쪽으로 이동)
        //4) 자리가 비었으면 삽입
         //            23↘
        //      ┌──────┴──────┐
        //      11            38 ↙
        //   ┌──┴──┐       ┌──┴──┐
        //   3     19      31↘  65
        //   └─┐ ┌─┴─┐   ┌─┘    
        //     6 17  22  24      

        ////////////////////////////////////////////////////
        [삭제]
        //1 . 자식이 0개인 경우 어떻게 지울꺼냐?
         //ㄴ 22삭제한다고 하면 부모노드의 자식노드를 null
         //            23                          23
        //      ┌──────┴──────┐             ┌──────┴──────┐
        //      11            38            11            38 
        //   ┌──┴──┐       ┌──┴──┐       ┌──┴──┐       ┌──┴──┐
        //   3     19      31   65       3     19      31   65
        //   └─┐ ┌─┴─┐   ┌─┘             └─┐ ┌─┴─┐   ┌─┘    
        //     6 17  22  24                6 17     24      


        //2. 자식이 1개인 노드의 삭제  :  삭제하는 노드의 부모와 자식을 연결 후 삭제
        //38을 삭제(23과 38의 자식을 연결 )
          //            23                           23          
         //      ┌──────┴──────┐              ┌──────┴──────┐   
         //      11            38             11            31
         //   ┌──┴──┐       ┌──┴──┐        ┌──┴──┐       ┌──┴──┐
         //   3     19      31             3     19      24   35
         //   └─┐ ┌─┴─┐   ┌─┘─             └─┐ ┌─┴─┐      
         //     6 17  22  24 35              6 17  22     
        //3 . 자식이 2개인경우 : 삭제하는 노드를 기준으로 오른쪽 자식중 가장 작은값 노드와 
              교체후 삭제
        //  23을 삭제한다면?

         //           (23)                     24                      24          
        //      ┌──────┴──────┐         ┌──────┴──────┐         ┌──────┴──────┐    
        //      11            38        11            38        11            38   
        //   ┌──┴──┐       ┌──┴──┐   ┌──┴──┐       ┌──┴──┐   ┌──┴──┐       ┌──┴──┐ 
        //   3     19      24    49  3     19    (23)    49  3     19      35     49  
        //   └─┐ ┌─┴─┐   ┌─┘─        └─┐ ┌─┴─┐   ┌─┘─        └─┐ ┌─┴─┐       
        //     6 17  22     35         6 17  22     35         6 17  22      
         */


        public class BinarySearchTree<T> where T : IComparable<T>
        {

            //노드를 나타내는 클래스
            private class Node
            {
                public T item;
                public Node parent;
                public Node left;
                public Node right;


                //노드 생성자
                public Node(T item, Node parent, Node left, Node right)
                {
                    this.item = item;
                    this.parent = parent;
                    this.left = left;
                    this.right = right;
                }
            }
            private Node root;

            public BinarySearchTree()
            {
                this.root = null;
            }
            public bool Add(T item)
            {
                //루트노드가 없으면 
                if (root == null)
                {
                    Node newNode = new Node(item, null, null, null);
                    root = newNode;
                    return true;
                }

                Node current = root;

                while (current != null)
                {
                    if (item.CompareTo(current.item) < 0)
                    {
                        if (current.left == null)
                        {
                            Node newNode = new Node(item, null, null, null);
                            current.left = newNode;
                            newNode.parent = current;
                            break;
                        }
                        current = current.left;
                    }
                    else if (item.CompareTo(current.item) > 0)
                    {
                        if (current.right == null)
                        {
                            Node newNode = new Node(item, null, null, null);
                            current.right = newNode;
                            newNode.parent = current;
                            break;
                        }
                        current = current.right;
                    }
                    else //if(item.CompareTo(current.item) == 0)
                    {
                        return false;
                    }
                }
                return true;
            }// end of Add
            public bool Remove(T item)
            {
                Node findNode = FindNode(item);

                if (findNode != null)
                {
                    EraseNode(findNode);
                    return true;
                }
                else
                {
                    return false;
                }
            }
            public bool Contains(T item)
            {
                Node findNode = FindNode(item);

                return findNode != null ? true : false;
            }
            public void Clear()
            {
                root = null;
            }
            //
            private Node FindNode(T item)
            {
                if (root == null) return null;

                Node current = root;
                while (current != null)
                {
                    if (item.CompareTo(current.item) < 0)
                    {
                        current = current.left;
                    }
                    else if (item.CompareTo(current.item) > 0)
                    {
                        current = current.right;
                    }
                    else
                    {
                        return current;
                    }
                }

                return null;

            }
            private void EraseNode(Node node)
            {
                if (node.left == null && node.right == null)
                {
                    Node parent = node.parent;

                    if (parent == null)
                    {
                        root = null;
                    }
                    else if (parent.left == node)
                    {
                        parent.left = null;
                    }
                    else if (parent.right == node)
                    {
                        parent.right = null;
                    }
                }
                else if (node.left != null || node.right != null)
                {
                    Node parent = node.parent;
                    Node child = node.left != null ? node.left : node.right;

                    if (parent == null)
                    {
                        root = child;
                        child.parent = null;
                    }
                    else if (parent.left == node)
                    {
                        parent.left = child;
                        child.parent = parent;
                    }
                    else if (parent.right == node)
                    {
                        parent.right = child;
                        child.parent = parent;
                    }

                }
                else//(node.left!=null && node.right != null)
                {
                    Node nextNode = node.right;
                    while (nextNode.left != null)
                    {
                        nextNode = nextNode.left;
                    }
                    node.item = nextNode.item;
                    EraseNode(nextNode);
                }
            }
        }

        static void Main()
        {
            BinarySearchTree<int> bst = new BinarySearchTree<int>();
            bst.Add(50);
            bst.Add(30);
            bst.Add(70);
            bst.Add(20);
            bst.Add(40);
            bst.Add(60);
            bst.Add(80);

            Console.WriteLine(bst.Contains(40));
            Console.WriteLine(bst.Contains(90));

            bst.Remove(20);
            Console.WriteLine(bst.Contains(20));

        }
    }
}
