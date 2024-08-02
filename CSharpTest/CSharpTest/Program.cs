﻿using System;
using System.Linq.Expressions;
using System.Reflection;
using static System.Console;


void PrintPreChorus(string prefix)
{
    Console.WriteLine
    (
        $"""
        {prefix}
        Dreaming 'bout the day when you wake up and find
        That what you're looking for has been here the whole time

        """
    );
}

void PrintChorus(int chorusIteration)
{

    Console.WriteLine((chorusIteration != 3 ? "If you could see that I'm the one who understands you" :
        "Can't you see that I'm the one who understands you"));


    Console.Write
    (
        """
        Been here all along, so why can't you see?
        You belong with me
        """
    );

    Console.Write((chorusIteration != 1 ?
        """"

        Standing by and waiting at your back door
        All this time, how could you not know, baby ?
        You belong with me, you belong with me

        """" : ""));

    Console.Write(", you belong with me\n");
}

void printBridge()
{
    Console.WriteLine
    (
        """
        Oh, I remember you driving to my house
        In the middle of the night
        I'm the one who makes you laugh
        When you know you're 'bout to cry
        And I know your favorite songs
        And you tell me 'bout your dreams
        Think I know where you belong
        Think I know it's with me

        """
    );
}


void PrintVerse1()
{
    Console.WriteLine
    (
        """
        You're on the phone with your girlfriend, she's upset
        She's going off about something that you said
        'Cause she doesn't get your humor like I do
        I'm in the room, it's a typical Tuesday night
        I'm listening to the kind of music she doesn't like
        And she'll never know your story like I do

        """
    );
}

void PrintVerse2()
{
    Console.WriteLine
    (
        """

        Walking the streets with you and your worn-out jeans
        I can't help thinking this is how it ought to be
        Laughing on a park bench, thinking to myself
        Hey, isn't this easy?
        And you've got a smile that could light up this whole town
        I haven't seen it in a while since she brought you down
        You say you're fine, I know you better than that
        Hey, whatcha doing with a girl like that?

        """
    );
}

void PrintOutro()
{
    Console.WriteLine
   (
       """
       You belong with me
       Have you ever thought just maybe
       You belong with me?
       You belong with me

       """
   );
}


PrintVerse1();
PrintPreChorus("But she wears short skirts, I wear T-shirts\nShe's Cheer Captain and I'm on the bleachers");
PrintChorus(1);
PrintVerse2();
PrintPreChorus("She wears high heels, I wear sneakers\nShe's Cheer Captain and I'm on the bleachers");
PrintChorus(2);
printBridge();
PrintChorus(3);
PrintOutro();