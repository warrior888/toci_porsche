using System.IO;
using System.Text;
using ConsoleApp1.VoiceRecognition.Interfaces;
using Google.Cloud.Speech.V1;
using Google.Protobuf;
using CodedOutputStream = Google.Protobuf.CodedOutputStream;

namespace ConsoleApp1.VoiceRecognition
{
    public class VoiceRecognizer : IVoiceRecognizer<byte[]>
    {
        public string Recognize(byte[] stream)
        {
            MemoryStream output = new MemoryStream();
            CodedOutputStream cos = new CodedOutputStream(output);
            RecognitionAudio rr =  Google.Cloud.Speech.V1.RecognitionAudio.FromBytes(stream);
           // rr.Content
            return cos.ToString();

           // return Encoding.UTF8.GetString(r.Content.ToByteArray());
        }
    }
}