using System.Linq.Expressions;
using NLayeredDemo.Core.Models;

namespace NLayeredDemo.Core.Repository;

public interface IGenericRepository<T> where T : class
{
    Task<T> GetByIdAsync(int id);
    T GetById(int id);
    IQueryable<T> GetAll();
    IQueryable<T> Where(Expression<Func<T, bool>> expression); //user.Where(x=>x.UserName=="test")
    Task AddAsync(T entity); //user.AddAsync(user) ekleme
    Task AddRangeAsync(IEnumerable<T> entities); //user.AddRangeAsync(users) coklu ekleme
    void Remove(T entity); //user.Remove(user) silme
    void RemoveRange(IEnumerable<T> entities); //user.RemoveRange(users) coklu silme
    void Update(T entity); //user.Update(user) guncelleme
    

}