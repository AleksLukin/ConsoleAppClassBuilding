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

            int quntityHouseAreaPerPerson = house.AreaPerPerson(60, 5, 2);
            Console.WriteLine("Количество площади в доме на 1 жильца равно " + quntityHouseAreaPerPerson + " кв.м.");

            Console.WriteLine();

            Building office = new Building();
            int quntityOfficeAreaPerPerson = office.AreaPerPerson(120, 24, 5);
            Console.WriteLine("Количество площади в oфисе на 1 служащего равно " + quntityOfficeAreaPerPerson + " кв.м.");

            Console.ReadLine();

        }
    }
    class Building
    {

        public int AreaPerPerson(int area, int occupants, int floors)
        {

            int areaPerPerson = (area*floors) / occupants;
            return areaPerPerson;
        }
    }
}
