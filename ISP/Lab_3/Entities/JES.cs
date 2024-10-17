using Generic.Math;
using Lab_3.Contracts;

namespace Lab_3.Entities;

public class JES : IJES {

    public List<Tenat> Tenats = new List<Tenat>();
    private Dictionary<string, Services> TenatsServecis = new Dictionary<string, Services>();
    private Journal journal = new Journal();
    public event Action<List<Tenat>> ChangeTenatCollection;  
    public event Action<Dictionary<string, Services>> ChangeTenatsServisecCollection; 

    public void AddTenat(Tenat tenat) {Tenats.Add(tenat); ChangeTenatCollection = journal.TenatsAdd; ChangeTenatCollection(Tenats);}

    public int FindBySurnamee(string surname) {

        return Tenats.Where(x => x.TenatSurname.Equals(surname))
            .Sum(x => x.GetTotalServicesCost());

    }

    public int GetTotalCost() {

        return Tenats.Sum(tenat => tenat.GetTotalServicesCost());

    }

    public int GetTotalServicesCostByTarif(string tarifName) {

        return Tenats.Sum(x => x.GetServiceAmmount(tarifName));

    }
    public void AddTenatServices(Services services) {TenatsServecis.Add(services.ServiceTarif.Name, services); ChangeTenatsServisecCollection = journal.ServicesAdd; ChangeTenatsServisecCollection(TenatsServecis);}
    public void AddServiceToTenat(int tenatIndex, string serviceIndex) {

        Tenats[tenatIndex].AddService(TenatsServecis[serviceIndex]);

    }
    public void GetEvents() {

        journal.InputEvents();

    }

    public IEnumerable<string> GetServices() {

        return TenatsServecis.OrderBy(x => x.Value.TotalServiceCost())
            .Select(x => x.Value.ServiceTarif.Name); 

    }

    public string GetOneTenatMaxName() {

        string? result = GetTenatsName().FirstOrDefault();

        if(result is null) throw new NullReferenceException();

        return result;

    }

    public IEnumerable<string> GetTenatsName() {

        var result = Tenats.Where(x => x.TenatsMonye == GetMaxMonye())
            .Select(x => x.TenatName);
            return result;

    }

    public int GetMaxMonye() {

        return Tenats.Max(x => x.TenatsMonye);

    }

    public int GetAmmountOfTenats(int fixedAmmountOfMonye) {

        return Tenats.Where(x => x.TenatsMonye > fixedAmmountOfMonye)
            .Count();

    }

    public IEnumerable<int> GetTenatsGroupSums(int tenatIndex) {

        return Tenats[tenatIndex].GetTenatsServices()
            .Select(x => x.TotalServiceCost());

    }

}