using System.Collections.Generic;
using Repository.Interface;
using Repository.Schema;

namespace Repository.Implementation.PostgreSQL
{
    public class EmployeeRepository : PostgreSQLContext, IEmployeeRepository
    {
        public EmployeeModel Select(int id)
        {
            var sql = @"
SELECT * FROM public.employee 
WHERE Id = @id;";
            return Select<EmployeeModel>(sql, new { id });
        }

        public List<EmployeeModel> SelectList()
        {
            var sql = @"
SELECT * FROM public.employee 
ORDER BY id;";
            return SelectList<EmployeeModel>(sql);
        }

        public void ExecuteNonQuery(string sql)
        {
            base.ExecuteNonQuery(sql);
        }

        public void Delete(int id)
        {
            throw new System.NotImplementedException();
        }

        public int Insert(EmployeeModel obj)
        {
            throw new System.NotImplementedException();
        }

        public void InsertBulk(List<EmployeeModel> list)
        {
            throw new System.NotImplementedException();
        }

        public void Update(EmployeeModel poco)
        {
            throw new System.NotImplementedException();
        }
    }
}
