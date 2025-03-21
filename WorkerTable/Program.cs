using System;
using Spectre.Console;
using Bogus;

namespace WorkerTable
{
    public class Program
    {
        private static void Main(string[] args)
        {
            Randomizer.Seed = new Random(int.Parse(args[0]));
            int workers = int.Parse(args[0]);
            Faker faker = new Faker("pt_PT");
            int base_number = 1
            
            
            var table = new Table();

            table.AddColumn("ID");
            table.AddColumn(new TableColumn("Name"));
            table.AddColumn(new TableColumn("Job"));

            while (base_number <= workers)
            {
                table.AddRow(new Markup(base_number, faker.FullName, faker.JobTitle));
                base_number++;
                
            }


            AnsiConsole.Write(table);
        }
    }
}
