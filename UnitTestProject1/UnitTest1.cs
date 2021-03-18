using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using LabyCS_12_03;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void All_Things_Is_Over_MaxCapacity_Then_CurrentCapacity_Is_0()
        {
            ListOfItem list = new ListOfItem();
            list.AddItemToListManual(new Item(10, 1));
            list.AddItemToListManual(new Item(11, 4));
            list.AddItemToListManual(new Item(12, 3));
            BackPack bb = new BackPack(9);
            bb.robTheHouse(list);
            Assert.AreEqual(0, bb.ItemsOnBackPack.Count);
        }
        [TestMethod]
        public void One_Thing_Is_Available_Then_One_Thing_In_BackPack()
        {
            ListOfItem list = new ListOfItem();
            list.AddItemToListManual(new Item(10, 1));
            BackPack bb = new BackPack(11);
            bb.robTheHouse(list);
            Assert.AreEqual(10,bb.CurrentCapacity);
        }
        [TestMethod]
        public void Different_Order_But_The_Same_Result()
        {
            ListOfItem list1 = new ListOfItem();
            list1.AddItemToListManual(new Item(20, 5));
            list1.AddItemToListManual(new Item(5, 5));
            list1.AddItemToListManual(new Item(1, 10));
            BackPack bb1 = new BackPack(25);
            bb1.robTheHouse(list1);

            ListOfItem list2 = new ListOfItem();
            list2.AddItemToListManual(new Item(1, 10));
            list2.AddItemToListManual(new Item(20, 5));
            list2.AddItemToListManual(new Item(5, 5));
            BackPack bb2 = new BackPack(25);
            bb2.robTheHouse(list2);

            Assert.AreEqual(bb1.CurrentCapacity, bb2.CurrentCapacity);//jak zmierzyć obiekty, same nie dziala
        }





    }
}
