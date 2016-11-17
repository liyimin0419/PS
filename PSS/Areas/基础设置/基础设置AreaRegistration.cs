using System.Web.Mvc;

namespace PSS.Areas.基础设置
{
    public class 基础设置AreaRegistration : AreaRegistration 
    {
        public override string AreaName 
        {
            get 
            {
                return "基础设置";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context) 
        {
            context.MapRoute(
                "基础设置_default",
                "基础设置/{controller}/{action}/{id}",
                new { action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}