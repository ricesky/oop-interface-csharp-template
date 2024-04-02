using Microsoft.VisualStudio.TestTools.UnitTesting;
using Solution.Bookstore;
using System;

namespace Solution.Bookstore.Tests;

[TestClass]
public class BookstoreTests
{
    [TestMethod]
    public void BukuFisik_PrintInfo_ReturnsCorrectFormat()
    {
        var bukuFisik = new BukuFisik("The Great Gatsby", "F. Scott Fitzgerald");
        string expected = "Buku fisik: The Great Gatsby oleh F. Scott Fitzgerald";
        Assert.AreEqual(expected, bukuFisik.PrintInfo());
    }

    [TestMethod]
    public void BukuDigital_PrintInfo_ReturnsCorrectFormat()
    {
        var bukuDigital = new BukuDigital("1984", "George Orwell");
        string expected = "Buku digital: 1984 oleh George Orwell";
        Assert.AreEqual(expected, bukuDigital.PrintInfo());
    }

    [TestMethod]
    public void BukuDigital_AccessDigitalCopy_ReturnsCorrectMessage()
    {
        var bukuDigital = new BukuDigital("1984", "George Orwell");
        string expected = "Mengakses salinan digital buku 1984";
        Assert.AreEqual(expected, bukuDigital.AccessDigitalCopy());
    }

    [TestMethod]
    public void DigitalLibrary_ProvideAccess_CallsAccessDigitalCopy()
    {
        var bukuDigital = new BukuDigital("Brave New World", "Aldous Huxley");

        using (var sw = new System.IO.StringWriter())
        {
            Console.SetOut(sw);
            DigitalLibrary.ProvideAccess(bukuDigital);

            var expected = "Mengakses salinan digital buku Brave New World" + Environment.NewLine;
            Assert.AreEqual(expected, sw.ToString());
        }
    }

    [TestCleanup]
    public void Cleanup()
    {
        // Reset the standard output to avoid redirecting Console.WriteLine calls in subsequent tests
        Console.SetOut(new StreamWriter(Console.OpenStandardOutput()));
    }

    [TestMethod]
    public void BukuFisik_IsDerivedFromBuku()
    {
        Assert.IsTrue(typeof(Buku).IsAssignableFrom(typeof(BukuFisik)), "BukuFisik harus turunan dari Buku.");
    }

    [TestMethod]
    public void BukuDigital_IsDerivedFromBuku()
    {
        Assert.IsTrue(typeof(Buku).IsAssignableFrom(typeof(BukuDigital)), "BukuDigital harus turunan dari Buku.");
    }

    [TestMethod]
    public void BukuDigital_ImplementsIDigitalAccessible()
    {
        Assert.IsTrue(typeof(IDigitalAccessible).IsAssignableFrom(typeof(BukuDigital)), "BukuDigital harus mengimplementasi interface IDigitalAccessible.");
    }
}
