using CoreDemo_Api.DataAccessLayer;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CoreDemo_Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DefaultController : ControllerBase
    {
        private Context _context;

        public DefaultController(Context context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult EmployeeList()
        {
            var values= _context.Employees;
            return Ok(values);
        }
    }
}
