using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppRespository
{
    public class GroupUserRepository : AppBaseRespository<GroupUserEntity>, IGroupUserRepository
    {
        private readonly DbContextOptions<DbContext> _dbContext;
        public GroupUserRepository(DbContextOptions<DbContext> options) : base(options)
        {
            _dbContext = options;
        }
    }
}
