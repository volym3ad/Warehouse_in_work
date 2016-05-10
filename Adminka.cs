using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace kursachForAxl
{
    public partial class Adminka : Form
    {
        public Adminka()
        {
            InitializeComponent();
            Password.PasswordChar = '*'; // заміняємо введені значення паролю знаком *
            Password.MaxLength = 7;
        }

        private void Adminka_Load(object sender, EventArgs e)
        {
            label1.Text = "Login";
            label2.Text = "Password";

        }

        private void OKButton_Click(object sender, EventArgs e)
        {
            if ((Login.Text == "shmiga") && (Password.Text == "0604"))
            {
                //MessageBox.Show("Логін і пароль введені правильно!");
                this.Close();
                EditDBase edit = new EditDBase();
                edit.Show();
            }
            else
            {
                SystemSounds.Hand.Play();
                MessageBox.Show("Error Data! Try again.");
                Login.Text = null;
                Password.Text = null;
            }
        }
    }
}
