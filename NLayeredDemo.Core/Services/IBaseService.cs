using System.Linq.Expressions;

namespace NLayeredDemo.Core.Services;

public interface IBaseService<T> where T:class
{
    Task<T> GetByIdAsync(int id);
    T GetById(int id);
    IQueryable<IEnumerable<T>> GetAllAsync();
    IQueryable<T> Where(Expression<Func<T, bool>> expression); //user.Where(x=>x.UserName=="test")
    Task AddAsync(T entity); //user.AddAsync(user) ekleme
    Task<IEnumerable<T>> AddRangeAsync(IEnumerable<T> entities); //user.AddRangeAsync(users) coklu ekleme
    Task RemoveAsync(T entity); //user.Remove(user) silme
    Task RemoveRangeAsync(IEnumerable<T> entities); //user.RemoveRange(users) coklu silme
    Task UpdateAsync(T entity); //user.Update(user) guncelleme
}