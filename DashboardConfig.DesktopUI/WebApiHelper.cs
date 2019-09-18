using DashboardConfig.Entities;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DashboardConfig.DesktopUI
{
    public class WebApiHelper
    {
        private RestClient restClient = new RestClient(ConfigurationManager.AppSettings["uri"]);

        public List<Dashboard> Get()
        {
            RestRequest request = new RestRequest("DashboardConfig", Method.GET);
            IRestResponse<List<Dashboard>> response = restClient.Execute<List<Dashboard>>(request);
            return response.Data;
        }

        public void Post(string data)
        {
            var request = new RestRequest("DashboardConfig?jsondata=" + data, Method.POST);
            var response = restClient.Execute(request);
            if (response.IsSuccessful)
                MessageBox.Show("Successful");
            else
                MessageBox.Show("Error");
        }

        public void Delete(int Id)
        {
            var request = new RestRequest("DashboardConfig/" + Id, Method.DELETE);
            var response = restClient.Execute(request);
            if (response.IsSuccessful)
                MessageBox.Show("Successful");
            else
                MessageBox.Show("Error");
        }

        public Dashboard Search(int Id)
        {
            RestRequest request = new RestRequest("DashboardConfig/" + Id, Method.GET);
            IRestResponse<Dashboard> response = restClient.Execute<Dashboard>(request);
            return response.Data;
        }

        public void Put(string data)
        {
            var request = new RestRequest("DashboardConfig?jsondata=" + data, Method.PUT);
            var response = restClient.Execute(request);
            if (response.IsSuccessful)
                MessageBox.Show("Successful");
            else
                MessageBox.Show("Error");
        }
    }
}
