using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GraphQL.Client;
using GraphQL.Common.Request;
using Microsoft.AspNetCore.Mvc;
using WebApi.Data.Models;

namespace Client.netcore.Controller
{
    [Route("Employee")]
    public class EmployeeController:Microsoft.AspNetCore.Mvc.Controller
    {
        [HttpGet]
        public async Task<List<Employee>> Get()
        {
            using (GraphQLClient graphQLClient = new GraphQLClient("http://localhost:59284/graphql"))
            {
                var query = new GraphQLRequest
                {
                    Query = @"   
                        { employees   
                            { name email }   
                        }",
                };
                var response = await graphQLClient.PostAsync(query);
                return response.GetDataFieldAs<List<Employee>>("employees");
            }
        }
    }
}
