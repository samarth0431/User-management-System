using System;
using System.Data;
using System.Configuration;
using System.Collections;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using System.Collections.Specialized;
using System.Data.OleDb;
using System.Data.SqlTypes;
using System.Text;
using System.Web.SessionState;
using System.Drawing;
using System.Data.SqlClient;

namespace WebApplication1
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        protected void btnResetPassword_Click(object sender, EventArgs e)
        {
            string userName = TextBox1.Text;
            string newPassword = TextBox2.Text;
            string confirmPassword = TextBox3.Text;

            if (newPassword != confirmPassword)
            {
                lblMessage.Text = "New password and Confirm password do not match.";
                return;
            }

            using (SqlConnection con = new SqlConnection("Data Source=DESKTOP-0DRBGAM\\SQLEXPRESS;Initial Catalog=aspnlogin;Integrated Security=True;TrustServerCertificate=True"))
            {
                con.Open();
                string query = "SELECT COUNT(*) FROM login WHERE username = @username";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@username", userName);

                int userCount = (int)cmd.ExecuteScalar();

                if (userCount > 0)
                {
                    string updateQuery = "UPDATE login SET password = @password WHERE username = @username";
                    SqlCommand updateCmd = new SqlCommand(updateQuery, con);
                    updateCmd.Parameters.AddWithValue("@password", newPassword);
                    updateCmd.Parameters.AddWithValue("@username", userName);
                    updateCmd.ExecuteNonQuery();

                    lblMessage.Text = "Password changed successfully.";
                }
                else
                {
                    lblMessage.Text = "Username not found.";
                }
            }
        }
    }
}
