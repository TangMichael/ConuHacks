using System;
using Google.Cloud.Translation.V2;

namespace api
{
    public class Translator
    {


        public Translator()
        { }

            public string translateEnglish(string txt)
            {
                    Console.OutputEncoding = System.Text.Encoding.Unicode;
            TranslationClient client = TranslationClient.Create();
                var response = client.TranslateText("Bonjour.", "en");
                return response.TranslatedText;
            }

        public string translateFrench(string txt)
        {
            Console.OutputEncoding = System.Text.Encoding.Unicode;
            TranslationClient client = TranslationClient.Create();
            var response = client.TranslateText("Hello World.", "fr");
            return response.TranslatedText;
        }


    
    }
}
