using Microsoft.VisualStudio.TestTools.UnitTesting;
using Solution.ObjectSorter;
using System;

namespace Solution.ObjectSorter.Tests;

[TestClass]
public class ObjectSorterTests
{
    [TestMethod]
    public void Buku_CompareToAnotherBuku_ReturnsCorrectValue()
    {
        var buku1 = new Buku("Buku 1", 100);
        var buku2 = new Buku("Buku 2", 150);

        Assert.IsTrue(buku1.Compare(buku2) < 0);
        Assert.IsTrue(buku2.Compare(buku1) > 0);
    }

    [TestMethod]
    public void Sepatu_CompareToAnotherSepatu_ReturnsCorrectValue()
    {
        var sepatu1 = new Sepatu("Sepatu 1", 42);
        var sepatu2 = new Sepatu("Sepatu 2", 40);

        Assert.IsTrue(sepatu1.Compare(sepatu2) > 0);
        Assert.IsTrue(sepatu2.Compare(sepatu1) < 0);
    }

    [TestMethod]
    public void Sorter_SortItems_ReturnsSortedArray()
    {
        var items = new ISortable[]
        {
            new Buku("Buku 3", 300),
            new Buku("Buku 1", 100),
            new Buku("Buku 2", 200)
        };

        var sortedItems = Sorter.SortItems(items);

        Assert.AreEqual("Buku 1", ((Buku)sortedItems[0]).Nama);
        Assert.AreEqual("Buku 2", ((Buku)sortedItems[1]).Nama);
        Assert.AreEqual("Buku 3", ((Buku)sortedItems[2]).Nama);
    }

    [TestMethod]
    public void Buku_ImplementsISortable()
    {
        Assert.IsTrue(typeof(ISortable).IsAssignableFrom(typeof(Buku)), "Kelas Buku harus mengimplementasi interface ISortable.");
    }

    [TestMethod]
    public void Sepatu_ImplementsISortable()
    {
        Assert.IsTrue(typeof(ISortable).IsAssignableFrom(typeof(Sepatu)), "Kelas Sepatu harus mengimplementasi interface ISortable.");
    }

    [TestMethod]
    public void Buku_IsDerivedFromItem()
    {
        Assert.IsTrue(typeof(Item).IsAssignableFrom(typeof(Buku)), "Kelas Buku harus turunan dari kelas Item.");
    }

    [TestMethod]
    public void Sepatu_IsDerivedFromItem()
    {
        Assert.IsTrue(typeof(Item).IsAssignableFrom(typeof(Sepatu)), "Kelas Sepatu harus turunan dari kelas Item.");
    }

}
