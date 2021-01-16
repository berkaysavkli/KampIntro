using System;

namespace Donguler
{
    class Program
    {
        static void Main(string[] args)
        {
            string kurs1 = "Yazılım Geliştirici Yetiştirme Kursu";
            string kurs2 = "Programlamaya Başlangıç İçin Temel Kurs";
            string kurs3 = "Java";

            // *********ARRAY (DİZİLER)**********

            string[] kurslar = new string[] { "Yazılım Geliştirici Yetiştirme Kursu", 
                "Programlamaya Başlangıç İçin Temel Kurs", "Java" ,"C#"};

            for (int i = 0; i < kurslar.Length; i++)
            {
                Console.WriteLine(kurslar[i]);
            }
            
            Console.WriteLine("For döngüsü bitti");

            //  foreach dizi temelli yapıları tek tek dönmeye yarar

            foreach (string kurs in kurslar)
            {
                Console.WriteLine(kurs);
            }

            Console.WriteLine("Foreach döngüsü bitti");
        }
    }
}
