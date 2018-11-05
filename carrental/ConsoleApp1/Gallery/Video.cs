using ConsoleApp1.Gallery.Interfaces;

namespace ConsoleApp1.Gallery
{
    public class Video : IVideo
    {
        public string Base64 { get; set; }
        public long Id { get; set; }
        public IExif Exif { get; set; }

        public Video(IExif exif)
        {
            Exif = exif;
        }

        public virtual void Accept()
        {
            var test = Exif.Location;
        }
    }
}