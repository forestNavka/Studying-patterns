namespace Adapter
{
    public interface IIterator<out T>
    {
        T GetNextElement();

        bool HasMoreElements();

        void RemoveLast();
    }
}
