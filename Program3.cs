using System;

namespace Assignment3
{
    // 1. Employee Class
    class Employee
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public double Salary { get; set; }

        public void DisplayDetails()
        {
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"Age: {Age}");
            Console.WriteLine($"Salary: {Salary:C}");
        }
    }

    // 2. BankAccount Class
    class BankAccount
    {
        public string AccountNumber { get; set; }
        public string AccountHolderName { get; set; }
        public double Balance { get; private set; }

        public void Deposit(double amount)
        {
            Balance += amount;
            Console.WriteLine($"Deposited: {amount:C}");
        }

        public void Withdraw(double amount)
        {
            if (amount <= Balance)
            {
                Balance -= amount;
                Console.WriteLine($"Withdrawn: {amount:C}");
            }
            else
            {
                Console.WriteLine("Insufficient balance.");
            }
        }

        public void DisplayDetails()
        {
            Console.WriteLine($"Account Number: {AccountNumber}");
            Console.WriteLine($"Account Holder: {AccountHolderName}");
            Console.WriteLine($"Balance: {Balance:C}");
        }
    }

    // 3. Static MathHelper Class
    static class MathHelper
    {
        public static double CalculateAverage(int[] numbers)
        {
            if (numbers.Length == 0) return 0;
            double sum = 0;
            foreach (int num in numbers) sum += num;
            return sum / numbers.Length;
        }
    }

    // 4. Static Logger Class
    static class Logger
    {
        public static void LogMessage(string message)
        {
            Console.WriteLine($"[LOG]: {message}");
        }
    }

    // 5. Partial Person Class (merged into one file)
    public partial class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
    public partial class Person
    {
        public void PrintFullName()
        {
            Console.WriteLine($"{FirstName} {LastName}");
        }
    }

    // 6. Partial EmployeeDetails Class (merged into one file)
    public partial class EmployeeDetails
    {
        public string Name { get; set; }
        public double BasicSalary { get; set; }
        public double Allowances { get; set; }
    }
    public partial class EmployeeDetails
    {
        public double CalculateTotalSalary()
        {
            return BasicSalary + Allowances;
        }
    }

    // 7. Abstract Shape Class
    abstract class Shape
    {
        public abstract double CalculateArea();
    }
    class Circle : Shape
    {
        public double Radius { get; set; }
        public override double CalculateArea() => Math.PI * Radius * Radius;
    }
    class Rectangle : Shape
    {
        public double Width { get; set; }
        public double Height { get; set; }
        public override double CalculateArea() => Width * Height;
    }

    // 8. Abstract Animal Class
    abstract class Animal
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public abstract void Speak();
    }
    class Dog : Animal
    {
        public override void Speak() => Console.WriteLine("Woof! Woof!");
    }
    class Cat : Animal
    {
        public override void Speak() => Console.WriteLine("Meow! Meow!");
    }

    // 9. Sealed Car Class
    class Vehicle
    {
        public void StartEngine() => Console.WriteLine("Engine started.");
        public void StopEngine() => Console.WriteLine("Engine stopped.");
    }
    sealed class Car : Vehicle
    {
        public void Drive() => Console.WriteLine("Car is driving.");
    }

    // 10. Sealed SavingsAccount Class
    class BankAccount2
    {
        public string AccountNumber { get; set; }
        public double Balance { get; set; }
    }
    sealed class SavingsAccount : BankAccount2
    {
        public double InterestRate { get; set; }
        public double CalculateInterest()
        {
            return Balance * InterestRate / 100;
        }
    }

    // Main Program to test all
    class Program
    {
        static void Main()
        {
            Console.WriteLine("===== Employee Test =====");
            Employee emp = new Employee { Name = "John", Age = 30, Salary = 50000 };
            emp.DisplayDetails();

            Console.WriteLine("\n===== Bank Account Test =====");
            BankAccount acc = new BankAccount { AccountNumber = "12345", AccountHolderName = "Alice" };
            acc.Deposit(1000);
            acc.Withdraw(200);
            acc.DisplayDetails();

            Console.WriteLine("\n===== MathHelper Test =====");
            int[] nums = { 1, 2, 3, 4, 5 };
            Console.WriteLine("Average: " + MathHelper.CalculateAverage(nums));

            Console.WriteLine("\n===== Logger Test =====");
            Logger.LogMessage("This is a test log");

            Console.WriteLine("\n===== Partial Person Test =====");
            Person p = new Person { FirstName = "Aryansh", LastName = "Chaudhary" };
            p.PrintFullName();

            Console.WriteLine("\n===== Partial EmployeeDetails Test =====");
            EmployeeDetails e = new EmployeeDetails { Name = "Mark", BasicSalary = 30000, Allowances = 5000 };
            Console.WriteLine($"Total Salary: {e.CalculateTotalSalary()}");

            Console.WriteLine("\n===== Shape Test =====");
            Circle c = new Circle { Radius = 5 };
            Rectangle r = new Rectangle { Width = 4, Height = 6 };
            Console.WriteLine($"Circle Area: {c.CalculateArea()}");
            Console.WriteLine($"Rectangle Area: {r.CalculateArea()}");

            Console.WriteLine("\n===== Animal Test =====");
            Dog d = new Dog { Name = "Buddy", Age = 3 };
            Cat cat = new Cat { Name = "Kitty", Age = 2 };
            d.Speak();
            cat.Speak();

            Console.WriteLine("\n===== Vehicle & Car Test =====");
            Car car = new Car();
            car.StartEngine();
            car.Drive();
            car.StopEngine();

            Console.WriteLine("\n===== Savings Account Test =====");
            SavingsAccount sa = new SavingsAccount
            {
                AccountNumber = "67890",
                Balance = 10000,
                InterestRate = 5
            };
            Console.WriteLine($"Interest: {sa.CalculateInterest()}");
        }
    }
}
