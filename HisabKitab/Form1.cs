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
    public partial class Form1 : Form
    {
        SqlCeConnection con = new SqlCeConnection(@"Data Source=C:\Users\Lakers\documents\visual studio 2012\Projects\HisabKitab\HisabKitab\HisabKitabDB.sdf");

        public Form1()
        {
            InitializeComponent();
            Fillcombo();
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

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'hisabKitabDBDataSet1.Supplier' table. You can move, or remove it, as needed.
           // this.supplierTableAdapter.Fill(this.hisabKitabDBDataSet1.Supplier);


        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        void Fillcombo()
        {
            con.Open();
            SqlCeCommand combocmd = new SqlCeCommand("select supplier_name from Supplier where supplier_view=1 order by supplier_name asc", con);
            try
            {
                SqlCeDataReader dr = combocmd.ExecuteReader();

                while(dr.Read())
                {
                    comboBox1.Items.Add(dr["supplier_name"]);
                }
                con.Close();
              
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private void btnSaveData_Click(object sender, EventArgs e)
        {
            try
            {
                //int id = int.Parse(comboBox1.SelectedValue.ToString());
                SqlCeCommand cmd1 = new SqlCeCommand("select supplier_id from Supplier where supplier_name='"+comboBox1.SelectedItem.ToString()+"'",con);
                //cmd1.ExecuteScalar();
                con.Open();

                int id = int.Parse(cmd1.ExecuteScalar().ToString());
                int initial_cost = int.Parse(txtRate.Text) * int.Parse(txtQuantity.Text);
                double discountper = initial_cost/int.Parse(txtDiscountper.Text);
                
                double cost = initial_cost - discountper - int.Parse(txtDiscountVal.Text);
                double vat_value;
                double vatbill_cost;
                double panbill_cost;
                if (txtVat.Text == "v")
                {
                    vat_value = cost * (0.13);
                    vatbill_cost = cost + vat_value;
                    panbill_cost = 0;                    
                }
                else
                {
                    vat_value = 0;
                    vatbill_cost = 0;
                    panbill_cost = cost;
                }
                
                SqlCeCommand cmdSaveData = new SqlCeCommand("insert into Particulars(supplier_id, date, item, size, quantity, Rate, discount, discount_value, vat, bill_no, initial_cost, vat_value, vatbill_cost, panbill_cost, particulars_view) values('" + id + "','" + txtDate.Text + "','" + txtParticulars.Text + "','" + txtSize.Text + "','" + txtQuantity.Text + "','" + txtRate.Text + "','" + txtDiscountper.Text + "','" + txtDiscountVal.Text + "','" + txtVat.Text + "','" + txtBillNo.Text + "', '" + initial_cost+ "','" + vat_value + "','" + vatbill_cost + "', '" + panbill_cost + "',0) ", con);
                
                cmdSaveData.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("All Data saved...");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnReports_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.ShowDialog();
        }

        int A = 1;
        private void btnAddEntry_Click(object sender, EventArgs e)
        {
            AddNewTextBox();             
        }

        public System.Windows.Forms.TextBox AddNewTextBox()
        {
            System.Windows.Forms.TextBox txt = new System.Windows.Forms.TextBox();
            this.Controls.Add(txt);
            txt.Top = A + 228;
            txt.Left = 1;
            A += 28;
            return txt;
        }

        private void vScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {

        }

        private void txtDate_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Home h1 = new Home();
            h1.ShowDialog();
        }

        int ID = 0;
        private void supplierDataGridView_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            //int i = supplierDataGridView.SelectedCells[0].RowIndex;        
            ID = Convert.ToInt32(supplierDataGridView.CurrentRow.Cells[0].Value.ToString());
            txtName.Text = supplierDataGridView.CurrentRow.Cells[1].Value.ToString();
            txtContactPerson.Text = supplierDataGridView.Rows[e.RowIndex].Cells[2].Value.ToString();
            txtContactNo.Text = supplierDataGridView.Rows[e.RowIndex].Cells[3].Value.ToString();
            
        }

        private void DisplayData()
        {
            con.Open();            
            SqlCeDataAdapter sda = new SqlCeDataAdapter("select * from Supplier where supplier_view = 1",con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            supplierDataGridView.DataSource = dt;
            con.Close();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            
                if (ID != 0)
                {                    
                    SqlCeCommand cmd = new SqlCeCommand("update Supplier set supplier_view=0 where supplier_id='" + ID + "' ",con);
                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Record Deleted Successfully...");
                    DisplayData();                   
                } 
            
        }

       
        private void btnEdit_Click(object sender, EventArgs e)
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

        private void btnView_Click(object sender, EventArgs e)
        {
            DisplayData();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtName.Text = "";
            txtContactPerson.Text = "";
            txtContactNo.Text = "";
            ID = 0;
        }
    }
}
