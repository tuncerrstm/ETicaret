using ETicaretAPI.Domain.Entities.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace ETicaretAPI.Application.Repositories
{
    public interface IReadRepository<T> : IRepository<T> where T : BaseEntity
    {
        IQueryable<T> GetAll(bool tracking = true);     // Sorgu üzerinde çalıştığım için IQueruable kullanıyorum.
        IQueryable<T> GetWhere(Expression<Func<T, bool>> method, bool tracking = true);  // Burada ise bir şarka uygun dataları elde ediyoruz. (Where şartı mayetinde kullanıyoruz.)
        Task<T> GetSingleAsync(Expression<Func<T, bool>> method, bool tracking = true);
        Task<T> GetByIdAsync(string id, bool tracking = true);
    }
}
