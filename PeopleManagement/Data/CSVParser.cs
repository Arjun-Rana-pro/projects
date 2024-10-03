namespace PeopleManagement;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
using System.IO;
using Microsoft.VisualBasic;

public class CSVParser
{
  

    public List<Person> ParseCsv()
    { 
       string filePath = @"C:\Users\arjun\OneDrive\Desktop\C#\projects\PeopleManagement\Data\People.csv";

            var people = new List<Person>();
            var lines = File.ReadAllLines(filePath);
            var header = lines[0];
            var headerParts = header.Split(",");
            Console.WriteLine(headerParts);
            foreach (var dataline in lines.Skip(1))
            {  
                var dataParts = dataline.Split(",");
                var person = new Person
                {
                 index = int.Parse(dataParts[0]),
                 userId = dataParts[1],
                 firstName = dataParts[2],
                 lastName = dataParts[3],
                    sex = dataParts[4],
                 email = dataParts[5],
                 phoneNumber=long.Parse(dataParts[6]),
                 dateOfBirth = DateTime.Parse(dataParts[7]),
                 jobTitle = dataParts[8]
               };
                people.Add(person);
           }
           return people;
        
        
    }
    }

