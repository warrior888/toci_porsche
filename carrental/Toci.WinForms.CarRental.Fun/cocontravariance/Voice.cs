namespace Toci.WinForms.CarRental.Fun.cocontravariance
{
    public class Voice<TStream> : IVoice<TStream>
        where TStream : DriverLicenseActionsHandler
    {
        public string Recognize(TStream stream)
        {
            (stream).AddButtons();
            throw new System.NotImplementedException();
        }

        public void test(TStream str)
        {
            throw new System.NotImplementedException();
        }
    }
}