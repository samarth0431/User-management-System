using System;
using System.Data;
using System.Configuration;
using System.Data.SqlClient;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Drawing;

namespace WebApplication1
{
    public partial class loginform : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection("Data Source=DESKTOP-0DRBGAM\\SQLEXPRESS;Initial Catalog=aspnlogin;Integrated Security=True;TrustServerCertificate=True"))
            {
                con.Open();
                string loginQuery = "SELECT COUNT(*) FROM login WHERE username=@username AND password=@password";
                SqlCommand cmd = new SqlCommand(loginQuery, con);
                cmd.Parameters.AddWithValue("@username", TextBox1.Text);
                cmd.Parameters.AddWithValue("@password", TextBox2.Text);
                int count = (int)cmd.ExecuteScalar();

                if (count > 0)
                {
                    lblMessage.Text = "Login successful.";
                    lblMessage.ForeColor = Color.Green;
                    Response.Redirect("WebForm2.aspx");
                }
                else
                {
                    lblMessage.Text = "User does not exist.";
                    lblMessage.ForeColor = Color.Red;
                }
            }
        }

        

        protected void Unnamed2_Click(object sender, EventArgs e)
        {
            Response.Redirect("WebForm1.aspx");
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            TextBox1.Text = "";
            TextBox2.Text = "";
        }
    }
}
