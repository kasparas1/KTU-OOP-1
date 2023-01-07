using System;


namespace Introduction.If.Step1
{
    class Program
    {
        static void Main(string[] args)
        {
            char character;
            int no = 0, columnNo = 0;
            Console.WriteLine("Iveskite spausdinama simboli");
            character = (char)Console.Read();
            Console.ReadLine();
            Console.WriteLine("Iveskite kiek simboliu norite");
            no = int.Parse(Console.ReadLine());
            Console.WriteLine("Iveskite kiek eiluteje norite simboliu");
            columnNo = int.Parse(Console.ReadLine());
            for (int i = 0; i < no; i++)
            {
                for (int j = 0; j < columnNo; j++)
                    Console.Write(character);
                Console.WriteLine();
            }

            Console.ReadKey();
        }
    }
}
