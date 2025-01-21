namespace randomCSharp.Delegate;

public delegate  bool IsPromotable(Employee employee);

public class Employee
{
    public int Id { get; set; }
    public string Name { get; set; }
    public int Salary { get; set; }
    public int Experience { get; set; }
    public int Level { get; set; }

    public static void PromoteEmployee(List<Employee> employees, IsPromotable isPromotable)
    {
        foreach (var employee in employees)
        {
            if (employee.Experience >= 5)
            {
                Console.WriteLine(employee.Name, "Promoted");
            }
        }
    }
}