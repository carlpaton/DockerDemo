using System.Collections.Generic;
using Repository.Interface;
using Repository.Schema;

namespace Repository.Implementation.MsSQL
{
   public class StaffMasterRepository : MsSQLContext, IStaffMasterRepository
   {
        public StaffMasterRepository(string connectionString)
          : base(connectionString)
        {

        }

        public StaffMasterModel Select(int id)
        {
         var sql = @"
SELECT * FROM staff_master 
WHERE Id = @id;";
           return Select<StaffMasterModel>(sql, new { id });
        }

        public List<StaffMasterModel> SelectList()
        {
         var sql = @"
SELECT * FROM staff_master 
ORDER BY id;";
           return SelectList<StaffMasterModel>(sql);
        }

        public int Insert(StaffMasterModel obj)
        {
         var sql = @"
INSERT INTO staff_master 
(first_name, surname, email, insert_date, salary)
VALUES
(@FirstName, @Surname, @Email, @InsertDate, @Salary);
SELECT SCOPE_IDENTITY();";
           return Insert<StaffMasterModel>(sql, obj);
        }

        public void InsertBulk(List<StaffMasterModel> listPoco)
        {
         var sql = @"
INSERT INTO staff_master 
(first_name, surname, email, insert_date, salary)
VALUES
(@FirstName, @Surname, @Email, @InsertDate, @Salary);";
           InsertBulk<StaffMasterModel>(sql, listPoco);
        }

        public void Update(StaffMasterModel obj)
        {
         var sql = @"
UPDATE staff_master 
SET 
first_name=@FirstName, surname=@Surname, email=@Email, insert_date=@InsertDate, salary=@Salary
WHERE id = @id";
           Update<StaffMasterModel>(sql, obj);
        }

        public void Delete(int id)
        {
         var sql = @"
DELETE FROM staff_master 
WHERE id = @id";
           Delete(sql, new { id });
        }
   }
}
