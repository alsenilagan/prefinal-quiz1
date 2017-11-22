using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(PreFinalQuiz1_IlaganAM.Startup))]
namespace PreFinalQuiz1_IlaganAM
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
