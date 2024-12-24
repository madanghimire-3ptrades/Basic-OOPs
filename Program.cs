using BasicOOPSRevise.Animals;
using BasicOOPSRevise.Interfaces;
using BasicOOPSRevise.Models;
using BasicOOPSRevise.Shapes;
using BasicOOPSRevise.utils;
using BasicOOPSRevise.Vehicles;
using System;
using System.Collections.Generic;



namespace BasicOOPSRevise
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== 1. Class and Object Demo ===");
            Person person1 = new Person("John", 30);
            person1.Introduce();

            Console.WriteLine("\n=== 2. Encapsulation Demo ===");
            BankAccount account = new BankAccount("12345", 1000);
            account.Deposit(500);
            account.WithDraw(200);
            Console.WriteLine($"Current Balance: ${account.Balance}");


            Console.WriteLine("\n=== 3. Inheritance Demo ===");
            Student student = new Student("Alice", 20, "CS101");
            student.Introduce();
            student.Study();


            Console.WriteLine("\n=== 4. Polymorphism Demo ===");

            Shape[] shapes = new Shape[]
            {
                new Circle(5),
                new Rectangle(4, 6)
            };

            foreach (Shape shape in shapes)
            {
                Console.WriteLine($"Area of {shape.GetType().Name}: {shape.CalculateArea()} ");
            }


            Console.WriteLine("\n=== 5. Abstraction Demo ===");
            Vehicle car = new Car("Toyota");
            Vehicle bike = new Bicycle("Giant");

            car.Start();
            bike.Start();


            Console.WriteLine("\n=== Method Overriding Examples ===\n");
            // Basic overriding
            Console.WriteLine("1. Basic Method Overriding:");



            Console.WriteLine("\n=== 6. Interface Demo ===");
            List<IPayable> payableItems = new List<IPayable>
            {
                new Employee("Bob", 5000),
                new Invoice(1000)
            };

            foreach (var item in payableItems)
            {
                Console.WriteLine($"Payment Amount: ${item.CalculatePayment()}");
            }


            Console.WriteLine("\n=== 7. Static Members Demo ===");
            Console.WriteLine($"Number of persons created: {Person.Count}");
            Console.WriteLine($"PI value: {MathOperations.PI}");
            Console.WriteLine($"Add numbers: {MathOperations.Add(5, 3)}");

            Console.WriteLine("\n=== 8. Properties Demo ===");
            Product product = new Product();
            product.Name = "Laptop";
            product.Price = 999.99m;
            Console.WriteLine($"Product: {product.Name}, Price: ${product.Price}");

            Console.WriteLine("\n=== 9. Method Overloading Demo ===");
            Calculator calc = new Calculator();
            Console.WriteLine($"Add two numbers: {calc.Add(5, 3)}");
            Console.WriteLine($"Add three numbers: {calc.Add(5, 3, 2)}");


            Console.WriteLine("\n=== 10. Composition Demo ===");
            Address address = new Address("123 Main St", "Cityville");
            Employee employee = new Employee("Jane", 6000) { Address = address };
            employee.DisplayInfo();

            Console.WriteLine("=== Method Overriding Examples ===\n");

            Console.WriteLine("1. Basic Method Overriding:");
            Animal animal = new Animal();
            Dog dog = new Dog();
            Cat cat = new Cat();
            Bird bird = new Bird();

            animal.MakeSound();
            dog.MakeSound();
            cat.MakeSound();
            bird.MakeSound();

            Console.WriteLine("\n2. Polymorphic Behavior:");
            List<Animal> animals = new List<Animal> { animal, dog, cat, bird };
            foreach (var a in animals)
            {
                Console.Write($"{a.GetType().Name} sound: ");
                a.MakeSound();
            }

            Console.WriteLine("\n3. Method Overriding with Parameters:");
            dog.Eat("bone");
            dog.Eat("carrot");
            cat.Eat("fish");
            cat.Eat("carrot");

            Console.WriteLine("\n4. Base Class Method Calling:");
            Animal dogAsAnimal = new Dog();
            dogAsAnimal.Sleep();

            Console.WriteLine("\n5. Return Type Overriding:");
            Console.WriteLine($"Dog age: {dog.GetAge()}");
            Console.WriteLine($"Cat age: {cat.GetAge()}");

            Console.WriteLine("\n6. Property Overriding:");
            Console.WriteLine($"Dog species: {dog.Species}");




            Console.ReadKey();

        }
    }
}
