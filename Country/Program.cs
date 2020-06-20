using System;

namespace Country
{
    class Program
    {
        class Country
        {
            private string name;
            private int population;

            //Свойства
            public string Name
            {
                get { return name; }
                set
                {
                    if (name != "") name = value;
                }
            }

            public int Population
            {
                get { return population; }
                set
                {
                    if (population > 0) population = value;
                }
            }

            //Конструкторы
            public Country() { }

            public Country(string newName)
            {
                Name = newName;
            }

            public Country(int Population)
            {
                population = Population;
            }

            public Country(string Name, int Population)
            {
                name = Name;
                population = Population;
            }

            //Методы
            public void ChangeCountryName(string Name)
            {
                name = Name;
            }


            public void ChangePopulationValue(int newPopulationValue)
            {
                Population = newPopulationValue;
            }

            public void PrintCountryInfo()
            {
                Console.WriteLine("Название страны: " + Name);
                Console.WriteLine("Население: " + Population);
            }
        }

        class Russia : Country
        {
            private double vvp;
            private string rubleValueToUSD;

            //Свойства
            public double VVP
            {
                get { return vvp; }
                set
                {
                    if (vvp > 0) vvp = value;
                }
            }

            public string RubleValueToUSD
            {
                get { return rubleValueToUSD; }
                set
                {
                    if (rubleValueToUSD != "") rubleValueToUSD = value;
                }
            }

            //Конструкторы
            public Russia() { }

            public Russia(double VVP)
            {
                vvp = VVP;
            }

            public Russia(string RubleValueToUSD)
            {
                rubleValueToUSD = RubleValueToUSD;
            }

            public Russia(double VVP, string RubleValueToUSD)
            {
                vvp = VVP;
                rubleValueToUSD = RubleValueToUSD;
            }

            //Методы
            public void PrintRussiaInfo()
            {
                Console.WriteLine("ВВП на душу населения: " + VVP);
                Console.WriteLine("Стоимость рубля: " + RubleValueToUSD);
            }

            public void MakeNuclearStrike(string CountryTarget)
            {
                Console.WriteLine("Произведён ядерный удар по стране: " + CountryTarget);
            }

            public void isChinaFriendToRussia(bool isItTrue)
            {
                if (isItTrue == true) Console.WriteLine("Китай является дружественной державой!");
                if (isItTrue == false) Console.WriteLine("Китай, кажется, готовит авиаудар, будьте осторожны");
            }
        }

        class Ukraine : Country
        {
            private int numberOfCities;
            private string capital;

            //Свойства
            public int NumberOfCities
            {
                get { return numberOfCities; }
                set
                {
                    if (numberOfCities > 0) numberOfCities = value;
                }
            }

            public string Capital
            {
                get { return capital; }
                set
                {
                    if (capital != "") capital = value;
                }
            }

            //Конструкторы
            public Ukraine() { }
            public Ukraine(int NumberOfCities)
            {
                numberOfCities = NumberOfCities;
            }

            public Ukraine(string Capital)
            {
                capital = Capital;
            }

            public Ukraine(int NumberOfCities, string Capital)
            {
                numberOfCities = NumberOfCities;
                capital = Capital;
            }

            //Методы
            public void MakeBuisness(double startUpCapital)
            {
                Console.WriteLine("Стартовый капитал для открытия бизнеса в Украине: " + startUpCapital);
            }

            public void ToStoleSomething(string yourTarget)
            {
                Console.WriteLine("Вы хотите украсть " + yourTarget + " и у вас это получается");
            }

            public void AreYouPresident(bool areYou)
            {
                if (areYou == true) Console.WriteLine("Вы президент Украины, поздравляем!");
                if (areYou == false) Console.WriteLine("К сожалению или к счастью, но вы не президент Украины");
            }
        }

        static void Main(string[] args)
        {
            Country one = new Country("Россия", 145_000_000);
            Russia two = new Russia(11288.87, "69");
            Ukraine three = new Ukraine(443, "Киев");

            //Country
            Console.WriteLine("Информация из класса Country:" + "\n");
            Console.WriteLine("Название страны: " + one.Name);
            Console.WriteLine("Население: " + one.Population);
            one.ChangeCountryName("Украина");
            one.ChangePopulationValue(42_000_000);
            Console.WriteLine();
            Console.WriteLine("Название страны: " + one.Name);
            Console.WriteLine("Население: " + one.Population);
            Console.WriteLine();
            one.PrintCountryInfo();
            Console.WriteLine("///////////////////////////////////////");

            //Russia
            Console.WriteLine("Информация из класса Russia:" + "\n");
            Console.WriteLine("ВВП на душу населения: " + two.VVP);
            Console.WriteLine("Стоимость рубля: " + two.RubleValueToUSD);
            Console.WriteLine();
            two.PrintRussiaInfo();
            two.MakeNuclearStrike("Польша");
            two.isChinaFriendToRussia(true);
            Console.WriteLine("///////////////////////////////////////");

            //Ukraine
            Console.WriteLine("Информация из класса Ukraine:" + "\n");
            Console.WriteLine("Количество городов Украины: " + three.NumberOfCities);
            Console.WriteLine("Столица Украины: " + three.Capital);
            Console.WriteLine();
            three.MakeBuisness(500_367);
            Console.WriteLine();
            three.ToStoleSomething("шоколад");
            Console.WriteLine();
            three.AreYouPresident(false);
            Console.WriteLine();
        }
    }
}
