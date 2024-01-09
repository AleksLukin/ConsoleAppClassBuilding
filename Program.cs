using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppClassBuilding
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Building house = new Building();
            house.Area = 160;
            house.Occupants = 4;
            house.Floors = 2;
            
            int quntityHouseAreaPerPerson = house.AreaPerPerson();
            Console.WriteLine("Количество площади в доме на 1 жильца равно " + quntityHouseAreaPerPerson + " кв.м.");

            Console.WriteLine();

            Building office = new Building();
            office.Area = 320;
            office.Occupants = 8;
            office.Floors = 4;

            int quntityOfficeAreaPerPerson = office.AreaPerPerson();
            Console.WriteLine("Количество площади в oфисе на 1 служащего равно " + quntityOfficeAreaPerPerson + " кв.м.");

            Console.ReadLine();

        }
    }
    class Building
    {
        public int Area;
        public int Occupants;
        public int Floors;

        public int AreaPerPerson()
        {
            
            return (Area*Floors) / Occupants;
            
        }
    }
}
