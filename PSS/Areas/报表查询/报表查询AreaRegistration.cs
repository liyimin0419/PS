using System.Web.Mvc;

namespace PSS.Areas.报表查询
{
    public class 报表查询AreaRegistration : AreaRegistration 
    {
        public override string AreaName 
        {
            get 
            {
                return "报表查询";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context) 
        {
            context.MapRoute(
                "报表查询_default",
                "报表查询/{controller}/{action}/{id}",
                new { action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}