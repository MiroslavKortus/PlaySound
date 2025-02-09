using NAudio.Wave;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlaySound
{
    internal class ArticlesLearning : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        private const string SOUND_FILES_FOLDER = @"C:\Users\Uzivatel\Documents\Jazyky\Franc\Sound\";
        private int _IndexOfArticlesList = -1;

        public ArticlesLearning()
        {
            ArticlesData.EmptyLanguageData();
            SetNextArticle();
            ArticlesData.ArticlesLoaded += Data_ArticlesLoaded;
        }

        private void Data_ArticlesLoaded(EventArgs e)
        {
            _IndexOfArticlesList = -1;
            SetNextArticle();
        }

        private string[] _HomeLanguageArticle = new string[0];
        public string[] HomeLanguageArticle
        {
            get
            {
                return _HomeLanguageArticle;
            }
            private set
            {
                _HomeLanguageArticle = value;
                OnPropertyChanged(nameof(HomeLanguageArticle));
            }
        }

        //private string _HomeLanguageArticle;
        //public string HomeLanguageArticle
        //{
        //    get
        //    {
        //        return _HomeLanguageArticle;
        //    }
        //    private set
        //    {
        //        _HomeLanguageArticle = value;
        //        OnPropertyChanged(nameof(HomeLanguageArticle));
        //    }
        //}

        private string[] _ForeignLanguageArticle = new string[0];
        public string[] ForeignLanguageArticle
        {
            get
            {
                return _ForeignLanguageArticle;
            }
            private set
            {
                _ForeignLanguageArticle = value;
                OnPropertyChanged(nameof(ForeignLanguageArticle));
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

        public void SetPreviousArticle()
        {
            _IndexOfArticlesList--;
            if (_IndexOfArticlesList < 0) { _IndexOfArticlesList = 0; }
            HomeLanguageArticle = ArticlesData.Articles[_IndexOfArticlesList].HomeLanguageArticle.Split("\n");
            //HomeLanguageArticle = ArticlesData.Articles[_IndexOfArticlesList].HomeLanguageArticle;
            ForeignLanguageArticle = ArticlesData.Articles[_IndexOfArticlesList].ForeignLanguageArticle.Split("\n");
            SoundFileName = SentencesData.Sentences[_IndexOfArticlesList].SoundFileName;
        }

        public void SetNextArticle()
        {
            _IndexOfArticlesList++;
            if (_IndexOfArticlesList >= ArticlesData.Articles.Count) { _IndexOfArticlesList = ArticlesData.Articles.Count - 1; }
            HomeLanguageArticle = ArticlesData.Articles[_IndexOfArticlesList].HomeLanguageArticle.Split("\n");
            //HomeLanguageArticle = ArticlesData.Articles[_IndexOfArticlesList].HomeLanguageArticle;
            ForeignLanguageArticle = ArticlesData.Articles[_IndexOfArticlesList].ForeignLanguageArticle.Split("\n");
            SoundFileName = ArticlesData.Articles[_IndexOfArticlesList].SoundFileName;
        }

        public void Play()
        {
            WaveOut wave = new WaveOut();
            try
            {
                var x = new AudioFileReader(SOUND_FILES_FOLDER + ArticlesData.Articles[_IndexOfArticlesList].SoundFileName + ".m4a");
                wave.Init(x);
                wave.Play();
            }
            catch (Exception ex)
            {
                MessageBox.Show("File name: " + SentencesData.Sentences[_IndexOfArticlesList].SoundFileName);
                MessageBox.Show(ex.Message);
            }
        }

    }
}
