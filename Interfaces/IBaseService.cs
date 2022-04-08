namespace EstoqueApp.Interfaces
{
    internal interface IBaseService<T>
    {
        void Save(T model);
        void Update(T model);
        void Remove(T model);
    }
}
