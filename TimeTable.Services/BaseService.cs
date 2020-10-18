using System.Collections.Generic;
using System.Linq;
using TimeTable.Data.Models;

namespace TimeTable.Services
{
    public abstract class BaseService<T> where T: class
    {
        protected TimetableContext _context;

        public BaseService()
        {
            _context = TimetableContext.Instance;
        }

        public List<T> GetAll()
        {
            return _context.Set<T>().ToList();
        }

        public T Add(T entity)
        {
            var saved = _context.Set<T>().Add(entity);
            _context.SaveChanges();
            return saved.Entity;
        }

        public virtual void Update(T entity)
        {
            _context.Update(entity);
            _context.SaveChanges();
        }

        public virtual T GetById(decimal id)
        {
            return _context.Set<T>().Find(id);
        }
        public virtual void DeleteById(decimal id)
        {
            var entity = _context.Set<T>().Find(id);
            _context.Set<T>().Remove(entity);
            _context.SaveChanges();
        }
    }
}
