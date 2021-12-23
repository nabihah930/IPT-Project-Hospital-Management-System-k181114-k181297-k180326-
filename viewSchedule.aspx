<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="viewSchedule.aspx.cs" Inherits="HospitalManagementSys.viewSchedule" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
    <script type="text/javascript">
        $(document).ready(function () {

            $(document).ready(function () {
            $('.table').DataTable();
            });

            //$(".table").prepend($("<thead></thead>").append($(this).find("tr:first"))).dataTable();
            //$('.table1').DataTable();
        });
    </script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container-fluid">
      <div class="row">
         <div  class="col-md-12">
             <div class="card">
               <div class="card-body">
                  <div class="row">
                     <div class="col">
                        <center>
                           <img width="100px" src="icons/view_schedule_icon.png"/>
                        </center>
                     </div>
                  </div>
                  <div class="row">
                     <div class="col">
                        <center>
                           <h3>Your Schedule</h3>
                        </center>
                     </div>
                  </div>
                  <div class="row">
                     <div class="col">
                        <hr>
                     </div>
                  </div>
                   <div class="row">
                     <div class="col">
                         <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:hospital_managementConnectionString %>" SelectCommand="SELECT [appointment_num], [fname], [lname], [age], [gender], [appointment_name], [appointment_day], [start_time], [end_time], [room_id], [charges] FROM [dr_appointments_view] WHERE ([doctor_id] = @doctor_id)">
                             <SelectParameters>
                                 <asp:SessionParameter Name="doctor_id" SessionField="userID" Type="String" />
                             </SelectParameters>
                         </asp:SqlDataSource>
                         <asp:GridView class="table table-striped table-bordered" ID="GridView1" runat="server" AutoGenerateColumns="False" DataKeyNames="appointment_num" DataSourceID="SqlDataSource1">
                             <Columns>
                                 <asp:BoundField DataField="appointment_num" HeaderText="Appointment ID" ReadOnly="True" SortExpression="appointment_num" />
                                 <asp:BoundField DataField="fname" HeaderText="First Name" SortExpression="fname" />
                                 <asp:BoundField DataField="lname" HeaderText="Last Name" SortExpression="lname" />
                                 <asp:BoundField DataField="age" HeaderText="Age" SortExpression="age" />
                                 <asp:BoundField DataField="gender" HeaderText="Gender" SortExpression="gender" />
                                 <asp:BoundField DataField="appointment_name" HeaderText="Type" SortExpression="appointment_name" />
                                 <asp:BoundField DataField="appointment_day" HeaderText="Day" SortExpression="appointment_day" />
                                 <asp:BoundField DataField="start_time" HeaderText="Start Time" SortExpression="start_time" />
                                 <asp:BoundField DataField="end_time" HeaderText="End Time" SortExpression="end_time" />
                                 <asp:BoundField DataField="room_id" HeaderText="Room No." SortExpression="room_id" />
                                 <asp:BoundField DataField="charges" HeaderText="Charges" SortExpression="charges" />
                             </Columns>
                         </asp:GridView>
                     </div>
                  </div>
               </div>
            </div>
             <br />
             <br />
         </div>
      </div>
        <div class="row">
         <div  class="col">
             <div class="card">
               <div class="card-body">
                  <div class="row">
                     <div class="col-md-9">
                         <label>Appointment ID</label>
                         <asp:TextBox CssClass="form-control" ID="TextBox1" runat="server" placeholder="Appointment ID"></asp:TextBox>
                     </div>
                  </div>
                   <br />
                   <div class="row">
                     <div class="col">
                         <asp:Button class="btn btn-success btn-lg" ID="Button1" runat="server" Text="Cross Off" OnClick="Button1_Click" />
                     </div>
                  </div>
                   <div class="row">
                     <div class="col">
                        <hr>
                     </div>
                  </div>
               </div>
            </div>
             <br />
             <br />
         </div>
      </div>
   </div>
</asp:Content>
