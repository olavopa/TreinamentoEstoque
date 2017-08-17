using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TreinamentoEstoque.Startup))]
namespace TreinamentoEstoque
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
