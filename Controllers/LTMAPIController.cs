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
    public class LTMAPIController : ApiController
    {
        LuckyTextileEntities1 dbobj = new LuckyTextileEntities1();

        [System.Web.Http.HttpGet]
        [System.Web.Http.Route("api/LTMApi/employeesdata")]
        public IHttpActionResult EmployeesData()
        {
            try
            {
                var data = dbobj.MI_Employer_Employee.ToList();
                if (data != null)
                {
                    return Ok(data);
                }
                else
                {
                    return NotFound();
                }
            }
            catch (Exception ex)
            {

                BadRequest(ex.Message.ToString());
            }
            return NotFound();
        }
        //GET api/values
        [system.web.http.httpget]
        [system.web.http.route("api/LTMApi/test")]
        public ienumerable<string> test()
        {

            return new string[] { "value1", "value2" };

        }

        //// GET api/values/5
        //public string Get(int id)
        //{
        //    return "value";
        //}

        //// POST api/values
        //public void Post([FromBody] string value)
        //{
        //}

        //// PUT api/values/5
        //public void Put(int id, [FromBody] string value)
        //{
        //}

        //// DELETE api/values/5
        //public void Delete(int id)
        //{
        //}
    }
}
