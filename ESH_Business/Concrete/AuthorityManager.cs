using ESH_DataAccess.Concrete;
using ESH_Entity.Data.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ESH_Business.Concrete
{
    public class AuthorityManager
    {
        Repository<Authority> repoAuthority = new Repository<Authority>();
        public List<Authority> GetAll()
        {
            return repoAuthority.List();
        }

        public int AuthorityAdd(Authority departman)
        {
            return repoAuthority.Insert(departman);
        }
        public int DeleteAuthority(int id)
        {
            Authority dep = repoAuthority.Find(x => x.Id == id);
            return repoAuthority.Delete(dep);
        }
        public Authority AuthorityFind(int id)
        {
            return repoAuthority.Find(x => x.Id == id);
        }
        //public int UpdateDepartmant(Authority dr)
        //{
        //    Authority departmanHospital = repoAuthority.Find(x => x.Id == dr.Id);
        //    departmanHospital.Name = dr.Name;
        //    departmanHospital.Status = dr.Status;
        //    departmanHospital.TotalPerson = dr.TotalPerson;
        //    return repoDepartman.Update(departmanHospital);
        //}
    }
}
