public class Admin:Person
{
    
    public string post;

 public Admin(string n,string p,DateTime d,char g):base(n,d,g)
 {
    post=p;
 }
   public override void PrintDetails()
    {
        // var output = name + ", " + rollNumber + ", " +  dateOfBirth.ToLongDateString(); 

        // string interpolation
        var message = $"{name}\t\t{post}\t\t{dateOfBirth.ToLongDateString()}\t\t{gender}";
        Console.WriteLine(message);
        base.PrintDetails();
        Console.WriteLine($"\t\t{post}");
    }
      public static void PrintHeader()
    {
        var header = $"Name\t\tpost\t\tDate Of Birth\t\tGender";
        Console.WriteLine(header);
    }


}