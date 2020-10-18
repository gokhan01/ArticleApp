using Autofac;

namespace ArticleApp.BLL.DependencyResolvers.Autofac
{
    public class AutofacBusinessModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            var assembly = System.Reflection.Assembly.GetExecutingAssembly();

            //builder.RegisterAssemblyTypes(System.Reflection.Assembly.Load("DataAccess"))
            //    .Where(type => type.Namespace.Contains("Repositories"))
            //    .AsImplementedInterfaces();

            builder.RegisterAssemblyTypes(assembly)
                .Where(type => type.Namespace.Contains("Concrete"))
                .AsImplementedInterfaces();
        }
    }
}
