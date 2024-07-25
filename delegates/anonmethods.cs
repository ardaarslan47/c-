using System;

namespace anonmethods
{
  public class Person
  {
    public string Name {get; set;}
    public int Age {get; set;}
  }
  internal class Program
  {
    public delegate bool FilterDelegate(Person p);

    public static void Main()
    {
      Person[] people = new Person[2]{new Person(){Name = "Arda", Age = 23}, new Person(){Name = "Ali", Age = 14}};

      FilterDelegate filter = delegate (Person p)
      {
        return p.Age >= 20 && p.Age <= 30;
      };

      DisplayPeople(people, filter);
      DisplayPeople(people, delegate (Person p) { return p.Age < 18; });
    }

    public static void DisplayPeople(Person[] people, FilterDelegate filter)
    {
      foreach(Person p in people)
      {
        if(filter(p))
        {
          Console.WriteLine(p.Name);
        }
      }
    }
  }
}
