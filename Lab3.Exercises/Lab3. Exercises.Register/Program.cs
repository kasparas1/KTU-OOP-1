using System;
using System.Collections.Generic;

namespace Lab3.Exercises.Register
{
    class Program
    {
        static void Main(string[] args)
        {
            DogsContainer dogs = InOutUtils.ReadDogs("Dogs.csv");
            dogs.Sort();
            Console.WriteLine("Registro informacija:");
            InOutUtils.PrintDogs(dogs);
            Console.WriteLine();
            Console.WriteLine("Iš viso šunų: {0}", dogs.Count);
            Console.WriteLine("Patinų: {0}", dogs.CountByGender(Gender.Male, dogs));
            Console.WriteLine("Patelių: {0}", dogs.CountByGender(Gender.Female, dogs));
            Console.WriteLine();
            List<Vaccination> VaccinationsData = InOutUtils.ReadVaccinations(@"Vaccinations.csv");
            dogs.UpdateVaccinationsInfo(VaccinationsData);
            Console.WriteLine("Šunys kuriems reikia vakcinuotis:");

           //InOutUtils.PrintDogs(dogs.FilterByVaccinationExpired());
            
            /*
            Dog oldestDog = TaskUtils.FindOldestDog(register);
            Console.WriteLine("Seniausias šuo:");
            InOutUtils.PrintDog(oldestDog);
            Console.WriteLine();
            List<string> breeds = TaskUtils.FindBreeds(register);
            Console.WriteLine("Šunų veislės:");
            InOutUtils.PrintBreeds(breeds);
            Console.WriteLine();
            List<string> popularBreeds = TaskUtils.FindMostPopularBreeds(register);
            Console.WriteLine("Populiariausios šunų veislės:");
            InOutUtils.PrintBreeds(popularBreeds);
            Console.WriteLine();
            Console.WriteLine("Kokios veislės šunis atrinkti?");
            string selectedBreed = Console.ReadLine().Trim();
            if (selectedBreed.Equals(""))
            {
                Console.WriteLine("Šunio veislė neįvesta");
                return;
            }
            List<Dog> filteredByBreed = TaskUtils.FilterByBreed(register, selectedBreed);
            if (filteredByBreed.Count == 0)
            {
                Console.WriteLine("Šunų su veisle '{0}' nerasta", selectedBreed);
                return;
            }
            Dog oldestFilteredDog = TaskUtils.FindOldestDog(filteredByBreed);
            Console.WriteLine("Seniausias šuo pagal '{0}' veislę:", selectedBreed);
            InOutUtils.PrintDog(oldestFilteredDog);
            InOutUtils.PrintDogs(filteredByBreed);
            string fileName = selectedBreed + ".csv";
            InOutUtils.PrintDogsToCSVFile(fileName, filteredByBreed);
            */
        }
    }
}
