using Microsoft.AspNetCore.Mvc;
using Repository.Implementation.MsSQL;
using Repository.Interface;

namespace NetCoreWebApi.Controllers
{
    [Route("api/[controller]")]
    public class MsSQLController : Controller
    {
        private readonly IEmployeeRepository _context;

        //Cant use DI when more than one db uses the same interface
        //MsSQLController(IEmployeeRepository context)
        //{
        //    _context = context;
        //}

        public MsSQLController()
        {
            _context = new EmployeeRepository();
        }

        // GET api/mssql
        [HttpGet]
        public JsonResult Get()
        {
            var dbModel = _context.SelectList();
            return Json(dbModel);
        }

        // GET api/mssql/1
        [HttpGet("{id}")]
        public JsonResult Get(int id)
        {
            var dbModel = _context.Select(id);
            return Json(dbModel);
        }
    }
}