using System;

namespace NetCoreMvc.Models
{
    public class EmployeeViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Title { get; set; }
        public string JobRole { get; set; }
        public DateTime StartDate { get; set; }
    }
}
