using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace quest14._1
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> russianToEnglishDictionary = new Dictionary<string, string>()
            {
                {"солнце", "sun"},
                {"дождь", "rain"},
                {"ветер", "wind"},
                {"снег", "snow"},
                {"туман", "fog"},
                {"гроза", "thunderstorm"},
                {"облачно", "cloudy"},
                {"тепло", "warm"},
                {"холодно", "cold"},
                {"влажность", "humidity"}
            };

            Dictionary<string, string> russianToUkrainianDictionary = new Dictionary<string, string>()
            {
                {"сонце", "сонце"},
                {"дощ", "дощ"},
                {"вітер", "вітер"},
                {"сніг", "сніг"},
                {"туман", "туман"},
                {"гроза", "гроза"},
                {"хмарно", "хмарно"},
                {"тепло", "тепло"},
                {"холодно", "холодно"},
                {"вологість", "вологість"}
            };

            Console.WriteLine("Введите слово на русском языке:");
            string input = Console.ReadLine();

            string translation = Translate(input, russianToEnglishDictionary);
            if (translation != null)
            {
                Console.WriteLine($"Английский перевод: {translation}");
            }
            else
            {
                translation = Translate(input, russianToUkrainianDictionary);
                if (translation != null)
                {
                    Console.WriteLine($"Украинский перевод: {translation}");
                }
                else
                {
                    Console.WriteLine("Такого слова нет в словаре.");
                }
            }

            Console.ReadLine();
        }

        static string Translate(string word, Dictionary<string, string> dictionary)
        {
            if (dictionary.ContainsKey(word))
            {
                return dictionary[word];
            }
            else
            {
                return null;
            }
        }
    }
}
