using ProjetoAlarme.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoAlarme.Infra.Data.Context
{
    public class EntityFramework : DbContext
    {
        public EntityFramework():base("ProjetoAlarme")
        {

        }

        public DbSet<Alarme> Alarmes { get; set; }
        public DbSet<AlarmeAtuado> AlarmesAtuados { get; set; }
        public DbSet<Equipamento> Equipamentos { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();
            modelBuilder.Conventions.Remove<ManyToManyCascadeDeleteConvention>();
            modelBuilder.Properties()
                .Where(x => x.Name == x.ReflectedType.Name + "Id")
                .Configure(x => x.IsKey());
        }
    }
}
