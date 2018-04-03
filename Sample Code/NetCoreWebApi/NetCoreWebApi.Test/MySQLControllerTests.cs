using Microsoft.VisualStudio.TestTools.UnitTesting;
using NetCoreWebApi.Controllers;
using Repository.Schema;
using System.Collections.Generic;

namespace NetCoreWebApi.Test
{
    [TestClass]
    public class MySQLControllerTests
    {
        [TestMethod]
        public void MySQL_Get()
        {
            // Act
            var controller = new MySQLController();
            var response = controller.Get();

            // Arrange
            var obj = (List<EmployeeModel>)response.Value;

            // Assert
            Assert.IsTrue(obj.Count > 0);
        }

        [TestMethod]
        public void MySQL_GetById()
        {
            // Act
            var controller = new MySQLController();
            var response = controller.Get(1);

            // Arrange
            var obj = (EmployeeModel)response.Value;

            // Assert
            Assert.IsTrue(obj.Id > 0);
        }
    }
}
