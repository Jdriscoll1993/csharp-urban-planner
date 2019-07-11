// using System;

// namespace Planner
// {
//     class Building
//     {
//         private string _designer = "Joey Driscoll"; // private fields
//         private DateTime _dateConstructed;
//         private string _address;
//         private string _owner;
//         public int Stories { get; set; } // properties
//         public double Width { get; set; }
//         public double Depth { get; set; }
//         // the following property is readonly because it only has a get and not a set
//         public double Volume
//         {
//             get
//             {
//                 return Width * Depth * (3 * Stories);
//             }
//         }
//         public Building(string address) // constructor
//         {
//             _address = address; // set field value
//         }

//         public void Construct() // public methods - do not return a value - hence void as return type
//         {
//             _dateConstructed = DateTime.Now;
//         }

//         public void Purchase(string name)
//         {
//             _owner = name;
//             Console.WriteLine($"{_address}");
//             Console.WriteLine("----------------");
//             Console.WriteLine($"Designed by {_designer}");
//             Console.WriteLine($"constructed on {_dateConstructed}");
//             Console.WriteLine($"owned by {_owner}");
//             Console.WriteLine($"{Volume} cubic meters of space");
//         }
//     }
// }

using System;

namespace Planner
{
    class Building
    {
        private string _designer = "Joey Driscoll";
        private DateTime _dateConstructed;
        private string _address;
        private string _owner;
        public int Stories { get; set; }
        public double Width { get; set; }
        public double Depth { get; set; }
        public double Volume
        {
            get
            {
                return Width * Depth * (3 * Stories);
            }
        }

        public Building(string address)
        {
            _address = address;
        }
        public void Construct()
        {
            _dateConstructed = DateTime.Now;
        }
        public void Purchase(string buyerOFBuilding)
        {
            _owner = buyerOFBuilding;

        }
        public void BuildingInfo()
        {
            Console.WriteLine("---------------------");
            Console.WriteLine($"{_address}");
            Console.WriteLine($"Designed by {_designer}");
            Console.WriteLine($"Constructed on{_dateConstructed}");
            Console.WriteLine($"Owned by {_owner}");
            Console.WriteLine($"{Volume} cubic meters of space");
        }

    }
}