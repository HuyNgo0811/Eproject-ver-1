using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Eproject_ver_1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LoginController : ControllerBase
    {
        [HttpGet("{EmployeeId}/{password}")]
        public async Task<bool> GetEmployee(string EmployeeId, string password)
        {
            var account = await db.Employees.SingleOrDefaultAsync(e => e.EmployeeId == EmployeeId && e.Password == password);
            if (account == null)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}
