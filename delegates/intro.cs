using system;

namespace intro
{
  class Person
  {
    public string Name {get; set;}
    public int Age {get; set;}
  }
  class Program
  {
    static void main(string[] args)
    {
      public delegate bool FilterDelegate(Person p);

//    List<string> names = new List<string>() { "Arda", "Azize", "Ahmet" };
//    names.RemoveAll(Filter);

//    foreach (string name in names)
//    {
//      Console.WritelLine(name);
//    }
//
      List<Person> people = new List<Person>() {
       new Person() { Name = "Arda", Age = 23 },
       new Person() { Name = "Azize", Age = 22},
       new Person() { Name = "Ahmet", Age = 24 } 
      }
      
      DisplayPeople(people, isMinor);

    }
    static void DisplayPeople(List<Person> people, FilterDelegate filter)
    {
      foreach (Person p in people)
      {
        if(filter(p))
        {
          Console.WriteLine(p.Name);
        }
      }
    }

    static bool isMinor(Person p)
    {
      return p.Age < 18;
    }

    static bool Filter(string s)
    {
      return s.Contains("i");
    }
  }
}
