namespace SoundPlayer;

using System;
//import the system.media 
using System.Media;
using System.Numerics;



public class Play
{
    //constructor
    public Play()
    {
        //now  get where the project is 
        string project_location = AppDomain.CurrentDomain.BaseDirectory;

        //check if it is getting the directory correctly 
        Console.WriteLine(project_location);


        //now lets replace the bin/Debug/net10.0 so it can get the wav file 
        //string updated_path  = project_location.Replace("bin\\Debug\\net10.0\\", "AudioFiles\\");

        //combine wav name as sound.wav with the updated path

        string full_path = Path.Combine(project_location, "WelcomeMessagee.wav");

        //nows lets pass it to the method to play the sound
        Play_wav(full_path);



    }//end of constructor

    //method to play the sound 
    private void Play_wav(string full_path) 
    {
        //try and catch 
        try
        {
            //or play the sound file
            using ( SoundPlayer Player = new SoundPlayer("WelcomeMessage.wav"))
            {
                //to play the sound till end use this 
                Player.PlaySync();
            }
        }
        catch (Exception error)
        {
            //then show the error message 
            Console.WriteLine(error.Message);
        }//end of try and catch
    }// end of mathod play wav
}//end of class 
//end of namespace