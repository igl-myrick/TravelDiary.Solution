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
      Place newPlace = new Place("Seattle", "1/1/2023 - 1/5/2023");
      Assert.AreEqual(typeof(Place), newPlace.GetType());
    }

    [TestMethod]
    public void GetCityName_GetsValueOfCityName_String()
    {
      string city = "Seattle";
      Place newPlace = new Place(city, "1/1/2023 - 1/5/2023");
      Assert.AreEqual(city, newPlace.CityName);
    }

    [TestMethod]
    public void SetCityName_SetsValueOfCityName_String()
    {
      string city = "Seattle";
      Place newPlace = new Place(city, "1/1/2023 - 1/5/2023");
      string newCity = "New York";
      newPlace.CityName = newCity;
      string result = newPlace.CityName;
      Assert.AreEqual(newCity, result);
    }

    [TestMethod]
    public void GetDuration_GetsValueOfDuration_String()
    {
      string tripDuration = "1/1/2023 - 1/5/2023";
      Place newPlace = new Place("Seattle", tripDuration);
      Assert.AreEqual(tripDuration, newPlace.Duration);
    }

    [TestMethod]
    public void GetAll_ReturnsAllPlaces_List()
    {
      Place newPlace1 = new Place("Seattle", "1/1/2023 - 1/5/2023");
      Place newPlace2 = new Place("New York", "6/1/2023 - 6/5/2023");
      List<Place> newList = new List<Place> { newPlace1, newPlace2 };

      List<Place> result = Place.GetAll();

      CollectionAssert.AreEqual(newList, result);
    }

    [TestMethod]
    public void GetId_PlacesInstantiateWithIdAndGetterReturns_Int()
    {
      Place newPlace = new Place("Seattle", "1/1/2023 - 1/5/2023");

      int result = newPlace.Id;

      Assert.AreEqual(1, result);
    }

    [TestMethod]
    public void Find_ReturnsCorrectPlace_Place()
    {
      Place newPlace1 = new Place("Seattle", "1/1/2023 - 1/5/2023");
      Place newPlace2 = new Place("New York", "6/1/2023 - 6/5/2023");

      Place result = Place.Find(2);

      Assert.AreEqual(newPlace2, result);
    }
  }
}