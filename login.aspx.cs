using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;


public partial class login : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        string cs = "Data Source=DELL-PC;Initial Catalog=Library;Integrated Security=True";
        SqlConnection cn = new SqlConnection(cs);
        cn.Open();
        string ch = "select count(*) from tbllogin where username='" + TextBox1.Text + "'";
        SqlCommand cmd = new SqlCommand(ch, cn);
        int i = Convert.ToInt32(cmd.ExecuteScalar().ToString());
        cn.Close();
        if (i == 1)
        {
            cn.Open();
            string chpass = "select password from tbllogin where username='" + TextBox1.Text + "'";
            SqlCommand passcmd = new SqlCommand(chpass, cn);
            string password = passcmd.ExecuteScalar().ToString().Replace(" ", "");
            if (password == TextBox2.Text)
            {
                Session["name"] = TextBox1.Text;
                Response.Write("password correct..");
                Response.Redirect("Default.aspx");
            }
            else
            {
                Response.Write("password not correct..");
            }
        }
        else
        {
            Response.Write("user name is not correct..");
        }
    }
}