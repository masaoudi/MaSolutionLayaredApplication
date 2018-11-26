using System.Web.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using BankinApp.L2.Service.Rest;
using BankinApp.L2.Service.Rest.Controllers;

namespace BankinApp.L2.Service.Rest.Tests.Controllers
{
    [TestClass]
    public class HomeControllerTest
    {
        [TestMethod]
        public void Index()
        {
            // Arrange
            HomeController controller = new HomeController();

            // Act
            ViewResult result = controller.Index() as ViewResult;

            // Assert
            Assert.IsNotNull(result);
            Assert.AreEqual("Home Page", result.ViewBag.Title);
        }
    }
}
