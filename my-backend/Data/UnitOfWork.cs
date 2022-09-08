using System;
using Microsoft.EntityFrameworkCore;

namespace MyBackend.Data
{
    public sealed class UnitOfWork : IDisposable
    {
        private readonly DbContext _db;

        public UnitOfWork(DbContext db)
        {
            this._db = db;
        }

        public bool Save()
        {
            bool isSuccess = _db.SaveChanges() > 0;
            return isSuccess;
        }

        public void Dispose()
        {
            if(_db == null) return;
            _db.Dispose();
        }

        public Task CommitAsync()   
        {   
            return _db.SaveChangesAsync();   
        }   
    }
}