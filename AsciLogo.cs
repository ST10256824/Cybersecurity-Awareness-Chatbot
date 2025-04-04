using System;
using System.Drawing;
using System.IO;
using System.Security.Cryptography;




namespace Cybersecurity_Awareness_Chatbot
{
    public class AsciLogo
    { // constructor

        //Method to create the Cybersecurity Awareness Logo
        public AsciLogo()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("=====================================================");
            Console.WriteLine("     🔐 Cybersecurity Awareness Chatbot 🔐 ");
            Console.WriteLine("======================================================");
            Console.ResetColor();

            string path_project = AppDomain.CurrentDomain.BaseDirectory;
            string new_path_project = path_project.Replace("bin\\Debug\\","");


            //Format
            //Adding the image to the project to create logo
            string full_path = Path.Combine(new_path_project,"logo.jfif");

            Bitmap image = new Bitmap(full_path);
            image = new Bitmap(image, new Size(210, 200));

            //for loop, for inner and the outer
            for (int height=0; height< image.Height; height ++) 
            {
                //width
                for (int width =0;width<image.Width; width++) 
                {
                    //Asci design
                    Color pixelColor =image.GetPixel(width, height);
                    int color =(pixelColor.R + pixelColor.G + pixelColor.B) / 3;

                    //Making use of the char
                    char ascii_design = color > 200 ? ',' : color > 150 ? '*' : color > 100 ? '0' : color > 50 ? '#' : '@';
                    Console.Write(ascii_design); 

                } // end of for loop outer
                Console.WriteLine();    
                {

                }//end of the for inner
            }
            {

            } // end of the for loop outer

        } // End of constructor

    } // end of class

} // end of namespace
