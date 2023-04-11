using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ESH_Entity.Data.Entity
{
    public class EmployeeDoctor
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime AstStartDate { get; set; }
        public bool Status { get; set; }
        public ICollection<GuardList> guardLists { get; set; }
        public ICollection<Authority> authorities { get; set; }
    }
}
