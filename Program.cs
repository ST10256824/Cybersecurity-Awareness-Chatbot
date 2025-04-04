using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Media;

namespace Cybersecurity_Awareness_Chatbot
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Cybersecurity Awareness Chatbot"; // Set console title
            Console.OutputEncoding = System.Text.Encoding.UTF8;


            //Welcome audio 

            new welcomeAudio() { };

            //Asci logo
            new AsciLogo() { };



            //Text based greeting
            Console.WriteLine("\n 👋! What is your name? ");
            string userName = Console.ReadLine()?.Trim();

            // Validate input
            while (string.IsNullOrWhiteSpace(userName))
            {
                Console.WriteLine("Please enter a valid name: ");
                userName = Console.ReadLine()?.Trim();
            }

            // Display personalized greeting
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"\nWelcome, {userName}! I'm your Cybersecurity Awareness Chatbot.");
            Console.WriteLine("I'm here to help you learn about online safety. Let's get started!");

            // To start chatbot interaction.
            ChatbotResponse.StartChatbot();

            //Chatbot Response System
            new ChatbotResponse() { };


         
        }

    }
}
