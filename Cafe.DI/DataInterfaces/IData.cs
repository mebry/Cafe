namespace Cafe.DI.DataInterfaces
{
    public interface IData<T>
    {
        void Add(T item);
        void Remove(T item);
        IEnumerable<T> GetAll();
    }
}
