using Lab_3.Entities;

namespace Lab_3.Contracts;

public interface IJES {

    public void AddTenat(Tenat tenat);

    public int FindBySurnamee(string surname);

    public int GetTotalCost();

    public int GetTotalServicesCostByTarif(string tarifName);

}