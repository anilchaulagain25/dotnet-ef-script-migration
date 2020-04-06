using Microsoft.EntityFrameworkCore;
using ScriptMigration.Models;

namespace ScriptMigration.context
{
    public class EfContext : DbContext
    {
        public EfContext(DbContextOptions<EfContext> options ): base(options)
        {
            
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //Seed data in first model [first mig]
            modelBuilder.Entity<FirstModel>().HasData(new FirstModel[]{
                //also edited in second mig [ Name Vue to VueJS ]
                new FirstModel{ Id=1 ,Name="VueJS"}

                //added in second migration and is delted in third migration by just commenting it
                //,new FirstModel{ Id=2 ,Name="Webpack"}


            });


             //Seed data in second model [second mig]
            modelBuilder.Entity<SecondModel>().HasData(new SecondModel[]{
                new SecondModel{ Id=1 ,Name="Shankhu"},
                new SecondModel{ Id=2 ,Name="Bhumethumka"},
            });

            base.OnModelCreating(modelBuilder);
        }
        public DbSet<FirstModel> FirstModel { get; set; }
        public DbSet<SecondModel> SecondModel { get; set; }
    }
}
