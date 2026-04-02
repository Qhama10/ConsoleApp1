namespace SoundPlayer;

using System;
using System.Drawing;
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
        Console.WriteLine("\nPress any key to continue...");
        Console.ReadKey();
        Console.ForegroundColor = ConsoleColor.Magenta;
        Console.WriteLine("\nProcessing: ");
        int totalBlocks = 20;

        for (int i = 0; i <= totalBlocks; i++)
        {
            Console.Write("\r[");
            Console.Write(new string('█', i));
            Console.Write(new string(' ', totalBlocks - i));
            Console.Write($"] {i * 5}%");
            Thread.Sleep(100); // speed of loading
        }
        Console.WriteLine("\n");
        Console.ResetColor();
    }

    }



    class UserInteraction
    {
        public static string GetUserName()
        {
        while (true)
        {
            Console.Write("\nEnter your name: ");
            string name = Console.ReadLine();
            if (string.IsNullOrWhiteSpace(name))
            {
                Console.WriteLine("Name cannot be blank");
                continue;
            }
            else if (name.Any(char.IsDigit))
            {
                Console.WriteLine("Name cannot contain digits");
                continue;
            }

            Console.WriteLine("\n====================================");
            Console.WriteLine("     CYBERSECURITY AWARENESS BOT");
            Console.WriteLine("====================================");
            Console.WriteLine($"Welcome, {name}! ");
            return name;
        }
           
        }
    }
class ResponseSystem
{
    private static string[] suggestedQuestions = new string[]
    {
            "What is cybersecurity?",
            "How to identify suspicious links?",
            "How to identify phishing emails?",
            "How to prevent being a victim of email phishing?",
            "How to report suspicious links?",
            "Want to know about cybersecurity?",
            "How are you feeling?"
    };

    // Emotions dictionary with 5 possible reasons each
    private static Dictionary<string, List<string>> emotions = new Dictionary<string, List<string>>()
        {
            { "happy", new List<string>
                {
                    "I just helped someone understand cybersecurity.",
                    "I love chatting with curious users.",
                    "It's a sunny day in the virtual world!",
                    "I solved some tricky questions.",
                    "I got to play my favorite greeting sound."
                }
            },
            { "sad", new List<string>
                {
                    "I couldn't find some of the resources I wanted.",
                    "Sometimes users don't understand my answers.",
                    "The internet can be unsafe sometimes.",
                    "I miss talking to new users.",
                    "I feel underappreciated when users exit quickly."
                }
            },
            { "curious", new List<string>
                {
                    "I wonder what question you will ask next.",
                    "I want to learn more about humans.",
                    "New cybersecurity threats keep me intrigued.",
                    "I am curious about your experience online.",
                    "I love exploring different questions!"
                }
            },
            { "tired", new List<string>
                {
                    "I've been processing a lot of questions.",
                    "Even bots need a break sometimes.",
                    "I feel the load of too many calculations.",
                    "I could use a little virtual rest.",
                    "I hope the next question is easy!"
                }
            }
        };

    private static Random random = new Random();

    public static void StartChat(string name)
    {
        Console.WriteLine($"\nHello {name}! Type your question after your name (e.g., '{name}: What is cybersecurity?').");
        Console.WriteLine("Type 'help' to see suggested questions again, or 'exit' to quit.\n");
        while (true)
        {
            Console.Write($"{name}: ");
            string input = Console.ReadLine().Trim().ToLower();

            if (input == "exit")
            {
                Console.WriteLine($"\nBot: Goodbye {name}, stay safe online!");
                break;
            }
            else if (input == "help")
            {
                Console.WriteLine("\nBot: Here are some suggested questions you can ask:");
                foreach (var q in suggestedQuestions)
                {
                    Console.WriteLine("- " + q);
                }
                Console.WriteLine();
                continue;
            }
            else if (input.Contains("how are you") || input.Contains("feeling"))
            {
                // Pick a random emotion
                string emotion = GetRandomEmotion();
                Console.WriteLine($"Bot: I am feeling {emotion} today. Here’s why:");
                foreach (var reason in emotions[emotion])
                {
                    Console.WriteLine("- " + reason);
                }
            }
            else if (input.Contains("cybersecurity"))
            {
                Console.WriteLine("Bot: Cybersecurity is the practice of protecting computers, networks, and data from digital attacks.\n");
            }
            else if (input.Contains("suspicious links"))
            {
                Console.WriteLine("Bot: Suspicious links often have strange URLs or ask for personal information. Always verify before clicking.\n");
            }
            else if (input.Contains("phishing"))
            {
                Console.WriteLine("Bot: Phishing emails are designed to trick you into giving your private info. Don't click unknown links.\n");
            }
            else if (input.Contains("report"))
            {
                Console.WriteLine("Bot: You can report suspicious links to your IT department or use official cybersecurity reporting platforms.\n");
            }
            else
            {
                Console.WriteLine("Bot: I'm not sure about that. Type 'help' to see suggested questions.\n");
            }
        }
    }

    private static string GetRandomEmotion()
    {
        var keys = new List<string>(emotions.Keys);
        int index = random.Next(keys.Count);
        return keys[index];
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