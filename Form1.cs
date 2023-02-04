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
using System.Xml.Linq;

namespace Product
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection("Data Source=LAPTOP-EO99ENAE\\SQLEXPRESS;Initial Catalog=Market;Integrated Security=True");
        SqlCommand cmd;
        SqlDataReader read;
        string sql;

        private void button1_Click(object sender, EventArgs e)
        {
            string pname = txtpname.Text;
            string price = txtprice.Text;
            string discount = txtdiscount.Text;


            sql = "insert into product(pname,price,discount) values(@pname,@price,@discount)";
            con.Open();
            cmd = new SqlCommand(sql, con);
            cmd.Parameters.AddWithValue("@pname", pname);
            cmd.Parameters.AddWithValue("@price", price);
            cmd.Parameters.AddWithValue("@discount", discount);

            MessageBox.Show("Record Added.....");
            cmd.ExecuteNonQuery();

            txtpname.Clear();
            txtprice.Clear();
            txtdiscount.Clear();
            txtpname.Focus();


        }

        private void button2_Click(object sender, EventArgs e)
        {
            string pname = txtpname.Text;
            string price = txtprice.Text;
            string discount = txtdiscount.Text;
            string pID = txtpID.Text;


            sql = "update product set pname=@pname,price=@price,discount=@discount where id =@pid";
            con.Open();
            cmd = new SqlCommand(sql, con);
            cmd.Parameters.AddWithValue("@pname", pname);
            cmd.Parameters.AddWithValue("@price", price);
            cmd.Parameters.AddWithValue("@discount", discount);
            cmd.Parameters.AddWithValue("@pID",pID);

            MessageBox.Show("Record Updated.....");
            cmd.ExecuteNonQuery();

            txtpname.Clear();
            txtprice.Clear();
            txtdiscount.Clear();
            txtpname.Focus();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string pID =txtpID.Text;

            sql = "select * from product where id =@pID";
            con.Open();
            cmd = new SqlCommand(sql, con);
            cmd.Parameters.AddWithValue("@pID", pID);
            SqlDataReader dr;
             dr = cmd.ExecuteReader();

            if (dr.Read())
            {
                txtpname.Text = dr["pname"].ToString();
                txtprice.Text = dr["price"].ToString();
                txtdiscount.Text = dr["discount"].ToString();

            }
            else
            {
                MessageBox.Show(" Product Id Not Found");
            }
            con.Close();
        }

        private void txtpID_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
