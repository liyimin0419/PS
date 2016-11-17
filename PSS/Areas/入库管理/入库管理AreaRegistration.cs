using System.Web.Mvc;

namespace PSS.Areas.入库管理
{
    public class 入库管理AreaRegistration : AreaRegistration 
    {
        public override string AreaName 
        {
            get 
            {
                return "入库管理";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context) 
        {
            context.MapRoute(
                "入库管理_default",
                "入库管理/{controller}/{action}/{id}",
                new { action = "RKAdd", id = UrlParameter.Optional }
            );
        }
    }
}