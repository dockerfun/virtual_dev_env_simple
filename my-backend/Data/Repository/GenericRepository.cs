using Microsoft.EntityFrameworkCore;
using my_backend.Data.Repository.Base;

namespace my_backend.Data.Repository;

public abstract class GenericRepository<T> : IRepository<T> where T : class
{
    private readonly DbContext _db;

    public GenericRepository(DbContext db)
    {
        this._db = db;
    }

    public void Create(T entity)
    {
        _db.Set<T>().Add(entity);
    }

    public void Delete(T entity)
    {
        _db.Set<T>().Remove(entity);
    }

    public IQueryable<T> List()
    {
        return _db.Set<T>();
    }

    public virtual T? Read(object keys)
    {
        return _db.Set<T>().Find(keys);
    }

    public void Update(T entity)
    {
        _db.Entry(entity).State = EntityState.Modified;
    }
}