using AccessCorp.GestaoCategoria.Service;
using AccessCorp.GestaoCategoria.Service.Interfaces;
using Ninject;

namespace AccessCorp.GestaoCategoria.IoC
{
    public static class ServiceModule
    {
        public static void Bind(IKernel kernel)
        {
            kernel.Bind<ITextoCampoService>().To<TextoCampoService>();
            kernel.Bind<ICamposService>().To<CamposService>();
            kernel.Bind<ICategoriaService>().To<CategoriaService>();
            kernel.Bind<ISubCategoriaService>().To<SubCategoriaService>();
        }
    }
}
