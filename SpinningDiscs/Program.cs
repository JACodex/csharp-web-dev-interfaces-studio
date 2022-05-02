using System;
using System.Collections.Generic;

namespace SpinningDiscs
{
    class Program
    {
        static void Main(string[] args)
        {
            List<CD> cdCollection = new List<CD>();
            MediaSorter mediaSorter = new MediaSorter();
            // TODO: Declare and initialize a CD and a DVD object.
            CD lateralus = new CD("Lateralus is the third studio album by American rock band Tool.", false, 2001);
            CD Salival = new CD("Salival is a live, outtake, and video album, released as a limited edition box set in CD", false, 2000);
            CD Aenima = new CD("Ænima is the second studio album by American rock band Tool. It was released in vinyl format on September 17, 1996,", false, 1996);
            CD Undertow = new CD("Undertow is the debut studio album by American rock band Tool, released on April 6, 1993 by Zoo Entertainment. Produced by the band and Sylvia Massy", false, 1993);
            CD FI = new CD("Fear Inoculum is the fifth studio album by American rock band Tool. It was released on August 30, 2019, through Tool Dissectional, Volcano Entertainment, and RCA Records.", false, 2019);

            cdCollection.Add(Salival);
            cdCollection.Add(FI);
            cdCollection.Add(Undertow);
            cdCollection.Add(lateralus);
            cdCollection.Add(Aenima);

            cdCollection.Sort(mediaSorter);
            foreach (CD cd in cdCollection)
            {
                Console.WriteLine($"Decs: {cd.Play()} \n- Date Released: {cd.YearReleased}");
            }

            Console.WriteLine("********************************* DVD ********************************************");
            /*********************************DVD Objects ********************************************/
            DVD EnemyOfTheState = new DVD("Corrupt National Security Agency official Thomas Reynolds (Jon Voight) has a congressman assassinated to assure the passage of expansive new surveillance legislation. When a videotape of the murder ends up in the hands of Robert Clayton Dean (Will Smith), a labor lawyer and dedicated family man", false, 1998);
            DVD Hackers = new DVD("A teenage hacker finds himself framed for the theft of millions of dollars from a major corporation. Master hacker Dade Murphy, aka Zero Cool, aka Crash Override, has been banned from touching a keyboard for seven years after crashing over 1,500 Wall Street computers at the age of 11", false, 1995);
            DVD ExMachina = new DVD("Caleb Smith (Domhnall Gleeson) a programmer at a huge Internet company, wins a contest that enables him to spend a week at the private estate of Nathan Bateman (Oscar Isaac), his firm's brilliant CEO. When he arrives, Caleb learns that he has been chosen to be the human component in a Turing test to…", false, 2015);
            DVD DEVS = new DVD("Devs is an FX limited series that focuses on a young software engineer named Lily Chan who works for Amaya, a cutting-edge tech company based in Silicon Valley. After her boyfriend Sergei's apparent suicide, Lily suspects foul play and begins to investigate.", false, 2020);
            DVD SiliconValley = new DVD("Partially inspired by co-creator Mike Judge's experiences as a Silicon Valley engineer in the 1980s, this comedy series follows the misadventures of introverted computer programmer Richard and his brainy friends as they attempt to strike it rich in a high-tech gold rush.", false, 2014);

            List<DVD> dvdCollection = new List<DVD>();
            dvdCollection.Add(EnemyOfTheState);
            dvdCollection.Add(Hackers);
            dvdCollection.Add(ExMachina);
            dvdCollection.Add(DEVS);
            dvdCollection.Add(SiliconValley);

            dvdCollection.Sort(mediaSorter);
            foreach(DVD dvd in dvdCollection)
            {
                Console.WriteLine($"Decs: {dvd.Play()} \n- Date Released: {dvd.YearReleased}");
            }

            // TODO: Call each CD and DVD method to verify that they work as expected.

        }
    }
}
