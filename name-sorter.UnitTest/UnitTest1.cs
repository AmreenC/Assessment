
using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace name_sorter.UnitTest
{
    [TestClass]
    public class ProgramUnitTest
    {
        List<string> NamesList;
        List<string> actual;
        List<string> expected;

        NameSorting NameSort;

        [TestInitialize]
        public void Init()
        {
            NamesList = new List<string>();
            actual = new List<string>();
            expected = new List<string>();

            NameSort = new NameSorting();
        }//Init

        [TestMethod]
        public void SortWithSurname_MixedLengthWordsTestMethod() //to test for sorting of all length of words in unsorted list
        {
            //arrange
            NamesList.Add("");
            NamesList.Add("Adonis Julius Archer");
            NamesList.Add("Janet Parsons");
            NamesList.Add("Lewis");

            expected.Add("Adonis Julius Archer");
            expected.Add("Lewis");
            expected.Add("Janet Parsons");

            //act
            actual = NameSort.SortWithSurname(NamesList);

            //assert
            CollectionAssert.AreEqual(expected, actual);
        }//SortWithSurname_MixedLengthWordsTestMethod

        [TestMethod]
        public void SortWithSurname_SameSurnameWordsTestMethod() //to test sorting of words with same surname in unsorted list
        {
            //arrange
            NamesList.Add("");
            NamesList.Add("Adonis Julius Archer");
            NamesList.Add("Janet Archer");
            NamesList.Add("Archer");

            expected.Add("Archer");
            expected.Add("Adonis Julius Archer");
            expected.Add("Janet Archer");

            //act
            actual = NameSort.SortWithSurname(NamesList);

            //assert
            CollectionAssert.AreEqual(expected, actual);
        }//SortWithSurname_SameSurnameWordsTestMethod

        [TestMethod]
        public void ReNameSurnameFirst_MixedLengthWordsTestMethod() //to test for all Mixed Length words lines in unsorted list
        {
            //arrange
            NamesList.Add("");
            NamesList.Add("Adonis Julius Archer");
            NamesList.Add("");
            NamesList.Add("Archer");
            NamesList.Add("Janet Parsons");

            expected.Add("Archer Adonis Julius ");
            expected.Add("Archer ");
            expected.Add("Parsons Janet ");

            //act
            actual = NameSort.ReNameSurnameFirst(NamesList);

            //assert
            CollectionAssert.AreEqual(expected, actual);
        }//ReNameSurnameFirst_MixedLengthWordsTestMethod

        [TestMethod]
        public void ReNameSurnameLast_MixedLengthWordsTestMethod() //to test all length of words in sorted list
        {
            //arrange
            NamesList.Add("");
            NamesList.Add("Archer Adonis Julius ");
            NamesList.Add("Lewis ");
            NamesList.Add("Parsons Janet ");

            expected.Add("Adonis Julius Archer");
            expected.Add("Lewis");
            expected.Add("Janet Parsons");

            //act
            actual = NameSort.ReNameSurnameLast(NamesList);

            //assert
            CollectionAssert.AreEqual(expected, actual);
        }//ReNameSurnameLast_MixedLengthWordsTestMethod

    }//ProgramUnitTest
}//name_sorter.UnitTest
