class Employee
{
    static void Main()
    {
        EmployeeRecord employee = new EmployeeRecord
        {
            EmployeeId = 1001,
            Name = "Shashank",
            BasicSalary = 50000m,
            IsActive = true,
            JoinedDate = new DateTime(2024, 1, 15)
        };

        Console.WriteLine($"Gross Salary: ₹{employee.CalculateGrossSalary():N2}");
    }
}

class EmployeeRecord
{
    public int EmployeeId { get; set; }
    public string Name { get; set; }
    public decimal BasicSalary { get; set; }
    public bool IsActive { get; set; }
    public DateTime JoinedDate { get; set; }

    public decimal CalculateGrossSalary()
    {
        return BasicSalary + (BasicSalary * 0.20m);
    }
}
