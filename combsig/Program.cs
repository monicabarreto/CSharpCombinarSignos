using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proj003
{
    class Carteira
    {
        public static void Main()
        {


            var signos = new[] { "", "peixes", "cancer", "escorpiao", "capricornio", "touro", "virgem", "Leão", " Gêmeos", "Aries", "Libra", "Aquario", "Sagitário" };

            var cont = 1;
            for (int i = 1; i < signos.Length; i++)
            {
                Console.WriteLine($"{cont} - {signos[i]}");
                cont++;
            }

            Console.WriteLine("Escolha um signo:");
            string signo1 = Console.ReadLine();

            Console.WriteLine("Escolha  outro signo:");
            string signo2 = Console.ReadLine();

            string res = $"{signos[int.Parse(signo1)]}-{signos[int.Parse(signo2)]}";

            switch (res)
            {
                case "peixes-capricornio":
                    Console.WriteLine("peixes se sente seguro com signo de terra");
                    break;
                case "peixes-cancer":
                    Console.WriteLine("peixes se sente seguro com signo de terra");
                    break;
                case "peixes-escorpiao":
                    Console.WriteLine("peixes se sente seguro com signo de terra");
                    break;
                case "peixes-touro":
                    Console.WriteLine("peixes se sente seguro com signo de terra");
                    break;
                case "peixes-virgem":
                    Console.WriteLine("peixes se sente seguro com signo de terra");
                    break;

                case "peixes-Leão":
                    Console.WriteLine("peixes se sente seguro com signo de terra");
                    break;
                case "peixes-Gêmeos":
                    Console.WriteLine("peixes se sente seguro com signo de terra");
                    break;
                case "peixes-peixes":
                    Console.WriteLine("peixes se sente seguro com signo de terra");
                    break;
                case "peixes-Libra":
                    Console.WriteLine("peixes se sente seguro com signo de terra");
                    break;
                case "peixes-aquario":
                    Console.WriteLine("peixes se sente seguro com signo de terra");
                    break;
                case "peixes-Sagitário":
                    Console.WriteLine("peixes se sente seguro com signo de terra");
                    break;
            }



            Console.ReadLine();
        }
    }
}
