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
using System.Data.SqlServerCe;

namespace HisabKitab
{
    public partial class AddSupplier : Form
    {
        SqlCeConnection con = new SqlCeConnection(@"Data Source=C:\Users\Lakers\documents\visual studio 2012\Projects\HisabKitab\HisabKitab\HisabKitabDB.sdf");
        int ID = 0;
        public AddSupplier()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtName.Text != "" && txtContactNo.Text != "")
            {
                SqlCeCommand cmd = new SqlCeCommand("insert into Supplier(supplier_name, supplier_contactperson, supplier_contactno, supplier_view) values('" + txtName.Text + "','" + txtContactPerson.Text + "','" + txtContactNo.Text + "', 1)", con);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Data saved...");
            }
            else
            {
                MessageBox.Show("Please provide the details...");
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtName.Text = "";
            txtContactPerson.Text = "";
            txtContactNo.Text = "";
            ID = 0;
        }

        private void supplierDataGridView_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            //int i = supplierDataGridView.SelectedCells[0].RowIndex;        
            ID = Convert.ToInt32(supplierDataGridView.CurrentRow.Cells[0].Value.ToString());
            txtName.Text = supplierDataGridView.CurrentRow.Cells[1].Value.ToString();
            txtContactPerson.Text = supplierDataGridView.Rows[e.RowIndex].Cells[2].Value.ToString();
            txtContactNo.Text = supplierDataGridView.Rows[e.RowIndex].Cells[3].Value.ToString();
            //rowheader mouse click event of datagrid view should be modified to the appropriate dataset...
        }

        private void DisplayData()
        {
            con.Open();
            SqlCeDataAdapter sda = new SqlCeDataAdapter("select * from Supplier where supplier_view = 1", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            supplierDataGridView.DataSource = dt;
            con.Close();
        }

        private void txtEdit_Click(object sender, EventArgs e)
        {
            if (ID != 0)
            {
                SqlCeCommand cmd = new SqlCeCommand("update Supplier set supplier_name='" + txtName.Text + "', supplier_contactperson='" + txtContactPerson.Text + "',supplier_contactno='" + txtContactNo.Text + "' where supplier_id='" + ID + "'", con);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Record updated Successfully...");
                DisplayData();
            } 
        }

        private void txtDelete_Click(object sender, EventArgs e)
        {

            if (ID != 0)
            {
                SqlCeCommand cmd = new SqlCeCommand("update Supplier set supplier_view=0 where supplier_id='" + ID + "' ", con);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Record Deleted Successfully...");
                DisplayData();
            } 
        }


        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void AddSupplier_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'hisabKitabDBDataSet1.Supplier' table. You can move, or remove it, as needed.
            //this.supplierTableAdapter.Fill(this.hisabKitabDBDataSet1.Supplier);
            // TODO: This line of code loads data into the 'hisabKitabDBDataSet1.Supplier' table. You can move, or remove it, as needed.
            //this.supplierTableAdapter.Fill(this.hisabKitabDBDataSet1.Supplier);

        }

        private void supplierDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void supplierDataGridView_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnViewSupplier_Click(object sender, EventArgs e)
        {
            DisplayData();
        }

        
    }
}
