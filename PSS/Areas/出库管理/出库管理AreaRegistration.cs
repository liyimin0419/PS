using System.Web.Mvc;

namespace PSS.Areas.出库管理
{
    public class 出库管理AreaRegistration : AreaRegistration 
    {
        public override string AreaName 
        {
            get 
            {
                return "出库管理";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context) 
        {
            context.MapRoute(
                "出库管理_default",
                "出库管理/{controller}/{action}/{id}",
                new { action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}