﻿using AccessCorp.GestaoCategoria.Domain;
using AccessCorp.GestaoCategoria.EntityFramework.Interfaces;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccessCorp.GestaoCategoria.EntityFramework.Mappings
{
    public class SubCategoriaMapping : EntityTypeConfiguration<SubCategoria>, IMapping
    {
        public SubCategoriaMapping()
        {
            ToTable("SUB_CATEGORIA");

            HasKey(x => x.Id);

            Property(x => x.Id).HasColumnName("ID");
            Property(x => x.Nome).HasColumnName("NOME").IsRequired().HasMaxLength(40);
            Property(x => x.Slug).HasColumnName("SLUG").IsRequired().HasMaxLength(350);
            Property(x => x.Descricao).HasColumnName("DESCRICAO").HasMaxLength(100);
            
        }
    }
}
