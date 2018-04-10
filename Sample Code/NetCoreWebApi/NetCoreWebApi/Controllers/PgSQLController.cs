using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using Repository.Implementation.PgSQL;
using Repository.Interface;

namespace NetCoreWebApi.Controllers
{
    [Route("api/[controller]")]
    public class PgSQLController : Controller
    {
        private readonly IStaffMasterRepository _context;
        private readonly AppSettings _appSettings;

        public PgSQLController(IOptions<AppSettings> appSettings)
        {
            _appSettings = appSettings.Value;
            _context = new StaffMasterRepository(_appSettings.ConnPgSQL); //Cant use DI when more than one db uses the same interface -> IStaffMasterRepository
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