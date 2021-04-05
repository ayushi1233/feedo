using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
namespace CA_Project
{
    public partial class studentsignup : System.Web.UI.Page
    {
        

        

        protected void Page_Load(object sender, EventArgs e)
        {
            

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string sql = "insert into Student(First Name,Last Name,Email Id,Contanct No,Password)values('"+TextBox1.Text+"','"+TextBox2.Text+"','"+TextBox3.Text+"',"+TextBox4.Text+",'"+TextBox5.Text+"')";
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=|DataDirectory|\Database1.mdf;Integrated Security=True");
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = sql;
            int a = 0;
            con.Open();
            a=cmd.ExecuteNonQuery();
            con.Close();
            if (a == 0)
            {
                Label2.Text="Not saved";
            }
            else
            {
                Label2.Text="Saved";
            }


        }
    }
}