namespace PeopleManagement;

public class PeopleReport
{
  public void saveMales(List<Person> people)
  {
    var males = people.Where(p =>p.sex=="male").ToList();
    Console.WriteLine(males);

  }
  public void saveFemales(List<Person> people)
  {
    var females = people.Where(p =>p.sex == "female").ToList();
    Console.WriteLine($"females: {females}");
  }
  public void saveDotComUsers(List<Person> people)
  {

  }
}