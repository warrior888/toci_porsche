using System;
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
            try
            {
                var speech = SpeechClient.Create();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
            
            /*var response = speech.Recognize(new RecognitionConfig()
            {
                Encoding = RecognitionConfig.Types.AudioEncoding.Linear16,
                SampleRateHertz = 16000,
                LanguageCode = "pl",
            }, RecognitionAudio.FromBytes(stream));

            string resultMsg = string.Empty;

            foreach (var result in response.Results)
            {
                foreach (var alternative in result.Alternatives)
                {
                    resultMsg += (alternative.Transcript);
                }
            }
            */


            return "";//resultMsg;
        }
    }
}