using Employe_salary;
using System;
public class Program
{
    public static void Main()
    {
        List<Employe> employes = new List<Employe>
        {
            new Employe { Name = "Mafuj", Id = 14172, Phone = "0175233251", Email = "pranto@gmail.com", Address = "Dhanmondi", City = "Dhaka", Designation = "CEO", Branch = "Dhanmondi", Basic = 8000 },
            new Employe
            {
                Name = "John Doe",
                Id = 1,
                Phone = "123-456-7890",
                Email = "john.doe@example.com",
                Address = "123 Main St",
                City = "Anytown",
                Designation = "Developer",
                Branch = "Headquarters",
                Basic = 50000 // Set the basic salary for John Doe
            }
        };

        foreach (var Employess in employes)
        {
            Console.WriteLine("Enter ID:");
            int n = int.Parse(Console.ReadLine());
            if (Employess.Id ==n)
            {
                Console.WriteLine(Employess.Name);
                Console.WriteLine(Employess.Email);
                break;
            }
        }

        foreach (var employe in employes)
        {
            Double totalSalary = employe.Salary();
            Console.WriteLine($"{employe.Name}'s salary is:{totalSalary}");
        }

    }
}