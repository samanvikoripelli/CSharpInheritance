using CSharp1;
using CSharp2;

class Program
{
    static void Main(string[] args)
    {
        //Car car = new Car("Toyota", 120);
        //Bike bike = new Bike("Yamaha", 80);
        //car.DisplayInfo();
        //bike.DisplayInfo();

        //Car1 car1 = new Car1("Audi", 120);
        //Bike1 bike1 = new Bike1("Honda", 80);
        //car1.DisplayInfo1();
        //bike1.DisplayInfo1();

        //Animal dog = new Dog();
        //Animal cat = new Cat();
        //dog.MakeSound();
        //cat.MakeSound();

        //Robot robot = new Robot();
        //robot.Start();
        //robot.Move();

        //Account account = new Account();
        //account.CalculateInterest();
        //SavingsAccount savings = new SavingsAccount();
        //savings.CalculateInterest();

        //Product laptop = new ElectronicProduct { Name = "Laptop", Price = 1000 };
        //Product tshirt = new ClothingProduct { Name = "T-Shirt", Price = 50 };
        //Console.WriteLine($"Product: {laptop.Name}, Discounted Price: ${laptop.GetDiscountedPrice()}");
        //Console.WriteLine($"Product: {tshirt.Name}, Discounted Price: ${tshirt.GetDiscountedPrice()}");

        SecuritySystem security = new SecuritySystem();
        security.AuthenticateUser();

        //Duck duck = new Duck();
        //duck.Fly();
        //duck.Swim();

        //Student student = new Student { name = "John", StudentID = 101 };
        //Person person = student;
        //Console.WriteLine("Upcasting: Student object is now treated as a Person.");
        //Student downcastedStudent = (Student)person;
        //Console.WriteLine("Downcasting: Person object is now treated as a Student again.");

        //Manager manager = new Manager("Alice", 75000, 5000);
        //manager.DisplayInfo();
    }
}