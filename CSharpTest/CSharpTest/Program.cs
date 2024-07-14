using Microsoft.VisualBasic;
using System.ComponentModel;
using System.Diagnostics.Metrics;
using System.IO;
using System.Threading.Tasks;
using System.Xml.Linq;

class CSharpTest
{ 

    static void Main(string[] args)
    {
        playFlowers();
    }

    static void playFlowers()
    {
        // keep track of which verses we have played
        bool playedFirstVerse = false;
        bool playedSecondVerse = false;
        // there are 3 iterations of the chorus in this song
        int chorusIterations = 3;

        // structure of the song: (verse1 chorus1) (verse2 chorus2) (chorus3)
        for (int i = 0; i < chorusIterations; i++)
        {
            if (!playedFirstVerse)
            {
                PrintVerseOne();
                playedFirstVerse = true;
                // since this is a special version of the chorus,
                // print it and then "continue" to the next iteration of the loop
                // so we do not print the default chorus below (PrintChorus2)
                PrintChorusOne();
                continue;
            }
            else if(!playedSecondVerse)
            {
                PrintSecondVerse();
                playedSecondVerse = true;
                PrintChorusTwo();
            }
            // the chorus print statement is here so it is printed every
            // iteration
            PrintChorusThree();
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
}