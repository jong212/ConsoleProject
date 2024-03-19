//https://mychrome.info/c-%ec%9d%bc%eb%b0%98%ed%99%94-%ed%81%b4%eb%9e%98%ec%8a%a4-%ec%9d%bc%eb%b0%98%ed%99%94-%eb%a9%94%ec%84%9c%eb%93%9c-%ed%98%95%ec%8b%9d-%eb%a7%a4%ea%b0%9c-%eb%b3%80%ec%88%98-%ec%a0%9c%ec%95%bd-%ec%a0%95/


/*일반화 메서드*/
void CopyArray<T> (T[], source, T[] target){
  for(int i =0; i < source.Length; i++)
  target[i] = source[i];
}

/*일반화 메서드 함수 호출 방법*/
CopyArray<int> (source, target);



/*일반화 클래스*/
class Array_Generic<T>
{
    private T[] array;
    public T GetElement(int index) { return array[index]; }
}

/*일반화 클래스 객체 생성방법*/
Array_generic<int> int_Arr = new Arr_generic<int>();
Array_generic<double> dblArr = new Arr_generic<double>();



/*형식 매개변수에는 또 다른 기능이 있는데 "형식 매개 변수 제약" 이라는 기능이다.*/
/*형식 매개 변수 제약*/
/*일반화 프로그래밍에서 형식 매개 변수 T는 아무 표시가 없을 경우 모든 데이터 형식을 대신한다.그럼, 특정 조건에만 데이터 형식을 대신하는 형식 매개 변수를 사용하고 싶다면 어떻게 해야할까?
예를 들어 형식 매개 변수가 값 형식일때만 작동하게 하고 싶습니다. 그럼 아래처럼 where 을 통해 이를 해결할 수 있습니다.*/

void CopyArray<T>(T[] source, T[] target) where T : struct {
    for (int i = 0; i<source.Length; i++) {
        target[i] = source[i];
    }
}
/*
그 외 T 의 제약 조건들은 아래와 같다

T의 제약조건들
형식 매개 변수의 제약 조건들을 살펴봅니다.

where T : struct
T는 값 형식만 받습니다.

where T : class
T는 참조 형식만 받습니다.

where T : new()
T는 반드시 매게 변수가 없는 생성자가 있어야 합니다.

where T : 기반 클래스명
T는 명시한 기반 클래스의 파생 클래스여야 합니다.

where T : 인터페이스명
T는 명시한 인터페이스를 반드시 구현해야합니다. 여러개의 인터페이스 명시가 가능합니다.

where T : U
T는 또 다른 형식 매개 변수 U로부터 상속받은 클래스입니다.

이해를 위해 예제 코드를 작성해보겠습니다.
*/

using System;
 
namespace ConstraintsOnTypeParameters
{

    class StructArray<T> where T : struct
    {
        public T[] Array { get; set; }
        public int Length { get; set; }

        public StructArray(int size)
        {
            Array = new T[size];
            Length = size;
        }
    }

    class RefArray<T> where T : class
    {
        public T[] Array { get; set; }
        public int Length { get; set; }

        public RefArray(int size)
        {
            Array = new T[size];
            Length = size;
        }
    }

    class Base { }
    class Derived : Base { }
    class BaseArray<U> where U : Base
    {
        public U[] Array { get; set; }
        public int Length { get; set; }

        public BaseArray(int size)
        {
            Array = new U[size];
            Length = size;
        }

        public void CopyArray<T>(T[] Source) where T : U
        {
            Source.CopyTo(Array, 0);
        }
    }


    public interface IInterface
    {

    }

    public interface IWhatever : IInterface
    {
        void ShowArrayLength();
    }

    public class InterfaceArray<T> where T : IInterface
    {
        public T[] Array { get; set; }
        public int Length { get; set; }
        public InterfaceArray(int size)
        {
            Array = new T[size];
            Length = Array.Length;
        }
    }

    class Program
    {
        public static T CreateInstance<T>() where T : new()
        {
            return new T();
        }

        static void Main(string[] args)
        {

            // 값 형식으로 제약
            StructArray<int> a = new StructArray<int>(3);
            a.Array[0] = 1;
            a.Array[1] = 2;
            a.Array[2] = 3;

            for (int i = 0; i < a.Length; i++)
            {
                Console.WriteLine(a.Array[i]);
            }
            Console.WriteLine("/////////");

            // 참조형식으로 제약
            RefArray<StructArray<double>> b = new RefArray<StructArray<double>>(3);
            b.Array[0] = new StructArray<double>(5);
            b.Array[1] = new StructArray<double>(10);
            b.Array[2] = new StructArray<double>(200);

            for (int i = 0; i < b.Length; i++)
            {
                Console.WriteLine(b.Array[i].Length);
            }
            Console.WriteLine("/////////");

            // 기반 클래스로 제약
            BaseArray<Base> c = new BaseArray<Base>(3);
            c.Array[0] = new Base();
            c.Array[1] = new Derived();
            c.Array[2] = CreateInstance<Base>();

            for (int i = 0; i < c.Length; i++)
            {
                Console.WriteLine(c.Array[i]);
            }
            Console.WriteLine("/////////");

            // 기반 클래스로 제약
            BaseArray<Derived> d = new BaseArray<Derived>(3);
            d.Array[0] = new Derived(); //Derived가 기반 클래스가 되기 때문에 Base 할당 불가
            d.Array[1] = CreateInstance<Derived>();
            d.Array[2] = CreateInstance<Derived>();

            for (int i = 0; i < d.Length; i++)
            {
                Console.WriteLine(d.Array[i]);
            }
            Console.WriteLine("/////////");

            // U로부터 상속받은
            BaseArray<Derived> e = new BaseArray<Derived>(3);
            e.CopyArray<Derived>(d.Array);

            Console.WriteLine(e.Array.Length);

            //인터페이스 제약
            InterfaceArray<IWhatever> f = new InterfaceArray<IWhatever>(3);
        }
    }
}

이상입니다.