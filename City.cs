using System;
using System.Collections.Generic;

namespace Planner
{
    public class City
    {
        public string Name { get; set; }
        public string Mayor { get; set; }

        public int Year { get; set ; }

        public City(string cityName, string cityMayor, int yearEstablished)
        {
            Name = cityName;
            Mayor = cityMayor;
            yearEstablished = Year;

        }

        private List<Building> myCity = new List<Building>();

        public void AddBuilding(Building newBuilding){
            myCity.Add(newBuilding);
        }

        public void ListBuildings() {
            myCity.ForEach(building => building.PrintBuilding(building));
        }
    }
}