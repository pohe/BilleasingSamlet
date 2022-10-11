using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BilleasingSamlet
{
    public class Engine
    {
        private string _type;
        private string _size;
        private int _weight;
        private int _cylinders;

        public string Type
        {
            get { return _type; }
        }

        public string Size
        {
            get { return _size; }
        }

        public int Weight
        {
            get { return _weight; }
        }

        public int Cylinders
        {
            get { return _cylinders; }
        }

        public Engine(string type, string size, int weight, int cylinders)
        {
            _type = type;
            _size = size;
            _weight = weight;
            _cylinders = cylinders;
        }

        public override string ToString()
        {
            return $"Type {_type}, Size {_size}, Weight {_weight}, Cylinders {_cylinders}";
        }

    }

}
