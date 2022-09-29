using DeviceManagement_WebApp.Data;
using System.Collections.Generic;
using System.Linq.Expressions;
using System;
using DeviceManagement_WebApp.Project3_Interface;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using DeviceManagement_WebApp.Models;
using Microsoft.EntityFrameworkCore;

namespace DeviceManagement_WebApp.Project3_Repo_s
{
    public class RepoGenerics<T> : GenericInterface<T> where T : class
    {
        protected readonly ConnectedOfficeContext _context;
        
        public RepoGenerics(ConnectedOfficeContext context)
        {
            _context = context;

        }
        public void Add(T entity)   // Encapsulate the SET and ADD function from the context into a new ADD function
        {
            _context.Set<T>().Add(entity);
        }
        public void AddRange(IEnumerable<T> entities)   // Encapsulate the SET and ADDRANGE function from the context into a new ADD RANGE function
        {
            _context.Set<T>().AddRange(entities);
        }       
        public IEnumerable<T> Find(Expression<Func<T, bool>> expression)    // Encapsulate and return the SET and WHERE function from the context into a new FIND function
        {
            return _context.Set<T>().Where(expression);
        }
        public IEnumerable<T> GetAll()  // Encapsulate and return the SET and TOLIST function from the context into a new ADD function
        {
            return _context.Set<T>().ToList();
        }
        public T GetById(Guid id)   // Encapsulate and return the SET and FIND function from the context into a new GET BY ID function
        {
            return _context.Set<T>().Find(id);
        }
        public void Remove(T entity)    // Encapsulate the SET and REMOVE function from the context into a new REMOVE function
        {
            _context.Set<T>().Remove(entity);
        }
        public void RemoveRange(IEnumerable<T> entities)    // Encapsulate the SET and REMOVERANGE function from the context into a new REMOVE RANGE function
        {
            _context.Set<T>().RemoveRange(entities);
        }
        public async Task<T> FindAsync(Guid id)     
        {
            return await _context.Set<T>().FindAsync(id);
        }
        public async Task<int> SaveChangesAsync()     
        {
            return await _context.SaveChangesAsync();
        }
        public void Update(T entity)        
        {
            _context.Update(entity);
        }
        public bool Exists(Guid id)          
        {
            return _context.Category.Any(e => e.CategoryId == id);
        }
        public ConnectedOfficeContext GetContext()       
        {
            return this._context;
        }
    }
}

