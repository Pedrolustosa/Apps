using MongoDB.Driver;
using System.Linq.Expressions;
namespace Orders.API.Domain.Interfaces;

public interface IMongoDbServiceHandler<T, TId>
{
    Task<IEnumerable<T>> GetAllAsync(Expression<Func<T, bool>> predicate);
    Task<T> GetSingleAsync(Expression<Func<T, bool>> predicate);
    Task InsertAsync(T entity, CancellationToken cancellationToken);
    Task<ReplaceOneResult> UpdateAsync(TId id, T entity);
    Task RemoveAsync(TId id);
}
