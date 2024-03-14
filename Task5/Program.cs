﻿using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Linq.Expressions;
using System.Runtime.CompilerServices;

namespace Task5
{
    public class Country
    {
        private int _ID;
        private string _Title;

        public int ID
        {
            get { return _ID; }
            set { _ID = value; }
        }

        public string Title
        {
            get { return _Title; }
            set { _Title = value; }
        }
    }

    public class City
    {
        private int _ID;
        private int _CountryID;
        private string _Title;

        public int ID
        {
            get { return _ID; }
            set { _ID = value; }
        }

        public int CountryID
        {
            get { return _CountryID; }
            set { _CountryID = value; }
        }

        public string Title
        {
            get { return _Title; }
            set { _Title = value; }
        }
    }

    public class Street
    {
        private int _ID;
        private int _CityID;
        private string _Title;

        public int ID
        {
            get { return _ID; }
            set { _ID = value; }
        }

        public int CityID
        {
            get { return _CityID; }
            set { _CityID = value; }
        }

        public string Title
        {
            get { return _Title; }
            set { _Title = value; }
        }
    }

    public class HomeAddress
    {
        private int _ID;
        private int _StreetID;
        private string _HomeNumber;
        private int _Apartment;

        public int ID
        {
            get { return _ID; }
            set { _ID = value; }
        }

        public int StreetID
        {
            get { return _StreetID; }
            set { _StreetID = value; }
        }

        public string HomeNumber
        {
            get { return _HomeNumber; }
            set { _HomeNumber = value; }
        }

        public int Apartment
        {
            get { return _Apartment; }
            set { _Apartment = value; }
        }
    }

    public class People
    {
        private int _ID;
        private string _FirstName;
        private string _LastName;
        private DateTime _Birthday;
        private int _RegistrationID;
        private int? _LiveID;

        public int ID
        {
            get { return _ID; }
            set { _ID = value; }
        }

        public string FirstName
        {
            get { return _FirstName; }
            set { _FirstName = value; }
        }

        public string LastName
        {
            get { return _LastName; }
            set { _LastName = value; }
        }

        public DateTime Birthday
        {
            get { return _Birthday; }
            set { _Birthday = value; }
        }

        public int RegistrationID
        {
            get { return _RegistrationID; }
            set { _RegistrationID = value; }
        }

        public int? LiveID
        {
            get { return _LiveID; }
            set { _LiveID = value; }
        }
    }

    public static class Task5
    {
        public static void Run()
        {
            List<Country> countries = new List<Country>();
            List<City> cities = new List<City>();
            List<Street> streets = new List<Street>();
            List<HomeAddress> homes = new List<HomeAddress>();
            List<People> peoples = new List<People>();

            // Заполнение списка стран
            countries.Add(new Country { ID = 1, Title = "Россия" });
            countries.Add(new Country { ID = 2, Title = "США" });
            countries.Add(new Country { ID = 3, Title = "Германия" });
            countries.Add(new Country { ID = 4, Title = "Франция" });
            countries.Add(new Country { ID = 5, Title = "Италия" });

            // Заполнение списка городов
            cities.Add(new City { ID = 1, CountryID = 1, Title = "Москва" });
            cities.Add(new City { ID = 2, CountryID = 1, Title = "Санкт-Петербург" });
            cities.Add(new City { ID = 3, CountryID = 2, Title = "Нью-Йорк" });
            cities.Add(new City { ID = 4, CountryID = 2, Title = "Лос-Анджелес" });
            cities.Add(new City { ID = 5, CountryID = 3, Title = "Берлин" });
            cities.Add(new City { ID = 6, CountryID = 4, Title = "Париж" });
            cities.Add(new City { ID = 7, CountryID = 4, Title = "Марсель" });
            cities.Add(new City { ID = 8, CountryID = 5, Title = "Рим" });
            cities.Add(new City { ID = 9, CountryID = 5, Title = "Милан" });

            // Заполнение списка улиц
            streets.Add(new Street { ID = 1, CityID = 1, Title = "Тверская" });
            streets.Add(new Street { ID = 2, CityID = 1, Title = "Арбат" });
            streets.Add(new Street { ID = 3, CityID = 2, Title = "Невский проспект" });
            streets.Add(new Street { ID = 4, CityID = 2, Title = "Малая Конюшенная" });
            streets.Add(new Street { ID = 5, CityID = 3, Title = "Пятая авеню" });
            streets.Add(new Street { ID = 6, CityID = 6, Title = "Шанз-Элизе" });
            streets.Add(new Street { ID = 7, CityID = 6, Title = "Лувр" });
            streets.Add(new Street { ID = 8, CityID = 7, Title = "Канебье" });
            streets.Add(new Street { ID = 9, CityID = 8, Title = "Виа деи Фори Империали" });
            streets.Add(new Street { ID = 10, CityID = 9, Title = "Корсо Буэнос-Айрес" });

            // Заполнение списка домов
            homes.Add(new HomeAddress { ID = 1, StreetID = 1, HomeNumber = "10", Apartment = 5 });
            homes.Add(new HomeAddress { ID = 2, StreetID = 1, HomeNumber = "15", Apartment = 3 });
            homes.Add(new HomeAddress { ID = 3, StreetID = 2, HomeNumber = "20", Apartment = 8 });
            homes.Add(new HomeAddress { ID = 4, StreetID = 3, HomeNumber = "30", Apartment = 12 });
            homes.Add(new HomeAddress { ID = 5, StreetID = 4, HomeNumber = "40", Apartment = 20 });
            homes.Add(new HomeAddress { ID = 6, StreetID = 5, HomeNumber = "50", Apartment = 15 });
            homes.Add(new HomeAddress { ID = 7, StreetID = 6, HomeNumber = "60", Apartment = 10 });
            homes.Add(new HomeAddress { ID = 8, StreetID = 7, HomeNumber = "70", Apartment = 5 });
            homes.Add(new HomeAddress { ID = 9, StreetID = 8, HomeNumber = "80", Apartment = 12 });

            // Заполнение списка людей
            peoples.Add(new People { ID = 1, FirstName = "Иван", LastName = "Иванов", RegistrationID = 1, Birthday = new DateTime(2000, 1, 2) });
            peoples.Add(new People { ID = 2, FirstName = "Петр", LastName = "Петров", RegistrationID = 2, Birthday = new DateTime(2000, 1, 2) });
            peoples.Add(new People { ID = 3, FirstName = "Алексей", LastName = "Алексеев", RegistrationID = 3, Birthday = new DateTime(2000, 1, 2) });
            peoples.Add(new People { ID = 4, FirstName = "Иван", LastName = "Иванов", RegistrationID = 1, Birthday = new DateTime(2020, 1, 2) });
            peoples.Add(new People { ID = 5, FirstName = "Петр", LastName = "Петров", RegistrationID = 2, Birthday = new DateTime(2000, 1, 2) });
            peoples.Add(new People { ID = 6, FirstName = "Алексей", LastName = "Алексеев", RegistrationID = 3, Birthday = new DateTime(2000, 1, 2) });

        }
    }
}
