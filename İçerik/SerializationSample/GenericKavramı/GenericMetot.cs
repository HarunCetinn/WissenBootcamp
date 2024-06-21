using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericKavramı
{
    internal class GenericMetot<T>
    {
        public T[] dizi = new T[5];

        public void VeriEkle(int index,T data)
        {
            if(index >= 0 && index < 5)
                dizi[index] = data;
        }

        public void VeriEkle(T index, T data)
        {
            //diziye eklencek datalar
        }

        public void VeriEkle(string index, T data)
        {
            //diziye eklencek datalar
        }

        public void VeriEkle(T data)
        {
            //diziye eklencek datalar
        }

        public T VeriyiGetir(int index)
        {
            if (index >= 0 && index < 5)
                return dizi[index];//Gelen index sayısı 0 ile 4 arasında ise ilgili indexte bulunan elemanı return edecek
            else
                return default(T);// T tipi ne belirlendi ise onun default değerini return edecek.
        }
    }
}
