using Microsoft.VisualStudio.TestTools.UnitTesting;
using Solution.Zoo;
using System.IO;
using System;

namespace Solution.Zoo.Tests;

[TestClass]
public class ZooTests
{
    [TestMethod]
    public void Singa_Suara_ReturnsRoar()
    {
        var singa = new Singa("Simba");
        Assert.AreEqual("Roar", singa.Suara());
    }

    [TestMethod]
    public void Kuda_Suara_ReturnsNeigh()
    {
        var kuda = new Kuda("Woody");
        Assert.AreEqual("Neigh", kuda.Suara());
    }

    [TestMethod]
    public void KebunBinatang_DengarkanHewanBersuara_ReturnsCorrectSounds()
    {
        var kebunBinatang = new KebunBinatang();
        kebunBinatang.TambahHewan(new Singa("Simba"));
        kebunBinatang.TambahHewan(new Kuda("Woody"));

        using (var sw = new StringWriter())
        {
            Console.SetOut(sw);
            kebunBinatang.DengarkanHewanBersuara();

            var expected = string.Format("Singa bernama Simba bersuara Roar{0}Kuda bernama Woody bersuara Neigh{0}", Environment.NewLine);
            Assert.AreEqual(expected, sw.ToString());
        }
    }

    // Cleanup method to reset Console.Out if you are going to run more tests that do not redirect the console output
    [TestCleanup]
    public void Cleanup()
    {
        Console.SetOut(new StreamWriter(Console.OpenStandardOutput()));
    }

    [TestMethod]
    public void Singa_IsInstanceOfIBersuara_ReturnsTrue()
    {
        var singa = new Singa("Simba");
        Assert.IsTrue(singa is IBersuara, "Singa harus mengimplementasikan interface IBersuara.");
    }

    [TestMethod]
    public void Kuda_IsInstanceOfIBersuara_ReturnsTrue()
    {
        var kuda = new Kuda("Woody");
        Assert.IsTrue(kuda is IBersuara, "Kuda harus mengimplementasikan interface IBersuara.");
    }

    [TestMethod]
    public void Ular_IsNotInstanceOfIBersuara_ReturnsTrue()
    {
        var ular = new Ular("Kaa");
        Assert.IsFalse(ular is IBersuara, "Ular tidak seharusnya mengimplementasikan interface IBersuara.");
    }

    [TestMethod]
    public void Singa_IsInstanceOfHewan_ReturnsTrue()
    {
        var singa = new Singa("Simba");
        Assert.IsTrue(singa is Hewan, "Singa harus merupakan turunan dari kelas Hewan.");
    }

    [TestMethod]
    public void Kuda_IsInstanceOfHewan_ReturnsTrue()
    {
        var kuda = new Kuda("Woody");
        Assert.IsTrue(kuda is Hewan, "Kuda harus merupakan turunan dari kelas Hewan.");
    }

    [TestMethod]
    public void Ular_IsInstanceOfHewan_ReturnsTrue()
    {
        var ular = new Ular("Kaa");
        Assert.IsTrue(ular is Hewan, "Ular harus merupakan turunan dari kelas Hewan.");
    }


}
