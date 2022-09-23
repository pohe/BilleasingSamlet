using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BilleasingSamlet
{
    public class Wheel
    {
        private int _pressure = 3;
        private string _type;
        private int _size;
        private int _weight = 10;

        //properties
        public int Pressure
        {
            get { return _pressure; }
        }
        public string Type
        {
            get { return _type; }
            set { _type = value; }
        }
        public int Size
        {
            get { return _size; }
            set { _size = value; }
        }
        public int Weight
        {
            get { return _weight; }

        }

        //construcotr
        public Wheel(string type, int size)
        {
            //_pressure = pressure;
            _type = type;
            _size = size;
            //_weight = weight;
        }

        public override string ToString()
        {
            return $"pressure: {_pressure} bar " +
                              $"Type: {_type} tires " +
                              $"Size: {_size}" +
                              $"Weight: {_weight} kg ";
        }
    }


}
