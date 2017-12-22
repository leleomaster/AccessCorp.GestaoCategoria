using AccessCorp.GestaoCategoria.Domain.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccessCorp.GestaoCategoria.Domain
{
    public class Campos
    {
        public Guid Id { get; set; }
        public Guid SubCategoriaId { get; set; }
        public TipoCampos TipoCampo { get; set; }
        public short Ordem { get; set; }
        public bool Obrigatorio { get; set; }
        public Guid TextoCampoId { get; set; }
    }
}
