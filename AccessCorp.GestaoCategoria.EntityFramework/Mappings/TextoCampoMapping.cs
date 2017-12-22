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
    public class TextoCampoMapping : EntityTypeConfiguration<TextoCampo>, IMapping
    {
        public TextoCampoMapping()
        {
            ToTable("TEXTO_CAMPOS");
            HasKey(x => x.Id);

            Property(x => x.Id).HasColumnName("ID");
            Property(x => x.Texto).HasColumnName("TEXTO").HasMaxLength(40);            

            HasMany(x => x.Campos).WithOptional().HasForeignKey(x => x.TextoCampoId);
        }
    }
}
