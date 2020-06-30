using Microsoft.Extensions.DependencyInjection;

namespace ArticleApp.Core.Utilities.IoC
{
    public interface ICoreModule
    {
        void Load(IServiceCollection collection);
    }
}
