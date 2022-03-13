using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
//tao class de truy cap, update database
namespace ProjectManagement.Model
{
    class DatabaseContext: DbContext
    {
        public DatabaseContext() { }
        
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
        public DbSet<Student> Students { get; set; }
        public DbSet<Teacher> Teachers { get; set; }
        public DbSet <Project> Projects { get; set; }
    }
}
