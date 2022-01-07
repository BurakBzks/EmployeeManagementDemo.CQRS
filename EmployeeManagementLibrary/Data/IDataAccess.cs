using EmployeeManagementLibrary.Models;
using System.Collections.Generic;

namespace EmployeeManagementLibrary.Data
{
    public interface IDataAccess
    {
        List<EmployeeModel> GetEmployees();
        EmployeeModel AddEmployee(string firstName, string lastName);

    }
}
