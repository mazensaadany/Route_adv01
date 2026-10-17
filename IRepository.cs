namespace Route_adv01;

public interface IRepository<T>
{
    void Add(T entity);

    T GetById(int id);

    IEnumerable<T> GetAll();
}
