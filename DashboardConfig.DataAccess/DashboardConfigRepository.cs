using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DashboardConfig.Entities;
using Newtonsoft.Json;

namespace DashboardConfig.DataAccess
{
    public class DashboardConfigRepository : IDashboardConfigRepository
    {
        private DashboardConfigDbContext db = new DashboardConfigDbContext();

        public bool DeleteDetails(int Id)
        {
            var item = db.Dashboard.SingleOrDefault(c => c.ID == Id);
            if (item == null)
                return false;
            db.Dashboard.Remove(item);
            db.SaveChanges();
            return true;
        }

        public string ReadDetails()
        {
            string JsonString = string.Empty;
            JsonString = JsonConvert.SerializeObject(db.Dashboard);
            return JsonString;
        }

        public bool SaveDetails(string jsondata)
        {
            Dashboard data = JsonConvert.DeserializeObject<Dashboard>(jsondata);
            if (data == null)
                return false;
            db.Dashboard.Add(data);
            db.SaveChanges();
            return true;
        }

        public Dashboard SearchDetails(int Id)
        {
            return db.Dashboard.Where(c => c.ID == Id).First();
        }

        public bool UpdateDetails(string jsondata)
        {
            Dashboard data = JsonConvert.DeserializeObject<Dashboard>(jsondata);
            if (data == null)
                return false;
            db.Dashboard.AddOrUpdate(data);
            db.SaveChanges();
            return true;
        }
    }
}
