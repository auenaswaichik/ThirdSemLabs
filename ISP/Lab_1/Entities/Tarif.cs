namespace Lab_1.Entities;

public class Tarif {

    public string Name{ get; set; }
    public int Cost{ get; set; }
    public Tarif(string name, int cost){Name = name; Cost = cost;}

}