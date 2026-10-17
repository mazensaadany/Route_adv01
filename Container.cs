namespace Route_adv01;
internal class Container<T>
{
    private T item;

    public void Add(T _item)
    {
        item = _item;
    }

    public T Get()
    {
        return item;
    }
}
