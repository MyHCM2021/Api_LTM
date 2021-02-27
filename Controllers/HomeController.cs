using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class HomeController : ApiController
    {
        LuckyTextileEntities1 dbobj = new LuckyTextileEntities1();
        public JsonResult EmployeesData()
        {
            var data = dbobj.MI_Employer_Employee.ToList();
            return Json(data, JsonRequestBehavior.AllowGet);
        }

        private JsonResult Json(List<MI_Employer_Employee> data, JsonRequestBehavior allowGet)
        {
            throw new NotImplementedException();
        }
    }
}
