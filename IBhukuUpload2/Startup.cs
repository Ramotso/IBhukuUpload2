using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(IBhukuUpload2.Startup))]
namespace IBhukuUpload2
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
