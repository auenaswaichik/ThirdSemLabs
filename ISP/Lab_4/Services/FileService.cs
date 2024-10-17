using System.Runtime.CompilerServices;
using System.Text;
using Lab_4.Entities.Passanger;   
using Lab_4.Contracts.FileService;


namespace Lab_4.Services.FileService;

public class FileService<T> : IFileService<T> where T : Passanger
{
    public IEnumerable<T> ReadFile(string path)
    {

        int id;
        string name;
        string surname;
        int placeinbus;

        using var fs = File.Open(path, FileMode.Open);
        using var reader = new BinaryReader(fs, Encoding.UTF8, false);

        while(reader.BaseStream.Position != reader.BaseStream.Length) {

            id = reader.ReadInt32();
            name = reader.ReadString();
            surname = reader.ReadString();
            placeinbus = reader.ReadInt32();    

            yield return (T)new Passanger(id, name, surname, placeinbus);

        }

            
    }

    public void SaveData(IEnumerable<T> data, string path)
    {

        if(File.Exists(path))
            File.Delete(path);  

        using var fs = new FileStream(path, FileMode.Create);
        using var writer = new BinaryWriter(fs, Encoding.UTF8, false);

        foreach(Passanger passanger in data) {

            writer.Write(passanger.Id);
            writer.Write(passanger.Name);
            writer.Write(passanger.Surname);
            writer.Write(passanger.PlaceInBus);

        }

    }
}