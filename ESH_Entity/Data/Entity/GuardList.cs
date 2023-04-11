using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ESH_Entity.Data.Entity
{
    public class GuardList
    {
        public int Id { get; set; } 
        public string Month { get; set; } 
        public int DepartmanHospitalId { get; set; }
        public virtual DepartmanHospital DepartmanHospital { get; set; }

        public int EmployeeDoctorId { get; set; }
        public virtual EmployeeDoctor EmployeeDoctor { get; set; }
    }
}
