using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace HospitalManagementSys
{
    public partial class Site1 : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                if (Session["user_type"]==null)                                        //No one has logged in/signed up
                {
                    LinkButton1.Visible = false;                                            //Book Appointment
                    LinkButton2.Visible = false;                                            //Donate Blood
                    LinkButton3.Visible = true;                                             //Login
                    LinkButton6.Visible = false;                                            //Logout
                    Label1.Visible = false;                                                 //Label for Grretings
                    LinkButton4.Visible = true;                                             //Sign Up
                    LinkButton5.Visible = false;                                            //Cafeteria
                    LinkButton7.Visible = false;                                            //View Schedule
                    //Session["userID"] = dataReader.GetValue(0).ToString();
                    //Session["first_name"] = dataReader.GetValue(1).ToString();
                    //Session["last_name"] = dataReader.GetValue(2).ToString();
                    //Session["user_type"] = "patient";
                }
                else if (Session["user_type"].Equals("patient"))                            //User is a patient
                {
                    LinkButton1.Visible = true;                                             //Book Appointment
                    LinkButton2.Visible = true;                                             //Donate Blood
                    LinkButton3.Visible = false;                                            //Login
                    LinkButton6.Visible = true;                                             //Logout
                    Label1.Visible = true;                                                  //Label for Grretings
                    Label1.Text = "Hello, " + Session["first_name"];
                    LinkButton4.Visible = false;                                            //Sign Up
                    LinkButton5.Visible = false;                                            //Cafeteria
                    LinkButton7.Visible = false;                                            //View Schedule
                }
                else if (Session["user_type"].Equals("doctor"))
                {
                    LinkButton1.Visible = false;                                            //Book Appointment
                    LinkButton2.Visible = true;                                             //Donate Blood
                    LinkButton3.Visible = false;                                            //Login
                    LinkButton6.Visible = true;                                             //Logout
                    Label1.Visible = true;                                                  //Label for Grretings
                    Label1.Text = "Hello, Dr " + Session["first_name"];
                    LinkButton4.Visible = false;                                            //Sign Up
                    LinkButton5.Visible = true;                                             //Cafeteria
                    LinkButton7.Visible = true;                                             //View Schedule
                }
            }
            catch(Exception excpt)
            {
                Response.Write("<script>alert('" + excpt.Message + "');</script>");
            }
        }

        protected void LinkButton3_Click(object sender, EventArgs e)
        {
            Response.Redirect("userlogin.aspx");
        }

        protected void LinkButton6_Click(object sender, EventArgs e)
        {
            Response.Write("<script>alert('Goodbye');</script>");
            Session["userID"] = "";
            Session["first_name"] = "";
            Session["last_name"] = "";
            Session["user_type"] = "";
            //Setting back to default
            LinkButton1.Visible = false;                                            //Book Appointment
            LinkButton2.Visible = false;                                            //Donate Blood
            LinkButton3.Visible = true;                                             //Login
            LinkButton6.Visible = false;                                            //Logout
            Label1.Visible = false;                                                 //Label for Grretings
            LinkButton4.Visible = true;                                             //Sign Up
            LinkButton5.Visible = false;                                            //Cafeteria
            LinkButton7.Visible = false;                                            //View Schedule
            Response.Redirect("homepage.aspx");
        }

        protected void LinkButton1_Click(object sender, EventArgs e)
        {
            Response.Redirect("bookAppointment.aspx");
        }

        protected void LinkButton7_Click(object sender, EventArgs e)
        {
            Response.Redirect("viewSchedule.aspx");
        }

        protected void LinkButton2_Click(object sender, EventArgs e)
        {
            Response.Redirect("bloodBank.aspx");
        }

        protected void LinkButton5_Click(object sender, EventArgs e)
        {
            Response.Redirect("cafeteria.aspx");
        }

        protected void LinkButton4_Click(object sender, EventArgs e)
        {
            Response.Redirect("signUp.aspx"); 
        }
    }
}