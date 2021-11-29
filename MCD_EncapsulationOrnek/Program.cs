using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MCD_EncapsulationOrnek
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Daire isimli bir class'a aşağıdaki şekilde nesne oluşturma kuralları uygulayınız.
             * pi sayısı olarak bir özellik tutunuz.Bu özelliğin değerini 3 atayınız.
             * Pi sayısı değerini dışarıdan gönderiniz.
             * Bu dairenin çevresini ve alanını hesaplayınız.
             */

            Daire daire1 = new Daire(4);
            daire1.Yaricap = 5;
            Console.WriteLine("Çap: "+daire1.Cap.ToString("0.00"));
            daire1.AlanHesapla();
            Console.WriteLine();
            daire1.CevreHesapla();
            Console.WriteLine();

            Console.ReadKey();

        }
    }
}
