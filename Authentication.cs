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
    public partial class Authentication : Form
    {
        public Authentication()
        {
            InitializeComponent();
        }

        private void Authentication_Load(object sender, EventArgs e)
        {
            label1.Text = "Please choose the user you want to log on as.";
            label1.AutoSize = false;
            label1.TextAlign = ContentAlignment.TopCenter;
            label1.Dock = DockStyle.Fill;
            label1.Font = new Font("Arial", 10, FontStyle.Bold,
   GraphicsUnit.Point);
            Font font = new Font("Arial", 14, FontStyle.Regular,
   GraphicsUnit.Point);
            adminButton.Font = font;
            guestButton.Font = font;
        }

        private void guestButton_Click(object sender, EventArgs e)
        {
            DataBase data = new DataBase();
            data.Show();
        }

        private void adminButton_Click(object sender, EventArgs e)
        {
            Adminka adm = new Adminka();
            adm.Show();
        }
    }
}
