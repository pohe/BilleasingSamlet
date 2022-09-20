using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BilleasingSamlet
{
    public class Seat
    {
        private string _Brand;
        private string _Material;
        private string _Model;
        private double _Weight;
        private string _Colour;


        public string Brand
        {
            get { return Brand; }
        }

        public string Material
        {
            get { return Material; }
        }
        public string Model
        {
            get { return Model; }
        }
        public double Weight
        {
            get { return Weight; }
        }
        public string Colour
        {
            get { return Colour; }
        }
        public Seat(string Brand, string Material, string Model, double Weight, string Colour)
        {
            _Brand = Brand;
            _Material = Material;
            _Model = Model;
            _Weight = Weight;
            _Colour = Colour;

        }
        public override string ToString()
        {
            return $"Sædets brand er: {_Brand}, materialet er: {_Material}, modellen er: {_Model}, vægten er: {_Weight}, farven er: {_Colour}";
        }





    }


}
