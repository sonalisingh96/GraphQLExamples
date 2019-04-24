using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using WebApi.Data;
using WebApi.Data.Models;

namespace WebApi.Repository
{
    public class EmployeeRepository
    {
        private readonly ApplicationDbContext _context;
        public EmployeeRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public Task<List<Employee>> GetEmployees()
        {
            return _context.Employees.ToListAsync();
        }
    }
}
