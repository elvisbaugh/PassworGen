using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(PasswordGeneratorApp.Startup))]
namespace PasswordGeneratorApp
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
