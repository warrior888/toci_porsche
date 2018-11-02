using System;
using System.IO;
using System.Text;
using ConsoleApp1.VoiceRecognition.Interfaces;
using Google.Cloud.Speech.V1;
using Google.Protobuf;
using Grpc.Core;
using CodedOutputStream = Google.Protobuf.CodedOutputStream;

namespace ConsoleApp1.VoiceRecognition
{
    public class VoiceRecognizer : IVoiceRecognizer<byte[]>
    {
        public string Recognize(byte[] stream)
        {
            string messageresult = string.Empty;
            try
            {
                
                var speech = SpeechClient.Create();

                var response = speech.Recognize(new RecognitionConfig()
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
                        messageresult += (alternative.Transcript);
                    }
                }

                return messageresult;
            }
            catch (Exception e)
            {
                if (e.InnerException != null)
                {
                    messageresult += e.InnerException.Message;
                    if (e.InnerException.InnerException != null)
                    {
                        messageresult += e.InnerException.InnerException.Message;
                        if (e.InnerException.InnerException.InnerException != null)
                        {
                            messageresult += e.InnerException.InnerException.InnerException.Message;
                        }
                    }
                }
                 messageresult += e.Message;
                return messageresult;
            }
            
            
            


            
        }
    }
}