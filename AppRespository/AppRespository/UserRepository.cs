using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppRespository
{
    public class UserRepository : AppBaseRespository<UserEntity>, IUserRepository
    {
        private readonly DbContextOptions<DbContext> _dbContext;
        public UserRepository(DbContextOptions<DbContext> options) : base(options)
        {
            _dbContext = options;
        }

        public async Task<List<UserEntity>> GetUsers()
        {
            var t = from u in Table
                    where u.State == 2
                    select u;
            return await t.ToListAsync();
        }
    }
}
