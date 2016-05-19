using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MVCMovies.Startup))]
namespace MVCMovies
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
