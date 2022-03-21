using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Zapisovani
{
    internal class App
    {
        public void Run()
        {
            Random random = new Random();

            var procced = true;
            int input;
            string letter;
            int letterOrNumber;
            int number;

            string Hex = "";

            string[] letters = {"a", "b", "c", "d", "e", "f"};

            while (procced)
            {
                input = Convert.ToInt32(Console.ReadLine());  
                if(input == 0)
                { 
                    break;
                }
                for(int j = 0; j < input; j++)
                {
                    for (int i = 0; i < 6; i++)
                    {
                        letterOrNumber = random.Next(0, 2);

                        if (letterOrNumber == 0)
                        {
                            letter = letters[random.Next(letters.Length)];
                            Hex = Hex + letter;
                        }
                        else
                        {
                            number = random.Next(0, 9);
                            number.ToString();
                            Hex = Hex + number;
                        }
                    }
                    File.AppendAllText(@"C:\Users\vende\source\repos\Zapisovani\Zapisovani\hex.txt", "#" + Hex + Environment.NewLine);
                    Console.WriteLine(Hex);
                    Hex = "";
                }
            }
        }
    }
}
