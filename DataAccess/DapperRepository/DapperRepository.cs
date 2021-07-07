using System.Collections.Generic;
using WizardOrbit.Core.Entity;
using WizardOrbit.Core.Context;
using Dapper;

namespace WizardOrbit.Core.DataAccess
{
    public class DapperRepository<TEntity> : IRepository<TEntity>
        where TEntity : class, IEntity, new()
    {
        private string _conn;
        public DapperRepository(string conn)
        {
            _conn = conn;
        }
        public TEntity Add(string sql, TEntity entity)
        {
            using (var db = DapperContext.OpenConn(_conn))
            {
                return db.QueryFirstOrDefault<TEntity>(sql, entity);
            }
        }

        public TEntity Update(string sql, TEntity entity)
        {
            using (var db = DapperContext.OpenConn(_conn))
            {
                return db.QueryFirstOrDefault<TEntity>(sql, entity);
            }
        }

        public TEntity Delete(string sql, TEntity entity)
        {
            using (var db = DapperContext.OpenConn(_conn))
            {
                return db.QueryFirstOrDefault<TEntity>(sql, entity);
            }
        }

        public IEnumerable<TEntity> GetAll(string sql, DynamicParameters dynamicParameters)
        {
            using (var db = DapperContext.OpenConn(_conn))
            {
                return db.Query<TEntity>(sql, dynamicParameters);
            }
        }

        public TEntity GetT(string sql, DynamicParameters dynamicParameters)
        {
            using (var db = DapperContext.OpenConn(_conn))
            {
                return db.QueryFirstOrDefault<TEntity>(sql, dynamicParameters);
            }
        }
    }
}