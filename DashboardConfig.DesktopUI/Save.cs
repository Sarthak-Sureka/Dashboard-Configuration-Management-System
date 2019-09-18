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
    public partial class Save : Form
    {
        public Save()
        {
            InitializeComponent();
        }

        private void Savebutton1_Click(object sender, EventArgs e)
        {
            string data = "{'Username':'" + NametextBox.Text + "','Component':'" + comboBox1.Text.ToString() + "','Datapoint':'" + combobox2.Text.ToString() + "'}";
            WebApiHelper helper = new WebApiHelper();
            helper.Post(data);
        }

        private void Cancelbutton1_Click(object sender, EventArgs e)
        {
            NametextBox.Text = " ";
            combobox2.Text = " ";
            comboBox1.Text = " ";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Operations o = new Operations();
            o.Show();
            this.Close();
        }

        private void NametextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
