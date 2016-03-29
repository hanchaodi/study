using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(_6._1_Server_Side_Validation.Startup))]
namespace _6._1_Server_Side_Validation
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
