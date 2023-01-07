using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Lab3.Exercises.Register
{
    class InOutUtils
    {
        public static List<Vaccination> ReadVaccinations(string fileName)
        {
            List<Vaccination> Vaccinations = new List<Vaccination>();
            string[] Lines = File.ReadAllLines(fileName);
            foreach (string line in Lines)
            {
                string[] values = line.Split(';');
                int id = int.Parse(values[0]);
                DateTime vaccinationDate = DateTime.Parse(values[1]);
                Vaccination v = new Vaccination(id, vaccinationDate);
                Vaccinations.Add(v);
            }
            return Vaccinations;
        }
        public static DogsContainer ReadDogs(string fileName)
        {
            DogsContainer dogs = new DogsContainer();
            string[] Lines = File.ReadAllLines(fileName, Encoding.UTF8);
            foreach (string line in Lines)
            {
                string[] values = line.Split(';');
                int id = int.Parse(values[0]);
                string name = values[1];
                string breed = values[2];
                DateTime birthDate = DateTime.Parse(values[3]);
                Gender gender;
                Enum.TryParse(values[4], out gender); //tries to convert value to enum
                Dog dog = new Dog(id, name, breed, birthDate, gender);
                if (!dogs.Contains(dog))
                {
                    dogs.Add(dog);
                }
            }
            return dogs;
        }
        public static void PrintDogs(string label, DogsContainer dogs)
        {
            Console.WriteLine(new string('-', 74));
            Console.WriteLine("| {0,8} | {1,-15} | {2,-15} | {3,-12} | {4,-8} |", "Reg.Nr.", "Vardas", "Veislė", "Gimimo data", "Lytis");
            Console.WriteLine(new string('-', 74));
            for (int i = 0; i < dogs.Count; i++)
            {
                Dog dog = dogs.Get(i);
                Console.WriteLine("| {0,8} | {1,-15} | {2,-15} | {3,-12:yyyy-MM-dd} | {4,-8} |", dog.ID, dog.Name, dog.Breed, dog.BirthDate, dog.Gender);
            }
            Console.WriteLine(new string('-', 74));
        }
        public static void PrintDogs(DogsContainer dogs)
        {
            Console.WriteLine(new string('-', 74));
            Console.WriteLine("| {0,8} | {1,-15} | {2,-15} | {3,-12} | {4,-8} |", "Reg.Nr.", "Vardas", "Veislė", "Gimimo data", "Lytis");
            Console.WriteLine(new string('-', 74));
            for (int i = 0; i < dogs.Count; i++)
            {
                Dog dog = dogs.Get(i);
                Console.WriteLine("| {0,8} | {1,-15} | {2,-15} | {3,-12:yyyy-MM-dd} | {4,-8} |", dog.ID, dog.Name, dog.Breed, dog.BirthDate, dog.Gender);
            }
            Console.WriteLine(new string('-', 74));
        }
        public static void PrintDog(Dog dog)
        {
            Console.WriteLine("Vardas: {0}, Veislė: {1}, Amžius: {2}", dog.Name, dog.Breed, dog.Age);
        }
        public static void PrintBreeds(List<string> breeds)
        {
            foreach (string breed in breeds)
            {
                Console.WriteLine(breed);
            }
        }
        public static void PrintDogsToCSVFile(string fileName, List<Dog> Dogs)
        {
            string[] lines = new string[Dogs.Count + 1];
            lines[0] = String.Format("{0};{1};{2};{3};{4}", "Reg.Nr.", "Vardas", "Veislė", "Gimimo data", "Lytis");
            for (int i = 0; i < Dogs.Count; i++)
            {
                lines[i + 1] = String.Format("{0};{1};{2};{3};{4}", Dogs[i].ID, Dogs[i].Name, Dogs[i].Breed, Dogs[i].BirthDate, Dogs[i].Gender);
            }
            File.WriteAllLines(fileName, lines, Encoding.UTF8);
        }
    }
}
