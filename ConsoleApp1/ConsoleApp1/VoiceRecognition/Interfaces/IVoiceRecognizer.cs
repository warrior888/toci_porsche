namespace ConsoleApp1.VoiceRecognition.Interfaces
{
    public interface IVoiceRecognizer<in TStream>
    {
        string Recognize(TStream stream);

    }
}