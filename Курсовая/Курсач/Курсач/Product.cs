using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using System.Xml.Serialization;

namespace Курсач
{
   // [Serializable]
    public class Product:Laptop
    {
        public bool Availability { get; set; }

        public Product(int ID, string name, int RAM, int capacity, float monitorSize, string Proc, int battery, float price,bool availability) :base(ID,name,RAM,capacity,monitorSize,Proc,battery,price)
        {
            this.Availability = availability;
        }

        public Product() { }

    }
}
