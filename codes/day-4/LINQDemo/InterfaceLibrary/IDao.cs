namespace InterfaceLibrary
{
    public interface IDao<T>
    {
        bool Add(T data);
        bool Delete(int id);
        T[] GetAll();
        T Get(int id);
        bool Update(T data);
    }
}
