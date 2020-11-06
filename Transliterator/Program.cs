using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using System.Globalization;


namespace Transliterator
{

    static class Program
    {

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
        public enum TransliterationType
        {
            PASSPORT
        }

        public static class Transliteration
        {
            private static Dictionary<string, string> PASSPORT = new Dictionary<string, string>(); //PASSPORT 1997
            public static string Front(string text)
            {
                return Front(text, TransliterationType.PASSPORT);
            }
            public static string Front(string text, TransliterationType type)
            {
                string output = text;

                output = Regex.Replace(output, @"\s|\.|\(", " ");
                output = Regex.Replace(output, @"\s+", " ");
                output = Regex.Replace(output, @"[^\s\w\d-]", "");
                output = output.Trim();

                Dictionary<string, string> tdict = GetDictionaryByType(type);

                foreach (KeyValuePair<string, string> key in tdict)
                {
                    output = output.Replace(key.Key, key.Value);
                }

                output = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(output.ToLower());
                return output;
            }

            public static string Back(string text)
            {
                return Back(text, TransliterationType.PASSPORT);
            }
            public static string Back(string text, TransliterationType type)
            {
                string output = text;
                Dictionary<string, string> tdict = GetDictionaryByType(type);

                foreach (KeyValuePair<string, string> key in tdict)
                {
                    output = output.Replace(key.Value, key.Key);
                }
                return output;
            }

            private static Dictionary<string, string> GetDictionaryByType(TransliterationType type)
            {
                Dictionary<string, string> tdict = PASSPORT;
                if (type == TransliterationType.PASSPORT) tdict = PASSPORT;
                return tdict;
            }

            static Transliteration()
            {
                PASSPORT.Add("Є", "E");
                PASSPORT.Add("І", "I");
                PASSPORT.Add("Ѓ", "G");
                PASSPORT.Add("і", "i");
                PASSPORT.Add("№", "#");
                PASSPORT.Add("є", "e");
                PASSPORT.Add("ѓ", "g");
                PASSPORT.Add("А", "A");
                PASSPORT.Add("Б", "B");
                PASSPORT.Add("В", "V");
                PASSPORT.Add("Г", "G");
                PASSPORT.Add("Д", "D");
                PASSPORT.Add("Е", "E");
                PASSPORT.Add("Ё", "E");
                PASSPORT.Add("Ж", "ZH");
                PASSPORT.Add("З", "Z");
                PASSPORT.Add("И", "I");
                PASSPORT.Add("Й", "Y");
                PASSPORT.Add("К", "K");
                PASSPORT.Add("Л", "L");
                PASSPORT.Add("М", "M");
                PASSPORT.Add("Н", "N");
                PASSPORT.Add("О", "O");
                PASSPORT.Add("П", "P");
                PASSPORT.Add("Р", "R");
                PASSPORT.Add("С", "S");
                PASSPORT.Add("Т", "T");
                PASSPORT.Add("У", "U");
                PASSPORT.Add("Ф", "F");
                PASSPORT.Add("Х", "KH");
                PASSPORT.Add("Ц", "TS");
                PASSPORT.Add("Ч", "CH");
                PASSPORT.Add("Ш", "SH");
                PASSPORT.Add("Щ", "SHCH");
                PASSPORT.Add("Ъ", "'");
                PASSPORT.Add("Ы", "Y");
                PASSPORT.Add("Ь", "");
                PASSPORT.Add("Э", "E");
                PASSPORT.Add("Ю", "YU");
                PASSPORT.Add("Я", "YA");
                PASSPORT.Add("а", "a");
                PASSPORT.Add("б", "b");
                PASSPORT.Add("в", "v");
                PASSPORT.Add("г", "g");
                PASSPORT.Add("д", "d");
                PASSPORT.Add("е", "e");
                PASSPORT.Add("ё", "e");
                PASSPORT.Add("ж", "zh");
                PASSPORT.Add("з", "z");
                PASSPORT.Add("и", "i");
                PASSPORT.Add("й", "y");
                PASSPORT.Add("к", "k");
                PASSPORT.Add("л", "l");
                PASSPORT.Add("м", "m");
                PASSPORT.Add("н", "n");
                PASSPORT.Add("о", "o");
                PASSPORT.Add("п", "p");
                PASSPORT.Add("р", "r");
                PASSPORT.Add("с", "s");
                PASSPORT.Add("т", "t");
                PASSPORT.Add("у", "u");
                PASSPORT.Add("ф", "f");
                PASSPORT.Add("х", "kh");
                PASSPORT.Add("ц", "ts");
                PASSPORT.Add("ч", "ch");
                PASSPORT.Add("ш", "sh");
                PASSPORT.Add("щ", "shch");
                PASSPORT.Add("ъ", "");
                PASSPORT.Add("ы", "y");
                PASSPORT.Add("ь", "");
                PASSPORT.Add("э", "e");
                PASSPORT.Add("ю", "yu");
                PASSPORT.Add("я", "ya");
                PASSPORT.Add("«", "");
                PASSPORT.Add("»", "");
                PASSPORT.Add("—", "-");
                PASSPORT.Add(" ", " ");
            }

        }
    }
}