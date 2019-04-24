using GraphQL.Client;
using GraphQL.Common.Request;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;
using WebApi.Data.Models;

namespace WebApi.Controller
{
    [Route("Employee")]
    public class EmployeeController : Microsoft.AspNetCore.Mvc.Controller
    {
        [HttpGet]
        public async Task<List<Employee>> Get()
        {
            using (GraphQLClient graphQLClient = new GraphQLClient("http://localhost:59284/graphql"))
            {
                var query = new GraphQLRequest
                {
                    Query = @"   
                        {
 employee
  {
    name
    email
  }
}"
                };
                var response = await graphQLClient.PostAsync(query);
                return response.GetDataFieldAs<List<Employee>>("employee");
            }
        }
    }
}