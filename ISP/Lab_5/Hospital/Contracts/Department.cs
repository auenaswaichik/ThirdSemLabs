using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Hospital.Contracts;
public interface IDepartment
{
    
    public int DepartmentNumber{ get; set; }
    protected List<string> DoctorsName{ get; set; }
    public void GetDepartmentInfo(); 

}
