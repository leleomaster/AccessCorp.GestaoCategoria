using AccessCorp.GestaoCategoria.Domain;
using AccessCorp.GestaoCategoria.EntityFramework;
using AccessCorp.GestaoCategoria.EntityFramework.Interfaces;

namespace AccessCorp.GestaoCategoria.Repository
{
    public class CategoriaRepository : DbContextAccessCorp<Categoria>, IUnitOfWork<Categoria>
    {
    }
}
