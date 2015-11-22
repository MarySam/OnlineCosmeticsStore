using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(OnlineCosmeticsStoreUI.Startup))]
namespace OnlineCosmeticsStoreUI
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
