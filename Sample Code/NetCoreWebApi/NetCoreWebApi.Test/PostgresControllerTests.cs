using Microsoft.VisualStudio.TestTools.UnitTesting;
using NetCoreWebApi.Controllers;
using Repository.Implementation.PostgreSQL;
using Repository.Schema;
using System.Collections.Generic;

namespace NetCoreWebApi.Test
{
    [TestClass]
    public class PostgresControllerTests
    {
        [TestMethod]
        public void Postgres_Get()
        {
            // Act
            var employeeRepository = new EmployeeRepository();
            var controller = new PostgresController(employeeRepository);
            var response = controller.Get();

            // Arrange
            var obj = (List<EmployeeModel>)response.Value;

            // Assert
            Assert.IsTrue(obj.Count > 0);
        }

        [TestMethod]
        public void Postgres_GetById()
        {
            // Act
            var employeeRepository = new EmployeeRepository();
            var controller = new PostgresController(employeeRepository);
            var response = controller.Get(1);

            // Arrange
            var obj = (EmployeeModel)response.Value;

            // Assert
            Assert.IsTrue(obj.Id > 0);
        }
    }
}
