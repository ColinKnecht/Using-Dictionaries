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
    class Program
    {
        static void Main(string[] args)
        {
            Book book = new Book();
            book.LoadBook("c:/Users/lori/desktop/comc.txt");

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Total Number of words " + book.GetTotalNumberOfDifferentWords());
            Console.WriteLine("All Words Total " + book.GetAllWordsTotal());
            book.GetMostFrequentWord();
            Console.WriteLine("Num Times Count Occurs " + book.GetCountNumber());
            Console.WriteLine("Num Times May Occurs " + book.GetMayNumber());
            Console.WriteLine("Num Times Color Occurs " + book.GetColorNumber());
            Console.ResetColor();

            string MENU = "Enter the Following \n" +
                           "(1) Get Count of Certain Word \n" +
                           "(2) Words That Appear X Times \n" +
                           "(3) Words With the Length X \n" +
                           "(4) Quit";
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine(MENU);
            string choice = Console.ReadLine();
            int key = int.Parse(choice);

            while (key != 4)
            {
                switch (key)
                {
                    case 1:
                        Console.WriteLine("You Picked Get Count Of a Certain Word-------------");
                        Console.WriteLine("What is the word you would like to search?");
                        string ch1 = Console.ReadLine();
                        Console.WriteLine(book.WordSearch(ch1));
                        break;
                    case 2:
                        Console.WriteLine("You Picked Words That Appear X Times----------------");
                        Console.WriteLine("What Number Would You Like to Search for X Times?");
                        string ch2 = Console.ReadLine();
                        int key2 = int.Parse(ch2);
                        book.WordsThatAppearXTimes(key2);
                        break;
                    case 3:
                        Console.WriteLine("You Picked Words With The Length X-------------------");
                        Console.WriteLine("What Length of Word Would You Like To Find?");
                        string ch3 = Console.ReadLine();
                        int key3 = int.Parse(ch3);
                        book.WordLengthEquals(key3);
                        break;
                    default:
                        Console.WriteLine("Invalid Selcection");
                        break;
                }
                Console.WriteLine(MENU);
                choice = Console.ReadLine();
                key = int.Parse(choice);
            }
            Console.ResetColor();

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("============Program Terminated====================");
            Console.ResetColor();
            //book.GetTopTen();
            //book.GetMostFrequentWord();
            //Console.WriteLine("Total Number of words " + book.GetTotalNumberOfDifferentWords());
            //Console.WriteLine("All Words Total " + book.GetAllWordsTotal());
            //Console.WriteLine("Num Times Count Occurs " + book.GetCountNumber());
            //Console.WriteLine("Num Times May Occurs " + book.GetMayNumber());
            //Console.WriteLine("Num Times Color Occurs " + book.GetColorNumber());
            //Console.WriteLine(book.WordSearch("monte"));
            //book.WordLengthEquals(5);
            //book.WordsThatAppearXTimes(3);
            Console.ReadLine();
        }
    }
}
