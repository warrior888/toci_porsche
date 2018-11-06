using System;
using System.Linq;
using System.Reflection;
using System.Speech.Recognition;
using ConsoleApp1.Gallery.Interfaces;
using ConsoleApp1.VoiceRecognition;
using Google.Cloud.Speech.V1;
using Newtonsoft.Json.Serialization;
using SharpLearning.Neural;
using Toci.CarRental.Dal.EF;

namespace ConsoleApp1.Gallery
{
    public class Dummy
    {
        System.Speech.Recognition.SpeechRecognitionEngine sre = new SpeechRecognitionEngine();

        public void ReflectionIndependentInjection()
        {
            rentaloption ro = new rentaloption();

            var properties = ro.GetType().GetProperties();

            string code = "";
            foreach (var property in properties)
            {
                code += "entity." + property.Name + " = " + ";"+  Environment.NewLine;
            }


            IVideo Holidays = Dependencyresolver.Resolve<IVideo>();//new Video(/*resolve*/ (IExif)(Dependencyresolver.Resolve<IExif>()));


            sre.LoadGrammar(new DictationGrammar());
            /*sre.SetInputToDefaultAudioDevice();

            

            sre.SpeechRecognized += Engine_RecognizeCompleted;

            sre.RecognizeAsync();*/

            //SharpLearning.Neural.NeuralNetLearner l = new NeuralNetLearner(new NeuralNet(), );

           //Type typ = Assembly.GetExecutingAssembly().GetTypes().Where(t => t.Name == "IExif").First().DeclaringType;
            //Activator.CreateInstance<IExif>();

        }

        private void Engine_RecognizeCompleted(object sender, SpeechRecognizedEventArgs e)
        {

            string tetx = e.Result.Text;
            FieldInfo f = e.Result.Audio.GetType().GetField("_rawAudioData", BindingFlags.Instance | BindingFlags.NonPublic);
            f.SetValue(e.Result.Audio, 1);
  
        }
    }
}