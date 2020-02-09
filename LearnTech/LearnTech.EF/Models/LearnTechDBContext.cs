using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Text;

namespace LearnTech.EF.Models
{
    public class LearnTechDBContext : DbContext
    {
        public LearnTechDBContext(): base("name = LearnTechConnectionstring")
        {
            Database.SetInitializer(new CreateDatabaseIfNotExists<LearnTechDBContext>());
        }

        public DbSet<Student> Students { get; set; }
        public DbSet<Grade> Grades { get; set; }
    }
}
