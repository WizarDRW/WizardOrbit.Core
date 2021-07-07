using System.Collections.Generic;
using Dapper;
using WizardOrbit.Core.Entity;

namespace WizardOrbit.Core.DataAccess
{
    interface IRepository<T>
        where T: class, IEntity, new()
    {
        IEnumerable<T> GetAll(string sql, DynamicParameters dynamicParameters);
        T GetT(string sql, DynamicParameters dynamicParameters);
        T Add(string sql, T entity);
        T Update(string sql, T entity);
        T Delete(string sql, T entity);
    }
}