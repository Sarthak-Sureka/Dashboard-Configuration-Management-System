using DashboardConfig.DataAccess;
using DashboardConfig.Entities;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace DashboardConfig.Service.Controllers
{
    public class DashboardConfigController : ApiController
    {
        private DashboardConfigRepository bdr = new DashboardConfigRepository();

        public IHttpActionResult GetAllDetails()
        {
            List<Dashboard> data = JsonConvert.DeserializeObject<List<Dashboard>>(bdr.ReadDetails());
            if (data == null)
                return NotFound();
            return Ok(data);
        }

        public IHttpActionResult PostDetails(string jsondata)
        {
            var data = bdr.SaveDetails(jsondata);
            if (data == false)
                return NotFound();
            return Ok(data);
        }

        public IHttpActionResult DeleteDetails(int Id)
        {
            var result = bdr.DeleteDetails(Id);
            if (result == false)
                return NotFound();
            return Ok();
        }

        public IHttpActionResult PutDetails(string jsondata)
        {
            var data = bdr.UpdateDetails(jsondata);
            if (data == false)
                return NotFound();
            return Ok(data);
        }

        public IHttpActionResult GetDetails(int Id)
        {
            Dashboard data = bdr.SearchDetails(Id);
            if (data == null)
                return NotFound();
            return Ok(data);
        }

    }
}
