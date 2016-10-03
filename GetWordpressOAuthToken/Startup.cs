using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(GetWordpressOAuthToken.Startup))]
namespace GetWordpressOAuthToken
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
