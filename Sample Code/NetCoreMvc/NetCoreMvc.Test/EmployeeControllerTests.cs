using Microsoft.AspNetCore.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NetCoreMvc.Common;
using NetCoreMvc.Controllers;
using System.Collections.Generic;

namespace NetCoreMvc.Test
{
    [TestClass]
    public class EmployeeControllerTests
    {
        [TestMethod]
        public void Index()
        {
            // Act
            var context = new GetEmployee();
            var controller = new EmployeeController(context);

            // Arrange
            var result = controller.Index();
            var model = ((ViewResult)result).Model as List<GetEmployee>;

            // Assert
            Assert.IsTrue(controller.ModelState.IsValid);
            Assert.IsTrue(model.Count > 0);
        }
    }
}
