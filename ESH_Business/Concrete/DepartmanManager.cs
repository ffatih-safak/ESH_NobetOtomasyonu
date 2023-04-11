using ESH_DataAccess.Concrete;
using ESH_Entity.Data.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ESH_Business.Concrete
{
    public class DepartmanManager
    {
        Repository<DepartmanHospital> repoDepartman = new Repository<DepartmanHospital>();
        public List<DepartmanHospital> GetAll()
        {
            return repoDepartman.List();
        }

        public int DepartmanAdd(DepartmanHospital departman)
        {
            return repoDepartman.Insert(departman);
        }
        public int DeleteDepartman(int id)
        {
            DepartmanHospital dep = repoDepartman.Find(x => x.Id == id);
            return repoDepartman.Delete(dep);
        }
        public DepartmanHospital DepartmanFind(int id)
        {
            return repoDepartman.Find(x => x.Id == id);
        }
        public int UpdateDepartmant(DepartmanHospital dr)
        {
            DepartmanHospital departmanHospital = repoDepartman.Find(x => x.Id == dr.Id);
            departmanHospital.Name = dr.Name;
            departmanHospital.Status = dr.Status;
            departmanHospital.TotalPerson = dr.TotalPerson;
            return repoDepartman.Update(departmanHospital);
        }
    }
}
