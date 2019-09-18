using DashboardConfig.Entities;
using Newtonsoft.Json;
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
    public partial class Update : Form
    {
        public Update()
        {
            InitializeComponent();
        }

        private void Savebutton1_Click(object sender, EventArgs e)
        {
            Dashboard d = new Dashboard
            {
                ID = int.Parse(textBox1.Text),
                Username = NametextBox.Text,
                Component = comboBox1.Text,
                Datapoint = comboBox2.Text
            };
            string data = JsonConvert.SerializeObject(d);
            WebApiHelper helper = new WebApiHelper();
            helper.Put(data);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int i = int.Parse(textBox1.Text);
            WebApiHelper helper = new WebApiHelper();
            Dashboard dd = helper.Search(i);
            NametextBox.Text = dd.Username;
            comboBox1.Text = dd.Component;
            comboBox2.Text = dd.Datapoint;
        }

        private void Cancelbutton1_Click(object sender, EventArgs e)
        {
            textBox1.Text = " ";
            NametextBox.Text = " ";
            comboBox2.Text = " ";
            comboBox1.Text = " ";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Operations i = new Operations();
            i.Show();
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
