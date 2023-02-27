using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace Seasons
{
    internal class Program
    {
        public static class Seesons
        {
            public static int averageTemp(Seasons season)
            {
                switch (season)
                {
                    case Seasons.spring:
                        return 10;
                    case Seasons.summer:
                        return 27;
                    case Seasons.autumn:
                        return 8;
                    case Seasons.winter:
                        return -25;
                }
                return 0;
            }
            public static string returnString(Seasons season)
            {
                switch (season)
                {
                    case Seasons.spring:
                        return "Веснa - хорошее время года";
                    case Seasons.summer:
                        return "Лето радует нас своим урожаем фруктов и ягод";
                    case Seasons.autumn:
                        return "Осень - время года перемен";
                    case Seasons.winter:
                        return "Зимой часто идет снег, бушуют метели и зимние вьюги";
                }
                return "";
            }
            public static string returnString(Seasons season, Seasons temperature)
            {
                switch (season)
                {
                    case Seasons.spring:
                        return "Я люблю весну";
                    case Seasons.summer:
                        return "Я люблю лето";
                    case Seasons.autumn:
                        return "Я люблю осень";
                    case Seasons.winter:
                        return "Я люблю зиму";
                }
                return "";
            }
            public static string getDescription(Seasons season)
            {
                if (season == Seasons.summer)
                {
                    return "Тёплое время года";
                }
                return "Холодное время года";
            }
            public enum Seasons
            {
                spring = 0,
                summer = 1,
                autumn = 2,
                winter = 3,
                springTemperature = 14,
                summerTemperature = 27,
                autumnTemperature = 8,
                winterTemperature = -25,
            }
            static void Main(string[] args)
            {
                Console.WriteLine(getDescription(Seasons.spring));
                Console.WriteLine(getDescription(Seasons.summer));
                Console.WriteLine(getDescription(Seasons.autumn));
                Console.WriteLine(getDescription(Seasons.winter));
                Console.WriteLine(averageTemp(Seasons.spring));
                Console.WriteLine(averageTemp(Seasons.summer));
                Console.WriteLine(averageTemp(Seasons.autumn));
                Console.WriteLine(averageTemp(Seasons.winter));
                Console.WriteLine(returnString(Seasons.spring));
                Console.WriteLine(returnString(Seasons.summer));
                Console.WriteLine(returnString(Seasons.autumn));
                Console.WriteLine(returnString(Seasons.winter));
            }
        }

    }
}
    
