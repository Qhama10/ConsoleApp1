namespace SoundPlayer;

using System;
using System.Media;
using MediaSoundPlayer = System.Media.SoundPlayer;



class Audio
{
    public static void PlayGreeting()
    {
        try
        {
            // "welcome.wav" in order to welcome users with a voice greeting 
            SoundPlayer Player = new SoundPlayer("WelcomeMessage.wav"); //the audio of my own voice 
            Player.Play(); // Plays the audio asynchronously
        }
        catch
        {
            Console.WriteLine("(Voice greeting could not be played)");
        }
    }


}




class ImageDisplay
{
    public static void Show()
    {
        // ASCII Art Header
        Console.WriteLine(@"
 ____         __       ____ _           _   
/ ___|  __ _ / _| ___ / ___| |__   __ _| |_ 
\___ \ / _` | |_ / _ \ |   | '_ \ / _` | __|
 ___) | (_| |  _|  __/ |___| | | | (_| | |_ 
|____/ \__,_|_|  \___|\____|_| |_|\__,_|\__|

       Welcome to the Cybersecurity Awareness Bot!
");
    }


    static class Program
    {
        static void Main(string[] args)
        {
            ImageDisplay.Show(); // Display the ASCII art header
            Audio.PlayGreeting(); // Play the voice greeting
            new Play() { };
        }
    }
}

