// See https://aka.ms/new-console-template for more information
using BilleasingSamlet;

Console.WriteLine("Hello, World!");


Wheel tire1 = new Wheel("Winter", 16);
Wheel tire2 = new Wheel("Winter", 16);
Wheel tire3 = new Wheel("Winter", 16);
Wheel tire4 = new Wheel("Winter", 16);

Car c1 = new Car("Toyota", "Grey", 2020, "AB123123", 123, 5, 5, 2000, tire1, tire2, tire3, tire4);



//Engine e1 = new Engine("Type1", "Large", 888.8, 2);

c1.PrintAllInfo();

Wheel summmertire1 = new Wheel("Summer", 16);
Wheel summertire2 = new Wheel("Summer", 16);
Wheel summertire3 = new Wheel("Summer", 16);
Wheel summertire4 = new Wheel("Summer", 16);

c1.ChangeWheels(summmertire1, summertire2, summertire3, summertire4);

c1.PrintAllInfo();

//Console.WriteLine(e1.ToString());



Wheel tire = new Wheel("Winter", 16);
//Console.WriteLine(tire);



