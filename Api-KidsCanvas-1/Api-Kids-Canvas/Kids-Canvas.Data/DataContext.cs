using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Kids_Canvas.Core.Entities;

namespace Kids_Canvas.Data
{
    public class DataContext: DbContext
    {
        public DbSet<User> Users { get; set; }

        public DbSet<Category> Categories { get; set; }

        public DbSet<Drowings> Drowings { get; set; }

        public DbSet<Comments> Comments { get; set; }

        public DbSet<Favorite_Drowings> FavoriteDrowings { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\MSSQLLocalDB;Database=Kids_Canvas_Db");
        }
    }
}
