using System.Globalization;

namespace ArticleApp.Core.Utilities.Security
{
    public class AuthConfig
    {
        public string Instance { get; set; } =
            "https://login.microsoftonline.com/{0}";

        public string TenantId { get; set; }
        public string ClientId { get; set; }

        public string Authority =>
            string.Format(CultureInfo.InvariantCulture,
                Instance, TenantId);

        public string ClientSecret { get; set; }
        public string BaseAddress { get; set; }
        public string ResourceID { get; set; }
    }
}
