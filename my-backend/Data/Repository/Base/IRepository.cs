namespace  my_backend.Data.Repository.Base;

public interface IRepository<T> where T: class
{
    void Create(T entity);
    T? Read(object keys);
    void Update(T entity);
    void Delete(T entity);
    IQueryable<T> List();
}