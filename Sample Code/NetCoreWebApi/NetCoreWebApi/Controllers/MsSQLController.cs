using Microsoft.AspNetCore.Mvc;
using Repository.Interface;

namespace NetCoreWebApi.Controllers
{
    [Route("api/[controller]")]
    public class MsSQLController : Controller
    {
        private readonly IStaffMasterRepository _context;

        public MsSQLController(IStaffMasterRepository context)
        {
            _context = context;
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