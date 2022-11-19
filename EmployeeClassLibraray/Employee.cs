namespace EmployeeClassLibraray
{
     public class Employee
    {
        public string? EmployeeName { get; set; }
        public int EmployeeID { get; set; }
        public double Salary { get; set; }
        public void EmployeeInfo()
        {

            Console.WriteLine("\n\t***EMPLOYEE dETAILS***");
            Console.WriteLine("Employee Name: " + EmployeeName);
            Console.WriteLine("Employee ID: " + EmployeeID);
            Console.WriteLine("Employee Salary: " + Salary);
        }

    }
}