namespace constructorInharitance;

class Program
{
    public class Employee
    {
       public string Name { set; get; } 
       public int Age { set; get; }

       /// <summary> Makes employee one year older </summary>
       /// <returns>Returns new age of a employee</returns>
       public int GetAged()
       {
           Age += 1;
           return Age;
       }
       public virtual void Display()
       {
           Console.WriteLine($"employee {Name}, {Age}");
       }
       public Employee(string name, int age)
       {
           Name = name;
           Age = age;
       } 
    }

    public sealed class Manager : Employee
    {
        public override void Display()
        {
            base.Display();
            Console.WriteLine("Manager");
        }
        public  Manager(string name, int age) : base(name, age)
        {
        }
    }
    static void Main(string[] args)
    {
        Manager man = new Manager("Arda", 23);
        man.Display(); 
        Console.WriteLine(man.ToString());
    }
}