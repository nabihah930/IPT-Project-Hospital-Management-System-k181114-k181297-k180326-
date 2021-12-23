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
    public partial class departments : System.Web.UI.Page
    {
        string cs = ConfigurationManager.ConnectionStrings["connection"].ConnectionString;
        protected void Page_Load(object sender, EventArgs e)
        {
            cardio();
            ortho();
            hema();
        }
        protected void cardio()
        {
            SqlConnection con = new SqlConnection(cs);
            con = new SqlConnection(cs);
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            SqlCommand cmd1 = new SqlCommand("SELECT * FROM departments where department_id = 'CDP01'", con);
            SqlDataReader dr1 = cmd1.ExecuteReader();

            while (dr1.Read())
            {
                Label1.Text = dr1["department_number"].ToString();
                Label2.Text = dr1["department_email"].ToString();
            }
        }
        protected void ortho()
        {
            SqlConnection con = new SqlConnection(cs);
            con = new SqlConnection(cs);
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            SqlCommand cmd1 = new SqlCommand("SELECT * FROM departments where department_id = 'ODP01'", con);
            SqlDataReader dr1 = cmd1.ExecuteReader();

            while (dr1.Read())
            {
                Label3.Text = dr1["department_number"].ToString();
                Label4.Text = dr1["department_email"].ToString();
            }
        }
        protected void hema()
        {
            SqlConnection con = new SqlConnection(cs);
            con = new SqlConnection(cs);
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            SqlCommand cmd1 = new SqlCommand("SELECT * FROM departments where department_id = 'HDP01'", con);
            SqlDataReader dr1 = cmd1.ExecuteReader();

            while (dr1.Read())
            {
                Label5.Text = dr1["department_number"].ToString();
                Label6.Text = dr1["department_email"].ToString();
            }
        }

    }
}