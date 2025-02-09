using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace PlaySound
{
    public delegate void ArticlesLoadedEventHandler(EventArgs e);

    internal class ArticlesData
    {
        public static event ArticlesLoadedEventHandler ArticlesLoaded;
        public static List<Article> Articles = new List<Article>();

        public static void LoadData(string lesson)
        {
            ReadDataOfOneLesson(lesson);
            ArticlesLoaded?.Invoke(new EventArgs());
        }

        private static void ReadDataOfOneLesson(string lessonNumber)
        {
            try
            {
                XDocument doc = XDocument.Load(@"C:\Code\PlaySound\PlaySound\Articles.xml");
                var activeLesson = doc.Descendants("Lesson").FirstOrDefault(o => o.Attribute("lesson").Value == lessonNumber);
                if (activeLesson != null)
                {
                    Articles.Clear();
                    var desc = activeLesson.Elements();
                    foreach (var e in desc)
                    {
                        var x = e;
                        Article article = new Article();
                        article.HomeLanguageArticle = e.Element("HomeLanguage").Value;
                        article.ForeignLanguageArticle = e.Element("ForeignLanguage").Value;
                        article.SoundFileName = e.Element("SoundFileName").Value;
                        Articles.Add(article);
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
            Articles.Clear();
            Article article = new Article();
            article.ForeignLanguageArticle = "Článek nenačten";
            article.HomeLanguageArticle = "Článek nenačten";
            article.SoundFileName = String.Empty;
            Articles.Add(article);
        }
    }
}
