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
    public partial class viewSchedule : System.Web.UI.Page
    {
        string connectionStr = ConfigurationManager.ConnectionStrings["connection"].ConnectionString;
        protected void Page_Load(object sender, EventArgs e)
        {
            GridView1.DataBind();
        }
        protected void Update_Appointment_Room(string app_id)
        {
            try
            {
                string room_id = "";
                SqlConnection connection = new SqlConnection(connectionStr);
                if (connection.State == ConnectionState.Closed)                             //Check if connection is open.
                    connection.Open();
                SqlCommand getAppointments = new SqlCommand("SELECT room_id FROM appointments where appointment_num='" + app_id + "'", connection);
                SqlDataReader dataReader = getAppointments.ExecuteReader();
                while (dataReader.Read())
                {
                    room_id = dataReader["room_id"].ToString();
                    //Response.Write("<script>alert('" + dataReader.GetValue(0).ToString() + "');</script>");
                }
                dataReader.Close();
                //Increasing available spots in the room
                int available_spots = 0;
                SqlCommand getRoomSpots = new SqlCommand("SELECT available_spots FROM rooms where room_id='" + room_id + "'", connection);
                dataReader = getRoomSpots.ExecuteReader();
                while (dataReader.Read())
                {
                    available_spots = Convert.ToInt32(dataReader["available_spots"].ToString());
                }
                dataReader.Close();
                available_spots = available_spots + 1;
                SqlCommand setRoomSpots = new SqlCommand("UPDATE rooms SET available_spots = '" + available_spots + "' where room_id='" + room_id + "'", connection);
                dataReader = setRoomSpots.ExecuteReader();
                while (dataReader.Read())
                {
                }
                dataReader.Close();
                Response.Write("<script>alert('Spots increased!');</script>");
                connection.Close();
            }
            catch (Exception excpt)
            {
                Response.Write("<script>alert('" + excpt.Message + "');</script>");
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            //Response.Write("<script>alert('Button clicked');</script>");
            try
            {
                SqlConnection connection = new SqlConnection(connectionStr);
                if (connection.State == ConnectionState.Closed)                             //Check if connection is open.
                    connection.Open();
                SqlCommand deleteAppointment = new SqlCommand("DELETE from appointments WHERE appointment_num='" + TextBox1.Text.Trim() + "'", connection);
                SqlDataReader dataReader = deleteAppointment.ExecuteReader();
                while (dataReader.Read())
                {
                }
                dataReader.Close();
                connection.Close();
                //Response.Write("<script>alert('Appointment Deleted Successfully');</script>");
                TextBox1.Text = "";
                GridView1.DataBind();
                Update_Appointment_Room(TextBox1.Text.Trim());
            }
            catch (Exception ex)
            {
                Response.Write("<script>alert('" + ex.Message + "');</script>");
            }
        }
    }
}