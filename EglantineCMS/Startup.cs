using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(EglantineCMS.Startup))]
namespace EglantineCMS
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
