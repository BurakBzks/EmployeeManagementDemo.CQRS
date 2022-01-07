using EmployeeManagementLibrary.Commands;
using EmployeeManagementLibrary.Data;
using EmployeeManagementLibrary.Models;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace EmployeeManagementLibrary.Handlers
{
    public class AddEmployeeHandler : IRequestHandler<AddEmployeeCommand, EmployeeModel>
    {
        private readonly IDataAccess _dataAccess;

        public AddEmployeeHandler(IDataAccess dataAccess)
        {
            _dataAccess = dataAccess;
        }
        public  Task<EmployeeModel> Handle(AddEmployeeCommand request, CancellationToken cancellationToken)
        {
            return Task.FromResult(_dataAccess.AddEmployee(request.FirstName, request.LastName));
        }
    }
}
