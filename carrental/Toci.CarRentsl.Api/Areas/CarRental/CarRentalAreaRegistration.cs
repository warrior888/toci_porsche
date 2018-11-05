using System.Web.Mvc;

namespace Toci.CarRentsl.Api.Areas.CarRental
{
    public class CarRentalAreaRegistration : AreaRegistration 
    {
        public override string AreaName 
        {
            get 
            {
                return "CarRental";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context) 
        {
            context.MapRoute(
                "CarRental_default",
                "CarRental/{controller}/{action}/{id}",
                new { area = "CarRental", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}