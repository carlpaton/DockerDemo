using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using Repository.Implementation.MySQL;
using Repository.Interface;

namespace NetCoreWebApi.Controllers
{
    [Route("api/[controller]")]
    public class MySQLController : Controller
    {
        private readonly IStaffMasterRepository _context;
        private readonly AppSettings _appSettings;

        public MySQLController(IOptions<AppSettings> appSettings)
        {
            _appSettings = appSettings.Value;
            _context = new StaffMasterRepository(_appSettings.ConnMySQL); //Cant use DI when more than one db uses the same interface -> IStaffMasterRepository
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