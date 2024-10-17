namespace Lab_2.Entities;

public class Services {

    public Tarif ServiceTarif;
    public int ServicesAmount{get; set;}
    public Services(Tarif tarif){ServiceTarif = tarif;}
    public Services(Tarif tarif, int ammount){ServiceTarif = tarif; ServicesAmount = ammount;}

    public void ChangeServiceAmmount(int ammount){ServicesAmount = ammount;}
    public int TotalServiceCost() => ServicesAmount * ServiceTarif.Cost;

}