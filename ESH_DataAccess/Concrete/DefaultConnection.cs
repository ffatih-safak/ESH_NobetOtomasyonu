using ESH_Entity.Data.Entity;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ESH_DataAccess.Concrete
{
    public class DefaultConnection : DbContext
    {
        public DbSet<EmployeeDoctor> EmployeeDoctors { get; set; }
        public DbSet<DepartmanHospital> DepartmanHospitals { get; set; }
        public DbSet<GuardList> GuardList { get; set; }
        public DbSet<Authority> Authority { get; set; }
    }
}
