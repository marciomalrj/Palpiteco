using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Palpiteco.Startup))]
namespace Palpiteco
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            //ConfigureAuth(app);
        }
    }
}
