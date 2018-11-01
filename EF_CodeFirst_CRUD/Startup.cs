using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(EF_CodeFirst_CRUD.Startup))]
namespace EF_CodeFirst_CRUD
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
