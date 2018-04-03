using Microsoft.AspNetCore.Mvc;
using Repository.Implementation.MySQL;
using Repository.Interface;

namespace NetCoreWebApi.Controllers
{
    [Route("api/[controller]")]
    public class MySQLController : Controller
    {
        private readonly IEmployeeRepository _context;

        //Cant use DI when more than one db uses the same interface
        //MySQLController(IEmployeeRepository context)
        //{
        //    _context = context;
        //}

        public MySQLController()
        {
            _context = new EmployeeRepository();
        }

        // GET api/mysql
        [HttpGet]
        public JsonResult Get()
        {
            var dbModel = _context.SelectList();
            return Json(dbModel);
        }

        // GET api/mysql/1
        [HttpGet("{id}")]
        public JsonResult Get(int id)
        {
            var dbModel = _context.Select(id);
            return Json(dbModel);
        }
    }
}