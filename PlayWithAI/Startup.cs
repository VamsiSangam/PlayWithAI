using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(PlayWithAI.Startup))]
namespace PlayWithAI
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
        }
    }
}
