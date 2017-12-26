using AccessCorp.GestaoCategoria.Domain;
using AccessCorp.GestaoCategoria.EntityFramework;
using AccessCorp.GestaoCategoria.EntityFramework.Interfaces;

namespace AccessCorp.GestaoCategoria.Repository
{
    public class CamposRepository : DbContextAccessCorp<Campos>, IUnitOfWork<Campos>
    {
    }
}
