using System.Collections.Generic;
using System.Linq.Expressions;
using System;
using System.Threading.Tasks;
using DeviceManagement_WebApp.Data;
using Microsoft.AspNetCore.Mvc;

namespace DeviceManagement_WebApp.Project3_Interface
{
    public interface GenericInterface<T> where T : class
    {        
        T GetById(Guid id);
        IEnumerable<T> GetAll();
        IEnumerable<T> Find(Expression<Func<T, bool>> expression);
        void Add(T entity);
        void AddRange(IEnumerable<T> entities);
        void Remove(T entity);
        void RemoveRange(IEnumerable<T> entities);
        public Task<int> SaveChangesAsync();
        public Task<T> FindAsync(Guid id);
        public void Update(T entity);
        public bool Exists(Guid id);
        public ConnectedOfficeContext GetContext();
    }
}
