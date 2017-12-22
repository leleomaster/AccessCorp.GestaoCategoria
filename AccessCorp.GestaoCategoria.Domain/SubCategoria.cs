using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccessCorp.GestaoCategoria.Domain
{
    public class SubCategoria
    {
        public Guid Id { get; set; }
        public string Nome { get; set; }
        public string  Slug { get; set; }
        public string Descricao { get; set; }
        public Guid CategoriaId { get; set; }
        public Guid CamposId { get; set; }
    }
}
