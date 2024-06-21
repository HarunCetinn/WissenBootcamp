using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticClassSample
{
    public static class FizikKutuphanesi
    {
        public static decimal YerCekimiKuvveti {  get; set; }
        public const int SuyunKaldirmaKuvveti = 12;//const : Sabit değişken tanımlar
        public static readonly int Kuvvet = 2;//Sadece okunabilir bir değişken(field)

        public static void SuyunKaldırmaKuvvetiniKUllan()
        {
            Console.WriteLine($"Suyun Kaldırma KUvveti : {SuyunKaldirmaKuvveti}");
        }
    }
}
