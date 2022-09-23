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

        private Engine _engine; //reference til engine implementation af Composition

        private Wheel _tire1;
        private Wheel _tire2;
        private Wheel _tire3;
        private Wheel _tire4;

        private Seat _seat1;
        private Seat _seat2;
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


        public Car(string brand, string colour, int year, string regno, double mileage, int seats, int doors, int weight, Wheel t1, Wheel t2, Wheel t3, Wheel t4)
        {

            _brand = brand;
            _regno = regno;
            _colour = colour;
            _year = year;
            _mileage = mileage;
            _seats = seats;
            _weight = weight;
            _doors = doors;
            _engine = new Engine("Diesel", "2 liter", 1.2, 8);
            _tire1 = t1;
            _tire2 = t2;
            _tire3 = t3;
            _tire4 = t4;

            _seat1 = new Seat("SuperBrand", "Leather", "Comfort", 0.02, "Black");
            _seat2 = new Seat("SuperBrand", "Leather", "Comfort", 0.02, "Black");

        }

        public void ChangeWheels(Wheel t1, Wheel t2, Wheel t3, Wheel t4)
        {
            _tire1 = t1;
            _tire2 = t2;
            _tire3 = t3;
            _tire4 = t4;
        }

        public void PrintAllInfo()
        {
            Console.WriteLine($"Car is made from {_brand} it's {_colour}. Was made in the year {_year}. The car has the registration number{_regno}. it has Driven {_mileage}, it has {_seats} Seats, it has {_doors} doors, and it weighs {_weight}  \n\tEngine info {_engine.ToString() } \n\tSeat info { _seat1.ToString() }  \n\tWheel info { _tire1.ToString()}");
        }

        public override string ToString()
        {
            return $" Car is made from {_brand} it's {_colour}. Was made in the year {_year}. The car has the registration number{_regno}. it has Driven {_mileage}, it has {_seats} Seats, it has {_doors} doors, and it weighs {_weight}";
        }

    }
}



