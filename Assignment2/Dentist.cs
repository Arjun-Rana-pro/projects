
class Dentist:Person,IMedicine
{
    public string specilization;
    public int experience;
    public Dentist(string name, DateTime d,string a,char g,string s,int e ):base(name,d,a,g){
        this.specilization = s;
        this.experience = e;
    }
       public List<string> GetRoles()=>new List<string>{"diagonasis","advice","pain killer"};
    public override void displayPersonInfo()
    {
        base.displayPersonInfo(); 
        var message=$"{specilization}\t\t{experience}";
        Console.Write("msg");
    }
    
            public static void printHeader()
            {
                var msg=$"Name\tdateOfBirth\tGender\tAddress\tExperience\tSpecilist";
                Console.WriteLine(msg);
            }
}