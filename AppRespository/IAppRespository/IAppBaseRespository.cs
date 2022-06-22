using AppDenpendency;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace AppRespository
{
    public interface IAppBaseRespository<TEntity> where TEntity : BaseEntity
    {
        public DbSet<TEntity> Table { get; set; }
        public TEntity GetEntityById(int id);
        public List<TEntity> GetEntitiesByIds(List<int> ids);
        public Task<TEntity> InsertAsync(TEntity entity);
        public Task<long> BatchInsertAsync(List<TEntity> entity);
        public Task<long> DeleteByIdAsync(int id);
        public Task<long> DeleteByIdsAsync(List<int> ids);
        public Task<TEntity> UpdateAsync(TEntity entity);
        public Task<List<TEntity>> QueryBySql(string sql, params object[] paramaters);
        public Task BatchUpdateAsync(List<TEntity> entitys);
        public Task<List<TEntity>> GetAll();
    }
}
