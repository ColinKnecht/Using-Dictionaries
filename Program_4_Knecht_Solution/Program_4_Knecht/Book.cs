using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Threading.Tasks;
/// <summary>
/// Colin Knecht - Program 4 - CPT 244
/// </summary>
namespace Program_4_Knecht
{
    class Book
    {
        Dictionary<string, Word> bookWords = new Dictionary<string, Word>();

        public void LoadBook(String fileName)
        {
            FileStream fs = new FileStream(fileName, FileMode.Open);
            StreamReader input = new StreamReader(fs);

            while (!input.EndOfStream)
            {
                string line = input.ReadLine();
                string[] fields = line.Split(" ".ToCharArray());
                for (int i = 0; i < fields.Length; i++)
                {
                    if (bookWords.ContainsKey(fields[i]))
                    {
                        bookWords[fields[i]].AddCount();
                        continue;
                    }
                    Word bookWord = new Word(fields[i]);
                    bookWords.Add(fields[i], bookWord);

                }
            }
            //fs.Close();
        }


        public int GetTotalNumberOfDifferentWords()
        {
            int total = 0;
            total = bookWords.Count;

            return total;
        }

        public int GetAllWordsTotal()
        {
            int totalWords = 0;

            foreach (KeyValuePair<string, Word> entry in bookWords)
            {
                totalWords += entry.Value.GetCount();
            }
            return totalWords;
        }

        public string GetCountNumber()
        {
            string answer = "Count Appears 0 times" ;
            foreach (KeyValuePair<string, Word> entry in bookWords)
            {
                if (entry.Value.GetWord().Equals("count"))
                {
                    //Console.WriteLine(entry.Value.GetWord() + " appears in book " + entry.Value.GetCount() + " times");
                    answer = entry.Value.GetWord() + " appears in book " + entry.Value.GetCount() + " times";
                    return answer;
                }
            }
            return answer;
        }

        public string GetMayNumber()
        {
            string answer = "May Appears 0 Times";
            foreach (KeyValuePair<string, Word> entry in bookWords)
            {
                if (entry.Value.GetWord().Equals("may"))
                {
                    //Console.WriteLine(entry.Value.GetWord() + " appears in book " + entry.Value.GetCount() + " times");
                    answer = entry.Value.GetWord() + " appears in book " + entry.Value.GetCount() + " times";
                    return answer;
                }
            }

            return answer;
        }

        public string GetColorNumber()
        {
            string answer = "Color Appears 0 Times";
            foreach (KeyValuePair<string, Word> entry in bookWords)
            {
                if (entry.Value.GetWord().Equals("color"))
                {
                    //Console.WriteLine(entry.Value.GetWord() + " appears in book " + entry.Value.GetCount() + " times");
                    answer = entry.Value.GetWord() + " appears in book " + entry.Value.GetCount() + " times";
                    return answer;
                }
            }

            return answer;
        }

        public string WordSearch(string search)
        {
            string answer = search + " not found in book";

            foreach (KeyValuePair<string, Word> entry in bookWords)
            {
                if (entry.Value.GetWord().Equals(search))
                {
                    answer = entry.Value.GetWord() + " appears in book " + entry.Value.GetCount() + " times";
                    return answer;
                }
            }

           return answer;
        }

        public List<KeyValuePair<string,Word>> WordLengthEquals(int count)
        {
            List<KeyValuePair<string, Word>> wordMatch = new List<KeyValuePair<string, Word>>();
            foreach (KeyValuePair<string, Word> entry in bookWords)
            {
                if (entry.Key.Length == count)
                {
                    wordMatch.Add(new KeyValuePair<string, Word>(entry.Key, entry.Value));
                }
            }
            if (wordMatch.Count <= 0)
            {
                Console.WriteLine("Count Cannot be zero or negative to find a wordset");
            }
            else if (wordMatch.Count > 0)
            {
                Console.WriteLine("All Words With the Length of " + count);
                //Print out all words equal to count
                for (int i = 0; i < wordMatch.Count; i++)
                {
                    Console.WriteLine(wordMatch[i].Key);
                }

            }

            return wordMatch;
        }

        public List<KeyValuePair<string, Word>> WordsThatAppearXTimes(int count)
        {
            List<KeyValuePair<string, Word>> wordMatch = new List<KeyValuePair<string, Word>>();
            foreach (KeyValuePair<string, Word> entry in bookWords)
            {
                if (entry.Value.GetCount() == count)
                {
                    wordMatch.Add(new KeyValuePair<string, Word>(entry.Key, entry.Value));
                }
            }
            if (count <= 0)
            {
                Console.WriteLine("Count cannot be zero or negative number");
            }
            else if (wordMatch.Count > 0)
            {
                Console.WriteLine("Words That Appear " + count + " times");

                for (int i = 0; i < wordMatch.Count; i++)
                {
                    Console.WriteLine(wordMatch[i].Key);
                }

            }
            else if (wordMatch.Count == 0)
            {
                Console.WriteLine("No Word in the Book Appears " + count + " times");
            }
            return wordMatch;
        }

        public Word GetMostFrequentWord()
        {
            Word w = null;
            int maxCount = 0;

            foreach (KeyValuePair<string, Word> entry in bookWords)
            {
                //w = entry.Value;
                int thisNum = entry.Value.GetCount();
                if (thisNum > maxCount)
                {
                    maxCount = thisNum;
                    w = entry.Value;
                }
            }
            Console.WriteLine("The Word That Occurs Most is -- " + w.GetWord() + " -- occurring " + w.GetCount() + " times.");

                return w;
        }

        public List<KeyValuePair<string, Word>> GetTopTen()
        {
            List<KeyValuePair<string, Word>> topTen = new List<KeyValuePair<string, Word>>();
            //Word[] topTen = new Word[10];

            int maxCount = 0;
            Word w;
            foreach (KeyValuePair<string, Word> entry in bookWords)
            {
                int thisNum = entry.Value.GetCount();
                //w = entry.Value;
                if (thisNum > maxCount)
                {
                    topTen.Add(new KeyValuePair<string, Word>(entry.Key, entry.Value));
                }
            }
            Console.WriteLine("Debug");
            for (int i = 0; i < topTen.Capacity; i ++)
            {
                Console.WriteLine(topTen[i].Key + " " + topTen[i].Value.GetWord());
            }

            return topTen;
        }
        public Word[] GetMostWordsAKATopTenWords()
        {
            Word[] topTen = new Word[10];
            int maxCount = 0;
            Word w;
            foreach (KeyValuePair<string, Word> entry in bookWords)
            {
                int thisNum = entry.Value.GetCount();

                if (thisNum > maxCount)
                {
                    w = entry.Value;
                    w = topTen[0];
                    //topTen.so
                }
            }


            return topTen;
        }
    }//end class
}
