
using System.Data;
using System.Data.SqlClient;

namespace nwap3010
{
    public partial class Form1 : Form
    {
        SqlConnection con;
        SqlCommand cmd;
        SqlCommand cmdtedarik;

        string constr = "Data Source=10.10.88.248;Initial Catalog=dbnwind;Persist Security Info=True;User ID=sa;Password=sanane";

        public Form1()
        {
            InitializeComponent();
        }

        private void btnkaydet_Click(object sender, EventArgs e)
        {
            con = new SqlConnection(constr);

            con.Open();
            cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = $"insert into Products(ProductName,SupplierID,CategoryID,UnitPrice) " +
                $"values('{txturunad.Text.ToString()}',{cmbtedarik.SelectedValue},{cmbkategori.SelectedValue},{nupbirimfiyat.Value})";
            cmd.ExecuteNonQuery();
            con.Close();
            tazele();

        }


        private void tazele()
        {
            con = new SqlConnection(constr);
            con.Open();

            cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "select * from Products order by " +
                "ProductID desc";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            con = new SqlConnection(constr);
            con.Open();


            //Kategori bilgileri cmbkategori combosuna aktarýlýyor
            cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "select CategoryID,CategoryName from Categories";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);

            cmbkategori.ValueMember = "CategoryID";
            cmbkategori.DisplayMember = "CategoryName";
            cmbkategori.DataSource = dt;


            //Tedarikçiler bilgileri cmbtedarik combosuna aktarýlýyor

            cmdtedarik = new SqlCommand();
            cmdtedarik.Connection = con;
            cmdtedarik.CommandText = "select SupplierID,CompanyName from Suppliers";
            cmdtedarik.ExecuteNonQuery();
            DataTable dt2 = new DataTable();
            SqlDataAdapter da2 = new SqlDataAdapter(cmdtedarik);
            da2.Fill(dt2);
            cmbtedarik.ValueMember = "SupplierID";
            cmbtedarik.DisplayMember = "CompanyName";
            cmbtedarik.DataSource = dt2;

            con.Close();





        }

        private void btnsil_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {

                int selectedRowIndex = dataGridView1.SelectedRows[0].Index;
                int productID = Convert.ToInt32(dataGridView1.Rows[selectedRowIndex].Cells["ProductID"].Value);

                con = new SqlConnection(constr);
                con.Open();

                cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandText = $"DELETE FROM products Where productID = {productID}";
                cmd.ExecuteNonQuery();
                con.Close();

                tazele();
            }
        }


        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnbul_Click(object sender, EventArgs e)
        {
            string searchKeyword = txturunad.Text.Trim();

            if (string.IsNullOrEmpty(searchKeyword))
            {
                return;
            }

            con = new SqlConnection(constr);
            con.Open();

            cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = $"Select * from Products Where ProductName Like '%{searchKeyword}%'";
            cmd.ExecuteNonQuery();

            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            dataGridView1.DataSource = dt;

            con.Close();


        }

        private void btnguncel_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                int selectedProductId = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["ProductID"].Value);

                string selectedProductName = dataGridView1.SelectedRows[0].Cells["ProductName"].Value.ToString();
                int selectedSupplierId = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["SupplierID"].Value);
                int selectedCategoryId = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["CategoryID"].Value);
                decimal selectedUnitPrice = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["UnitPrice"].Value);

                con.Open();
                cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandText = "SELECT CategoryID, CategoryName FROM Categories";
                cmd.ExecuteNonQuery();
                DataTable dtCategory = new DataTable();
                SqlDataAdapter daCategory = new SqlDataAdapter(cmd);
                daCategory.Fill(dtCategory);
                cmbkategori.ValueMember = "CategoryID";
                cmbkategori.DisplayMember = "CategoryName";
                cmbkategori.DataSource = dtCategory;

                cmdtedarik = new SqlCommand();
                cmdtedarik.Connection = con;
                cmdtedarik.CommandText = "SELECT SupplierID, CompanyName FROM Suppliers";
                cmdtedarik.ExecuteNonQuery();
                DataTable dtSupplier = new DataTable();
                SqlDataAdapter daSupplier = new SqlDataAdapter(cmdtedarik);
                daSupplier.Fill(dtSupplier);
                cmbtedarik.ValueMember = "SupplierID";
                cmbtedarik.DisplayMember = "CompanyName";
                cmbtedarik.DataSource = dtSupplier;
                con.Close();

                cmbkategori.SelectedValue = selectedCategoryId;
                cmbkategori.SelectedValue = selectedSupplierId;
                nupbirimfiyat.Value = selectedUnitPrice;
                txturunad.Text = selectedProductName;

                txturunad.Enabled = true;
                cmbkategori.Enabled = true;
                cmbtedarik.Enabled = true;
                nupbirimfiyat.Enabled = true;

                btnkaydet.Enabled = false;
                btnsil.Enabled = false;
            }
            else
            {
                MessageBox.Show("Lütfen güncellenecek bir satýr seçin.");
            }
        }

        private void btnspkaydet_Click(object sender, EventArgs e)
        {
            con = new SqlConnection(constr);
            con.Open();

            cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "Urunekle";
            cmd.Parameters.AddWithValue("@vproductname", txturunad.Text);
            cmd.Parameters.AddWithValue("@vsupid", cmbtedarik.SelectedValue);
            cmd.Parameters.AddWithValue("@vcatid", cmbkategori.SelectedValue);
            cmd.Parameters.AddWithValue("@vunitprice", nupbirimfiyat.Value);
            cmd.ExecuteNonQuery();

            con.Close();
            tazele();






        }

        private void btnspsil_Click(object sender, EventArgs e)
        {
            con = new SqlConnection(constr);
            con.Open();

            cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "spurunsil";
            cmd.Parameters.AddWithValue("@vproductid", Convert.ToInt32(dataGridView1.CurrentRow.Cells["ProductID"].Value));

            cmd.ExecuteNonQuery();

            con.Close();
            tazele();

        }

        private void btnspara_Click(object sender, EventArgs e)
        {
            con = new SqlConnection(constr);
            con.Open();

            cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "spurunara";
            cmd.Parameters.AddWithValue("@vpname",txturunad.Text );

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt=new DataTable();
            da.Fill(dt);

            dataGridView1.DataSource = dt;

            //cmd.ExecuteNonQuery();



            con.Close();
            


        }
    }
}