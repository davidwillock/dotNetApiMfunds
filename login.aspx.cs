using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Configuration;


public partial class login : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void Button1_Click(object sender, EventArgs e)
    {



            try
            {

                SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["MfundsConnectionString"].ConnectionString);
                conn.Open();

            
                string checkUser = "Select count(*) from userdata where username = '" + TextBoxUserName.Text + "'";

                SqlCommand com = new SqlCommand(checkUser, conn);

                int temp = Convert.ToInt32(com.ExecuteScalar().ToString());

            if (temp == 1)
            {


                string checkPasswordQuery = "Select password from userdata where password = '" + TextBoxPassword.Text + "'";
                SqlCommand comPassword = new SqlCommand(checkPasswordQuery, conn);
                String password = comPassword.ExecuteScalar().ToString().Replace(" ", "");
                if (password == TextBoxPassword.Text)
                {

                    Session["New"] = TextBoxUserName.Text;
                    Response.Write("Password is correct");
                    Response.Redirect("~/mainmenu.aspx"); 

                }
                else
                {

                    Response.Write("Password incorrect");
                    Response.Redirect("~/login.aspx");
                    

                }




                conn.Close();



            }
            else
            {





                Response.Write("Incorrect UserName");







            }
            }
            catch (Exception ex)
            {
                Response.Write("Error: " + ex.Message.ToString());

           }









        








    }
}