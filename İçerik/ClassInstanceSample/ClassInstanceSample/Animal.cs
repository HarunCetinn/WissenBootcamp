using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassInstanceSample
{
    public class Animal
    {
        /// <summary>
        /// Animal sınıfı constructor
        /// </summary>
        public Animal() //Constructor(Yapıcı Metot)
        {
            Console.WriteLine("Animal Class Instance ALındı");
        }
        /// <summary>
        /// Animal Type alan constructor
        /// </summary>
        /// <param name="animalType">animalTYpe string değer alır</param>
        public Animal(string animalType)//Parametre alan consturctor
        {
            Console.WriteLine(animalType);
        }

        //private string animalType;//Field

        //public string AnimalType { get => animalType; set => animalType = value; }

        //public string AnimalType { get; set; }

        private string animalType;//Field
        //Property
        public string AnimalTYpe
        {
            get
            {
                if (!string.IsNullOrEmpty(animalType))
                    return animalType;
                else
                    return "Animal TYpe boş geldi";
            }
            set
            {
                animalType = value;
            }
        }

        //Property
        public int Speed { get; set; }
        //public string getAnimalTYpe()
        //{
        //    return animalType;
        //}

        //public void setAnimalTYpe(string _animaType)
        //{
        //    animalType = _animaType;
        //}
        ~Animal()//Yıkıcı Metot
        {
            Console.WriteLine("Animal Sınıfı bellekten kaldırıldı");
        }

    }
}
