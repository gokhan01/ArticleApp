using System;
using System.Collections.Generic;
using System.Text;
using ArticleApp.Core.Utilities.IoC;
using Microsoft.Extensions.DependencyInjection;

namespace ArticleApp.Core.DependencyResolvers
{
    public class CoreModule : ICoreModule
    {
        public void Load(IServiceCollection services)
        {
            //services.AddMemoryCache();
            //services.AddSingleton<ICacheManager, MemoryCacheManager>();
        }
    }
}
