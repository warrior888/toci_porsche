using System.Diagnostics;

namespace Toci.WinForms.CarRental.Fun
{
    public class DriverLicencseActionClass: DriverLicenseActionsHandler
    {
        public override void AddButtons()
        {
            base.AddButtons();
            Debug.WriteLine("Jestesmy zoveridowani");
        }

        public void TegoNieUruchomimy()
        {

        }
    }
}