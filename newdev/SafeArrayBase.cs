namespace shop
{
    private class SafeArrayBase<T>
    {
        public T Get(int index)
        {
            if (index < 0 || index >= array.Length)
            {
                return default(T); //자료형의 기본값을 나타냄
            }
        }
    }
}