using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BilleasingSamlet
{
    public class Seat
    {
        private string _brand;
        private string _material;
        private string _model;
        private int _weight;
        private string _colour;


        public string Brand
        {
            get { return _brand; }
        }

        public string Material
        {
            get { return _material; }
        }
        public string Model
        {
            get { return _model; }
        }
        public int Weight
        {
            get { return _weight; }
        }
        public string Colour
        {
            get { return _colour; }
        }
        public Seat(string Brand, string Material, string Model, int Weight, string Colour)
        {
            _brand = Brand;
            _material = Material;
            _model = Model;
            _weight = Weight;
            _colour = Colour;

        }
        public override string ToString()
        {
            return $"Sædets brand er: {_brand}, materialet er: {_material}, modellen er: {_model}, vægten er: {_weight}, farven er: {_colour}";
        }





    }


}
