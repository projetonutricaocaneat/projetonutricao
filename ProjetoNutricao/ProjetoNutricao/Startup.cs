using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ProjetoNutricao.Startup))]
namespace ProjetoNutricao
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
