using System;
using System.Collections.Generic;

namespace Koleksiyonlar
{
    class Program
    {
        static void Main(string[] args)
        {
            //string[] isimler = new string[] { "Engin", "Murat", "Kerem", "Halil" };
            //Console.WriteLine(isimler[0]);
            //Console.WriteLine(isimler[1]);
            //Console.WriteLine(isimler[2]);
            //Console.WriteLine(isimler[3]);

            //isimler = new string[5];      // isimler dizisi oluşturduktan sonra eleman eklemek istersek bu şekilde yeniden 
            //isimler[4] = "İlker";         // 5 elemanlı bir dizi oluşturabiliriz. Fakat yeniden oluşturunca ilk veriler silinmiş
            //Console.WriteLine(isimler[4]);// olur.
            //Console.WriteLine(isimler[0]);

            //------------Koleksiyon (list) Kullanımı------------
            List<string> isimler2 = new List<string>() { "Engin", "Murat", "Kerem", "Halil" };

            Console.WriteLine(isimler2[0]);
            Console.WriteLine(isimler2[1]);
            Console.WriteLine(isimler2[2]);
            Console.WriteLine(isimler2[3]);
            isimler2.Add("İlker");
            Console.WriteLine(isimler2[4]);
            Console.WriteLine(isimler2[0]);
            
            //Koleksiyonlar sayesinde sonradan veri eklediğimizde önceki verileri kaybetmemiş oluyoruz.
            





        }
    }
}
