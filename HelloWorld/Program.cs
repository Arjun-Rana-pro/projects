﻿// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
﻿// OOP: Object Oriented Programming with C#
// C#: Multi Paradigm Language
// Static vs Dynamic
// Procedural vs OOP vs Functional
// Imperative vs Declarative

// var student1 = new Student();
// student1.name = "Bhawana Rawal";
// student1.rollNumber = 34;
// student1.dateOfBirth = new DateTime(2000, 12, 12);
// student1.PrintDetails();

// var student2 = new Student();
// student2.name = "James Bond";
// student2.rollNumber = 67;
// student2.dateOfBirth = new DateTime(1990, 1, 11);
// student2.PrintDetails();

// Create two more student objects and print student details in console in following format
// Name     Roll Number  DOB    Gender
// Bhawana Rawal   0       Tuesday, December 12, 2000   F
// James Bond      0       Thursday, January 11, 1990   M


//Student.PrintHeader();

//var student = new Student("Sita Bond", 68, new DateTime(1990, 1, 11), 'F');
//student.PrintDetails();

//var student3 = new Student("James Bond", 67, new DateTime(1990, 1, 11), 'F');
//student3.PrintDetails();

//var student4 = new Student("Rakeesh Bond", 798, new DateTime(2000, 1, 11), 'M');
//student4.PrintDetails();

//Admin.PrintHeader();
//var admin1 = new Admin("Arjun Rana", "Admin",new DateTime(1999, 1,5),'M');
//admin1.PrintDetails();

//Methods m = new();
//m.SayHello();
//m.SayHello("Hi!!!");

//var av = m.GetAverage(23, 45, 67, 34, 456456, 45646, 335);
//var (Sum, Avarage) = m.GetResults(23, 45, 67, 34, 456456);

//Generics g = new();
//g.Print<decimal>(234.234234m);
//g.Print<string>("Hello");

 //Collections c= new ();
 //c.LearnList();
 //c.LearnArrays();
 //c.LearnDictionary();
  FileAndFolderHandler fd= new();
  //fd.CreateFile();
  //fd.ReadFile();
  //fd.CreateFolder("ABC");
  fd.ReadCsvFolder();
 


