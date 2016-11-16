using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(BodyTune.Startup))]
namespace BodyTune
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
