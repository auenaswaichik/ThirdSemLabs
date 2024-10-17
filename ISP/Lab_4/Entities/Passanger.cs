namespace Lab_4.Entities.Passanger;

public class Passanger {

    public int Id { get; set;}
    public string Name { get; set;}
    public string Surname{ get; set;}
    public int PlaceInBus{ get; set;}
    public Passanger(){Id = 0; Name = ""; Surname = ""; PlaceInBus = 0;} 
    public Passanger(int id, string name, string surname, int placeinbus) { Id = id; Name = name; Surname = surname; PlaceInBus = placeinbus;}

    public void PrintPassangerInfo() {

        Console.WriteLine("Passanger's id:" + Id);
        Console.WriteLine("Passanger's name:" + Name);
        Console.WriteLine("Passanger's surname:" + Surname);
        Console.WriteLine("Passanger's place in bus:" + PlaceInBus);

    }

}