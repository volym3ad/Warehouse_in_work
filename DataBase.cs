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

namespace kursachForAxl
{
    public partial class DataBase : Form
    {
        public DataBase()
        {
            InitializeComponent();

            ToolTip tool = new ToolTip();
            tool.SetToolTip(OrderButton, "You can order only one type of item per once!");
        }

        DataTable table = new DataTable();

        private void DataBase_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "warehouseDataDataSet1.Warehouse". При необходимости она может быть перемещена или удалена.
            this.warehouseTableAdapter.Fill(this.warehouseDataDataSet1.Warehouse);
            OrderButton.Enabled = false;
            label1.Text = "Find what you need.";
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

        }

        private void warehouseDataDataSetBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                this.warehouseTableAdapter.SearchName(this.warehouseDataDataSet1.Warehouse, textBox1.Text);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            OrderButton.Enabled = true;
            dataGridView1.Rows[e.RowIndex].ReadOnly = true;
            if (dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value == null)
            {
                dataGridView1.Rows[e.RowIndex].ReadOnly = false;
            }
        }

        private void OrderButton_Click(object sender, EventArgs e)
        {
            SelectedItem item = new SelectedItem(dataGridView1.SelectedRows[0].Cells[0].Value.ToString(), 
                                                dataGridView1.SelectedRows[0].Cells[1].Value.ToString(), 
                                                dataGridView1.SelectedRows[0].Cells[2].Value.ToString());
            item.Show();
        }

    }
}
