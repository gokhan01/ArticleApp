using ArticleApp.BLL.Abstract;
using ArticleApp.BLL.Concrete;
using Autofac;

namespace ArticleApp.BLL.DependencyResolvers.Autofac
{
    public class AutofacBusinessModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<AuthManager>().As<IAuthManager>();
        }
    }
}
