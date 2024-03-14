using System;
using System.Collections.Generic
using System.Collections;
using System.Linq;

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

    public class Task5
    {
        public static void Run()
        {
        }
    }
}
