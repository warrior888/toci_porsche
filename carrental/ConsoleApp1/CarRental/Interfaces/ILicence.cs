using System;
using System.Collections.Generic;

namespace ConsoleApp1.CarRental.Interfaces
{
    public interface ILicence
    {
        string LicensNumber { get; set; }
        DateTime ExpiredTime { get; set; }
        string Country { get; set; }
    }
}