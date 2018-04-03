using System.Collections.Generic;
using Repository.Interface; 
using Repository.Schema; 

namespace Repository.Implementation.MySQL
{
   public class EmployeeRepository : MySQLContext, IEmployeeRepository
   {
        public EmployeeModel Select(int id)
        {
         var sql = @"
SELECT * FROM employee 
WHERE Id = @id;";
           return Select<EmployeeModel>(sql, new { id });
        }

        public List<EmployeeModel> SelectList()
        {
         var sql = @"
SELECT * FROM employee 
ORDER BY id;";
           return SelectList<EmployeeModel>(sql);
        }

        public int Insert(EmployeeModel obj)
        {
         var sql = @"
INSERT INTO employee 
(name, surname, title, job_role, start_date)
VALUES
(@Name, @Surname, @Title, @JobRole, @StartDate);
SELECT LAST_INSERT_ID();";
           return Insert<EmployeeModel>(sql, obj);
        }

        public void InsertBulk(List<EmployeeModel> listPoco)
        {
         var sql = @"
INSERT INTO employee 
(name, surname, title, job_role, start_date)
VALUES
(@Name, @Surname, @Title, @JobRole, @StartDate);";
           InsertBulk<EmployeeModel>(sql, listPoco);
        }

        public void Update(EmployeeModel obj)
        {
         var sql = @"
UPDATE employee 
SET 
name=@Name, surname=@Surname, title=@Title, job_role=@JobRole, start_date=@StartDate
WHERE id = @id";
           Update<EmployeeModel>(sql, obj);
        }

        public void Delete(int id)
        {
         var sql = @"
DELETE FROM employee 
WHERE id = @id";
           Delete(sql, new { id });
        }
   }
}
