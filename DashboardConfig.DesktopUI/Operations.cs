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
    public partial class Operations : Form
    {
        public Operations()
        {
            InitializeComponent();
        }

        private void Savebutton_Click(object sender, EventArgs e)
        {
            Save s = new Save();
            s.Show();
            this.Close();
        }

        private void Updatebutton_Click(object sender, EventArgs e)
        {
            Update u = new Update();
            u.Show();
            this.Close();
        }

        private void Viewbutton_Click(object sender, EventArgs e)
        {
            View v = new View();
            v.Show();
            this.Close();
        }

        private void Deletebutton_Click(object sender, EventArgs e)
        {
            Delete d = new Delete();
            d.Show();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Homepage hp = new Homepage();
            hp.Show();
            this.Close();
        }
    }
}
