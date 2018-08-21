using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SampleApplicationForPOC.Startup))]
namespace SampleApplicationForPOC
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
