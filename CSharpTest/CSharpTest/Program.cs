using Microsoft.VisualBasic;
using System.ComponentModel;
using System.Diagnostics.Metrics;
using System.IO;
using System.Threading.Tasks;
using System.Xml.Linq;


/// <summary>
/// Notes: I started this project with 'Flowers' because I thought it was pretty
/// repetative. With further inspection, I noticed small differences between all
/// the verses and choruses, hence the verse1,chorus1...ect. I kept at it, but wanted
/// a chance to show a simpler implimentation, and that is why I also included
/// Funky Town. That song is very repetative. My thought process with the if statements
/// is to mimic the structure of the song by grouping each verse/chorus pair as
/// a repeated iteration.
///
/// As for repatition within verses, my general rule was if there was more than
/// 3 iterations of the same line, I would create a repatition loop. I thought
/// smaller iterations would sacrifice readability. I also chose to encapsulate all
/// my print functions to try to make the main function as simple as possible.
///
/// I realized after doing the other two functions, that I could just havea  text file
/// and read in the lines, it's short, but not very readable. 
/// </summary>
class CSharpTest
{ 

    static void Main(string[] args)
    {
        //playFlowers();
        //playFunkyTown();
        shortPlayFlowers();
    }


    /////////////////////////////////
    /// Flowers
    /////////////////////////////////


    static void playFlowers()
    {
        // keep track of which verses we have played
        bool playedFirstVerse = false;
        bool playedSecondVerse = false;
        // there are 2 iterations of the verse/chorus structure
        int verseIterations = 2;

        // structure of the song: (verse1 chorus1) (verse2 chorus2) (chorus3)
        for (int i = 0; i < verseIterations; i++)
        {
            if (!playedFirstVerse)
            {
                PrintVerseOne();
                playedFirstVerse = true;
                PrintChorusOne();
            }
            else if (!playedSecondVerse)
            {
                PrintSecondVerse();
                playedSecondVerse = true;
                PrintChorusTwo();
                PrintChorusThree();
            }
        }
    }

    static void shortPlayFlowers()
    {
        IEnumerable<string> fileContents = File.ReadLines("Flowers.txt");

        foreach (string line in fileContents)
        {
            Console.WriteLine(line);
        }
    }

    static void PrintChorusOne()
    {
        Console.WriteLine("I didn't wanna leave you\nI didn't wanna lie\n" +
            "Started to cry, but then remembered I\n\nI can buy myself flowers"+
            "\nWrite my name in the sand\nTalk to myself for hours\n" +
            "Say things you don't understand\nI can take myself dancing\n" +
            "And I can hold my own hand\nYeah, I can love me better than you can" +
            "\n\nCan love me better\nI can love me better, baby\n" +
            "Can love me better\nI can love me better, baby\n");
    }
    static void PrintChorusTwo()
    {
        Console.WriteLine("I didn't wanna leave you, baby\nI didn't wanna fight\n" +
            "Started to cry, but then remembered I\n\nI can buy myself flowers" +
            "\nWrite my name in the sand\nTalk to myself for hours\n" +
            "Say things you don't understand\nI can take myself dancing, yeah\n" +
            "I can hold my own hand\nYeah, I can love me better than you can" +
            "\n\nCan love me better\nI can love me better, baby\n" +
            "Can love me better\nI can love me better, baby\n" +
            "Can love me better\nI can love me better, baby\nCan love me better\n"+
            "Oh, I");
    }
    static void PrintChorusThree()
    {
        Console.WriteLine("I didn't wanna leave you\nI didn't wanna fight\n" +
            "Started to cry, but then remembered I\nI can buy myself flowers (oh)" +
            "\nWrite my name in the sand (mm)\nTalk to myself for hours (yeah)" +
            "\nSay things you don't understand (you never will)\n" +
            "I can take myself dancing, yeah\nI can hold my own hand\n" +
            "Yeah, I can love me better than\nYeah, I can love me better than you can" +
            "\nCan love me better\nI can love me better, baby (oh)\n" +
            "Can love me better\nI can love me better (than you can), baby\n" +
            "Can love me better\nI can love me better, baby\nCan love me better" +
            "\nI");
    }
    static void PrintVerseOne()
    {
        Console.Write("We were good, we were gold\n" +
            "Kinda dream that can't be sold\nWe were right 'til we weren't\n" +
            "Built a home and watched it burn\n\nMm, ");

    }
    static void PrintSecondVerse()
    {
        Console.Write("Paint my nails cherry red\n" +
            "Match the roses that you left\nNo remorse, no regret\n" +
            "I forgive every word you said\n\nOoh, ");
    }

    /////////////////////////////////
    /// Funky Town
    /////////////////////////////////

    static void playFunkyTown()
    {
        // the verse/chorus structure of this song is repeated twice
        int songIterations = 2;
        // structure of the song: (verse preChorus chorus) (verse prechorus chorus) outro
        for (int i = 0; i < songIterations; i++)
        {
            PrintVerse();
            PrintPreChorus();
            PrintChorus();
        }
        PrintOutro();
    }

    static void PrintVerse()
    {
        Console.WriteLine("Gotta make a move to a town that's right for me\n" +
            "Town to keep me movin', keep me groovin' with some energy\n");
    }

    static void PrintPreChorus()
    {
        Console.WriteLine("Well, I talk about it, talk about it\n" +
            "Talk about it, talk about it\nTalk about, talk about\n" +
            "Talk about movin'\nGotta move on\nGotta move on\nGotta move on\n");
    }

    static void PrintChorus()
    {
        // "Won't you take me to Funkytown?" repeats 7 times
        int funkyTownIteration = 7;

        Console.WriteLine("A-won't you take me to Funkytown?");

        for (int i = 0; i < funkyTownIteration; i++)
        {
            Console.WriteLine("Won't you take me to Funkytown?");
        }

        // add a new line for separation
        Console.WriteLine("\n");
    }

    static void PrintOutro()
    {
        //"Won't you take me down to Funkytown?" repeats 8 times
        int funkyTownIteration = 8;

        for (int i = 0; i < funkyTownIteration; i++)
        {
            Console.WriteLine("Won't you take me down to Funkytown?");
        }

        Console.WriteLine("Take me, won't you take me?\n" +
            "Take me, won't you take me?" + "Take me, (won't you take me)"+
            " won't you take me?\nTake me, (won't you take me) won't you take me?");

        // "I wanna go (won't you take me) to Funkytown" repeats 4 times
        int wantToGoIteration = 4;

        for (int i = 0; i < wantToGoIteration; i++)
        {
            Console.WriteLine("I wanna go (won't you take me) to Funkytown");
        }

        // add a new line for separation
        Console.WriteLine("\n");
    }
}