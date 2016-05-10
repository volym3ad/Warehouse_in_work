using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kursachForAxl
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label1.Text = "This program is dedicated to work with Warehouses.";
            label1.Font = new Font("Arial", 10, FontStyle.Bold,
   GraphicsUnit.Point);
        }

        private void NextButton_Click(object sender, EventArgs e)
        {
            //this.Hide();
            Authentication authent = new Authentication();
            authent.Show();
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hope you enjoy using our program. \nGoodBye!");
            Application.Exit();
        }
    }
}
