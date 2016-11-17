using System.Web.Mvc;

namespace PSS.Areas.系统管理
{
    public class 系统管理AreaRegistration : AreaRegistration 
    {
        public override string AreaName 
        {
            get 
            {
                return "系统管理";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context) 
        {
            context.MapRoute(
                "系统管理_default",
                "系统管理/{controller}/{action}/{id}",
                new { action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}