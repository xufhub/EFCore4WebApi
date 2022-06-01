using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace MysqlRespository
{
    public class MysqlDbContext : DbContext
    {
        public MysqlDbContext(DbContextOptions<MysqlDbContext> options) : base(options)
        {

        }
    }
}
