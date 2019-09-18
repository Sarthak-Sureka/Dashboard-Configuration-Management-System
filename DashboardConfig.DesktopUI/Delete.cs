using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DashboardConfig.DesktopUI
{
    public partial class Delete : Form
    {
        public Delete()
        {
            InitializeComponent();
        }

        private void Delete_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the '_DashboardConfig_DataAccess_DashboardConfigDbContextDataSet.Dashboards' table. You can move, or remove it, as needed.
            this.dashboardsTableAdapter.Fill(this._DashboardConfig_DataAccess_DashboardConfigDbContextDataSet.Dashboards);

        }

        private void Deletebutton1_Click(object sender, EventArgs e)
        {
            int i = int.Parse(IdtextBox1.Text);
            WebApiHelper helper = new WebApiHelper();
            IdtextBox1.Text = "";
            helper.Delete(i);
        }

        private void Cancelbutton2_Click(object sender, EventArgs e)
        {
            Operations o = new Operations();
            o.Show();
            this.Close();
        }
    }
}
