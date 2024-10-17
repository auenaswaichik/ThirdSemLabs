using Lab_1.Entities;

JES jes = new JES();

jes.AddTenat(new Tenat("Ilia", "Peshkur"));

jes.AddTenatServices(new Services(new Tarif("Uslugi", 3), 4));
jes.AddTenatServices(new Services(new Tarif("Mem", 2), 1));
jes.AddTenatServices(new Services(new Tarif("Kopat", 55), 2));
jes.AddTenatServices(new Services(new Tarif("Dengi",1003), 1));

jes.AddServiceToTenat(0,1);
jes.AddServiceToTenat(0,3);

//Console.WriteLine(jes.Tenats[0].TenatsServices.Count);
Console.WriteLine("Peshkurs servecis cost is " + jes.FindBySurnamee("Peshkur"));
Console.WriteLine("Total servecis cost " + jes.GetTotalCost());
Console.WriteLine("Ammout of Ilia`s services by name Uslugi is " + jes.GetTotalSevecesAmmount("Uslugi"));