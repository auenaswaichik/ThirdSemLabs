using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Hospital.Contracts;

namespace Hospital.Entities;

public class AdmissionsDepartment : IDepartment
{
    public int DepartmentNumber { get; set;}
    public List<string> DoctorsName { get ; set; }
    public List<string> PatientsName = new List<string>();
    public AdmissionsDepartment(){DepartmentNumber = 0; DoctorsName = new List<string>();}
    public AdmissionsDepartment(int departmentNumber) {DepartmentNumber = departmentNumber;DoctorsName = new List<string>();}
    public AdmissionsDepartment(int departmentNumber, List<string> doctorsName, List<string> patientsName) {DepartmentNumber = departmentNumber; DoctorsName = doctorsName; PatientsName = patientsName;}

    public void AddPatient(string patientName) {PatientsName.Add(patientName);}
    public string GetLastPatient() {return PatientsName.Last();}
    public string GetPatient(int patientNuber) {
        
        if(patientNuber > PatientsName.Count) throw new OutOfMemoryException();

        return PatientsName[patientNuber];
    
    }

    public void GetDepartmentInfo() {

        Console.WriteLine("Department's number is: " + DepartmentNumber);
        
        Console.WriteLine("Department's doctors names:" );
        foreach(var doctor in DoctorsName) {

            Console.WriteLine(doctor);

        }

        Console.WriteLine("Department's patients names:" );
        foreach(var patient in PatientsName) {

            Console.WriteLine(patient);

        }

    }

}
