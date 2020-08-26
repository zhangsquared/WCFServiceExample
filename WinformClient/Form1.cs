using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinformClient
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            button1.Click += Button1_Click;
        }

        private async void Button1_Click(object sender, EventArgs e)
        {
            string name = textBox1.Text;

            TestServiceReference.TestServiceClient client = new TestServiceReference.TestServiceClient();
            string response = await client.TestAsync(name);

            label3.Text = response;
        }
    }
}
