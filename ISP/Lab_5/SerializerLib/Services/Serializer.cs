using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Hospital.Domain.Contracts;
using Hospital.Entities;
using Hospital;
using System.Xml.Linq;
using System.Xml.Serialization;
using System.Text.Json;
using Microsoft.VisualBasic;

namespace SerializerLib.Services;
public class Serializer : ISerializer
{
    public IEnumerable<Hospital.Hospital> DeSerializeByLINQ(string fileName)
    {
        var pathToFile = FilePathService.GetPath(fileName);

        var xdoc = XDocument.Load(pathToFile);

        return xdoc.Descendants("Hospital")
        .Select(x => new Hospital.Hospital
        {

            HospitalNumber = Int32.Parse(x.Attribute("Id")?.Value),
            HospitalName = x.Attribute("Name")?.Value,
            HospitalPosition = x.Attribute("Position")?.Value,
            AdmissionsDepartments = x.Element("Departments")?.Elements("Department")
            .Select(y => new AdmissionsDepartment
            {

                DepartmentNumber = Int32.Parse(y.Attribute("Number")?.Value),
                DoctorsName = (List<string>)y.Element("DoctorsNames")?.Elements("Name").Select(z => z.Value),
                PatientsName = (List<string>)y.Element("PatientsNames")?.Elements("Name").Select(z => z.Value)

            }).ToList()
    
        }).ToList();                
        
    }   

    public IEnumerable<Hospital.Hospital> DeSerializeJSON(string fileName)
    {

        using var fileStream = new FileStream(fileName, FileMode.Open, FileAccess.Read);
        while(fileStream.Position != fileStream.Length) {

            yield return JsonSerializer.Deserialize<Hospital.Hospital>(fileStream);

        }

    }

    public IEnumerable<Hospital.Hospital> DeSerializeXML(string fileName)
    {
        var xmlSerializer = new XmlSerializer(typeof(List<Hospital.Hospital>));

        using var fileStream = new FileStream(fileName, FileMode.Open);
        var hospitals = xmlSerializer.Deserialize(fileStream) as IEnumerable<Hospital.Hospital>;

        return hospitals;   
    }

    public void SerializeByLINQ(IEnumerable<Hospital.Hospital> hospitals, string fileName)
    {
        throw new NotImplementedException();
    }

    public void SerializeJSON(IEnumerable<Hospital.Hospital> hospitals, string fileName)
    {
        using var fileStream = new FileStream(fileName, FileMode.Open, FileAccess.Write );

        foreach(var hospital in hospitals) {

            JsonSerializer.Serialize<Hospital.Hospital>(fileStream, hospital);

        }

    }

    public void SerializeXML(IEnumerable<Hospital.Hospital> hospitals, string fileName)
    {
        throw new NotImplementedException();
    }
}
