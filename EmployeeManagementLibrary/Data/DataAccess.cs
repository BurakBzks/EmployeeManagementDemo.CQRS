using EmployeeManagementLibrary.Models;
using System.Collections.Generic;
using System.Linq;

namespace EmployeeManagementLibrary.Data
{
    public class DataAccess : IDataAccess
    {
        private List<EmployeeModel> _employees = new(); // C# 9 syntax.

        public DataAccess()
        {
            _employees.Add(new EmployeeModel { Id = 1, FirstName = "Burak", LastName = "Bozkuş" });
            _employees.Add(new EmployeeModel { Id = 2, FirstName = "Murat", LastName = "Han" });
        }

        public List<EmployeeModel> GetEmployees()
        {
            return _employees;
        }

        public EmployeeModel AddEmployee(string firstName, string lastName)
        {
            EmployeeModel newEmployee = new() { FirstName = firstName, LastName = lastName };
            newEmployee.Id = _employees.Max(x => x.Id) + 1;
            return newEmployee;
        }
    }


}
