using System.Diagnostics;

namespace HomeWork13
{
    internal class Program
    {
        static void Main(string[] args)
        {            
            try
            {
                string text = File.ReadAllText("D://lms-cdn.skillfactory.ru_assets_courseware_v1_dc9cf029ae4d0ae3ab9e490ef767588f_asset-v1_SkillFactory+CDEV+2021+type@asset+block_cdev_Text.txt");
                char[] delimiters = new char[] { ',', '.', ' ', '\r', '\n' };
                var wordsInText = text.Split(delimiters, StringSplitOptions.RemoveEmptyEntries);
                ListWords(wordsInText);
                LinkedListWords(wordsInText);
            }
            catch (Exception e)
            {
                Console.WriteLine("Ошибка: " + e.Message);
            }
            finally
            {
                Console.WriteLine("Все готово");
            }
        }
        static void ListWords(string[] wordsInText)
        {
            var wordList = new List<string>();
            var stopWatch = Stopwatch.StartNew();
            for (int i = 0; i < wordsInText.Length; i++)
            {
                wordList.Add(wordsInText[i]);
            }
            Console.WriteLine("List добавил все значения в список за " + stopWatch.Elapsed.TotalMilliseconds);
        }
        static void LinkedListWords(string[] wordsInText)
        {
            var wordList = new LinkedList<string>();
            var stopWatch = Stopwatch.StartNew();
            for (int i = 0; i < wordsInText.Length; i++)
            {
                wordList.AddLast(wordsInText[i]);
            }            
            Console.WriteLine("LinkedList добавил все значения в список за " + stopWatch.Elapsed.TotalMilliseconds);
        }
    }
}