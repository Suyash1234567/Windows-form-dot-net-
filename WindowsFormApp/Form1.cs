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

namespace WindowsFormApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection connect = new SqlConnection("Data Source=KELLGGNCPU0339;Initial Catalog=FormEntry;Persist Security Info=True;User ID=sa;Password=pwd@123");
        private void save_Click(object sender, EventArgs e)
        {
            //DAL.SampleConnection sampleCon = new DAL.SampleConnection();
            //sampleCon.


            connect.Open();
            string query = "INSERT INTO tbl(Name,Address,Phone,Email) VALUES ('" + textName.Text + "','"+ textAddress.Text+"','"+textPhoneNo.Text+"','"+textEmailID.Text+"')";
            SqlCommand SDA = new SqlCommand(query, connect);

            SDA.ExecuteNonQuery(); // for executing queries that does not return any data
            connect.Close();
            MessageBox.Show("Successful");
        }
    }
}
