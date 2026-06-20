using CSharpLinqPractice.Data;
using CSharpLinqPractice.Models;
using Microsoft.EntityFrameworkCore;

namespace CSharpLinqPractice.LINQCodeFiles;

public class LinqToEntities
{
    public static AppDbContext GetDbConnection()
    {
        var options = new DbContextOptionsBuilder<AppDbContext>()
            .UseSqlServer("Server=(localdb)\\MSSQLLocalDB;Database=TestDB;Trusted_Connection=True;")
            .Options;
        return new AppDbContext(options);
    }

    public static void FindFemaleEmployees()
    {
        using var db = GetDbConnection();

        // Query Syntax
        //IEnumerable<Employee> femaleEmployees = from employee in db.Employees
        //                                        where employee.Gender == "Female"
        //                                        select employee;

        // Method Syntax
        IEnumerable<Employee> femaleEmployees = db.Employees.Where(e => e.Gender == "Female");
        femaleEmployees = femaleEmployees.Take(1);

        foreach (var employee in femaleEmployees)
        {
            Console.WriteLine($"{employee.FirstName}, {employee.Gender}");
        }
    }
}
