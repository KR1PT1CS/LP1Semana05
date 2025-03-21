using System;
using Bogus;
using Bogus.DataSets;
using Spectre.Console;

namespace WorkerTable
{
    public class Program
    {
        private static void Main(string[] args)
        {
            int count = int.Parse(args[0]);
            Randomizer.Seed = new Random(int.Parse(args[0]));
            Faker faker = new Faker ("pt_PT");
            
            var columns = new List<Faker>(){
            new Faker("Item 1"),
            new Faker("Item 2"),
            new Faker("Item 3")
            }
        }
    }
}
