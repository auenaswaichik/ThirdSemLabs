using Generic.Math;
using Lab_1.Collections;
using Lab_1.Contracts;

namespace Lab_1.Entities;

public class JES : IJES {

    public MyCustomeCollection<Tenat> Tenats = new MyCustomeCollection<Tenat>();
    private MyCustomeCollection<Services> TenatsServecis = new MyCustomeCollection<Services>();
    public void AddTenat(Tenat tenat) {Tenats.Add(tenat);}

    public int FindBySurnamee(string surname) {

        for(int i = 0 ; i < Tenats.Count ; ++i) {

            if(Tenats[i].TenatSurname.Equals(surname)) 
                return Tenats[i].GetTotalServicesCost();

        }

        return 0;

    }

    public int GetTotalCost() {

        int result = GenericMath.Add(0,0);

        for(int i = 0 ; i < Tenats.Count ; ++i) {

            result = GenericMath.Add(Tenats[i].GetTotalServicesCost(), result);

        }

        return result;

    }

    public int GetTotalSevecesAmmount(string name) {

        int result = GenericMath.Add(0,0);

        for(int i = 0 ; i < Tenats.Count ; ++i) {

            result =GenericMath.Add(Tenats[i].GetServiceAmmount(name), result);

        }

        return result;

    }
    public void AddTenatServices(Services services) {TenatsServecis.Add(services);}
    public void AddServiceToTenat(int tenatIndex, int serviceIndex) {

        Tenats[tenatIndex].AddService(TenatsServecis[serviceIndex]);

    }

}