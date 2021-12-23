using System;
using System.Data;
using System.Configuration;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace HospitalManagementSys
{
    public partial class userlogin : System.Web.UI.Page
    {
        string connectionStr = ConfigurationManager.ConnectionStrings["connection"].ConnectionString;
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            try
            {
                int which_user = 2;                                                         //To differentiate b/w patients and doctors and invalid user
                SqlConnection connection = new SqlConnection(connectionStr);
                if (connection.State == ConnectionState.Closed)                             //Check if connection is open.
                    connection.Open();
                SqlCommand getPatients = new SqlCommand("SELECT * FROM patients where patient_id='" + TextBox1.Text.Trim() + "' AND patient_password='" + TextBox2.Text.Trim() + "'", connection);
                SqlDataReader dataReader = getPatients.ExecuteReader();
                if (dataReader.HasRows)                                                     //User is a patient
                {
                    which_user = 1;                                                         //which_user: 0->Invalid Credentials, 1->Patient and 2->Doctors
                    while (dataReader.Read())
                    {
                        //Store PID and Name, dataReader starts at the 1st attribute in a row at index[0] 
                        Response.Write("<script>alert('Hello, " + dataReader.GetValue(1).ToString() + "');</script>");
                        //Setting session variables
                        Session["userID"] = dataReader.GetValue(0).ToString();
                        Session["first_name"] = dataReader.GetValue(1).ToString();
                        Session["last_name"] = dataReader.GetValue(2).ToString();
                        Session["user_type"] = "patient";
                    }
                    dataReader.Close();
                    Response.Redirect("homepage.aspx");
                }
                dataReader.Close();
                if (which_user == 2)                                                        //User is probably a doctor
                {
                    SqlCommand getDoctors = new SqlCommand("SELECT * FROM doctors where doctor_id='" + TextBox1.Text.Trim() + "' AND dr_password='" + TextBox2.Text.Trim() + "'", connection);
                    dataReader = getDoctors.ExecuteReader();
                    if (dataReader.HasRows)                                                 //User is a doctor
                    {
                        which_user = 1;
                        while (dataReader.Read())
                        {
                            Response.Write("<script>alert('Hello, Dr " + dataReader.GetValue(1).ToString() + "');</script>");
                            Session["userID"] = dataReader.GetValue(0).ToString();
                            Session["first_name"] = dataReader.GetValue(1).ToString();
                            Session["last_name"] = dataReader.GetValue(2).ToString();
                            Session["user_type"] = "doctor";
                        }
                        dataReader.Close();
                        Response.Redirect("homepage.aspx");
                    }
                    else
                    {
                        which_user = 0;
                    }
                }
                if (which_user == 0)
                {
                    Response.Write("<script>alert('INVALID CREDENTIALS');</script>");
                }
            }
            catch (Exception excpt)
            {
                Response.Write("<script>alert('" + excpt.Message + "');</script>");
            }
        }
    }
}