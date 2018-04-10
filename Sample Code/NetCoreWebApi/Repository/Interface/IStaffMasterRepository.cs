using Repository.Schema; 
using System.Collections.Generic;

namespace Repository.Interface 
{
   public interface IStaffMasterRepository
   {
       StaffMasterModel Select(int id);
       List<StaffMasterModel> SelectList();
       int Insert(StaffMasterModel obj);
       void InsertBulk(List<StaffMasterModel> list);
       void Update(StaffMasterModel poco);
       void Delete(int id);
   }
}
