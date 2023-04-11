using ESH_DataAccess.Concrete;
using ESH_Entity.Data.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ESH_Business.Concrete
{
    public class GuardManager
    {
        Repository<GuardList> repoNobet = new Repository<GuardList>();
        public List<GuardList> GetAll()
        {
            return repoNobet.List();
        }

        public int GuardAdd(GuardList guardList)
        {
            return repoNobet.Insert(guardList);
        }
    }
}
