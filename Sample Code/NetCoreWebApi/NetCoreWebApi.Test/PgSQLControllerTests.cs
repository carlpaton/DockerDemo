using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Options;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NetCoreWebApi.Controllers;
using Repository.Schema;
using System.Collections.Generic;

namespace NetCoreWebApi.Test
{
    [TestClass]
    public class PgSQLControllerTests
    {
        [TestMethod]
        public void Postgres_Get()
        {
            // Act
            var controller = new PgSQLController(Inject());
            var response = controller.Get();

            // Arrange
            var obj = (List<StaffMasterModel>)response.Value;

            // Assert
            Assert.IsTrue(obj.Count > 0);
        }

        [TestMethod]
        public void Postgres_GetById()
        {
            // Act
            var controller = new PgSQLController(Inject());
            var response = controller.Get(1);

            // Arrange
            var obj = (StaffMasterModel)response.Value;

            // Assert
            Assert.IsTrue(obj.Id > 0);
        }

        #region helpers
        private IOptions<AppSettings> Inject()
        {
            var config = new ConfigurationBuilder().AddJsonFile("appsettings.Development.json").Build();
            var d = config.GetSection("AppSettings");

            var appSettings = new AppSettings() { ConnPgSQL = d["ConnPgSQL"] };
            var options = Options.Create(appSettings);

            return options;
        }
        #endregion
    }
}
