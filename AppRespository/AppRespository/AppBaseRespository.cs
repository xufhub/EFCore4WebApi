using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppRespository
{
    public class AppBaseRespository<TEntity> : DbContext, IAppBaseRespository<TEntity> where TEntity : BaseEntity
    {
        public AppBaseRespository(DbContextOptions<DbContext> options) : base(options)
        {

        }

        public DbSet<TEntity> Table { get; set; }

        public TEntity GetEntityById(int id)
        {
            return Table.Where(d => d.Id == id).FirstOrDefault();
        }

        public async Task<List<TEntity>> GetAll()
        {
            return await Table.ToListAsync();
        }

        public List<TEntity> GetEntitiesByIds(List<int> ids)
        {
            return Table.Where(d => ids.Contains(d.Id)).ToList();
        }

        public async Task<TEntity> InsertAsync(TEntity entity)
        {
            await Table.AddAsync(entity);
            await SaveChangesAsync();
            return entity;
        }

        public async Task<long> BatchInsertAsync(List<TEntity> entity)
        {
            await Table.AddRangeAsync(entity);
            return await SaveChangesAsync();
        }

        public async Task<long> DeleteByIdAsync(int id)
        {
            var model = GetEntityById(id);
            if (model == null)
                return 0;
            Table.Remove(model);
            return await SaveChangesAsync();
        }

        public async Task<long> DeleteByIdsAsync(List<int> ids)
        {
            var models = GetEntitiesByIds(ids);
            if (models == null || models.Count < 1)
                return 0;
            Table.RemoveRange(models);
            return await SaveChangesAsync();
        }

        public async Task<TEntity> UpdateAsync(TEntity entity)
        {
            var model = Table.Update(entity).Entity;
            await SaveChangesAsync();
            return model;
        }

        public async Task BatchUpdateAsync(List<TEntity> entitys)
        {
            Table.UpdateRange(entitys);
            await SaveChangesAsync();
        }

        public async Task<List<TEntity>> QueryBySql(string sql, params object[] paramaters)
        {
            return await Table.FromSqlRaw(sql, paramaters).ToListAsync();
        }
    }
}
