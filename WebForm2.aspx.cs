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
using System.Collections.Generic;
using System.Net;
using System.Security.Policy;
using System.Xml.Linq;

namespace WebApplication1
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        string gender;
        protected void Page_Load(object sender, EventArgs e)
        {
            //Control myControl1 = FindControl("TextBox1");
            //TextBox1.Text = "SAMARTH";
        }

        

        protected void RadioButton1_CheckedChanged(object sender, EventArgs e)
        {
            gender = "male";
        }

        protected void RadioButton2_CheckedChanged(object sender, EventArgs e)
        {
            gender = "female";
        }

        protected void RadioButton3_CheckedChanged(object sender, EventArgs e)
        {
            gender = "others";
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            //Control myControl1 = FindControl("TextBox1");
            //TextBox1.Text = "SAMARTH";
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-0DRBGAM\\SQLEXPRESS;Initial Catalog=userreg;Integrated Security=True");
            SqlCommand cmd = new SqlCommand(@"INSERT INTO[dbo].[userreg]
           ( name
           , fathersname
           , email
           , address
           , phone
           , gender)
     VALUES
           ('" + TextBox1.Text + "' , '" + TextBox2.Text + "' , '" + TextBox3.Text + "' , '" + TextBox4.Text + "' , '" + TextBox5.Text + "' , '" + gender + "' )" ,  con);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            Response.Write("<script>alert('login success');</script>");
        }
    }
}
