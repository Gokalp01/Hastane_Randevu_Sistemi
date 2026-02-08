using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace HASTANERANDEVUPROGRAMI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string connectionString = "Server=localhost;Database=HastaneRandevuSistemi;Integrated Security=True;";


        private void button1_Click(object sender, EventArgs e)
        {
            newform1 newForm = new newform1();
            newForm.ShowDialog();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            newform1 newForm = new newform1();
            newForm.ShowDialog();
        }
    }
}
