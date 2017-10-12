using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlServerCe;
using System.Data.SqlClient;

namespace HisabKitab
{
    public partial class Form2 : Form
    {
        SqlCeConnection con = new SqlCeConnection(@"Data Source=C:\Users\Lakers\documents\visual studio 2012\Projects\HisabKitab\HisabKitab\HisabKitabDB.sdf");

        public Form2()
        {
            InitializeComponent();
            Fillcombo();

        }

        private void btnView_Click(object sender, EventArgs e)
        {
            try
            {
                //int id = int.Parse(comboBox1.SelectedValue.ToString());
                SqlCeCommand cmd1 = new SqlCeCommand("select supplier_id from Supplier where supplier_name='" + comboBoxReportSupplier.SelectedItem.ToString() + "'", con);
                //cmd1.ExecuteScalar();
                con.Open();
                int id = int.Parse(cmd1.ExecuteScalar().ToString());
                SqlCeCommand cmdSaveData = new SqlCeCommand("select * from Particulars where supplier_id ='"+id+"' and particulars_view = 1",con);

                //cmdSaveData.ExecuteNonQuery();
                SqlCeDataAdapter sda = new SqlCeDataAdapter(cmdSaveData);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                dataGridViewReport.DataSource = dt;
                con.Close();
                MessageBox.Show("Result displayed...");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        void Fillcombo()
        {
            con.Open();
            SqlCeCommand combocmd = new SqlCeCommand("select supplier_name from Supplier where supplier_view = 1 order by supplier_name asc", con);
            try
            {
                SqlCeDataReader dr = combocmd.ExecuteReader();

                while (dr.Read())
                {
                    comboBoxReportSupplier.Items.Add(dr["supplier_name"]);
                }
                con.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
    }
}
