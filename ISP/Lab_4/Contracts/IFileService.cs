using Lab_4.Entities.Passanger;

namespace Lab_4.Contracts.FileService;

public interface IFileService<Passanger>{

    IEnumerable<Passanger> ReadFile(string path);
    void SaveData(IEnumerable<Passanger> data, string path);

}