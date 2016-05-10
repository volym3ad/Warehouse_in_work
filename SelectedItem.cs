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
    public partial class SelectedItem : Form
    {
        private double value;
        private double end;

        public SelectedItem(string name, string quantity, string price)
        {
            InitializeComponent();

            dataGridView1.Rows.Add();
            dataGridView1.Rows[0].Cells[0].Value = name;
            dataGridView1.Rows[0].Cells[1].Value = quantity;
            dataGridView1.Rows[0].Cells[2].Value = price;

            int amount = Int32.Parse(quantity);
            for (int i = 0; i < amount; i++)
            {
                comboBox1.Items.Insert(i, i + 1);
            }

            double cost = Convert.ToDouble(price);
            value = cost;
            
        }

        private void SelectedItem_Load(object sender, EventArgs e)
        {
            label1.Text = "You select following product.";
            label2.Text = "How many items do you want? ";
            CommitButton.Enabled = false;
        }

        private void CommitButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Your order is approved. Wait for our call)\nExpected price: " + end + " $.");
            this.Close();
        }

        private void comboBox1_SelectionChangeCommitted(object sender, EventArgs e)
        {
            CommitButton.Enabled = true;
            int max = comboBox1.SelectedIndex + 1;
            end = max * value;
        }
    }
}
