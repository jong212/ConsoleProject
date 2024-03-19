namespace CSharp009
{
    internal class Program
    {

        //=============================================
        //트리
        //계층적인 자료를 나타내는 자주사용하는 자료구조
        //부모노드가 여러자식노드들을 가질수 있는 1대 다 구조


        //[구성요소]
        //부모 : 루트노드 방향으로 직접 연결된 노드
        //자식 : 루트 노드 반대뱡향으로 직접 연결된 노드
        //뿌리(root) :  부모노드가 없는 최상위 노드 ,  트리의 깊이 0에 하나만 존재
        //가지(branch) : 부모노드와 자식노드가 모두 있는 노드, 트리의 중간에 존재
        //잎 : 자식 노드가 없는 노드, 트리의 끝에 존재
        //길이 : 출발 노드에서 도착노드까지 거치는 수
        //깊이 :  루트 노드부터의 길이
        //차수 : 자식노드의 갯수


        //[이진트리]
        //부모노드가 자식 노드를 최대 2개까지만 가질수 있는트리
        //일반적으로 이진트리로 구현한다.

        //[이진트리 순회]
        //비선형적인 자료구조이기 때문에 순서에대해 규칙이 있어야함.
        //전위 : 노드->왼쪽->오른쪽
        //중위 : 왼쪽->노드->오른쪽
        //후위 : 왼쪽->오른쪽->노드 
        //=============================================

        //Recursive Function

        public class BinaryNode<T>
        {
            public T item;
            public BinaryNode<T> parent;
            public BinaryNode<T> left;
            public BinaryNode<T> right;

            public BinaryNode(T item)
            {
                this.item = item;
            }
        }
        public class BinaryTree<T>
        {
            private BinaryNode<T> root;

            //루트노드 받아서 초기화
            public BinaryTree(BinaryNode<T> root)
            {
                this.root = root;
            }

            //전위
            public void PreOrder(BinaryNode<T> node)
            {
                if (node != null)
                {
                    Console.Write(node.item + " -> ");
                    PreOrder(node.left);
                    PreOrder(node.right);
                }
            }
            public void InOrder(BinaryNode<T> node)
            {
                if (node != null)
                {
                    PreOrder(node.left);
                    Console.Write(node.item + " -> ");
                    PreOrder(node.right);
                }
            }
            //후위
            public void PostOrder(BinaryNode<T> node)
            {
                if (node != null)
                {
                    PostOrder(node.left);
                    PostOrder(node.right);
                    Console.Write(node.item + " -> ");
                }
            }
        }

        static void Main(string[] args)
        {
            BinaryNode<char> root = new BinaryNode<char>('A');
            root.left = new BinaryNode<char>('B');
            root.right = new BinaryNode<char>('C');
            root.left.left = new BinaryNode<char>('D');
            root.left.right = new BinaryNode<char>('E');
            root.right.left = new BinaryNode<char>('F');
            root.right.right = new BinaryNode<char>('G');

            BinaryTree<char> tree = new BinaryTree<char>(root);

            Console.WriteLine("전위 순회");
            tree.PreOrder(root);
        }
    }
}