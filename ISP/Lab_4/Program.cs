
using Lab_4.Entities.Passanger;
using Lab_4.Services;
using Lab_4.Services.FileService;
using Lab_4.Services.MyCustomeCompaer;

var random = new Random();
var directoryInfo = new DirectoryInfo("./Peshkur_Lab_4");
var fileManagerSerice = new FileManagerSerice();

fileManagerSerice.AddExtension(".txt");
fileManagerSerice.AddExtension(".rtf");
fileManagerSerice.AddExtension(".dat");
fileManagerSerice.AddExtension(".inf");

if(directoryInfo.Exists) {

    foreach (var file in directoryInfo.GetFiles()) {
    
        file.Delete(); 
    
    }
    
    foreach (var dir in directoryInfo.GetDirectories()) {

        dir.Delete(true); 
    
    }

}
else
    directoryInfo.Create();    

var passangers = new List<Passanger>();

for(int i = 0 ; i < 6 ; ++i) {

    passangers.Add(new Passanger(i, $"Name_{i}", $"Surname{i}", i + i * i + 1));

}

var fileService = new FileService<Passanger>();
List<Passanger> passangersFromFile;

for(int i = 0 ; i < 10 ; ++i) {

    fileManagerSerice.CreateFile(directoryInfo.Name, $"File_{i}", random.Next(0, 3));
    fileService.SaveData(passangers, fileManagerSerice.GetLastPath());

}

passangersFromFile = fileService.ReadFile(fileManagerSerice.GetPath(0       )).ToList();

passangersFromFile.OrderBy(x => x, new MyCustomeCompare());

foreach(var passanger in passangersFromFile) {

    passanger.PrintPassangerInfo();

} 

passangersFromFile.OrderBy(x => x.PlaceInBus);

foreach(var passanger in passangersFromFile) {

    passanger.PrintPassangerInfo();

}