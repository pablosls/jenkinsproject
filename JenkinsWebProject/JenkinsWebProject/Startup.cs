using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(JenkinsWebProject.Startup))]
namespace JenkinsWebProject
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
