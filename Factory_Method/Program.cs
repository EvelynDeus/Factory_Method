using System;



namespace Factory_Method
{

    class Program
    {
        static void Main(string[] args)
        {
            System.Threading.Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("en-US");

            TariffFactory factory;
            List<Flat> flats = new List<Flat>();

            for(int i = 0; i < 3; i++)
            {
                Console.WriteLine($"Введите колличество используемой электроэнергии для квартиры {i+1}");
                double elect = Convert.ToDouble(Console.ReadLine());
                flats.Add(new Flat { Elek = elect });
            }


            foreach(var flat in flats)
            {
                if (flat.Elek <= 2500)
                {
                    Console.WriteLine("Расчет по первому тарифу");
                    factory = new FirstTariffFactory();
                    factory.Cout(flat.Elek);
                }
                else if(flat.Elek <= 5750)
                {
                    Console.WriteLine("Расчет по второму тарифу");
                    factory = new SecondTariffFactory();
                    factory.Cout(flat.Elek);
                }
                else
                {
                    Console.WriteLine("Расчет по третьему тарифу");
                    factory = new ThirdTariffFactory();
                    factory.Cout(flat.Elek);
                }
            }
        }
    }
}
