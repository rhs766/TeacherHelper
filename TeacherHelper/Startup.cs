using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TeacherHelper.Startup))]
namespace TeacherHelper
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
