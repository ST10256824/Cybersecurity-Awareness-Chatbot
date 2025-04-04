using System;
using System.Threading;

namespace Cybersecurity_Awareness_Chatbot
{
    public class ChatbotResponse
    {
        private int input;

        public static void StartChatbot()
        {
            while (true)
            {
                Console.Write("\n💬 Ask me a question (or type 'exit' to quit): ");
                string userInput = Console.ReadLine()?.Trim().ToLower();

                //To handle empty input
                if (string.IsNullOrEmpty(userInput))
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("⚠ Please enter a valid question.");
                    Console.ResetColor();
                    continue;
                }

                //Exit condition
                if (userInput == "exit")
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("\n👋 Goodbye! Stay safe online.");
                    Console.ResetColor();
                    break;
                }

                //typing effect
                Console.Write("\n Thinking");
                for (int i = 0; i < 5; i++)
                {
                    Thread.Sleep(400);
                    Console.Write(".");
                }
                Console.WriteLine("\n");

                //Chatbot response
                Console.ForegroundColor= ConsoleColor.Blue;
                Console.WriteLine(GetResponse(userInput));
            }
        } // end of constructor

        private static string GetResponse(string userInput)
        {
            switch (userInput.ToLower())
            {
                case "How are you":
                    return "😊I'm just a chatbot, but I'm functioning optimally! How can I assist you today?";

                case "what is your purpose?":
                    return "🎯I'm here to help you understand cybersecurity and stay safe online!";
                case "what can i ask you about?":
                    return "💡You can ask me about password safety, phishing, and safe browsing.";
                case "password safety":
                    return "🔑Always use strong, unique passwords and enable multi-factor authentication (MFA) for better security.";
                case "phishing":
                    return "🚨Phishing is a type of online scam where attackers trick you into providing sensitive information. Be cautious of suspicious emails and links!";
                case "safe browsing":
                    return "🌐Avoid clicking on unknown links, use secure websites (HTTPS), and keep your browser updated for a safer online experience.";

                default:
                    return "I'm not certain of that yet. Try asking me about password safety, phishing, and safe browsing!";

            }
        }
    } //end of class

}//end of namespace