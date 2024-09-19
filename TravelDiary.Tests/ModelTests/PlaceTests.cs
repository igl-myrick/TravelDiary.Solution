using Microsoft.VisualStudio.TestTools.UnitTesting;
using TravelDiary.Models;
using System;
using System.Collections.Generic;

namespace JobBoard.Tests
{
  [TestClass]
  public class PlaceTests
  {
    [TestMethod]
    public void PlaceConstructor_CreatesInstanceOfPlace_Place()
    {
      Place newPlace = new Place();
      Assert.AreEqual(typeof(Place), newPlace.GetType());
    }

    [TestMethod]
    public void GetCityName_GetsValueOfCityName_String()
    {
      Place newPlace = new Place();
      string city = newPlace.cityName;
      Assert.AreEqual(city, newPlace.cityName);
    }
  }
}