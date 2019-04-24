using GraphQL;
using GraphQL.Types;

namespace WebApi.GraphQl
{
    public class EmployeeSchema:Schema
    {
        public EmployeeSchema(IDependencyResolver resolver) : base(resolver)
        {
            Query = resolver.Resolve<EmployeeQuery>();
        }
    }
}
