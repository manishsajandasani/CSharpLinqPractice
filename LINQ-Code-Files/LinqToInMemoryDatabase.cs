using CSharpLinqPractice.Data;
using CSharpLinqPractice.Models;
using Microsoft.EntityFrameworkCore;

namespace CSharpLinqPractice.LINQCodeFiles;

public static class LinqToInMemoryDatabase
{
    public static AppDbContext GetInMemoryDbConnection()
    {
        var options = new DbContextOptionsBuilder<AppDbContext>()
                .UseInMemoryDatabase("TestDB")
                .Options;
        return new AppDbContext(options);
    }

    public static void FindMaleEmployees()
    {
        using var db = GetInMemoryDbConnection();

        // Clear Existing Data Before Seeding
        db.Employees.RemoveRange(db.Employees);
        db.SaveChanges();

        // Seed Data
        if (!db.Employees.Any())
        {
            db.Employees.AddRange(
                new Employee { FirstName = "Manish", Gender = "Male" },
                new Employee { FirstName = "Sanjay", Gender = "Male" },
                new Employee { FirstName = "Geet", Gender = "Female" }
            );
            db.SaveChanges();
        }

        // Fetch Male Employees
        IEnumerable<Employee> maleEmployees = from employee in db.Employees
                                              where employee.Gender.Equals("Male")
                                              orderby employee.FirstName descending
                                              select employee;

        // Iterate Male Employees
        foreach(var employee in maleEmployees)
        {
            Console.WriteLine($"{employee.FirstName}, {employee.Gender}");
        }
    }
}