using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using LoginMVCPlusCrud.Models;

namespace LoginMVCPlusCrud.Data
{
    public class LoginMVCPlusCrudContext : DbContext
    {
        public LoginMVCPlusCrudContext (DbContextOptions<LoginMVCPlusCrudContext> options)
            : base(options)
        {
        }

        public DbSet<LoginMVCPlusCrud.Models.Blog> Blog { get; set; } = default!;
    }
}
