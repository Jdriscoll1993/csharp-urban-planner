using System;
using System.Collections.Generic;
// blueprint 
namespace Planner
{
    class City
    {
        // Name of the city
        public string NameOfCity { get; set; }
        // The mayor of the city
        public string Mayor { get; set; }
        // Year the city was established
        public int Year { get; set; }
        // A collection of all of the buildings in the city.
        public List<Building> Buildings { get; set; } = new List<Building>();
        public City()
        {

        }
        // A method to add a building to the city
        public void AddBuilding(Building name)
        {
            Buildings.Add(name);
        }

    }
}