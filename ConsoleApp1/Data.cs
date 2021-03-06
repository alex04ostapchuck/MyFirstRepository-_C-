﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public static class Data
    {
        static Random rnd;
        public static string NameMale()
        {
            string[] Name = {"Абрам","Аваз","Аввакум","Август",
            "Августин","Авдей","Авраам","Автандил","Агап","Агафон","Аггей","Адам",
            "Адис","Адольф","Адриан","Азамат","Айдар",};
            int nIndex = rnd.Next(0, Name.Length);
            string NameMale = Name[nIndex];
            return NameMale;
        }
        public static string NameFemale() {
            string[] Name = {
                "Августа","Аврора","Агата","Беатриса","Белла","Бенедикта","Валентина",
                "Валерия","Ванда","Габриэлла","Галина","Гаянэ","Джулия","Джульетта",
                "Диана","Дилара"
            };
            int nIndex = rnd.Next(0, Name.Length);
            string NameFemale = Name[nIndex];
            return NameFemale;
        }
        public static int Rand(int i, int j)
        {
            int a = rnd.Next(i, j);
            return a;
        }
        public static string RandAdressRestoraunt()
        {
            string[] Name = { "Москва, Кутузовский пр., д. 48", "Москва, Тамбовская ул., д. 4",
                "Москва, Смоленская пл., д. 3",
                "Москва, Моховая ул., д. 15/1", "Москва, Кутузовский пр., д. 12",
                "Москва, ул. Демьяна Бедного, д. 4","Москва, Пресненская наб., д. 12",
                "Москва, Космодамианская наб., д. 2","Москва, Якиманская наб., д. 4",
                "Москва, ул. Пречистенка, д. 4","Москва, Гагаринский переулок, д. 15а",
                "Москва, Берсеневская наб., д. 16, с. 9",
                "Москва, Цветной бульвар, 2","Москва, Ленинский пр., д. 69",
                "Москва, ул. Кузнецкий Мост, д. 7",
                "Чеховская","Москва, 1-й Монетчиковский пер., д. 5",
                "Москва, ул. Кузнецкий Мост, д. 18/7",
                "Москва, 8-й км Рублево-Успенского","Москва, ул. Сретенка, 1" };

            int nIndex = rnd.Next(0, Name.Length);
            string NameEnd = Name[nIndex];
            return NameEnd;
        }
        public static string RandNameRestoraunt()
        {
            string[] Name = { "Облака", "Nabat Palace / Набат Пэлас", "White Rabbit / Белый кролик",
                "Beluga / Белуга", "Nofar","Азербайджан","Sixty / Сиксти",
                "Community / Комьюнити","The Waiters","Воронеж","Эларджи","Pescatore / Пескаторе",
                "The Mad Cook","Корчма Тарас Бульба","La Marée / Ла Маре",
                "Mr. Lee / Мистер Ли","Обломов","MoreGrill / МореГриль",
                "Китайская Грамота (Барвиха)","Китайская грамота. Бар и Еда" };

            int nIndex = rnd.Next(0, Name.Length);
            string NameEnd = Name[nIndex];
            return NameEnd;
        }

        public static void ListOfResoraunt()
        {

            int NumberOfRestoraunt;
            do
            {
                NumberOfRestoraunt = int.Parse(Console.ReadLine());
            } while (NumberOfRestoraunt > 21);
            List<Restoraunt> Restoraunts = new List<Restoraunt>();
            for (int i = 0; i < NumberOfRestoraunt; i++)
            {
                Restoraunts.Add(new Restoraunt { Name = RandNameRestoraunt(), Adress = RandAdressRestoraunt() });
            }
        }
    }
}
