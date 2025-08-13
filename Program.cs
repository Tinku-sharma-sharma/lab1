using System;
using System.Collections.Generic;

namespace Assignment2
{

    class UserProfile
    {
        private string username;
        private string password;
        private string email;

        public string Username
        {
            get { return username; }
            set
            {
                if (!string.IsNullOrWhiteSpace(value))
                    username = value;
                else
                    Console.WriteLine("Invalid username!");
            }
        }

        public string Password
        {
            get { return password; }
            set
            {
                if (!string.IsNullOrWhiteSpace(value) && value.Length >= 6)
                    password = value;
                else
                    Console.WriteLine("Password must be at least 6 characters.");
            }
        }

        public string Email
        {
            get { return email; }
            set
            {
                if (value.Contains("@"))
                    email = value;
                else
                    Console.WriteLine("Invalid email format.");
            }
        }

        public void DisplayProfile()
        {
            Console.WriteLine($"Username: {username}, Email: {email}");
        }
    }


    class Vehicle
    {
        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
    }

    class Truck : Vehicle
    {
        public void DisplayDetails()
        {
            Console.WriteLine($"Truck: {Make} {Model} ({Year})");
        }
    }

    class Bus : Vehicle
    {
        public void DisplayDetails()
        {
            Console.WriteLine($"Bus: {Make} {Model} ({Year})");
        }
    }


    class Calculator
    {
        public int Add(int a, int b) => a + b;
        public float Add(float a, float b) => a + b;
        public double Add(double a, double b) => a + b;
        public int Add(int a, int b, int c) => a + b + c;
    }


    abstract class Employee
    {
        public string Name { get; set; }
        public abstract double CalculateSalary();
    }

    class FullTimeEmployee : Employee
    {
        public double MonthlySalary { get; set; }
        public override double CalculateSalary() => MonthlySalary;
    }

    class PartTimeEmployee : Employee
    {
        public double HourlyRate { get; set; }
        public int HoursWorked { get; set; }
        public override double CalculateSalary() => HourlyRate * HoursWorked;
    }


    class Student
    {
        public string Name { get; set; }
        public int RollNo { get; set; }
        public double Marks { get; set; }

        public Student()
        {
            Name = "Unknown";
            RollNo = 0;
            Marks = 0;
        }

        public Student(string name, int rollNo)
        {
            Name = name;
            RollNo = rollNo;
            Marks = 0;
        }

        public Student(string name, int rollNo, double marks)
        {
            Name = name;
            RollNo = rollNo;
            Marks = marks;
        }

        public void Display()
        {
            Console.WriteLine($"Name: {Name}, Roll No: {RollNo}, Marks: {Marks}");
        }
    }


    class Product
    {
        public int ProductID { get; set; }
        public string ProductName { get; set; }

        private double price;
        public double Price
        {
            get { return price; }
            set
            {
                if (value >= 0)
                    price = value;
                else
                    Console.WriteLine("Price cannot be negative.");
            }
        }

        public int Quantity { get; set; }

        public void Display()
        {
            Console.WriteLine($"ID: {ProductID}, Name: {ProductName}, Price: {Price}, Quantity: {Quantity}");
        }
    }


    class Book
    {
        public string Title { get; set; }
        public bool IsAvailable { get; set; } = true;
    }

    class Member
    {
        public string Name { get; set; }
        public List<Book> BorrowedBooks { get; set; } = new List<Book>();
    }

    class Library
    {
        public List<Book> Books { get; set; } = new List<Book>();
        public List<Member> Members { get; set; } = new List<Member>();

        public void RegisterMember(Member m) => Members.Add(m);

        public void AddBook(Book b) => Books.Add(b);

        public void LendBook(string title, Member m)
        {
            Book book = Books.Find(b => b.Title == title && b.IsAvailable);
            if (book != null)
            {
                book.IsAvailable = false;
                m.BorrowedBooks.Add(book);
                Console.WriteLine($"{m.Name} borrowed {title}");
            }
            else
                Console.WriteLine("Book not available.");
        }
    }


    class Program
    {
        static void Main()
        {

            Console.WriteLine("\n--- Experiment 1 ---");
            UserProfile u1 = new UserProfile { Username = "John", Password = "123456", Email = "john@mail.com" };
            UserProfile u2 = new UserProfile { Username = "Alice", Password = "abcdef", Email = "alice@mail.com" };
            u1.DisplayProfile();
            u2.DisplayProfile();


            Console.WriteLine("\n--- Experiment 2 ---");
            Truck t = new Truck { Make = "Tata", Model = "X1", Year = 2022 };
            Bus b = new Bus { Make = "Volvo", Model = "B9R", Year = 2021 };
            t.DisplayDetails();
            b.DisplayDetails();


            Console.WriteLine("\n--- Experiment 3 ---");
            Calculator calc = new Calculator();
            Console.WriteLine(calc.Add(2, 3));
            Console.WriteLine(calc.Add(2.5f, 3.5f));
            Console.WriteLine(calc.Add(2.5, 3.5));
            Console.WriteLine(calc.Add(1, 2, 3));


            Console.WriteLine("\n--- Experiment 4 ---");
            FullTimeEmployee fte = new FullTimeEmployee { Name = "Mark", MonthlySalary = 50000 };
            PartTimeEmployee pte = new PartTimeEmployee { Name = "Sara", HourlyRate = 500, HoursWorked = 40 };
            Console.WriteLine($"{fte.Name}'s Salary: {fte.CalculateSalary()}");
            Console.WriteLine($"{pte.Name}'s Salary: {pte.CalculateSalary()}");


            Console.WriteLine("\n--- Experiment 5 ---");
            Student s1 = new Student();
            Student s2 = new Student("Rahul", 101);
            Student s3 = new Student("Priya", 102, 89.5);
            s1.Display();
            s2.Display();
            s3.Display();


            Console.WriteLine("\n--- Experiment 6 ---");
            Product p1 = new Product { ProductID = 1, ProductName = "Laptop", Price = 50000, Quantity = 5 };
            Product p2 = new Product { ProductID = 2, ProductName = "Mouse", Price = -100, Quantity = 10 };
            p1.Display();
            p2.Display();


            Console.WriteLine("\n--- Experiment 7 ---");
            Library lib = new Library();
            Book book1 = new Book { Title = "C# Basics" };
            Book book2 = new Book { Title = "OOP Concepts" };
            lib.AddBook(book1);
            lib.AddBook(book2);

            Member m1 = new Member { Name = "Ankit" };
            lib.RegisterMember(m1);

            lib.LendBook("C# Basics", m1);
            lib.LendBook("C# Basics", m1);
        }
    }
}