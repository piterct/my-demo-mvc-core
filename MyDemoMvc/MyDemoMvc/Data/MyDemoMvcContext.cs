using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MyDemoMvc.Models;

namespace MyDemoMvc.Data
{
    public class MyDemoMvcContext : DbContext
    {
        public MyDemoMvcContext (DbContextOptions<MyDemoMvcContext> options)
            : base(options)
        {
        }

        public DbSet<MyDemoMvc.Models.Livro> Livro { get; set; }
    }
}
