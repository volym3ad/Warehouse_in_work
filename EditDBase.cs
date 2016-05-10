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
    public partial class EditDBase : Form
    {
        public EditDBase()
        {
            InitializeComponent();
        }

        private void EditDBase_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "warehouseDataDataSet1.Warehouse". При необходимости она может быть перемещена или удалена.
            this.warehouseTableAdapter.Fill(this.warehouseDataDataSet1.Warehouse);

            Font font = new Font("Arial", 10, FontStyle.Regular, GraphicsUnit.Point);
            label1.Text = "You can add the needed information \nby editing the DataGridView. \nTo save this changes \npress 'Save' button. \nIf you want to delete the item, \npress Delete button.";
            label1.Font = font;

            label2.Text = "Designed by @kalym.";
        }


        private void SaveButton_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;

            try
            {
                warehouseBindingSource.EndEdit();
                warehouseTableAdapter.Update(this.warehouseDataDataSet1.Warehouse);
                MessageBox.Show("You have been successfully saved.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            Cursor.Current = Cursors.Default;
        }

        private void dataGridView1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                if (MessageBox.Show("Are you sure you want to delete this item ?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    warehouseBindingSource.RemoveCurrent();
                }
            }
        }
    }
}
