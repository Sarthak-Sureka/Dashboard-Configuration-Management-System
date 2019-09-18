using DashboardConfig.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DashboardConfig.DataAccess
{
    public interface IDashboardConfigRepository
    {
        bool SaveDetails(string jsondata);
        string ReadDetails();
        bool DeleteDetails(int Id);
        bool UpdateDetails(string jsondata);
        Dashboard SearchDetails(int Id);
    }
}
