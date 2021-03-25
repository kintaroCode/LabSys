using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace Entidades
{
    public partial class ModeloLaboratorio : DbContext
    {
        public ModeloLaboratorio()
            : base("name=ModeloLaboratorio1")
        {
        }

        public virtual DbSet<ProtocolosResultados> ProtocolosResultados { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ProtocolosResultados>()
                .Property(e => e.DNI)
                .IsFixedLength();

            modelBuilder.Entity<ProtocolosResultados>()
                .Property(e => e.Sexo)
                .IsFixedLength()
                .IsUnicode(false);
        }
    }
}
