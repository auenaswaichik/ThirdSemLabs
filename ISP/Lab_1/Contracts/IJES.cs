using Lab_1.Entities;

namespace Lab_1.Contracts;

public interface IJES {

    public void AddTenat(Tenat tenat);

    public int FindBySurnamee(string surname);

    public int GetTotalCost();

    public int GetTotalSevecesAmmount(string name);

}