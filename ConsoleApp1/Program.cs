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
}

    class Loader
    {
        public static void ShowLoading()
        {
            // 👇 Ask user to continue
            Console.WriteLine("\nPress any key to continue...");
            Console.ReadKey();

            Console.WriteLine("\nProcessing: ");

            for (int i = 0; i <= 100; i++)
            {
                Console.Write($"\rProcessing: {i}%");
                System.Threading.Thread.Sleep(10); // fast loading
            }

            Console.WriteLine("\nDone!\n");
        }

    }

    class UserInteraction
    {
        public static string GetUserName()
        {
            Console.Write("\nEnter your name: ");
            string name = Console.ReadLine();

            Console.WriteLine("\n====================================");
            Console.WriteLine("     CYBERSECURITY AWARENESS BOT");
            Console.WriteLine("====================================");
            Console.WriteLine($"Welcome, {name}! ");

            return name;
        }
    }

class ResponseSystem
{
    public static void StartChat(string name)
    {
        while (true)
        {
            Console.Write("\nAsk a question (type 'exit' to quit): ");
            string input = Console.ReadLine().ToLower();

            if (input == "exit")
            {
                Console.WriteLine($"Goodbye {name}, stay safe online ");
                break;
            }
            else if (input.Contains("how are you"))
            {
                Console.WriteLine("I'm functioning perfectly! ");
            }
            else if (input.Contains("your purpose"))
            {
                Console.WriteLine("I help users stay safe online.");
            }
            else if (input.Contains("password"))
            {
                Console.WriteLine("Use strong passwords and never share them.");
            }
            else if (input.Contains("phishing"))
            {
                Console.WriteLine("Phishing is a scam to steal your information.");
            }
            else
            {
                Console.WriteLine("I didn't understand that. Try again.");
            }
        }
    }
}


static class Program
    {
        static void Main(string[] args)
        {
            ImageDisplay.Show(); // Display the ASCII art header
            Audio.PlayGreeting(); // Play the voice greeting
            new Play() { };


            Loader.ShowLoading();
                 string name = UserInteraction.GetUserName();

        ResponseSystem.StartChat(name);
        }
    }




