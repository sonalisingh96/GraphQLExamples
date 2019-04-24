using GraphQL.Types;
using WebApi.Repository;

namespace WebApi.GraphQl
{
    public class EmployeeQuery:ObjectGraphType
    {
        public EmployeeQuery(EmployeeRepository employeeRepository)
        {
            Field<ListGraphType<EmployeeType>>(
                name: "employee",
                description:"To get all the employees",
                resolve: context => employeeRepository.GetEmployees()
            );
        }
    }
}
