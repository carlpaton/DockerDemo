using System;

namespace Repository.Schema 
{
   public class StaffMasterModel
   {
       public int Id { get; set; }
       public string FirstName { get; set; }
       public string Surname { get; set; }
       public string Email { get; set; }
       public DateTime InsertDate { get; set; }
       public double Salary { get; set; }
   }
}
