using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(VSTSWithGit.Startup))]
namespace VSTSWithGit
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
