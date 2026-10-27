namespace PracticeDay2
{
    public class Class1
    {
        //public class Student
        //{
        //    public string? Name;
        //    public int Age;

        //    public void ShowDetails()
        //    {
        //        Console.WriteLine($"Name: {Name}");
        //        Console.WriteLine($"Age: {Age}");
        //    }
        //}
        //public class Program
        //{
        //    public static void Main()
        //    {
        //        Student student = new Student();

        //        student.Name = "Siraj";
        //        student.Age = 22;

        //        student.ShowDetails();
        //        Console.WriteLine();

        //        student.Name = "Saqeeb";
        //        student.Age = 22;

        //        student.ShowDetails();
        //    }
        //}


        //public class Employee
        //{
        //    public string? Name { get; set; }
        //    public double Salary { get; set; }
        //    public string? Role { get; set; }

        //    public void ShowEmployee()
        //    {
        //        Console.WriteLine($"Name: {Name}");
        //        Console.WriteLine($"Salary: {Salary}");
        //        Console.WriteLine($"Role: {Role}");
        //    }
        //}
        //public class Program
        //{
        //    public static void Main()
        //    {
        //        Employee employee = new Employee();
        //        employee.Name = "Siraj";
        //        employee.Salary = 50000;
        //        employee.Role = "BackEndDeveloper";

        //        employee.ShowEmployee();

        //        employee.Name = "Kaif";
        //        employee.Salary = 50000;
        //        employee.Role = "FrontEndDevelpoer";
        //    }
        //}


        public class Product
        {
            public int Id;
            public string? Name;
            public double Price;

            public Product(int id, string name, double price)
            {
                Id = id;
                Name = name;
                Price = price;
            }
            public void ShowDetails()
            {
                Console.WriteLine($"Id: {Id}");
                Console.WriteLine($"Name: {Name}");
                Console.WriteLine($"Price: {Price}");
            }
        }
        public class Program
        {
            public static void Main()
            {
                Product product = new Product(1, "BMW", 500000);

                product.ShowDetails();
            }
        }


        //    public class Calculator
        //    {
        //        public int Add(int a, int b)
        //        {
        //            return a + b;
        //        }
        //        public int substract(int a, int b)
        //        {
        //            return a - b;
        //        }
        //        public int Multiply(int a, int b)
        //        {
        //            return a * b;
        //        }
        //        public int Divid(int a, int b)
        //        {
        //            return a / b;
        //        }
        //    }
        //    public class Program
        //    {
        //        public static void Main()
        //        {
        //            Calculator calculator = new Calculator();

        //            int result = calculator.Add(10, 20);
        //            Console.WriteLine($"Add: {result}");

        //            int result1 = calculator.substract(10, 20);
        //            Console.WriteLine($"substract: {result1}");

        //            int result2 = calculator.Multiply(10, 10);
        //            Console.WriteLine($"Multiply: {result2}");

        //            int result3 = calculator.Divid(100, 10);
        //            Console.WriteLine($"Divid: {result3}");
        //        }
        //    }



    }
}
