using PeopleManagement;
 string filePath = @"C:\Users\arjun\OneDrive\Desktop\C#\projects\PeopleManagement\Data\People.csv";
CSVParser cSVParser= new CSVParser();
var people = cSVParser.ParseCsv(filePath);
PeopleReport pr = new PeopleReport();
pr.saveMales(people);
pr.saveFemales(people);

Console.WriteLine("Reports generated successfully");