using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scope
{
    class Program
    {
        static string language = "English";

        static void Main(string[] args)
        {
            
            ShowOff();
        
        }

        private static void ShowOff()
        {
            List<string> languages = new List<string> {
                "English","German","French","Yorkshire","Spanish"
            };

            foreach(string language in languages)
            {
                SayHello(language);
            }
        }

        private static void SayHello(string language)
        {
            Console.Write($"You can greet someone in {language} by saying ");
            switch(language)
            {
                case "English":
                    Console.WriteLine("Hello");
                    break;
                case "German":
                    Console.WriteLine("Guten Tag");
                    break;
                case "French":
                    Console.WriteLine("Bonjour");
                    break;
                case "Spanish":
                    Console.WriteLine("Hola");
                    break;
                default:
                    Console.WriteLine("How do?!");
                    break;
            }
        }
    }
}
