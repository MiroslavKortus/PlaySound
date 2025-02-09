using NAudio.Wave;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace PlaySound
{
    internal class SentencesLearning : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        private const string SOUND_FILES_FOLDER = @"C:\Users\Uzivatel\Documents\Jazyky\Franc\Sound\";
        private int _IndexOfSentencesList = -1;

        public SentencesLearning()
        {
            SentencesData.EmptyLanguageData();
            SetNextSentence();
            SentencesData.SentencesLoaded += Data_SentencesLoaded;
        }

        private void Data_SentencesLoaded(EventArgs e)
        {
            _IndexOfSentencesList = -1;
            SetNextSentence();
        }

        private string _HomeLanguageSentence = "";
        public string HomeLanguageSentence
        {
            get
            {
                return _HomeLanguageSentence;
            }
            private set
            {
                _HomeLanguageSentence = value;
                OnPropertyChanged(nameof(HomeLanguageSentence));
            }
        }

        private string _ForeignLanguageSentence = "";
        public string ForeignLanguageSentence
        {
            get
            {
                return _ForeignLanguageSentence;
            }
            private set
            {
                _ForeignLanguageSentence = value;
                OnPropertyChanged(nameof(ForeignLanguageSentence));
            }
        }

        private string _Comment = "";
        public string Comment
        {
            get
            {
                return _Comment;
            }
            private set
            {
                _Comment = value;
                OnPropertyChanged(nameof(Comment));
            }
        }

        private string _SoundFileName = "";
        public string SoundFileName
        {
            get
            {
                return _SoundFileName;
            }
            private set
            {
                _SoundFileName = value;
                OnPropertyChanged(nameof(SoundFileName));
            }
        }

        protected void OnPropertyChanged(string property)
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(property));
        }

        public void SetPreviousSentence()
        {
            _IndexOfSentencesList--;
            if (_IndexOfSentencesList < 0) { _IndexOfSentencesList = 0; }
            HomeLanguageSentence = SentencesData.Sentences[_IndexOfSentencesList].HomeLanguageSentence;
            ForeignLanguageSentence = "";
            Comment = "";
            SoundFileName = SentencesData.Sentences[_IndexOfSentencesList].SoundFileName;
        }

        public void SetNextSentence()
        {
            _IndexOfSentencesList++;
            if (_IndexOfSentencesList >= SentencesData.Sentences.Count) { _IndexOfSentencesList = SentencesData.Sentences.Count - 1; }
            HomeLanguageSentence = SentencesData.Sentences[_IndexOfSentencesList].HomeLanguageSentence;
            ForeignLanguageSentence = "";
            Comment = "";
            SoundFileName = SentencesData.Sentences[_IndexOfSentencesList].SoundFileName;
        }

        public void DisplayTranslation()
        {
            ForeignLanguageSentence = SentencesData.Sentences[_IndexOfSentencesList].ForeignLanguageSentence;
        }

        public void DisplayComment()
        {
            Comment = SentencesData.Sentences[_IndexOfSentencesList].Comment;
        }

        public void Play()
        {
            WaveOut wave = new WaveOut();
            try
            {
                var x = new AudioFileReader(SOUND_FILES_FOLDER + SentencesData.Sentences[_IndexOfSentencesList].SoundFileName + ".m4a");
                wave.Init(x);
                wave.Play();
            }
            catch (Exception ex) 
            {
                MessageBox.Show("File name: " + SentencesData.Sentences[_IndexOfSentencesList].SoundFileName);
                MessageBox.Show(ex.Message);
            }
        }

    }
}
