using System.Collections;

namespace RTProSLDevTools.Dtos.Common
{
    public class ListDto<T> : IReadOnlyList<T>
    {
        public T this[int index] => throw new NotImplementedException();

        public int Count => throw new NotImplementedException();

        public IEnumerator<T> GetEnumerator()
        {
            throw new NotImplementedException();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
}
