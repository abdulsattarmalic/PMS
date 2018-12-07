using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(App_Project.Startup))]
namespace App_Project
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
