﻿using System.Threading.Tasks;

namespace CatWorx.BadgeMaker
{
    class Program
    {
        async static Task Main(string[] args)
        {
            List<Employee> employees = PeopleFetcher.UseApiQuestion() ? await PeopleFetcher.GetFromApi() : PeopleFetcher.GetEmployees();
            Util.PrintEmployees(employees);
            Util.MakeCSV(employees);
            await Util.MakeBadges(employees);
        }
    }
}