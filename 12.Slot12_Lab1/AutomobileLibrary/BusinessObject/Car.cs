using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomobileLibrary.BusinessObject
{
    public class Car
    {
        public int CarID {  get; set; }
        public string CarName {  get; set; }
        public string CarManufacturer {  get; set; }
        public double CarPrice {  get; set; }
        public int CarReleaseYear {  get; set; }
    }
}
