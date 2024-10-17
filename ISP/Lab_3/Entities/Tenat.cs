using Generic.Math;

namespace Lab_3.Entities;

public class Tenat {

    private List<Services> TenatsServices = new List<Services>();

    public int TenatsMonye;

    public string TenatName{get;set;}
    public string TenatSurname{get;set;}

    public Tenat(string name, string surname){TenatName = name; TenatSurname = surname; TenatsMonye = 0;}
    public Tenat(string name, string surname, int money){TenatName = name; TenatSurname = surname; TenatsMonye = money  ;}

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

    public int GetServiceAmmount(string tarifName) {

        return TenatsServices.Where(x => x.ServiceTarif.Name.Equals(tarifName))
            .Sum(x => x.TotalServiceCost());

    }

    public IEnumerable<Services> GetTenatsServices() {

        return TenatsServices;

    }

}