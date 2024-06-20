using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceSampleAnimal
{
    public class HelthCare
    {
        public HelthCare() 
        {
            Console.WriteLine("Muayene Bilgileri");
                
        }

        public DateTime Date { get; set; }

        public string Notes {  get; set; }

        public string GetInfo
        {
            get
            {
                string returnVal = $"Date : {this.Date.ToLongDateString()}\tNotes : {this.Notes}";
                return returnVal;
            }
        }
    }
}
