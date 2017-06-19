namespace Adapter
{
    public interface IEnumerator<out T>
    {
        T GetNext();

        bool HasNext();
    }
}
