using System;
using System.IO;
using System.Text;

namespace Obolonskih_WORK
{
    class InlineFunctions
    {
        public void numbersOfEntry(string text2, string leters)
        {
            int result = 0;
            string[] arrText = text2.Split('.', '!', '?', ' ');
            for (int i = 0; i < arrText.Length; i++)
            {
                string value = arrText[i];
                for (int j = 0; j < value.Length; j++)
                {
                    if (value[j] == leters[0])
                    {
                        result++;
                    }
                }
            }
            Console.WriteLine($"Количество слов в которых присутствукт буква {leters}=:{result}");
        }
        public string FuncText(string[] text)
        {
            string _text = "";
            for (int i = 0; i < text.Length; i++)
            {
                string test = text[i];
                if (test.Trim().Split(' ')[0].Length == 1)
                {
                    _text += text[i];
                    _text += ". ";
                }
            }
            for (int j = 0; j < text.Length; j++)
            {
                string test1 = text[j];

                if (test1.Trim().Split(' ')[0].Length > 1)
                {
                    _text += test1;
                    _text += ".";

                }
            }
            return _text;
        }
        public void ExclamatorySentence(string Recording, string ReadText)
        {
            if (File.Exists(ReadText))
            {
                StreamReader sr = new StreamReader(ReadText, Encoding.Default);
                string text = sr.ReadToEnd();
                string[] st = new string[10];
                var gg = new System.Collections.Generic.List<string> { };
                Console.WriteLine(text);
                System.Text.RegularExpressions.Regex reg = new System.Text.RegularExpressions.Regex(@"[\w\d\,\s]*\!");
                System.Text.RegularExpressions.MatchCollection matches = reg.Matches(text);
                for (int i = 0; i < matches.Count; i++)
                {
                    gg.Add(matches[i].Value);
                }
                string record = null;
                for (int i = 0; i < gg.Count; i++)
                {
                    record += (gg[i]);
                    Console.WriteLine(gg[i]);
                }
                using (FileStream file = new FileStream(Recording, FileMode.OpenOrCreate))
                    //Вам не придётся заранее создавать файл. Функия  OpenOrCreated сделает это за вас.                                                                         
                    //Просто при вызове метода укажите место, где бы вы хотели видеть этот файл. 
                {
                    using (StreamWriter stream = new StreamWriter(file))
                    {
                        stream.WriteLine(record);
                    }
                }
            }
            else
                Console.WriteLine("File not exist");
        }
    }
}