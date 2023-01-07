using System;
using System.Text;

namespace Lab2.Step1
{
    class Program
    {
        public const int MaxNumberOfBranches = 10;
        public const int MaxNumberOfAnimals = 50;
        public const int MaxNumberOfBreeds = 50;
        static void Main(string[] args)
        {
           
            ExtraCode.Branch[] branches = new ExtraCode.Branch[MaxNumberOfBranches];
            int NumberOfBranches = 0;
            const string DataDir = @"..\..\Data";
            ExtraCode.InOut.ReadData(DataDir, branches, ref NumberOfBranches);
            ExtraCode.InOut.PrintDataToConsole(branches, NumberOfBranches);
            Console.WriteLine("Registruoti šunys surikiuoti:");
            ExtraCode.Branch KaunoSunys = ExtraCode.TaskUtils.GetAnimals(branches[0], branches[0].Town,
           typeof(ExtraCode.Dog));
            KaunoSunys.SortAnimals();
            ExtraCode.InOut.PrintAnimalsToConsole(KaunoSunys, branches[0].Town);
            Console.WriteLine();
            Console.WriteLine("Registruotos katės surikiuotos:");
            ExtraCode.Branch KaunoKates = ExtraCode.TaskUtils.GetAnimals(branches[0], branches[0].Town,
           typeof(ExtraCode.Cat));
            KaunoKates.SortAnimals();
            ExtraCode.InOut.PrintAnimalsToConsole(KaunoKates, branches[0].Town);
            Console.WriteLine();
            Console.WriteLine("Agresyvūs šunys\n {0}: {1}", branches[0].Town,
           ExtraCode.TaskUtils.CountAggressive(branches[0]));
            Console.WriteLine("Agresyvūs šunys\n {0}: {1}", branches[1].Town,
           ExtraCode.TaskUtils.CountAggressive(branches[1]));
            Console.WriteLine("Populiariausia šunų veislė\n {0}: {1}", branches[0].Town,
           ExtraCode.TaskUtils.GetMostPopularBreed(ExtraCode.TaskUtils.GetAnimals(branches[0], "Filialas: {0} Gyvūnas:šuo", typeof(ExtraCode.Dog))));
            Console.WriteLine("Populiariausia kačių veislė\n {0}: {1}", branches[1].Town,
           ExtraCode.TaskUtils.GetMostPopularBreed(ExtraCode.TaskUtils.GetAnimals(branches[1], "Filialas: {0} Gyvūnas:katė", typeof(ExtraCode.Cat))));
            Console.WriteLine();
            Console.WriteLine("Pagal lusto Nr. surūšiuotas visų filialų šunų sąrašas:");
            Console.WriteLine();
            ExtraCode.Branch allDogs = new ExtraCode.Branch("Visi šunys");
            ExtraCode.TaskUtils.GetAllDogs(branches, NumberOfBranches, ref allDogs, "Filialas: {0}Gyvūnas: šuo");
            allDogs.SortAnimals();
            ExtraCode.InOut.PrintAnimalsToConsole(allDogs, allDogs.Town);
        }
    }

}
