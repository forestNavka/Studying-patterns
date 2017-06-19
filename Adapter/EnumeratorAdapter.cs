using System;

namespace Adapter
{
    public class EnumeratorAdapter<T> : IIterator<T>
    {
        private readonly IEnumerator<T> _enumerator;

        public EnumeratorAdapter(IEnumerator<T> enumerator)
        {
            _enumerator = enumerator;
        }
        public T GetNextElement()
        {
            return _enumerator.GetNext();
        }

        public bool HasMoreElements()
        {
            return _enumerator.HasNext();
        }

        public void RemoveLast()
        {
           throw  new NotSupportedException();
        }
    }
}
