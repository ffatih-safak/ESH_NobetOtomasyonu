using ESH_DataAccess.Concrete;
using ESH_Entity.Data.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ESH_Business.Concrete
{
    public class DoctorManager
    {
        Repository<EmployeeDoctor> repoEmplyeeDoctor = new Repository<EmployeeDoctor>();

        public List<EmployeeDoctor> GetAll()
        {
            return repoEmplyeeDoctor.List();
        }

        public int DoctorAdd(EmployeeDoctor employeeDoctor)
        {
            return repoEmplyeeDoctor.Insert(employeeDoctor);
        }
        public int DeleteDoctor(int id)
        {
            EmployeeDoctor dr = repoEmplyeeDoctor.Find(x => x.Id == id);
            return repoEmplyeeDoctor.Delete(dr);
        }
        public EmployeeDoctor DoctorFind(int id)
        {           
            return repoEmplyeeDoctor.Find(x => x.Id == id);
        }
        public int UpdateDoctor(EmployeeDoctor dr)
        {
            EmployeeDoctor doktor = repoEmplyeeDoctor.Find(x => x.Id == dr.Id);
            doktor.Name = dr.Name;
            doktor.Status = dr.Status;
            doktor.AstStartDate = dr.AstStartDate;
            return repoEmplyeeDoctor.Update(doktor);
        }

    }
}
