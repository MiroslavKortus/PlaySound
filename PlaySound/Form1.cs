using NAudio.Wave;
using NAudio.Wave.SampleProviders;
using System.Drawing;
using System.Xml.Linq;

namespace PlaySound
{
    public partial class Form1 : Form
    {
        private SentencesLearning _SentencesLearning;
        private ArticlesLearning _ArticleLearning;

        public Form1()
        {
            InitializeComponent();
            _SentencesLearning = new SentencesLearning();
            _ArticleLearning = new ArticlesLearning();

            lblHomeLanguageSentence.DataBindings.Add("Text", _SentencesLearning, "HomeLanguageSentence");
            lblForeignLanguageSentence.DataBindings.Add("Text", _SentencesLearning, "ForeignLanguageSentence");
            lblSoundFileName.DataBindings.Add("Text", _SentencesLearning, "SoundFileName");
            lblComment.DataBindings.Add("Text", _SentencesLearning, "Comment");

            txtHomeLanguage.DataBindings.Add("Lines", _ArticleLearning, "HomeLanguageArticle");
            txtForeignLanguage.DataBindings.Add("Lines", _ArticleLearning, "ForeignLanguageArticle");
        }
        /*
        private void _SentencesLearning_PropertyChanged(object? sender, System.ComponentModel.PropertyChangedEventArgs e)
        {
            throw new NotImplementedException();
        }*/

        private void LoadLessonData()
        {
            if (_SentencesLearning != null)
            {
                SentencesData.LoadData(numUpDnLessonNumber.Value.ToString("00"));
            }
            if (_ArticleLearning != null)
            {
                ArticlesData.LoadData(numUpDnLessonNumber.Value.ToString("00"));
            }
        }

        private void btnLoadLessonData_Click(object sender, EventArgs e)
        {
            LoadLessonData();
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            _SentencesLearning?.SetPreviousSentence();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            _SentencesLearning?.SetNextSentence();
        }

        private void btnDisplayTranslation_Click(object sender, EventArgs e)
        {
            _SentencesLearning?.DisplayTranslation();
            _SentencesLearning?.DisplayComment();
        }

        private void btnPlaySentence_Click(object sender, EventArgs e)
        {
            _SentencesLearning.Play();
        }

        private void btnPlayArticle_Click(object sender, EventArgs e)
        {
            _ArticleLearning.Play();
        }

        private void numUpDnLessonNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\r')
            {
                LoadLessonData();
            }
        }
    }
}