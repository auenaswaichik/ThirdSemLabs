using Generic.Math;
using Lab_2.Collections;

namespace Lab_2.Entities;

public class Tenat {

    private MyCustomeCollection<Services> TenatsServices = new MyCustomeCollection<Services>();

    public string TenatName{get;set;}
    public string TenatSurname{get;set;}

    public Tenat(string name, string surname){TenatName = name; TenatSurname = surname;}

    public void AddService(Services service) {

        TenatsServices.Add(service);

    }

    public int GetTotalServicesCost() {

        int result = GenericMath.Add(0,0);

        for(int i = 0 ; i < TenatsServices.Count; ++i) {

            result =GenericMath.Add(TenatsServices[i].TotalServiceCost(), result);

        }

        return result;

    }

    public int GetServiceAmmount(string ServiceName) {

        int result = 0;

        for(int i = 0 ; i < TenatsServices.Count ; ++i) {

            if(TenatsServices[i].ServiceTarif.Name == ServiceName)
                result += TenatsServices[i].ServicesAmount;

        }

        return result;

    }

}