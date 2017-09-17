using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Курсач
{
    public class Laptop
    {
        public int LaptopID { get; set; }
        public string LaptopName { get; set; }
        public int RAM { get; set; }
        public int Capacity { get; set; }
        public float MonotorSize { get; set; }
        public string Processor { get; set; }
        public int BatteryCapacity { get; set; }
        public float Price { get; set; }

        public Laptop(int ID,string name,int RAM,int capacity,float monitorSize,string Proc,int battery,float price)
        {
            this.LaptopID = ID;
            this.LaptopName = name;
            this.RAM = RAM;
            this.Capacity = capacity;
            this.MonotorSize = monitorSize;
            this.Processor = Proc;
            this.BatteryCapacity = battery;
            this.Price = price;
        }

        public Laptop() { }
    }
}
