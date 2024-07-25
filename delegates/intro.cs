using System;
using System.Collections.Generic;

namespace intro
{
  internal class Person
  {
    public string Name {get; set;}
    public int Age {get; set;}
  }
  internal class Program
  {
    public static void Main(string[] args)
    {

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
       new Person() { Name = "Ahmet", Age = 14 } 
      };
      
      DisplayPeople(people, isMinor);

    }
    public delegate bool FilterDelegate(Person p);
    public static void DisplayPeople(List<Person> people, FilterDelegate filter)
    {
      foreach (Person p in people)
      {
        if(filter(p))
        {
          Console.WriteLine(p.Name);
        }
      }
    }

    public static bool isMinor(Person p)
    {
      return p.Age < 18;
    }

    public static bool Filter(string s)
    {
      return s.Contains("i");
    }
  }
}
