﻿using BehavioralDesignPatterns.TemplateMethod.Odev1;
using BehavioralDesignPatterns.TemplateMethod.TemplateMethod1;
using BehavioralDesignPatterns.TemplateMethod.TemplateMethod2;

namespace BehavioralDesignPatterns.TemplateMethod
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello, World!");

            //Icecek cay = new Cay();
            //Icecek kahve = new Kahve();

            //Console.WriteLine("Çay hazırlanıyor...");
            //cay.IcecegiHazirla();

            //Console.WriteLine("Kahve hazırlanıyor...");
            //kahve.IcecegiHazirla();

            //OnlinePayment creditCartPayment = new CreditCartPayment();
            //OnlinePayment bankTransferPayment = new BankTransferPayment();

            //Console.WriteLine("Kredi kartı seçimi ile devam ediliyor...");
            //creditCartPayment.OdemeIslemi();

            //Console.WriteLine("Banka havalesi seçimi ile devam ediliyor...");
            //bankTransferPayment.OdemeIslemi();

            İşeAlımSüreci yazılımGeliştirmeAlımı = new YazılımGeliştirmeAlımı();
            İşeAlımSüreci pazarlamaAlımı = new PazarlamaAlımı();

            Console.WriteLine("Yazılım geliştirme departmanına işe alım süreci...");
            yazılımGeliştirmeAlımı.İşBaşvurusuİşle();

            Console.WriteLine("\nPazarlama departmanı işe alım süreci...");
            pazarlamaAlımı.İşBaşvurusuİşle();
        }
    }
}