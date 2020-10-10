using System;
using TimeTable.Services;

namespace TimeTable.ConsoleTest
{
    class Program
    {
        static void Main(string[] args)
        {
            EmployeeService employeeService = new EmployeeService();
            employeeService.GetAll().ForEach(e => Console.WriteLine($"{e.EmployeeEgn} {e.EmployeeName}"));

            ProjectService projectService = new ProjectService();
            projectService.GetAll().ForEach(e => Console.WriteLine($"{e.ProjectName} {e.ProjectDescription}"));

            Console.WriteLine(projectService.GetById(1).ProjectDescription);
        }
    }
}
