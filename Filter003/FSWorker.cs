using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Filter003
{
    internal class FSWorker
    {
        static public string GetCurrentDir() // возвращает путь , текущего каталога
        {
            return Directory.GetCurrentDirectory();
        }
        static public string GetPathMyDocuments() //возвращает путь "мои документы"
        {
            string path = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            return path;
        }

        static public List<string> ListOfFiles(string _path) // поиск в каталоге и подкаталогах название всех файлов txt
        {
            List<string> result = new List<string>();
            foreach (string filename in Directory.EnumerateFiles(_path, "*.txt", SearchOption.AllDirectories))
            {
                result.Add(filename);
            }
            return result;
        }

        static public string ReadAllFile(string _filename) //читаем фаил
        {
            string result = string.Empty;
            try
            {
                using (StreamReader sr = new StreamReader(_filename))
                {
                    result = sr.ReadToEnd();
                }
            }
            catch
            {
                result = "<empty>";
            }

            return result;
        }
        static public void WriteToFile(string path, string content)
        {
            try
            {
                StreamWriter sr = new StreamWriter(path,true);
                sr.Write(content);
                sr.Close();
            }
            catch 
            {
                string empty_ = "<empty>";
            }
        }
    }
}
