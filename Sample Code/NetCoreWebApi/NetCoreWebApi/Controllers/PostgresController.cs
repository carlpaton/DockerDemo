using Microsoft.AspNetCore.Mvc;
using Repository.Interface;

namespace NetCoreWebApi.Controllers
{
    [Route("api/[controller]")]
    public class PostgresController : Controller
    {
        private readonly IEmployeeRepository _context;

        public PostgresController(IEmployeeRepository context)
        {
            _context = context;
        }

        // GET api/postgres
        [HttpGet]
        public JsonResult Get()
        {
            var dbModel = _context.SelectList();
            return Json(dbModel);
        }

        // GET api/postgres/1
        [HttpGet("{id}")]
        public JsonResult Get(int id)
        {
            var dbModel = _context.Select(id);
            return Json(dbModel);
        }
    }
}