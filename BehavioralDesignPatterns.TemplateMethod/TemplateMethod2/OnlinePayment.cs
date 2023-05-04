using BehavioralDesignPatterns.TemplateMethod.TemplateMethod2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BehavioralDesignPatterns.TemplateMethod.TemplateMethod2
{
    public abstract class OnlinePayment
    {
        public void OdemeIslemi()
        {
            OdemeBilgileriniDogrula();
            OdemeDetaylariniDogrula();
            OdemeSureciOzelOdemeMetodu();
            OnayMailiGonder();
        }

        protected abstract void OdemeSureciOzelOdemeMetodu();

        private void OdemeBilgileriniDogrula()
        {
            Console.WriteLine("Ödeme bilgileri doğrulanıyor...");
        }

        private void OdemeDetaylariniDogrula()
        {
            Console.WriteLine("Ödeme detayları doğrulanıyor...");
        }

        private void OnayMailiGonder()
        {
            Console.WriteLine("Onay maili gönderiliyor...");
        }
    }
}

public class CreditCartPayment : OnlinePayment
{
    protected override void OdemeSureciOzelOdemeMetodu()
    {
        Console.WriteLine("Kredi kartı ödeme ile devam ediliyor...");
    }
}

public class BankTransferPayment : OnlinePayment
{
    protected override void OdemeSureciOzelOdemeMetodu()
    {
        Console.WriteLine("Banka havalesi ödeme yöntemi ile devam ediliyor...");
    }
}
