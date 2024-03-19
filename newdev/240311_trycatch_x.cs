/*
    예외처리 프로그램 도중 발생하는 의도 하지 않은 상황을 처리하는 방법
*/
namespace cs.complete
{
    internal class _240311
    {
        static void Main(string[] args)
        {

            #region try catch 사용방법 설명하는 주석코드
            /*
            try //돌아가다가 예외가 발생되면 catch로 던짐
            {
                //실행하려는 코드...
                //ㄴ 예외가 일어나지 않을경우의 실행되어야 할 코드...

            }
            catch (Exception)
            {
                //예외가 발생했을때 처리할 코드가...
                //ㄴ예외가 던져지면 여기서 받음
                //ㄴcatch는 try에서 던질 객체와 형식이 동일해야 한다.
                //ㄴ만약 try에서 여러 종류의 예외를 던질 가능성이 있다면
                //ㄴcatch도 여러개가 있어야함
            }
            */
            #endregion
            #region try catch 에제 : 배열 길이 보다 더 많이 for문 돈 경우 에러 발생
            /*
            int[] arr2 = new int[3] { 1, 2, 3, };
            try
            {
                for (int i = 0; i<4; i++)
                {
                    //배열크기의 -1을 벗어나면 예외발생-> 아래 e로 에러 내역을 던진다.
                    Console.WriteLine(arr2[i]);
                }
            }
            catch (IndexOutOfRangeException e)
            {
                Console.WriteLine($"{e.Message}");
            }
            */
            #endregion
            #region try catch 예제 : 입력값 받아서 체크 정수 체크
            /*
            try
            {
                Console.WriteLine("숫자를 입력해라 : "); ;
                string input = Console.ReadLine();
                int value = int.Parse(input);
                int[] array = new int[value];

                array[10] = 10;
            }
            catch (FormatException ex) 
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine("입력값이 정수로 변환이 불가능하다면 예외발생");
            }
            catch (IndexOutOfRangeException ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine("입력값이 10 이하인 경우 [10]인덱스 접근이 불가하므로 예외발생");
            }
            */
            #endregion
            #region try catch 예제
            /*

            try
            {
                int[] array = { 1, 3, 5, 7, 9 };
                int index = Array.IndexOf(array, 8);//콘솔에서 이 값 수정
                if (index < 0)
                    throw new InvalidOperationException();
                array[index] = 0;
            }
            catch(InvalidOperationException ex) 
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine("배열에서 원하는 값을찾지 못함");
            }*/
            #endregion
        }
    }
}
