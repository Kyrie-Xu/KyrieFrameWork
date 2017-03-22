using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MyFrameWork.WebMVC.Startup))]
namespace MyFrameWork.WebMVC
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
