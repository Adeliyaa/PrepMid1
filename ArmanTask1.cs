using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

using System.IO;

namespace exampleser
{
    class Program
    {
        static void Main(string[] args)
        {
            List<car> myList = new List<car>();

            myList.AddRange(new car[] {
                new car("X5", "BMW", 2005),
                new car("X6", "BMW", 2008),
                new car("Camry", "Toyota", 2003),
                new car("40", "Toyota", 2007),
                new car("30", "Toyota", 2002),
                new car("R5", "Audi", 2009),
                new car("Passat", "Volkswagen", 2000),
                new car("priora", "Nissan", 1999),
                new car("Adora", "Hyundai", 1934),
                new car("MK5", "Bentley", 2010)
});

            FileStream fs = new FileStream("output.txt", FileMode.Create, FileAccess.Write);
            XmlSerializer xmlSer = new XmlSerializer(typeof(List<car>));
            xmlSer.Serialize(fs, myList);
           
        }
    }
    public class car
    {
        public string name;
        public string mark;
        public int yearOfRelease;
        public car() {
            this.name = "1";
            this.mark = "Car";
            this.yearOfRelease = 0;
        }
        
        public car(string n, string m, int y)
        {
            this.name = n;
            this.mark = m;
            this.yearOfRelease = y;
        }
        
    }
}