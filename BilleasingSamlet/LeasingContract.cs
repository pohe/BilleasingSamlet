using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BilleasingSamlet
{
    public class LeasingContract
    {

        private static int _leasingCounter = 0;
        private int _contractID;

        const int tax = 25;

        private Car _car;

        public Car Car
        {
            get { return _car; }
            set { _car = value; }
        }

        private Customer _customer;

        public Customer Customer
        {
            get { return _customer; }
            set { _customer = value; }
        }


        public int ContractID
        {
            get { return _contractID; }
            private set { _contractID = value; }
        }

        public DateTime StartDate { get; private set; }
        public DateTime EndDate { get; private set; }
        public int KmStart { get; private set; }
        public int KmToDrive { get; set; }

        public LeasingContract(int kmStart, int kmToDrive, Car aCar, Customer customer)
        {
            _leasingCounter++;
            _contractID = _leasingCounter;
            StartDate = DateTime.Now;
            EndDate = StartDate.AddYears(1);
            KmStart = kmStart;
            KmToDrive = kmToDrive;
            _car = aCar;
            _customer = customer;

        }




        public override string ToString()
        {
            return $"ContractID {_contractID} start {StartDate.ToString("MM/dd/yyyy")}  end {EndDate.ToString("MM/dd/yyyy")} km start {KmStart}  km to drive {KmToDrive} Car regn0 {_car.Regno}  Customer name {_customer.Name} Customer ID {_customer.CID}";
        }

    }
}
