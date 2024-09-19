using Microsoft.VisualStudio.TestTools.UnitTesting;
using TravelDiary.Models;
using System;
using System.Collections.Generic;

namespace JobBoard.Tests
{
  [TestClass]
  public class PlaceTests : IDisposable
  {
    public void Dispose()
    {
      Place.ClearAll();
    }

    [TestMethod]
    public void PlaceConstructor_CreatesInstanceOfPlace_Place()
    {
      Place newPlace = new Place("Seattle");
      Assert.AreEqual(typeof(Place), newPlace.GetType());
    }

    [TestMethod]
    public void GetCityName_GetsValueOfCityName_String()
    {
      string city = "Seattle";
      Place newPlace = new Place(city);
      Assert.AreEqual(city, newPlace.CityName);
    }

    [TestMethod]
    public void SetCityName_SetsValueOfCityName_String()
    {
      string city = "Seattle";
      Place newPlace = new Place(city);
      string newCity = "New York";
      newPlace.CityName = newCity;
      string result = newPlace.CityName;
      Assert.AreEqual(newCity, result);
    }

    [TestMethod]
    public void GetAll_ReturnsAllPlaces_List()
    {
      Place newPlace1 = new Place("Seattle");
      Place newPlace2 = new Place("New York");
      List<Place> newList = new List<Place> { newPlace1, newPlace2 };

      List<Place> result = Place.GetAll();

      CollectionAssert.AreEqual(newList, result);
    }
  }
}