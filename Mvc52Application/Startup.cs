using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Mvc52Application.Startup))]
namespace Mvc52Application
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
