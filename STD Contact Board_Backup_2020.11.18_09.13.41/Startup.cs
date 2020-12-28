using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(STD_Contact_Board.Startup))]
namespace STD_Contact_Board
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
