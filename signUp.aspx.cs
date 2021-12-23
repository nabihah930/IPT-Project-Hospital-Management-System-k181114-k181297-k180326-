using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace HospitalManagementSys
{
    public partial class signUp : System.Web.UI.Page
    {
        string cs = ConfigurationManager.ConnectionStrings["connection"].ConnectionString;
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        bool checkMemberExists()
        {
            try
            {
                SqlConnection con = new SqlConnection(cs);
                if (con.State == ConnectionState.Closed)
                    con.Open();
                SqlCommand cmd = new SqlCommand("SELECT * from patients where patient_id ='" + TextBox1.Text.Trim() + "';", con);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                if (dt.Rows.Count >= 1)
                    return true;
                else
                    return false;
            }
            catch (Exception ex)
            {
                Response.Write("<script>alert('" + ex.Message + "');</script>");
                return false;
            }
        }
        protected string generateID()
        {
            string patient_id = "", patient_code = "", patient_num = "";
            SqlConnection connection = new SqlConnection(cs);
            if (connection.State == ConnectionState.Closed)                             //Check if connection is open.
                connection.Open();
            SqlCommand getPatID = new SqlCommand("SELECT MAX(patient_id) AS patient_id FROM patients;", connection);
            SqlDataReader dataReader = getPatID.ExecuteReader();
            while (dataReader.Read())
            {
                patient_id = dataReader["patient_id"].ToString();
            }
            dataReader.Close();
            patient_num = patient_id.Substring(3);
            patient_code = patient_id.Substring(0, 3);

            int pat_number1 = (int)Char.GetNumericValue(patient_num[0]);
            int pat_number2 = (int)Char.GetNumericValue(patient_num[1]);

            if (pat_number2 == 9)
            {
                pat_number2++;
                pat_number1++;
            }
            else
                pat_number2++;
            patient_num = Convert.ToString(pat_number1) + Convert.ToString(pat_number2);
            //appointment_num = String.Concat(Convert.ToString(app_number1), Convert.ToString(app_number2));
            patient_id = patient_code + patient_num;
            //Response.Write("<script>alert('Appointment_num Generated: " + new_appointmentID + "💃 ');</script>");

            return patient_id;
        }
        protected void insertpatient()
        {
            string patient_id = generateID();
            SqlConnection con = new SqlConnection(cs);
            if (con.State == System.Data.ConnectionState.Closed)
                con.Open();

            //string str = "INSERT INTO patients(patient_id,fname,lname,age,gender,phone,current_address,blood_type,patient_email,patient_password) VALUES(@patient_id,@fname,@lname,@age,@gender,@phone,@current_address,@blood_type,@patient_email,@patient_password)";
            SqlCommand cmd = new SqlCommand("INSERT INTO patients(patient_id,fname,lname,age,gender,phone_number,address,blood_type,patient_email,patient_password) VALUES(@patient_id,@fname,@lname,@age,@gender,@phone_number,@address,@blood_type,@patient_email,@patient_password)", con);
            cmd.Parameters.AddWithValue("@patient_id", patient_id);
            //cmd.Parameters.AddWithValue("@patient_id", TextBox1.Text.Trim());
            cmd.Parameters.AddWithValue("@fname", TextBox11.Text.Trim());
            cmd.Parameters.AddWithValue("@lname", TextBox2.Text.Trim());
            cmd.Parameters.AddWithValue("@age", TextBox1.Text.Trim());
            cmd.Parameters.AddWithValue("@gender", TextBox3.Text.Trim());
            cmd.Parameters.AddWithValue("@phone_number", TextBox14.Text.Trim());
            cmd.Parameters.AddWithValue("@address", TextBox15.Text.Trim());
            cmd.Parameters.AddWithValue("@blood_type", TextBox16.Text.Trim());
            cmd.Parameters.AddWithValue("@patient_email", TextBox17.Text.Trim());
            cmd.Parameters.AddWithValue("@patient_password", TextBox18.Text.Trim());
            cmd.ExecuteNonQuery();
            con.Close();
            Session["userID"] = patient_id;
            Session["user_type"] = "patient";
            Session["first_name"] = TextBox11.Text.Trim();
            Session["last_name"] = TextBox2.Text.Trim();
        }
        protected void Button2_Click(object sender, EventArgs e)
        {
            if (checkMemberExists())
                Response.Write("<script>alert('Member Already Exists with this Member ID try to login');</script>");
            else
            {
                insertpatient();
                Response.Write("<script>alert('Use this ID the next time you login: " + Session["userID"] + "');</script>");
                Response.Redirect("homepage.aspx");
            }
        }
    }
}