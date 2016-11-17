using System.Web.Mvc;

namespace PSS.Areas.库存管理
{
    public class 库存管理AreaRegistration : AreaRegistration 
    {
        public override string AreaName 
        {
            get 
            {
                return "库存管理";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context) 
        {
            context.MapRoute(
                "库存管理_default",
                "库存管理/{controller}/{action}/{id}",
                new { action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}