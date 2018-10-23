namespace ConsoleApp1.Gallery.Interfaces
{
    public interface IPhoto : IFile
    {
        IExif Exif { get; set; }
    }
}