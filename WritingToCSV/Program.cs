using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using CsvHelper;

namespace WritingToCSV
{
    /// <summary>
    /// read from object class and write into csv file 
    /// https://code-maze.com/csharp-writing-csv-file/
    /// </summary>
    
    class Program
    {
        static void Main(string[] args)
        {
            //var myPersonObjects = new List<Person>()
            //{
            //    new Person { Id = 1, IsLiving = true, Name = "John" },
            //    new Person { Id = 2, IsLiving = true, Name = "Steve" },
            //    new Person { Id = 3, IsLiving = true, Name = "James" }
            //};

            //using (var writer = new StreamWriter("filePersons.csv"))
            //using (var csv = new CsvWriter(writer, CultureInfo.InvariantCulture))
            //{
            //    csv.WriteRecords(myPersonObjects);
            //}

            //Read from csv 

            using (var reader = new StreamReader("D:\\file.csv"))
            using (var csv = new CsvReader(reader, CultureInfo.InvariantCulture))
            {
                var records = csv.GetRecords<Person>();
                foreach (var item in records)
                {
                    Console.WriteLine($"{item.Id} {item.Name} {item.IsLiving}");
                }
            }
            Console.WriteLine("Done!");
        }
    }


    public class Person
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public bool IsLiving { get; set; }
    }
}
