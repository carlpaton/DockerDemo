using Repository.Schema; 
using System.Collections.Generic;

namespace Repository.Interface 
{
   public interface IEmployeeRepository
   {
       EmployeeModel Select(int id);
       List<EmployeeModel> SelectList();
       int Insert(EmployeeModel obj);
       void InsertBulk(List<EmployeeModel> list);
       void Update(EmployeeModel poco);
       void Delete(int id);
       void ExecuteNonQuery(string sql);
    }
}
