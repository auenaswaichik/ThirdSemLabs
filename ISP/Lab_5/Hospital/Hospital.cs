using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;
using Hospital.Entities;

namespace Hospital; 
public class Hospital
{   
    
    public int? HospitalNumber{ get; set; }
    public string? HospitalName{ get; set; }
    public string? HospitalPosition{ get; set; }
    public List<AdmissionsDepartment> AdmissionsDepartments = new List<AdmissionsDepartment>();

    public Hospital() {HospitalNumber = 0; HospitalName = ""; HospitalPosition = "";}
    public Hospital(int hospitalNumber, string hospitalName, string hospitalPosition) {HospitalNumber = hospitalNumber; HospitalName = hospitalName; HospitalPosition = hospitalPosition;}
    public Hospital(int hospitalNumber, string hospitalName, string hospitalPosition, List<AdmissionsDepartment> admissionsDepartments) {HospitalNumber = hospitalNumber; HospitalName = hospitalName; HospitalPosition = hospitalPosition; AdmissionsDepartments = admissionsDepartments;}
    public void AddAdmissionsDepartment(AdmissionsDepartment admissionsDepartment) {AdmissionsDepartments.Add(admissionsDepartment);}
    public void GetHospitalInfo() {

        Console.WriteLine("Hospital's number is: " + HospitalNumber);
        Console.WriteLine("Hospital's name is: " + HospitalName);
        Console.WriteLine("Hospital's position is: " + HospitalPosition);

        Console.WriteLine("Hospital's administration departments is: ");
        foreach(var administrationDepartment in AdmissionsDepartments) {

            administrationDepartment.GetDepartmentInfo();   

        }

    }

}
