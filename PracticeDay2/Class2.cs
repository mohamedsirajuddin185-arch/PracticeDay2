using System;
using System.Collections.Generic;
using System.Text;

namespace PracticeDay2
{
    public class Class2
    {
        //public class Employee
        //{
        //    private double _salary;

        //    public void SetSalary(double salary)
        //    {
        //        _salary = salary;
        //    }
        //    public double GetSalary()
        //    {
        //        return _salary;
        //    }
        //}
        //public class  Program
        //{
        //    public static void Main()
        //    {
        //        Employee employee = new Employee();

        //        employee.SetSalary(50000);
        //        Console.WriteLine($"Salary: {employee.GetSalary()}");
        //    }
        //}


        //public class Car
        //{
        //    public string? Brand { get; set; }
        //    public double Price { get; set; }
        //    public int Model { get; set; }
        //    public string? Color { get; set; }

        //    public void DisplayDetails()
        //    {
        //        Console.WriteLine($"Brand: {Brand}");
        //        Console.WriteLine($"Price: {Price}");
        //        Console.WriteLine($"Model: {Model}");
        //        Console.WriteLine($"Color: {Color}");
        //    }

        //}
        //public class Program
        //{
        //    public static void Main()
        //    {
        //        Car car1 = new Car();
        //        car1.Brand = "Tayota";
        //        car1.Price = 20000;
        //        car1.Model = 2007;
        //        car1.Color = "Red";

        //        Car car2 = new Car();
        //        car2.Brand = "Suzuki";
        //        car2.Price = 10000;
        //        car2.Model = 2004;
        //        car2.Color = "Black";

        //        car1.DisplayDetails();

        //        Console.WriteLine("---------------");

        //        car2.DisplayDetails();
        //    }
        //}





        //public class Shape
        //{
        //    public virtual void Draw()
        //    {
        //        Console.WriteLine("Drawing Shape");
        //    }
        //}
        //public class Circle : Shape
        //{
        //    public override void Draw()
        //    {
        //        Console.WriteLine("Drawing Circle");
        //    }
        //}
        //public class Rectangle : Shape
        //{
        //    public override void Draw()
        //    {
        //        Console.WriteLine("Drawing Rectangle");
        //    }
        //}
        //public class Program
        //{
        //    public static void Main()
        //    {
        //        Circle circle = new Circle();
        //        Rectangle rectangle = new Rectangle();

        //        circle.Draw();
        //        rectangle.Draw();
        //    }
        //}


        public class Animal
        {
            public void Eat()
            {
                Console.WriteLine("Animal is Eating");
            }
        }
        public class Dog : Animal
        {
            public void Bark()
            {
                Console.WriteLine("Dog is Barking");
            }
        }
        public class Dino : Animal 
        {
            public void Playing()
            {
                Console.WriteLine("Dino is Playing in water");
            }
        }
        public class Program
        {
            public static void Main()
            {
                Dog dog = new Dog();
                dog.Bark();
                dog.Eat();
                Console.WriteLine();

                Dino dino = new Dino();
                dino.Eat();
                dino.Playing();

            }
        }
    }
}
