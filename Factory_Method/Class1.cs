using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory_Method
{
    
    interface ITariff
    {
        double AmountOfTlectricity { get; set; }

        double GetCalculation(double amount);
    }


    abstract class TariffFactory
    {
        protected ITariff tariff;
        public abstract void Cout(double amount);
    }

    class FirstTariffFactory: TariffFactory
    {
        public override void Cout(double amount)
        {
            tariff = new FirsType();
            Console.WriteLine(tariff.GetCalculation(amount));
        }
    }

    class SecondTariffFactory: TariffFactory
    {
        public override void Cout(double amount)
        {
            tariff = new SecondType();
            Console.WriteLine(tariff.GetCalculation(amount));
        }
    }

    class ThirdTariffFactory : TariffFactory
    {
        public override void Cout(double amount)
        {
            tariff = new ThirdType();
            Console.WriteLine(tariff.GetCalculation(amount));
        }
    }

    class FirsType: ITariff
    {
        public double AmountOfTlectricity { get; set; }

        public double GetCalculation(double amount)
        {
            return amount * 5.2;
        }
    }

    class SecondType: ITariff
    {
        public double AmountOfTlectricity { get; set; }

        public double GetCalculation(double amount)
        {
            return amount * 7.5;
        }

    }

    class ThirdType : ITariff
    {
        public double AmountOfTlectricity { get; set; }

        public double GetCalculation(double amount)
        {
            return amount * 10.3;
        }
    }

    class Flat
    {
        public double Elek { get; set; }
    }
}
