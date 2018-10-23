namespace ConsoleApp1.Gallery.Interfaces
{
    public interface IVideo : IFile
    {
        IExif Exif { get; set; }

    }
}