using System;

namespace DelegatesAndGenerics
{
  public delegate int Comparison<T>(T x, T y);

  public class Person
  {
    public int Age {get; set;}
    public string Name {get; set;}
  }

  public class PersonSorter
  {
    public void Sort(Person[] people, Comparison<Person> comparison)
    {
      // -1 for last person to be compared with previous one
      // otherwise last element will be comparisoned with value outside of bond of array
      for (int i = 0; i < people.Length - 1; i++)
      {
        for (int j = i + 1; j < people.Length; j++)
        {
          // if previous person greater than next swap their position
          if (comparison(people[i], people[j]) > 0)
          {
            Person temp = people[i];
            people[i] = people[j];
            people[j] = temp;
          }
        }
      }
    }
  }

  internal class Program
  {
    static void Main()
    {
      Person[] people =
    {
      new Person {Name = "Arda", Age = 23},
      new Person {Name = "Azize", Age = 22},
      new Person {Name = "Ozan", Age = 25}
    };

    PersonSorter sorter = new PersonSorter();

    sorter.Sort(people, CompareByAge);

    foreach (Person p in people)
    {
      Console.WriteLine(p.Name);
    }

    }
    
    static int CompareByAge(Person x, Person y)
    {
      return x.Age - y.Age; 
    }
  }
}
