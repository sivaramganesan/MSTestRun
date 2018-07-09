using ChartSample;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Xamarin.Forms;

namespace NUnitTestProject
{
    [TestClass]
    public class Test
    {
        [TestInitialize()]
        public void SetUp()
        {
            Syncfusion.Licensing.SyncfusionLicenseProvider.RegisterLicense("MDODAwQDMxMzYyZTMyMmUzMFJDRjN6TjlNaEIzcUJRN09JbUdyczNCcDRxS2c2eVFndS9neTYzZXBsaTQ9");
            Xamarin.Forms.Mocks.MockForms.Init();
        }

        ContentPage page;
        ContentPage CreateInstance()
        {
            page = new MainPage();
            return page;
        }

        [TestMethod]
        public void TestCase()
        {
            CreateInstance();
            Assert.IsNotNull(page);
        }

        [TestMethod]
        public void TestCase1()
        {
            CreateInstance();
            Assert.AreEqual((page as MainPage).Drawer.DrawerWidth, 400);
        }
    }
}