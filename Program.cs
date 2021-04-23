using System;
using System.Collections.Generic;

namespace Planner
{
    class Program
    {
        static void Main(string[] args)
        {
            //using the constructor and the method GetAddress to get the address of the new building i created
            //    Building myHouse = new Building("123 Road");
            //    myHouse.GetAddress();


            //creating a new list of buildings 
            List<Building> myPropertiesList = new List<Building>();

            //creating a new city
            City CrazyWeatherHereLately = new City("CrazyWeatherHereLately", "Jordan", 2020);

                //creating a new building object and adding it to the myPropertiesList
                Building FiveOneTwoEight = new Building("512 8th Avenue")
                {
                    Width = 125.5,
                    Depth = 54.0,
                    Stories = 3
                };
                FiveOneTwoEight.Construct();
                FiveOneTwoEight.Purchase("Tommy");
                myPropertiesList.Add(FiveOneTwoEight);
                CrazyWeatherHereLately.AddBuilding(FiveOneTwoEight);

                Building OneTwoThree = new Building("123 Big Hill Rd")
                {
                    Width = 145.5,
                    Depth = 75.0,
                    Stories = 2
                };
                OneTwoThree.Construct();
                OneTwoThree.Purchase("Jordan");
                myPropertiesList.Add(OneTwoThree);
                CrazyWeatherHereLately.AddBuilding(OneTwoThree);

                Building SixSevenEight = new Building("678 Long Trail Rd")
                {
                    Width = 178.5,
                    Depth = 99.0,
                    Stories = 4
                };
                SixSevenEight.Construct();
                SixSevenEight.Purchase("Courtney");
                myPropertiesList.Add(SixSevenEight);
                CrazyWeatherHereLately.AddBuilding(SixSevenEight);

                Building NineNineNine = new Building("999 Home Lane")
                {
                    Width = 115.6,
                    Depth = 42.5,
                    Stories = 1
                };
                NineNineNine.Construct();
                NineNineNine.Purchase("Tommy");
                myPropertiesList.Add(NineNineNine);
                CrazyWeatherHereLately.AddBuilding(NineNineNine);

                Building OneOneOne = new Building("111 Who Lives Here")
                {
                    Width = 145.0,
                    Depth = 91.0,
                    Stories = 2
                };
                OneOneOne.Construct();
                OneOneOne.Purchase("Jordan");
                myPropertiesList.Add(OneOneOne);
                CrazyWeatherHereLately.AddBuilding(OneOneOne);

            //taking the list-- myPropertiesList and printing each one with the method PrintBuilding from Building.cs
            //myPropertiesList.ForEach(property => property.PrintBuilding());
            
            CrazyWeatherHereLately.ListBuildings();

        }
    }
}
