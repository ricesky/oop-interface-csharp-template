using Microsoft.VisualStudio.TestTools.UnitTesting;
using Solution.Shops;
using System;

namespace Solution.Shops.Tests
{
    [TestClass]
    public class ShopTests
    {
        [TestMethod]
        public void Televisi_PowerOn_ReturnsCorrectMessage()
        {
            var televisi = new Televisi("Sony");
            var result = televisi.PowerOn();
            Assert.AreEqual("Televisi dinyalakan", result);
        }

        [TestMethod]
        public void KipasAngin_PowerOn_ReturnsCorrectMessage()
        {
            var kipasAngin = new KipasAngin("Miyako");
            var result = kipasAngin.PowerOn();
            Assert.AreEqual("Kipas Angin dinyalakan", result);
        }

        [TestMethod]
        public void MobilListrik_PowerOn_ReturnsCorrectMessage()
        {
            var mobilListrik = new MobilListrik("Tesla");
            var result = mobilListrik.PowerOn();
            Assert.AreEqual("Mobil Listrik siap berjalan", result);
        }

        [TestMethod]
        public void ElectricityProvider_SupplyPower_Televisi()
        {
            var televisi = new Televisi("Sony");
            using (var sw = new StringWriter())
            {
                Console.SetOut(sw);
                ElectricityProvider.SupplyPower(televisi);

                var expected = "Televisi dinyalakan" + Environment.NewLine;
                Assert.AreEqual(expected, sw.ToString());
            }
        }

        // Test cleanup to reset Console.Out
        [TestCleanup]
        public void Cleanup()
        {
            Console.SetOut(new StreamWriter(Console.OpenStandardOutput()));
        }

        [TestMethod]
        public void Televisi_ImplementsIElectrifiableAndInheritsBarang()
        {
            Assert.IsTrue(typeof(Televisi).GetInterfaces().Contains(typeof(IElectrifiable)), "Televisi should implement IElectrifiable interface");
            Assert.IsTrue(typeof(Televisi).IsSubclassOf(typeof(Barang)), "Televisi should be a subclass of Barang");
        }

        [TestMethod]
        public void KipasAngin_ImplementsIElectrifiableAndInheritsBarang()
        {
            Assert.IsTrue(typeof(KipasAngin).GetInterfaces().Contains(typeof(IElectrifiable)), "KipasAngin should implement IElectrifiable interface");
            Assert.IsTrue(typeof(KipasAngin).IsSubclassOf(typeof(Barang)), "KipasAngin should be a subclass of Barang");
        }

        [TestMethod]
        public void MobilListrik_ImplementsIElectrifiableAndInheritsBarang()
        {
            Assert.IsTrue(typeof(MobilListrik).GetInterfaces().Contains(typeof(IElectrifiable)), "MobilListrik should implement IElectrifiable interface");
            Assert.IsTrue(typeof(MobilListrik).IsSubclassOf(typeof(Barang)), "MobilListrik should be a subclass of Barang");
        }

    }
}
