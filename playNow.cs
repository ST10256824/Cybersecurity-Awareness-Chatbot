namespace Cybersecurity_Awareness_Chatbot
{
    using System;
    using System.IO;
    using System.Media;



    public class welcomeAudio
    {
        //Contructor
        public welcomeAudio()
        {
            string project_location = AppDomain.CurrentDomain.BaseDirectory;

            Console.WriteLine( project_location );

            // This replace the bin\debug\ so it can get the audio
            string updated_path = project_location.Replace("bin\\Debug\\", "");

            // Combine the wav name as audio.wav with the updated path
            string full_path = Path.Combine(updated_path, "Audio.wav");

            // To pass it to the method play_wav
            Play_wav( full_path );



        } // End of constructor

        // Method to play welcome audio
        private void Play_wav(string full_path)
        {
            // try & catch 
            try
            {
                // Audio play
                using (SoundPlayer player = new SoundPlayer(full_path))
                {
                    player.PlaySync();
                } // end of using
            }catch( Exception error)
            {
                //error message
                Console.WriteLine(error.Message);
            }

        } 



    } //End of class

} //End of namespace