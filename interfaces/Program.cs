namespace interfaces;

class Program
{
    public interface IAnimal
    {
        void MakeSound(); 
        void Eat(string food);
    }

    public class Cat : IAnimal
    {
        public void MakeSound()
        {
            Console.WriteLine("meow");
        }

        public void Eat(string food)
        {
           Console.WriteLine($"Cat eats {food}"); 
        }
    }

    public class Dog : IAnimal
    {
        public void MakeSound()
        {
            Console.WriteLine("Bark!");
        }

        public void Eat(string food)
        {
            Console.WriteLine($"Dog eats {food}");
        }
    }
    static void Main(string[] args)
    {
        Dog dog = new Dog();
        dog.MakeSound();
        dog.Eat("treat");

        Cat cat = new Cat();
        cat.MakeSound();
        cat.Eat("fish");

        IAnimal dog2 = new Dog();
        dog2.MakeSound();

        PaymentService service = new PaymentService(new CreditCardProcessor());

        PaymentService service2 = new PaymentService(new PayPalProcessor());
        
        service.ProcessOrderPayment(300);
        service2.ProcessOrderPayment(300);
    }
}