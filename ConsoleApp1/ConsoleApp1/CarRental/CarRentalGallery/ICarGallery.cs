using System.Collections.Generic;
using ConsoleApp1.CarRental.Interfaces;
using ConsoleApp1.Gallery.Interfaces;

namespace ConsoleApp1.CarRental.CarRentalGallery
{
    public interface ICarGallery<TVehicle, TPhotos, TVideos> // List<IPhoto>
        where TPhotos : IList<IPhoto>
    {
       /* TVehicle Vehicle { get; set; }

        TPhotos Photos { get; set; }

        TVideos Videos { get; set; }*/

        TPhotos GetPhotos(long carId);

        ///hey czy widzisz to co wpisalem :D?
        ///
        /// a no widzę 
        /// 
    }
}