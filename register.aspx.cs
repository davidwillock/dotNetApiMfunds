using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Configuration;


public partial class register : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

        if (IsPostBack)
        {

            try {

                SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["MfundsConnectionString"].ConnectionString);
                conn.Open();

                string checkUser = "Select count(*) from userdata where username = '" + TextBoxUserName.Text + "'";

                SqlCommand com = new SqlCommand(checkUser, conn);

                int temp = Convert.ToInt32(com.ExecuteScalar().ToString());

                if (temp == 1)
                {
                    Response.Write("User already exists");


                }


                conn.Close();



            } catch ( Exception ex)
            {
               Response.Write("Error: " + ex.Message.ToString());

            }









        }



    }
    /*
    protected void Button1_Click(object sender, EventArgs e)
    {

        Guid newGuid = new Guid();

        try
        {
            SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["RegistrationConnectionStrings"].ConnectionString);
            conn.Open();




            // string checkUser = "Select count(*) from userdata where username = '" + TextBoxUserName.Text + "'";
            string insertUser = "Insert into userdata values (Id,Username,Email,Password,Country) values (@id,@username,@email,@password,@country)";

            SqlCommand com = new SqlCommand(insertUser, conn);
            com.Parameters.AddWithValue("@username", TextBoxUserName.Text);
            com.Parameters.AddWithValue("@email", TextBoxEmail.Text);
            com.Parameters.AddWithValue("@password", TextBoxPassword.Text);
            com.Parameters.AddWithValue("@country", TextBoxConfirmPassword.Text);
            com.Parameters.AddWithValue("@id", newGuid);

            com.ExecuteNonQuery();
            Response.Write("Registration is successful");



            conn.Close();
        }

        catch (Exception ex)
        {


            Response.Write("Error: " + ex.ToString());

        }


        Response.Write("Registration is successfully");





    }
    */





    protected void Button2_Click(object sender, EventArgs e)
    {

    }

    protected void Button1_Click1(object sender, EventArgs e)
    {



        Guid newGuid = Guid.NewGuid();

        try
        {
            SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["MfundsConnectionString"].ConnectionString);
            conn.Open();




            // string checkUser = "Select count(*) from userdata where username = '" + TextBoxUserName.Text + "'";
            string insertUser = "Insert into userdata (Id,Username,Email,Password,Country) values (@id,@username,@email,@password,@country)";

            SqlCommand com = new SqlCommand(insertUser, conn);
            com.Parameters.AddWithValue("@username", TextBoxUserName.Text);
            com.Parameters.AddWithValue("@email", TextBoxEmail.Text);
            com.Parameters.AddWithValue("@password", TextBoxPassword.Text);
            com.Parameters.AddWithValue("@country", TextBoxConfirmPassword.Text);
            com.Parameters.AddWithValue("@id", newGuid);

            com.ExecuteNonQuery();
            Response.Write("Registration is successful");



            conn.Close();
        }

        catch (Exception ex)
        {


            Response.Write("Error: " + ex.ToString());
          

        }


        Response.Write("Registration is successfully");




    }
}