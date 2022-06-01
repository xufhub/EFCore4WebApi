using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppRespository
{
    public class UserRepository<TEntity> : AppBaseRespository<TEntity>, IUserRepository<TEntity> where TEntity : BaseEntity
    {
        private readonly DbContextOptions<DbContext> _dbContext;
        public UserRepository(DbContextOptions<DbContext> options) : base(options)
        {
            _dbContext = options;
        }
    }
}
