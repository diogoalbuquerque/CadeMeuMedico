using System.Web.Mvc;
using System.Web.Routing;

namespace CadeMeuMedico.Areas.Mobile
{
    public class MobileAreaRegistration : AreaRegistration
    {
        public override string AreaName
        {
            get
            {
                return "Mobile";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context)
        {
            context.MapRoute("Mobile", "Mobile/{controller}/{action}/{id}", new { controller = "HomeMobile", action = "Index", id = UrlParameter.Optional });
        }

    }
}