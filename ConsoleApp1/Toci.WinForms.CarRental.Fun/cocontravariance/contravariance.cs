using System;
using System.Collections.Generic;

namespace Toci.WinForms.CarRental.Fun.cocontravariance
{
    public class contravariance
    {
        public void test()
        {
            //IVoice<DriverLicenseActionsHandler> DriverLicencseAction = new Voice<DriverLicenseActionsHandler>();
           // IVoice<DriverLicencseActionClass> DriverLicencseAction = new Voice<DriverLicencseActionClass>();
           // DriverLicencseAction.test(new DriverLicenseActionsHandler());
           // DriverLicencseAction.test(new DriverLicencseActionClass());

            IVoice<DriverLicencseActionClass> s = new Voice<DriverLicenseActionsHandler>();

            //s.Recognize(new DriverLicencseActionClass());

            //Ss.test(new DriverLicenseActionsHandler());

            Dictionary<string, Func<DriverLicenseActionsHandler>> hdgfey = new Dictionary<string, Func<DriverLicenseActionsHandler>>()
            {
                {
                    "fdsg", () => new DriverLicencseActionClass()
                }
            };


            IEnumerable<DriverLicenseActionsHandler> ddfa = new List<DriverLicencseActionClass>();
        }
    }
}