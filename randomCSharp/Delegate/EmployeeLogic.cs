namespace randomCSharp.Delegate;

public class EmployeeLogic
{
    private static List<Employee> employees = new List<Employee>();

    static EmployeeLogic()
    {
        employees.Add(new Employee() { Id = 101, Name = "Mary", Salary = 5000, Experience = 5, Level = 3 });
        employees.Add(new Employee() { Id = 102, Name = "Mike", Salary = 3000, Experience = 3, Level = 6 });
        employees.Add(new Employee() { Id = 103, Name = "John", Salary = 4000, Experience = 4, Level = 3 });
        employees.Add(new Employee() { Id = 104, Name = "Todd", Salary = 6000, Experience = 6, Level = 5 });
    }


    public static void Run()
    {
        Console.WriteLine("Employee Logic");

        IsPromotable del = new IsPromotable(emp => emp.Experience > 5);
        Employee.PromoteEmployee(employees, del);
    }
}