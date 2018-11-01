using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Speech.Recognition;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ConsoleApp1.VoiceRecognition;
using LibP2P.Utilities.Extensions;
using Toci.CarRental.Dal.EF;
using Un4seen.Bass;
using System.Runtime.InteropServices;
using System.Speech.AudioFormat;
using ConsoleApp1.CarRental;

namespace Toci.WinForms.CarRental.Fun
{
    public partial class Form1 : Form
    {
        System.Speech.Recognition.SpeechRecognitionEngine engine = new SpeechRecognitionEngine();
        private RecognitionResult res;
        // DataModel
        carrentalEntities ent = new carrentalEntities();
        
   
        int topVariable = 20;

        public Form1()
        {
            ICollection<string> lic  = ent.driverslicensecategory.Select(x => x.name.ToString()).ToList();
            InitializeComponent();

            foreach (var item in lic)
            {
                Button b = AddButton(item, topVariable, 20);
                this.Controls.Add(b);
                topVariable += 20;
            }
        }
        private Button AddButton(string licence, int top,int left)
        {
            Button but = new Button();
            but.Text = licence;
            but.Top = top;
            but.Left= left;
            return but;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            //System.Speech.Recognition.SpeechUI sp = new SpeechUI();
            //BASSInput bip = Bass.BASS_RecordGetInput(-1);

            //Assembly.LoadFile("C:\\Windows\\SysWOW64\\winmm.dll");

            
            engine.LoadGrammar(new DictationGrammar());
            engine.SetInputToDefaultAudioDevice();
            engine.SpeechRecognized += Engine_RecognizeCompleted;
           // engine.RecognizeCompleted += Engine_RecognizeCompleted;
            engine.RecognizeAsync(RecognizeMode.Multiple);
            
        }

        private void Engine_RecognizeCompleted(object sender, SpeechRecognizedEventArgs e)
        {
            VoiceRecognizer wr = new VoiceRecognizer();

            FieldInfo f = e.Result.Audio.GetType().GetField("_rawAudioData", BindingFlags.Instance | BindingFlags.NonPublic);

            string message = wr.Recognize((byte[])f.GetValue(e.Result.Audio));

            button1.Text = message;
        }

        private void button2_Click(object sender, EventArgs e)
        {
   
           

            List<int> input = new List<int>();

            Stream str =  new FileStream("c:\\mic.wav", FileMode.Open);

            int b;

            while ((b = str.ReadByte()) != -1)
            {
                input.Add(b);
            }

            
            //bip.SerializeToBytes();

            
        }
    }
}
