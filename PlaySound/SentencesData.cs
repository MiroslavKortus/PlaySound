using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace PlaySound
{
    public delegate void SentencesLoadedEventHandler (EventArgs e);

    internal static class SentencesData
    {
        public static event SentencesLoadedEventHandler SentencesLoaded;
        public static List<Sentence> Sentences = new List<Sentence>();

        public static void LoadData(string lesson)
        {
            ReadDataOfOneLesson(lesson);
            SentencesLoaded?.Invoke(new EventArgs());
        }

        private static void ReadDataOfOneLesson(string lessonNumber)
        {
            try
            {
                XDocument doc = XDocument.Load(@"C:\Code\PlaySound\PlaySound\Sentences.xml");
                var activeLesson = doc.Descendants("Lesson").FirstOrDefault(o => o.Attribute("lesson").Value == lessonNumber);
                if (activeLesson != null)
                {
                    Sentences.Clear();
                    var desc = activeLesson.Elements();
                    foreach (var e in desc)
                    {
                        var x = e;
                        Sentence sentence = new Sentence();
                        sentence.HomeLanguageSentence = e.Element("HomeLanguage").Value;
                        sentence.ForeignLanguageSentence = e.Element("ForeignLanguage").Value;
                        sentence.SoundFileName = e.Element("SoundFileName").Value;
                        sentence.Comment = e.Element("Comment").Value;
                        Sentences.Add(sentence);
                    }
                }
                else
                {
                    EmptyLanguageData();
                }
            }
            catch
            {
                MessageBox.Show($"Lekci {lessonNumber} se nepodařilo načíst.");
                EmptyLanguageData();
            }
        }

        internal static void EmptyLanguageData()
        {
            Sentences.Clear();
            Sentence sentence = new Sentence();
            sentence.ForeignLanguageSentence = "Lekce nenačtena";
            sentence.HomeLanguageSentence = "Lekce nenačtena";
            sentence.SoundFileName = String.Empty;
            Sentences.Add(sentence);
        }

    }
}
