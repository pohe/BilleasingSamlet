using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BilleasingSamlet
{
    public class Car
    {

        // Instance variabler
        private string _brand;
        private string _regno;
        private string _colour;
        private int _year;
        private double _mileage;
        private int _seats;
        private int _weight;
        private int _doors;
        //Properties

        public string Brand
        {
            get
            {
                return _brand;
            }
            set
            {
                _brand = value;
            }
        }

        public string Regno
        {
            get
            {
                return _regno;
            }
            set
            {
                _regno = value;
            }
        }
        public string Colour
        {
            get
            {
                return _colour;
            }
            set
            {
                _colour = value;
            }
        }
        public int Year
        {
            get
            {
                return _year;
            }
            set
            {
                _year = value;
            }
        }
        public double Mileage
        {
            get
            {
                return _mileage;
            }
            set
            {
                _mileage = value;
            }
        }
        public int Seats
        {
            get
            {
                return _seats;
            }
            set
            {
                _seats = value;
            }
        }
        public int Weight
        {
            get
            {
                return _weight;
            }
            set
            {
                _weight = value;
            }
        }
        public int Doors
        {
            get
            {
                return _doors;
            }
            set
            {
                _doors = value;
            }
        }


        public Car(string brand, string colour, int year, string regno, double mileage, int seats, int doors, int weight)
        {

            _brand = brand;
            _regno = regno;
            _colour = colour;
            _year = year;
            _mileage = mileage;
            _seats = seats;
            _weight = weight;
            _doors = doors;
        }

        public void PrintAllInfo()
        {
            Console.WriteLine($" Car is made from {_brand} it's {_colour}. Was made in the year {_year}. The car has the registration number{_regno}. it has Driven {_mileage}, it has {_seats} Seats, it has {_doors} doors, and it weighs {_weight}");
        }

        public override string ToString()
        {
            return $" Car is made from {_brand} it's {_colour}. Was made in the year {_year}. The car has the registration number{_regno}. it has Driven {_mileage}, it has {_seats} Seats, it has {_doors} doors, and it weighs {_weight}";
        }

    }
}



