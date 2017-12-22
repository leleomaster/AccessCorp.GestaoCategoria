using AccessCorp.GestaoCategoria.Domain;
using AccessCorp.GestaoCategoria.EntityFramework.Interfaces;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccessCorp.GestaoCategoria.EntityFramework.Mappings
{
    public class CamposMapping : EntityTypeConfiguration<Campos>, IMapping
    {
        public CamposMapping()
        {
            HasKey(x => x.Id);

            Property(x => x.Id).HasColumnName("ID");
            Property(x => x.Obrigatorio).IsRequired().HasColumnName("OBRIGATORIO").IsRequired();
            Property(x => x.Ordem).IsRequired().HasColumnName("ORDEM").IsRequired();
            Property(x => x.TipoCampo).IsRequired().HasColumnName("TIPOCAMPO").IsRequired();

        }
    }
}
