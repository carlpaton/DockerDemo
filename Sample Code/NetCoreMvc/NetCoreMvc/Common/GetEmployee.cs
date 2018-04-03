using NetCoreMvc.Models;
using System.Collections.Generic;

namespace NetCoreMvc.Common
{
    public interface IGetEmployee
    {
        List<EmployeeViewModel> SelectList();
    }

    public class GetEmployee : IGetEmployee
    {
        string urlBase = "http://192.168.231.129:62082/api/mysql";

        public List<EmployeeViewModel> SelectList()
        {
            var r = CallAPI.Go<List<EmployeeViewModel>>(urlBase);
            return r;
        }
    }
}
