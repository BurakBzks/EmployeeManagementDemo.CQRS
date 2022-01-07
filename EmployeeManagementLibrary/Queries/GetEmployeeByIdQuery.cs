using EmployeeManagementLibrary.Models;
using MediatR;

namespace EmployeeManagementLibrary.Queries
{
    public record GetEmployeeByIdQuery(int Id) : IRequest<EmployeeModel>;

}
