//public class Person(string n,DateTime d,string g,string a)
//{
    //public string name=n;
   // public DateTime dateOfBirth=d;
   // public string gender=g;
   // public string address=a;

  //  public void displayPersonInfo()
   // {
   //     var msg =$"{name}\t\t{dateOfBirth.ToString()}\t\t{gender}\t\t\t{address}";
   //     Console.WriteLine(msg);
   //}
//}
class Person 
{
    public string name;
    public DateTime dateOfBirth;
    public char Gender{get;set;}
    public string address;

    public Person(string name, DateTime d, string a, char g){
        this.name = name;
        this.dateOfBirth = d;
        this.address = a;
        this.Gender = g;
    }
    public virtual void displayPersonInfo()
    {
    
        var message = $"{name}\t{dateOfBirth.ToString()}\t{Gender}\t{address.ToString()}";
        Console.WriteLine(message);
            }
}