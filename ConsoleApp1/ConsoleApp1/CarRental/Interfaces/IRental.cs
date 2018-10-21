﻿using System;
using ConsoleApp1.CarRental.Interfaces.Geography;

namespace ConsoleApp1.CarRental.Interfaces
{
    public interface IRental
    {
        IRentalOptions Options { get; set; }

        DateTime StartDate { get; set; }

        DateTime EndDate { get; set; }

        ILocation VehicleRetrivalLocation { get; set; }

        ILocation VehicleReturnLocation { get; set; }


    }
}