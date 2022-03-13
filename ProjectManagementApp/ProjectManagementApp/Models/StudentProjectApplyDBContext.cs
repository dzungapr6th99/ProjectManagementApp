using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
//Tao quan he nhieu nhieu giua sinh vien va project
namespace ProjectManagement.Model
{
    class StudentProjectApplyDBContext:DbContext
    {
        public DbSet<Student> Students { get; set; }
        public DbSet<Project> Projects { get; set; }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}
