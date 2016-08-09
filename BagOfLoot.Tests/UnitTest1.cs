using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BagOfLoot.Tests
{
    [TestClass]
    public class BagOLootTests
    {
        //Items can be added to bag.
        [TestMethod]
        public void ItemsCanBeAddedToBag()
        {
        }

        //Items can be removed from bag, per child only. Removing ball from the bag should not be allowed. A child's name must be specified.
        [TestMethod]
        public void ItemsCanBeRemovedFromBagPerSpecificChild()
        {

        }

        //Items can be removed from bag, per child only. Removing ball from the bag should not be allowed. A child's name must be specified.
        [TestMethod]
        public void ItemsCANNOTBeRemovedFromBagWithoutSpecifyingChild()
        {

        }

        //Must be able to list all children who are getting a toy.
        [TestMethod]
        public void AbleToListAllChildrenWhoAreGettingAToy()
        {

        }

        //Must be able to list all toys for a given child's name.
        [TestMethod]
        public void AbleToListAllToysGivenAChildsName()
        {

        }

        //Must be able to list all toys for a given child's name.
        [TestMethod]
        public void AbleToListOnlySpecifcToysToChild()
        {

        }

        //Must be able to set the delivered property of a child, which defaults to false to true.
        [TestMethod]
        public void AbleToSetDeliveredPropertyPerChild()
        {

        }
    }
}
