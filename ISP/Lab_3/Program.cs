using Lab_3.Entities;

JES jes = new JES();

jes.AddTenat(new Tenat("Ilia", "Peshkur", 123));
jes.AddTenat(new Tenat("I", "eshkur", 1));
jes.AddTenat(new Tenat("I", "Peur", 246));
jes.AddTenat(new Tenat("ia", "Peshkur", 10));
jes.AddTenat(new Tenat("Ili", "Peshkur", 100        ));

jes.AddTenatServices(new Services(new Tarif("Uslugi", 3), 4));
jes.AddTenatServices(new Services(new Tarif("Mem", 2), 1));
jes.AddTenatServices(new Services(new Tarif("Kopat", 55), 2));
jes.AddTenatServices(new Services(new Tarif("Dengi",1003), 1));

jes.AddServiceToTenat(0,"Mem");
jes.AddServiceToTenat(0,"Dengi");

Console.WriteLine(jes.GetTotalCost());
Console.WriteLine(jes.GetMaxMonye());
Console.WriteLine(jes.GetAmmountOfTenats(101));
