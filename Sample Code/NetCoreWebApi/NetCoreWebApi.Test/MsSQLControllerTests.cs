using Microsoft.Extensions.Configuration;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NetCoreWebApi.Controllers;
using Repository.Implementation.MsSQL;
using Repository.Schema;
using System.Collections.Generic;

namespace NetCoreWebApi.Test
{
    [TestClass]
    public class MsSQLControllerTests
    {
        [TestMethod]
        public void MsSQL_Get()
        {
            // Act
            var controller = new MsSQLController(Inject());
            var response = controller.Get();

            // Arrange
            var obj = (List<StaffMasterModel>)response.Value;

            // Assert
            Assert.IsTrue(obj.Count > 0);
        }

        [TestMethod]
        public void MsSQL_GetById()
        {
            // Act
            var controller = new MsSQLController(Inject());
            var response = controller.Get(1);

            // Arrange
            var obj = (StaffMasterModel)response.Value;

            // Assert
            Assert.IsTrue(obj.Id > 0);
        }

        #region helpers
        private StaffMasterRepository Inject()
        {
            var config = new ConfigurationBuilder().AddJsonFile("appsettings.Development.json").Build();
            var connMsSQL = config.GetConnectionString("ConnMsSQL");

            var objStaffMasterRepository = new StaffMasterRepository(connMsSQL);
            return objStaffMasterRepository;
        }
        #endregion
    }
}
