/*

이 코드는 C#에서 메소드 오버로딩의 개념을 보여주는 예제입니다. 
메소드 오버로딩은 같은 이름의 메소드를 여러 개 정의할 수 있게 하며, 각 메소드는 매개변수의 타입이나 개수가 달라야 합니다. 
이를 통해 같은 작업을 수행하지만, 다른 매개변수를 사용하는 메소드를 여러 개 만들 수 있습니다. 
이 예제에서는 Add 메소드를 두 번 오버로딩하여, 서로 다른 매개변수를 받을 수 있게 합니다.\

*/
class GFG
{
    // 메소드 오버로딩을 이용한 첫 번째 Add 메소드 정의
    // 두 개의 정수를 매개변수로 받아 그 합을 반환
    public int Add(int a, int b)
    {
        return a + b;
    }

    // 메소드 오버로딩을 이용한 두 번째 Add 메소드 정의
    // 세 개의 정수를 매개변수로 받아 그 합을 반환
    public int Add(int a, int b, int c)
    {
        return a + b + c;
    }
}

class Program
{
    static void Main(string[] args)
    {
        // GFG 클래스의 인스턴스 생성
        GFG g = new GFG();

        // 첫 번째 Add 메소드 호출 (두 매개변수)
        // 1과 2를 더한 결과를 콘솔에 출력
        Console.WriteLine(g.Add(1, 2));

        // 두 번째 Add 메소드 호출 (세 매개변수)
        // 1, 2, 3을 더한 결과를 콘솔에 출력
        Console.WriteLine(g.Add(1, 2, 3));
    }
}
