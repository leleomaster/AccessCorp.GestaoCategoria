using AccessCorp.GestaoCategoria.Domain;
using AccessCorp.GestaoCategoria.EntityFramework;
using AccessCorp.GestaoCategoria.EntityFramework.Interfaces;

namespace AccessCorp.GestaoCategoria.Repository
{
    public class SubCategoriaRepository : DbContextAccessCorp<SubCategoria>, IUnitOfWork<SubCategoria>
    {
    }
}
