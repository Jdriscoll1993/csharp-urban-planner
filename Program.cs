using System;
using System.Collections.Generic;
// using blueprints
namespace Planner
{
    class Program
    {
        static void Main(string[] args)
        {
            // var allBuildings = new List<Building>();

            // Create instances of buildings
            Building FiveOneTwoEigth = new Building("512 8th Avenue");
            // define properties 
            FiveOneTwoEigth.Width = 101.5;
            FiveOneTwoEigth.Depth = 225.50;
            FiveOneTwoEigth.Stories = 10;

            Building TwentyFifthSecond = new Building("25 2th Avenue");
            TwentyFifthSecond.Width = 201.5;
            TwentyFifthSecond.Depth = 345.20;
            TwentyFifthSecond.Stories = 15;

            Building FourThreeNineFirst = new Building("439 1th Avenue");
            FourThreeNineFirst.Width = 350.65;
            FourThreeNineFirst.Depth = 225.50;
            FourThreeNineFirst.Stories = 25;

            // construct buildings
            FiveOneTwoEigth.Construct();
            TwentyFifthSecond.Construct();
            FourThreeNineFirst.Construct();

            // purchase buildings (who is purchasing)
            FiveOneTwoEigth.Purchase("Terry Boy");
            TwentyFifthSecond.Purchase("Larry Boy");
            FourThreeNineFirst.Purchase("Scarry Boy");

            // add each building to allBuildings List
            // allBuildings.Add(FiveOneTwoEigth);
            // allBuildings.Add(TwentyFifthSecond);
            // allBuildings.Add(FourThreeNineFirst);

            //New instance of City 
            City Joeytown = new City()
            {
                NameOfCity = "JoeyTown",
                Mayor = "Terry",
                Year = 1909,
            };

            // add each building using my AddBuilding method to Joeytown City 
            Joeytown.AddBuilding(FiveOneTwoEigth);
            Joeytown.AddBuilding(TwentyFifthSecond);
            Joeytown.AddBuilding(FourThreeNineFirst);

            Console.WriteLine($"The City of JoeyTown {Joeytown.NameOfCity}");
            foreach (Building building in Joeytown.Buildings)
            {
                building.BuildingInfo();
            }
        }
    }
}












// using System;
// using System.Collections.Generic;

// namespace Planner
// {
//     class Program
//     {
//         static void Main(string[] args)
//         {

//             List<Building> allBuildings = new List<Building>(); // Create a list for the buildings to go into

//             Building FiveOneTwoEigth = new Building("512 8th Avenue"); // Create a new instance of Building
//             FiveOneTwoEigth.Width = 100; // 
//             FiveOneTwoEigth.Depth = 200;
//             FiveOneTwoEigth.Stories = 15;



//             Building ThreeFourFiveEleventh = new Building("345 11th Ave");
//             ThreeFourFiveEleventh.Width = 85;
//             ThreeFourFiveEleventh.Depth = 220;
//             ThreeFourFiveEleventh.Stories = 25;



//             Building TwoNineFourth = new Building("29 4th street");
//             TwoNineFourth.Width = 100;
//             TwoNineFourth.Depth = 350;
//             TwoNineFourth.Stories = 10;

//             FiveOneTwoEigth.Construct(); // Construct a building
//             ThreeFourFiveEleventh.Construct();
//             TwoNineFourth.Construct();

//             allBuildings.Add(FiveOneTwoEigth); // Add building to List<Building> allBuildings
//             allBuildings.Add(ThreeFourFiveEleventh);
//             allBuildings.Add(TwoNineFourth);

//             FiveOneTwoEigth.Purchase("Joey"); // Purchase a building which prints to console on Building.cs
//             ThreeFourFiveEleventh.Purchase("Kenny");
//             TwoNineFourth.Purchase("Terry");
//         }
//     }
// }
