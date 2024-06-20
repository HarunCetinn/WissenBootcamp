using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceSampleAnimal
{
    public class Animal
    {
        public Animal() 
        {
            Console.WriteLine("Ortak Özelliklerin BUlunduğu Class");
        }

        #region Properties
        public int FootCount {  get; set; }

        public int Age {  get; set; }

        public DateTime BirthDate { get; set; }

        public List<HelthCare> HealthCareHistory { get; set; }  
        public double Weight {  get; set; }

        public string AnimalInfo
        {
            get
            {
                string info = $"FootCOunt : {FootCount}\n" +
                    $"Age : {Age}\n" +
                    $"Weight : {Weight}\n" +
                    $"HelathCare History : {HealthCareHistoryList(HealthCareHistory)}";
                return info;
            }
        }


        #endregion

        #region Procedures

        private string HealthCareHistoryList(List<HelthCare> healthCareHistory)
        {
            StringBuilder str = new StringBuilder();
            foreach (HelthCare hc in healthCareHistory)
            {
                str.Append($"{hc.Date.ToString("yyyy-MM-dd")} - {hc.Notes} ; ");
            }
            return str.ToString();
        }
        public void Eat()
        {
            Console.WriteLine("Animal Eat");
        }

        public int Run(int minute, int distance, out int cal)
        {
            int result = 0;
            cal = minute * distance / 100;
            result = minute * distance;
            return result;
        }

        public TimeSpan Rest(DateTime beginDate, DateTime endDate)
        {
            TimeSpan result;
            result = endDate.Subtract(beginDate);
            return result;
        }

        
        #endregion
    }
}
