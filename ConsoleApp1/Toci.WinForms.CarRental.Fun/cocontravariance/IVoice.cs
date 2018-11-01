using ConsoleApp1.VoiceRecognition.Interfaces;

namespace Toci.WinForms.CarRental.Fun.cocontravariance
{
    public interface IVoice<in TStream> : IVoiceRecognizer<TStream>
        //where TStream : DriverLicencseActionClass
    {
        void test(TStream str);
    }
}