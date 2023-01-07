using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Introduction.CharsAndStrings.Step2
{
    class Program
    {
        static void Main(string[] args)
        {
            string day;
            Console.WriteLine("Kokia siandien savaites diena?");
            day = Console.ReadLine().ToLower();
            switch (day)
            {
                case "pirmadienis":
                    Console.WriteLine("Pirmadienis - sudėtingiausia savaitės diena.");
                    break;
                case "antradienis":
                    Console.WriteLine("Antradienis – aktyvių veiksmų, Marso diena.");
                    break;
                case "treciadienis":
                    Console.WriteLine("Trečiadienis – sandoriams sudaryti tinkamiausiaiena.");
                    break;
                case "ketvirtadienis":
                    Console.WriteLine("Ketvirtadienį reikėtų imtis visuomeninių darbų.");
                    break;
                case "penktadienis":
                    Console.WriteLine("Penktadienį lengvai gimsta šedevrai, susitinkamylimieji.");
                    break;
                case "šeštadienis":
                    Console.WriteLine("Šeštadienis - savo problemų sprendimo diena.");
                    break;
                case "sekmadienis":
                    Console.WriteLine("Sekmadienį reikėtų pradėti naujus darbus.");
                    break;
                default:
                    Console.WriteLine("Tokios savaitės dienos pas mus nebūna.");
                    break;
            }
            Console.ReadKey();
        }
    }
}
