using ESH_Business.Concrete;
using ESH_Entity.Data.Entity;
using ESH_Nobet.ListModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ESH_Nobet.Controllers
{
    public class GrardController : Controller
    {
        DepartmanManager departmanManager = new DepartmanManager();
        DoctorManager doctorManager = new DoctorManager();
        GuardManager guardManager = new GuardManager();
        AuthorityManager authorityManager = new AuthorityManager();
        public ActionResult Index()
        {
            List<DepartmanHospital> departmanHospitals = new List<DepartmanHospital>();
            departmanHospitals = departmanManager.GetAll();
            List<EmployeeDoctor> employeeDoctors = new List<EmployeeDoctor>(); 
            employeeDoctors = doctorManager.GetAll();
            List<Authority> authorities = new List<Authority>();
            authorities = authorityManager.GetAll();
            List<Tuple<int, int>> guardList = new List<Tuple<int, int>>();                  
            var month = DateTime.Now.ToString("MM");
            
            var random = new Random();
            while (true)
            {
                guardList = new List<Tuple<int, int>>();
                foreach (var item in employeeDoctors)
                {
                    int index = random.Next(departmanHospitals.Count);
                    var atananNobet = departmanHospitals[index];
                    string doktor = item.Name;
                    bool tekrarla = false;
                    for (int i = 0; i < authorities.Count; i++)
                    {
                        if(authorities[i].EmployeeDoctorId == item.Id && authorities[i].DepartmanHospitalId == atananNobet.Id)
                        {
                            tekrarla = true;
                        }
                    } 
                    if(tekrarla == false)
                    {
                        guardList.Add(new Tuple<int, int>(atananNobet.Id, item.Id));
                    }
                    
                }            
                var result = guardList.GroupBy(x => x.Item1)
                    .Select(group => new { Id = group.Key, Values = group.Select(x => new { x.Item2 }).ToList() })
                    .OrderBy(x => x.Id).ToList();
                int sayac = 0;
                for (int i = 0; i < result.Count; i++)
                {
                    var sayi = departmanHospitals[i].TotalPerson;
                    if (result[i].Values.Count == sayi)
                    { 
                        if(result[i].Values.Count !=0)
                        {
                            if(result.Count == departmanHospitals.Count)
                            {
                                sayac++;
                            }
                        }                       
                    }
                } 
                if(sayac == result.Count)               
                {                     
                    break;
                }
            }
         
            List<MyListModel> finishList = new List<MyListModel>();

            for (int i = 0; i < guardList.Count; i++)
            {
                int bolumId = guardList[i].Item1;
                int doktorId = guardList[i].Item2;
                var bolum = departmanHospitals.Where(x => x.Id == bolumId).FirstOrDefault();
                var doktor = employeeDoctors.Where(x => x.Id == doktorId).FirstOrDefault();
                finishList.Add(new MyListModel { Nobet = bolum.Name + " Nöbeti  " +" - "+ " Nöbetci Doktor: " + doktor.Name });
            }
            return View(finishList);
        }
        public PartialViewResult ReportCreate()
        {
            return PartialView();
        }
    }
}