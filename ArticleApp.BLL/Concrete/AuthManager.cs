using ArticleApp.Core.Utilities.Security;
using Microsoft.Identity.Client;
using System;
using System.Collections.Generic;
using System.Text;
using ArticleApp.BLL.Abstract;
using Microsoft.Extensions.Options;

namespace ArticleApp.BLL.Concrete
{
    public class AuthManager : IAuthManager
    {
        private readonly IOptions<AuthConfig> _settings;

        public AuthManager(IOptions<AuthConfig> settings)
        {
            _settings = settings;
        }

        public string GetToken()
        {
            AuthConfig config = _settings.Value;

            IConfidentialClientApplication app;

            app = ConfidentialClientApplicationBuilder.Create(config.ClientId)
                .WithClientSecret(config.ClientSecret)
                .WithAuthority(new Uri(config.Authority))
                .Build();

            string[] resourceIds = { config.ResourceID };

            AuthenticationResult result = app.AcquireTokenForClient(resourceIds).ExecuteAsync().GetAwaiter()
                .GetResult();

            return result.AccessToken;
        }
    }
}
