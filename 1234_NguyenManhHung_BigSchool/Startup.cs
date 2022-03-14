using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(_1234_NguyenManhHung_BigSchool.Startup))]
namespace _1234_NguyenManhHung_BigSchool
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
