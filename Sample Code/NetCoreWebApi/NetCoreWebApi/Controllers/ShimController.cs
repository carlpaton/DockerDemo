using Microsoft.AspNetCore.Mvc;
using Repository.Implementation.PostgreSQL;
using System;
using System.Text;

namespace NetCoreWebApi.Controllers
{
    //PSQL Flyway shim


    [Route("api/[controller]")]
    public class ShimController : Controller
    {
        // GET api/shim
        [HttpGet]
        public string Get()
        {
            var sb = new StringBuilder();

//            try
//            {

//                var sql = @"
//CREATE DATABASE flyway_demo
//WITH
//OWNER = postgres
//ENCODING = 'UTF8'
//CONNECTION LIMIT = -1; ";

//                new EmployeeRepository().ExecuteNonQuery(sql);
//                sb.AppendLine("CREATE DATABASE OK");
//            }
//            catch(Exception ex)
//            {
//                sb.AppendLine(ex.Message);
//            }


            try
            {

                var sql = @"
CREATE TABLE employee (
  id serial NOT NULL,
  name text,
  surname text,
  title text,
  job_role text,
  start_date date,
  CONSTRAINT employee_pkey PRIMARY KEY (id));";

                new EmployeeRepository().ExecuteNonQuery(sql);
                sb.AppendLine("CREATE TABLE public.employee OK");
            }
            catch (Exception ex)
            {
                sb.AppendLine(ex.Message);
            }


            try
            {

                var sql = @"
INSERT INTO employee(
	name, surname, title, job_role, start_date)
	VALUES ('psql', 'psql', 'psql', 'psql', NOW());";

                new EmployeeRepository().ExecuteNonQuery(sql);
                sb.AppendLine("SEED public.employee OK");
            }
            catch (Exception ex)
            {
                sb.AppendLine(ex.Message);
            }

            return sb.ToString();
        }
    }
}