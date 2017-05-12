using System;
using System.Collections.Generic;
//using System.Linq;
using System.Text;
using System.Threading.Tasks;
/// <summary>
/// Colin Knecht - Program 4 - CPT 244
/// </summary>
namespace Program_4_Knecht
{
    class Word
    {
        string word;
        int count;

        public Word(string word, int count)
        {
            this.word = word;
            this.count = count;
        }

        public Word(string word)
        {
            this.word = word;
            count = 1;
        }

        public void AddCount()
        {
            count++;
        }

        public int GetCount()
        {
            return count;
        }

        public string GetWord()
        {
            return word;
        }


    }//end class
}
