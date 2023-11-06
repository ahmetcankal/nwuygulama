
using System.Data;
using System.Data.SqlClient;

namespace nwap3010
{
    public partial class Form1 : Form
    {
        SqlConnection con;
        SqlCommand cmd;

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
            cmd.CommandText = $"insert into Products(ProductName) values('{txturunad.Text.ToString()}')";
            cmd.ExecuteNonQuery();
            con.Close();0
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











            con.Close();





        }
    }
}