
class Dentist:Person,IMedicine
{
    public string specilization;
    public int experience;
    public Dentist(string name, DateTime d,string a,char g,string s,int e ):base(name,d,a,g){
        specilization = s;
        experience = e;
    }
       public List<string> GetMedicineNames()=>new List<string>{"pain killer","paracetamole"};
       public string GetDose()=>new string("");
       public string SideEffects()=>new string("");
    public override void displayPersonInfo()
    {
        base.displayPersonInfo(); 
        Console.Write($"{specilization}\t\t{experience}");
    }
    
            public static void printHeader()
            {
                var msg=$"Name\tdateOfBirth\tGender\tAddress\tExperience\tSpecilist";
                Console.WriteLine(msg);
            }
}