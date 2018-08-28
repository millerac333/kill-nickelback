// Make sure that some of the songs are from the band Nickelback. You can see a list of their greatest hits on Amazon lololololol... greatest hits .

using System;
using System.Collections.Generic;

namespace nickelback
{
    class Program
    {
        static void Main(string[] args)
        {
            // Define a List, named goodSongs, that will hold tuples consisting of two strings.
            List<(string artist, string songTitle)> goodSongs = new List<(string artist, string songTitle)>();

            // Define a HashSet, named allSongs, that contains 7 tuples. Each tuple should contain two string values:
            // The name of an artist
            // A song by that artist
            HashSet<(string artist, string songTitle)> allSongs = new HashSet<(string, string)>();
            (string artist, string songTitle) song1 = ("Nickelback", "If Everyone Cared");
            (string artist, string songTitle) song2 = ("Eagles", "Hotel California");
            (string artist, string songTitle) song3 = ("Nickelback", "Burn it to the Ground");
            (string artist, string songTitle) song4 = ("Red Hot Chili Peppers", "Under the Bridge");
            (string artist, string songTitle) song5 = ("NickelBack", "Never Again");
            (string artist, string songTitle) song6 = ("Wild Horses", "The Stones");
            (string artist, string songTitle) song7 = ("Heart of Gold", "Neil Young");

            // Once the set is populated with 7 tuples, iterate over the set of songs, and check if the band name is "Nickelback".
            foreach (var nonCrapSong in allSongs)
            {
                // If the band is not Nickelback, then add it to the goodSongs list.
                if (nonCrapSong.artist != "Nickelback")
                {
                    goodSongs.Add(nonCrapSong);
                }
            }

            // Use another foreach loop to print out all the good songs.
            Console.WriteLine(("Songs Not by Nickelback..."));
            Console.WriteLine();
            foreach (var song in goodSongs)
            {
                Console.WriteLine($"{song.songTitle} by {song.artist}");
            }
        }
    }
}
