using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft;
using System.Windows.Forms;
using System.Speech.Recognition;
using System.Speech.Synthesis;
using System.Speech.AudioFormat;
using System.IO;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace Voice_Assistant_Cyrus
{


    public partial class Form1 : Form
    {
        SpeechRecognitionEngine _recognize = new SpeechRecognitionEngine();
        SpeechSynthesizer ghost = new SpeechSynthesizer();//name of Voice Assistant

        SpeechRecognitionEngine listen = new SpeechRecognitionEngine();
        Random rnd = new Random();
        int rto = 0;// Record Time
        DateTime time = DateTime.Now;

        
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            _recognize.SetInputToDefaultAudioDevice();
            _recognize.LoadGrammarAsync(new Grammar(new GrammarBuilder(new Choices(File.ReadAllLines(@"Commands.txt")))));//Commands for Voice Assistant
            _recognize.SpeechRecognized += new EventHandler<SpeechRecognizedEventArgs>(SpeechR);
            _recognize.SpeechDetected += new EventHandler<SpeechDetectedEventArgs>(_recognize_SpeechR);
            _recognize.RecognizeAsync(RecognizeMode.Multiple);


            listen.SetInputToDefaultAudioDevice();
            listen.LoadGrammarAsync(new Grammar(new GrammarBuilder(new Choices(File.ReadAllLines(@"Commands.txt")))));
            listen.SpeechRecognized += new EventHandler<SpeechRecognizedEventArgs>(listen_SpeechR);

        }

        private void SpeechR(object sender, SpeechRecognizedEventArgs e)
        {
            

            int numR;
            string speech = e.Result.Text;

            if(speech == "Hello")//ghost
            {
                ghost.SpeakAsync("Hello, I am ghost");
            }
            if(speech == "How are you")
            {
                ghost.SpeakAsync("I am doing great, What can I do for you?");
            }
            if(speech == "Time")
            {
                ghost.SpeakAsync(DateTime.Now.ToString("h mm"));
            }
            if (speech == "Hush")
            {
                ghost.SpeakAsyncCancelAll();
                numR = rnd.Next(1,2);
                if (numR == 1)
                {
                    ghost.SpeakAsync("standing By");
                }
                if(numR==2)
                {
                    ghost.SpeakAsync("I will wait");
                }
            }
            if (speech == "sleep")
            {
                ghost.SpeakAsync("sure thing");
                _recognize.RecognizeAsyncCancel();
                listen.RecognizeAsync(RecognizeMode.Multiple);
            }
            if (speech == "Show commands")
            {
                string[] commands = (File.ReadAllLines(@"Commands.txt"));
                cmdBox.Items.Clear();
                cmdBox.SelectionMode = SelectionMode.None;
                cmdBox.Visible = true;
                foreach(string command in commands)
                {
                    cmdBox.Items.Add(command);
                }
                
            }
            if (speech == "Hide commands")
            {
                cmdBox.Visible = false;
            }
            /*
            //*any extra command* please, add to the file (Commands.txt)
            //ghost command
            if(speech == "")
            {
                ghost.SpeakAsync("");
            }

            */
        }
        private void _recognize_SpeechR(object sender, SpeechDetectedEventArgs e)
        {
            rto = 0;
        }
        private void listen_SpeechR(object sender, SpeechRecognizedEventArgs e)
        {
           string speech = e.Result.Text;
            if (speech == "Wake up")
            {
                listen.RecognizeAsyncCancel();
                ghost.SpeakAsync("huh, Oh sorry I'm listening");
                _recognize.RecognizeAsync(RecognizeMode.Multiple);
            }
        }

        private void TSpeech_Tick(object sender, EventArgs e)
        {
            if (rto == 10)
            {
                _recognize.RecognizeAsyncCancel();
            }
            else if (rto == 11)
            {
                TSpeech.Stop();
                listen.RecognizeAsync(RecognizeMode.Multiple);
                rto = 0;
            }
        }
    }
}
